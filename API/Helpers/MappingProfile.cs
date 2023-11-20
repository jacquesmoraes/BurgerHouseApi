using AutoMapper;
using CORE.Entities;

namespace API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(x => x.Category, o => o.MapFrom(s => s.Category.CategoryName))
                .ForMember(x => x.PictureUrl, o => o.MapFrom<ProductUrlResolver>());

        }
    }
}
