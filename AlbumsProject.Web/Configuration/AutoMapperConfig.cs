
using AlbumsProject.BLL.Entities;
using AlbumsProject.BLL.Entities.Identity;
using AlbumsProject.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AlbumsProject.Web.Configuration
{
    public static class AutoMapperConfig
    {
        public static IMapperConfigurationExpression AddMapping(this IMapperConfigurationExpression configurationExpression)
        {
            Mapper.Initialize(mapper =>
            {
                mapper.CreateMap<Post, PostVm>()
                    .ForMember(dest => dest.Author, y => y.MapFrom(src => src.Author.UserName));
                mapper.CreateMap<Comment, CommentVm>()
                    .ForMember(dest => dest.Author, y => y.MapFrom(src => src.Author.UserName));
                mapper.CreateMap<AddCommentVm, Comment>();
                mapper.CreateMap<AddPostVm, Post>();
                mapper.CreateMap<ChatGroup, SelectListItem>()
                    .ForMember(x => x.Text, y => y.MapFrom(z => z.Name))
                    .ForMember(x => x.Value, y => y.MapFrom(z => z.Id));
                mapper.CreateMap<User, SelectListItem>()
                    .ForMember(x => x.Text, y => y.MapFrom(z => z.UserName))
                    .ForMember(x => x.Value, y => y.MapFrom(z => z.Id));
            });
            return configurationExpression;
        }
    }
}
