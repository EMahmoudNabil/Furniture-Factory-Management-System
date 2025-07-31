using Api_Task_Techtroll.co.Application.DTOs;
using Api_Task_Techtroll.co.Domain.Entities;
using AutoMapper;

namespace Api_Task_Techtroll.co.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Product
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}
