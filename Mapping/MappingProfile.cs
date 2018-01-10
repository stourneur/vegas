using AutoMapper;
using vegas.Controllers.Resources;
using vegas.Models;

namespace vegas.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();

        }
    }
}