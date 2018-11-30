using vega.Models;
using vega.DTOs;
using AutoMapper;

namespace vega.Mappings
{
    public class MappingProfile : Profile    
    {
        public MappingProfile()
        {
            CreateMap<CarModel, CarModelDto>().ReverseMap();

            CreateMap<Make, MakeDto>().ReverseMap();

            CreateMap<Feature, FeatureDto>().ReverseMap();
        } 
    }
    
}