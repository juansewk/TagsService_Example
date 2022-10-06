using AutoMapper;
using TagsService.Models.BusinessEntities;
using TagsService.Models.DataModels;

namespace TagsService
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TagModel, TagBE>();
            CreateMap<TagBE, TagModel>();

            CreateMap<SubTagBE, SubTagModel>();
            CreateMap<SubTagModel, SubTagBE>();


        }
    }
}
