using BLL.DTO;

namespace BLL.Abstraction
{
    /// <summary>
    /// Сервис для работы с объявлениями
    /// </summary>
    public interface IPostService
    {
        /// <summary>
        /// Создать объявление
        /// </summary>
        void AddPost(PostDto post);
        /// <summary>
        /// Редактировать объявление
        /// </summary>
        void EditPost(PostDto post);
        /// <summary>
        /// Удалить объявление
        /// </summary>
        void RemovePost(PostDto post);
    }
}
