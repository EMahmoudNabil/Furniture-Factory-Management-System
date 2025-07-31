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

            // Component
            CreateMap<Component, ComponentDto>().ReverseMap();
            CreateMap<CreateComponentDto, Component>();
            CreateMap<UpdateComponentDto, Component>();

            // Subcomponent
            CreateMap<Subcomponent, SubcomponentDto>().ReverseMap();
            CreateMap<CreateSubcomponentDto, Subcomponent>();
            CreateMap<UpdateSubcomponentDto, Subcomponent>();
        }
    }
}
