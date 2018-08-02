namespace ProductShop.App
{
    using AutoMapper;
    using Dto.Import;
    using ProductShop.Models;

    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            CreateMap<UserImportDto, User>();
            CreateMap<ProductImportDto, Product>();
            CreateMap<CategoryImportDto, Category>();
        }
    }
}
