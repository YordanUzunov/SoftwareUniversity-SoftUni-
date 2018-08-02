namespace ProductShop.App
{
    using AutoMapper;

    using Data;
    using Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //InstantiateMapper();

            var context = new ProductShopContext();

            /******** 1. Import Data  ********/

            //ImportUsersInDatabase(context);
            //ImportProductsInDatabase(context);
            //ImportCategoriesInDatabase(context);
            //ImportDataInMappingTableCategoriesProducts(context);

            /********  2. Query and Export Data  ********/

            //////  Query 1. Products In Range  //////

            //ProductsInRangeJSON(context);


            //////  Query 2. Successfully Sold Products  //////

            //SuccessfullySoldProductsJSON(context);


            //////  Query 3. Categories By Products Count  //////

            //CategoriesByProductsCountJSON(context);


            //////  Query 4. Users and Products  //////

            UsersAndProductsJSON(context);

        }

        private static void InstantiateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });
            var mapper = config.CreateMapper();
        }

        private static void UsersAndProductsJSON(ProductShopContext context)
        {
            var users = new
            {
                usersCount = context.Users
                                    .Where(x => x.ProductsSold.Count >= 1 && x.ProductsSold.Any(s => s.Buyer != null)).Count(),
                users = context.Users
                                .OrderByDescending(x => x.ProductsSold.Count)
                                .ThenBy(l => l.LastName)
                                .Where(x => x.ProductsSold.Count >= 1 && x.ProductsSold.Any(s => s.Buyer != null))
                                .Select(u => new
                                {
                                    firstName = u.FirstName,
                                    lastName = u.LastName,
                                    age = u.Age,
                                    soldProducts = new
                                    {
                                        count = u.ProductsSold.Count(),
                                        products = u.ProductsSold.Select(s => new
                                        {
                                            name = s.Name,
                                            price = s.Price
                                        })
                                      .ToArray()
                                    }
                                })
                                .ToArray()
            };

            var jsonProducts = JsonConvert.SerializeObject(users, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            });

            File.WriteAllText("../../../Json/users-and-products.json", jsonProducts);
        }

        private static void CategoriesByProductsCountJSON(ProductShopContext context)
        {
            var categories = context.Categories
                                              .OrderByDescending(x => x.CategoryProducts.Count)
                                              .Select(x => new
                                              {
                                                  category = x.Name,
                                                  productsCount = x.CategoryProducts.Count,
                                                  averagePrice = x.CategoryProducts.Sum(s => s.Product.Price) / x.CategoryProducts.Count(),
                                                  totalRevenue = x.CategoryProducts.Sum(s => s.Product.Price)
                                              })
                                              .ToArray();

            var jsonProducts = JsonConvert.SerializeObject(categories, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            });

            File.WriteAllText("../../../Json/categories-by-products.json", jsonProducts);
        }

        private static void SuccessfullySoldProductsJSON(ProductShopContext context)
        {
            var users = context.Users
                               .Where(x => x.ProductsSold.Count >= 1 && x.ProductsSold.Any(s => s.Buyer != null))
                               .OrderBy(n => n.LastName)
                               .ThenBy(n => n.FirstName)
                               .Select(u => new
                               {
                                   firstName = u.FirstName,
                                   lastName = u.LastName,
                                   soldProducts = u.ProductsSold.Where(x => x.Buyer != null)
                                                                .Select(d => new
                                                                {
                                                                    name = d.Name,
                                                                    price = d.Price,
                                                                    buyerFirstName = d.Buyer.FirstName,
                                                                    buyerLastname = d.Buyer.LastName
                                                                })
                                                                .ToArray()
                               })
                               .ToArray();

            var jsonProducts = JsonConvert.SerializeObject(users, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            });

            File.WriteAllText("../../../Json/users-sold-products.json", jsonProducts);
        }

        private static void ProductsInRangeJSON(ProductShopContext context)
        {
            var products = context.Products
                                              .Where(x => x.Price >= 500 && x.Price <= 1000)
                                              .OrderBy(x => x.Price)
                                              .Select(p => new
                                              {
                                                  name = p.Name,
                                                  price = p.Price,
                                                  seller = p.Seller.FirstName + " " + p.Seller.LastName ?? p.Seller.LastName
                                              })
                                              .ToArray();

            var jsonProducts = JsonConvert.SerializeObject(products, Formatting.Indented);

            File.WriteAllText("../../../Json/products-in-range.json", jsonProducts);
            
        }

        private static void ImportDataInMappingTableCategoriesProducts(ProductShopContext context)
        {
            var categoryProducts = new List<CategoryProduct>();

            for (int productId = 1; productId < 200; productId++) //200 types of products exist
            {
                var categoryId = new Random().Next(1, 12);  //11 categories exist

                var categoryProduct = new CategoryProduct
                {
                    CategoryId = categoryId,
                    ProductId = productId
                };

                categoryProducts.Add(categoryProduct);
            }

            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();
        }

        private static void ImportCategoriesInDatabase(ProductShopContext context)
        {
            var jsonString = File.ReadAllText("../../../Json/categories.json");

            var deserializedCategories = JsonConvert.DeserializeObject<Category[]>(jsonString);

            List<Category> categories = new List<Category>();

            foreach (var category in deserializedCategories)
            {
                if (!IsValid(category))
                {
                    continue;
                }

                categories.Add(category);
            }

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }

        private static void ImportProductsInDatabase(ProductShopContext context)
        {
            var jsonString = File.ReadAllText("../../../Json/products.json");

            var deserializedProducts = JsonConvert.DeserializeObject<Product[]>(jsonString);

            List<Product> products = new List<Product>();

            foreach (var product in deserializedProducts)
            {
                if (!IsValid(product))
                {
                    continue;
                }

                var sellerId = new Random().Next(1, 35);
                var buyerId = new Random().Next(35, 57);

                var random = new Random().Next(1, 4);

                product.SellerId = sellerId;
                product.BuyerId = buyerId;

                if (random == 3)
                {
                    product.BuyerId = null;
                }

                products.Add(product);
            }

            context.Products.AddRange(products);
            context.SaveChanges();
        }

        private static void ImportUsersInDatabase(ProductShopContext context)
        {
            var jsonString = File.ReadAllText("../../../Json/users.json");

            var deserializedUsers = JsonConvert.DeserializeObject<User[]>(jsonString);

            List<User> users = new List<User>();

            foreach (var user in deserializedUsers)
            {
                if (IsValid(user))
                {
                    users.Add(user);
                }

            }

            context.Users.AddRange(users);
            context.SaveChanges();
        }

        public static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var results = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, results, true);
        }
    }
}
