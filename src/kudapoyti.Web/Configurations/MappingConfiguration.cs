using AutoMapper;
using kudapoyti.Domain.Entities.Admins;
using kudapoyti.Domain.Entities.Comment;
using kudapoyti.Domain.Entities.Places;
using kudapoyti.Service.ViewModels;

namespace kudapoyti.Web.Configuration
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<AdminViewModel, Admin1>().ReverseMap();
            CreateMap<PlaceViewModel, Place>().ReverseMap();
            CreateMap<CommentsViewModel, Comment>().ReverseMap();
        }
    }
}
