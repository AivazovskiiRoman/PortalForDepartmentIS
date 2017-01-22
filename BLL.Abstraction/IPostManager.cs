using System.Collections.Generic;
using BLL.DTO;
using BLL.DTO.Filters;

namespace BLL.Abstraction
{
    /// <summary>
    /// Сервис для работы с объявлениями
    /// </summary>
    public interface IPostManager
    {
        /// <summary>
        /// Создать объявление
        /// </summary>
        /// <param name="dto"></param>
        void AddPost(PostDto dto);
        /// <summary>
        /// Редактировать объявление
        /// </summary>
        /// <param name="dto"></param>
        void EditPost(PostDto dto);
        /// <summary>
        /// Удалить объявление
        /// </summary>
        /// <param name="postId"></param>
        void DeletePost(PostDto postId);
        /// <summary>
        /// Список объявлений
        /// </summary>
        /// <returns></returns>
        IEnumerable<PostDto> GetPosts(PostFilter filter = null);
        /// <summary>
        /// Получить объявление по id
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        PostDto GetPostById(int postId);
    }
}
