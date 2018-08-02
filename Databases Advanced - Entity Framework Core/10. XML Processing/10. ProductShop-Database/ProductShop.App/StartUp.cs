namespace ProductShop.App
{
    using System;
    using AutoMapper;
    using System.IO;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Xml;

    using Data;
    using Models;
    using Dto.Import;   
    using Dto.Export; 
    using Dto.UsersAndProducts4thQuery;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();

            //InstantiateMapper();

            /********   2.  Import Data     ********/
            //ImportUsersInDatabase(mapper, context);
            //ImportProductsInDatabase(mapper, context);
            //ImportCategoriesInDatabase(mapper, context);
            //ImportDataInMappingTableCategoriesProducts(context);

            /********   3.  Query and Export Data     ********/

            //////    Query 1. Products In Range    ///////

            //ProductsInRangeXml(context);

            //////   Query 2. Sold Products    ///////

            //SoldProductsXml(context);

            //////    Query 3. Categories By Products Count    ///////

            //CategoriesByProductsCountXml(context);

            //////    Query 4. Users and Products    ///////

            UsersAndProductsXml(context);
        }

        private static void UsersAndProductsXml(ProductShopContext context)
        {
            var users = new UsersDto4
            {
                Count = context.Users.Where(x => x.ProductsSold.Count >= 1).Count(),
                Users = context.Users
                            .Where(x => x.ProductsSold.Count >= 1)
                            .Select(x => new UserDto4
                            {
                                FirstName = x.FirstName,
                                LastName = x.LastName,
                                Age = x.Age.ToString(),
                                SoldProducts = new SoldProduct4
                                {
                                    Count = x.ProductsSold.Count(),
                                    ProductDto = x.ProductsSold.Select(k => new ProductDto4
                                    {
                                        Name = k.Name,
                                        Price = k.Price
                                    }).ToArray()
                                }
                            }).ToArray()
            };


            var sb = new StringBuilder();

            var xmlNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(UsersDto4), new XmlRootAttribute("users"));
            serializer.Serialize(new StringWriter(sb), users, xmlNamespaces);

            File.WriteAllText("../../../Xml/users-and-products.xml", sb.ToString());
        }

        private static void CategoriesByProductsCountXml(ProductShopContext context)
        {
            var categories = context.Categories
                                                .OrderByDescending(c => c.CategoryProducts.Count)
                                                .Select(x => new CategoryDto
                                                {
                                                    Name = x.Name,
                                                    Count = x.CategoryProducts.Count,
                                                    AveragePrice = x.CategoryProducts.Select(s => s.Product.Price).DefaultIfEmpty(0).Average(), // In case there is category without products
                                                    TotalRevenue = x.CategoryProducts.Sum(s => s.Product.Price)
                                                })
                                                .ToArray();

            var sb = new StringBuilder();

            var xmlNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(CategoryDto[]), new XmlRootAttribute("categories"));
            serializer.Serialize(new StringWriter(sb), categories, xmlNamespaces);

            File.WriteAllText("../../../Xml/categories-by-products.xml", sb.ToString());
        }

        private static void SoldProductsXml(ProductShopContext context)
        {
            var users = context.Users
                                           .Where(x => x.ProductsSold.Count > 1)
                                           .OrderBy(x => x.LastName)
                                           .ThenBy(x => x.FirstName)
                                           .Select(x => new UserDto
                                           {
                                               FirstName = x.FirstName,
                                               LastName = x.LastName,
                                               SoldProducts = x.ProductsSold.Select(s => new SoldProduct
                                               {
                                                   Name = s.Name,
                                                   Price = s.Price
                                               }).ToArray()
                                           })
                                           .ToArray();

            var sb = new StringBuilder();

            var xmlNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(UserDto[]), new XmlRootAttribute("users"));
            serializer.Serialize(new StringWriter(sb), users, xmlNamespaces);

            File.WriteAllText("../../../Xml/users-sold-products.xml", sb.ToString());
        }

        private static void ProductsInRangeXml(ProductShopContext context)
        {
            var products = context.Products
                                              .Where(p => p.Price >= 1000 && p.Price <= 2000 && p.Buyer != null)
                                              .OrderByDescending(p => p.Price)
                                              .Select(x => new ProductDto
                                              {
                                                  Name = x.Name,
                                                  Price = x.Price,
                                                  Buyer = x.Buyer.FirstName + " " + x.Buyer.LastName ?? x.Buyer.LastName
                                              })
                                              .ToArray();

            var sb = new StringBuilder();

            var xmlNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(ProductDto[]), new XmlRootAttribute("products"));
            serializer.Serialize(new StringWriter(sb), products, xmlNamespaces);

            File.WriteAllText("../../../Xml/products-in-range.xml", sb.ToString());
        }

        private static void ImportDataInMappingTableCategoriesProducts(ProductShopContext context)
        {
            List<CategoryProduct> categoryProducts = new List<CategoryProduct>();

            for (int productId = 1; productId < 200; productId++) // There are 200 products in the database.
            {
                var categoryId = new Random().Next(1, 12);  // There are 11 categories in the database.

                var categoryProduct = new CategoryProduct()
                {
                    ProductId = productId,
                    CategoryId = categoryId
                };

                categoryProducts.Add(categoryProduct);
            }

            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();
        }

        private static void ImportCategoriesInDatabase(IMapper mapper, ProductShopContext context)
        {
            var xmlString = File.ReadAllText("../../../Xml/categories.xml");

            var serializer = new XmlSerializer(typeof(CategoryImportDto[]), new XmlRootAttribute("categories"));
            var deserializedCategories = (CategoryImportDto[])serializer.Deserialize(new StringReader(xmlString));

            List<Category> categories = new List<Category>();

            foreach (var categoryDto in deserializedCategories)
            {
                if (!IsValid(categoryDto))
                {
                    continue;
                }

                var category = mapper.Map<Category>(categoryDto);

                categories.Add(category);
            }

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }

        private static void ImportProductsInDatabase(IMapper mapper, ProductShopContext context)
        {
            var xmlString = File.ReadAllText("../../../Xml/products.xml");

            var serializer = new XmlSerializer(typeof(ProductImportDto[]), new XmlRootAttribute("products"));
            var deserializedProducts = (ProductImportDto[])serializer.Deserialize(new StringReader(xmlString));

            List<Product> products = new List<Product>();

            int counter = 1;

            foreach (var productDto in deserializedProducts)
            {
                if (!IsValid(productDto))
                {
                    continue;
                }

                var product = mapper.Map<Product>(productDto);

                var buyerId = new Random().Next(1, 30);
                var sellerId = new Random().Next(31, 57); //There are 56 Users in the Database.

                product.BuyerId = buyerId;
                product.SellerId = sellerId;

                if (counter == 4)
                {
                    product.BuyerId = null;  // Some products must not have buyer.
                    counter = 0;
                }
                counter++;

                products.Add(product);
            }

            context.Products.AddRange(products);
            context.SaveChanges();
        }

        private static void ImportUsersInDatabase(IMapper mapper, ProductShopContext context)
        {
            var xmlString = File.ReadAllText("../../../Xml/users.xml");

            var serializer = new XmlSerializer(typeof(UserImportDto[]), new XmlRootAttribute("users"));
            var deserializedUsers = (UserImportDto[])serializer.Deserialize(new StringReader(xmlString));

            List<User> users = new List<User>();

            foreach (var userDto in deserializedUsers)
            {
                if (!IsValid(userDto))
                {
                    continue;
                }

                var user = mapper.Map<User>(userDto);

                users.Add(user);
            }

            context.Users.AddRange(users);
            context.SaveChanges();
        }

        public static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResults, true);
        }

        private static void InstantiateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });
            var mapper = config.CreateMapper();
        }
    }
}
