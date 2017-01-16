using System;
using BLL.Abstraction;
using BLL.DTO;
using DAL.DataAccessLayer;
using DAL.Models;

namespace BLL.Implementation
{
    public class PostService : IPostService
    {
        private DatabaseContext _context;

        public PostService(DatabaseContext ctx)
        {
            _context = ctx;
            AutoMapperConfig.Initialize();
        }

        public void AddPost(PostDto post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }
            if (string.IsNullOrEmpty(post.Title))
            {
                throw new Exception("Fill string title");
            }
            var postEntity = AutoMapper.Mapper.Map<Post>(post);
            _context.Posts.Add(postEntity);
            _context.SaveChanges();
        }

        public void EditPost(PostDto post)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePost(PostDto post)
        {
            throw new System.NotImplementedException();
        }
    }
}
