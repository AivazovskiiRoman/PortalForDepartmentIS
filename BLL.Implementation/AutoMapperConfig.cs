using AutoMapper;
using BLL.DTO;
using DAL.Models;

namespace BLL.Implementation
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<PostDto, Post>()
                .ForMember(p => p.Title, opt => opt.ResolveUsing(dto => dto.Title + " (Title) "))
                .ForMember(p => p.Content, opt => opt.ResolveUsing(dto => dto.Content + " (Content) "))
                );
        }
    }
}