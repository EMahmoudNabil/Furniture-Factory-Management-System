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
            CreateMap<Subcomponent, SubcomponentDto>()
                .ForMember(dest => dest.DetailLength, opt => opt.MapFrom(src => (decimal)src.DetailLength))
                .ForMember(dest => dest.DetailWidth, opt => opt.MapFrom(src => (decimal)src.DetailWidth))
                .ForMember(dest => dest.DetailThickness, opt => opt.MapFrom(src => (decimal)src.DetailThickness))
                .ForMember(dest => dest.CuttingLength, opt => opt.MapFrom(src => (decimal)src.CuttingLength))
                .ForMember(dest => dest.CuttingWidth, opt => opt.MapFrom(src => (decimal)src.CuttingWidth))
                .ForMember(dest => dest.CuttingThickness, opt => opt.MapFrom(src => (decimal)src.CuttingThickness))
                .ForMember(dest => dest.FinalLength, opt => opt.MapFrom(src => (decimal)src.FinalLength))
                .ForMember(dest => dest.FinalWidth, opt => opt.MapFrom(src => (decimal)src.FinalWidth))
                .ForMember(dest => dest.FinalThickness, opt => opt.MapFrom(src => (decimal)src.FinalThickness))
                .ForMember(dest => dest.VeneerInner, opt => opt.MapFrom(src => src.InnerVeneer))
                .ForMember(dest => dest.VeneerOuter, opt => opt.MapFrom(src => src.OuterVeneer));

            CreateMap<CreateSubcomponentDto, Subcomponent>()
                .ForMember(dest => dest.InnerVeneer, opt => opt.MapFrom(src => src.VeneerInner ?? ""))
                .ForMember(dest => dest.OuterVeneer, opt => opt.MapFrom(src => src.VeneerOuter ?? ""))
                .ForMember(dest => dest.DetailLength, opt => opt.MapFrom(src => (float)src.DetailLength))
                .ForMember(dest => dest.DetailWidth, opt => opt.MapFrom(src => (float)src.DetailWidth))
                .ForMember(dest => dest.DetailThickness, opt => opt.MapFrom(src => (float)src.DetailThickness))
                .ForMember(dest => dest.CuttingLength, opt => opt.MapFrom(src => (float)src.CuttingLength))
                .ForMember(dest => dest.CuttingWidth, opt => opt.MapFrom(src => (float)src.CuttingWidth))
                .ForMember(dest => dest.CuttingThickness, opt => opt.MapFrom(src => (float)src.CuttingThickness))
                .ForMember(dest => dest.FinalLength, opt => opt.MapFrom(src => (float)src.FinalLength))
                .ForMember(dest => dest.FinalWidth, opt => opt.MapFrom(src => (float)src.FinalWidth))
                .ForMember(dest => dest.FinalThickness, opt => opt.MapFrom(src => (float)src.FinalThickness));

            CreateMap<UpdateSubcomponentDto, Subcomponent>()
                .ForMember(dest => dest.InnerVeneer, opt => opt.MapFrom(src => src.VeneerInner ?? ""))
                .ForMember(dest => dest.OuterVeneer, opt => opt.MapFrom(src => src.VeneerOuter ?? ""))
                .ForMember(dest => dest.DetailLength, opt => opt.MapFrom(src => (float)src.DetailLength))
                .ForMember(dest => dest.DetailWidth, opt => opt.MapFrom(src => (float)src.DetailWidth))
                .ForMember(dest => dest.DetailThickness, opt => opt.MapFrom(src => (float)src.DetailThickness))
                .ForMember(dest => dest.CuttingLength, opt => opt.MapFrom(src => (float)src.CuttingLength))
                .ForMember(dest => dest.CuttingWidth, opt => opt.MapFrom(src => (float)src.CuttingWidth))
                .ForMember(dest => dest.CuttingThickness, opt => opt.MapFrom(src => (float)src.CuttingThickness))
                .ForMember(dest => dest.FinalLength, opt => opt.MapFrom(src => (float)src.FinalLength))
                .ForMember(dest => dest.FinalWidth, opt => opt.MapFrom(src => (float)src.FinalWidth))
                .ForMember(dest => dest.FinalThickness, opt => opt.MapFrom(src => (float)src.FinalThickness));
        }
    }
}
