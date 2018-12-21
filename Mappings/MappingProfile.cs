using vega.Models;
using vega.DTOs;
using AutoMapper;
using vega.Controllers.Resources;

namespace vega.Mappings
{
    public class MappingProfile : Profile    
    {
        public MappingProfile()
        {
            CreateMap<CarModel, CarModelResource>().ReverseMap();

            CreateMap<Make, MakeResource>().ReverseMap();

            CreateMap<Feature, FeatureResource>().ReverseMap();
         
            CreateMap<Vehicle, VehicleResource>()
            .ForMember(
                dest => dest.CarModelResource,
                opt => opt.MapFrom(src => src.CarModel))
            .ReverseMap();

           // CreateMap<Feature, FeatureDto>().ReverseMap();


        } 
    }
    
}