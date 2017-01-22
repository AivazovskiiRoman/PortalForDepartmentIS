using AutoMapper;
using BLL.DTO;
using DAL.Models;
using PortalForDepartmentIS.Models;

namespace PortalForDepartmentIS.Infrastructure
{
    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostDto>();
                cfg.CreateMap<PostDto, Post>();

                cfg.CreateMap<PostDto, PostViewModel>();
                cfg.CreateMap<PostViewModel, PostDto>();
            });
        }
    }
}