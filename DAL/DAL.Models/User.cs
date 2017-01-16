using System.Collections.Generic;

namespace DAL.Models
{
    /// <summary>
    /// Модель пользователь
    /// </summary>
    public class User : BaseModel<long>
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Информация о пользователе
        /// </summary>
        public string About { get; set; }

        /// <summary>
        /// Фото пользователя
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Группа(ы) в которой находится пользователь
        /// </summary>
        public virtual List<Group> Groups { get; set; }

        /// <summary>
        /// Сообщение(я) пользователя
        /// </summary>
        public virtual List<Message> Messages { get; set; }

        /// <summary>
        /// Документ(ы) пользователя
        /// </summary>
        public virtual List<Document> Documents { get; set; }

        /// <summary>
        /// Объявление(ия) пользователя
        /// </summary>
        public virtual List<Post> Posts { get; set; }

        /// <summary>
        /// Задачa(и) пользователя
        /// </summary>
        public virtual List<Task> Tasks { get; set; }

        /// <summary>
        /// Комментарий(ии) пользователя
        /// </summary>
        public virtual List<Comment> Comments { get; set; }
    }
}