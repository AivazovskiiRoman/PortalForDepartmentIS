using System;
using System.Collections.Generic;

namespace DAL.Models
{
    /// <summary>
    /// Модель объявление
    /// </summary>
    public class Post : BaseModel<long?>
    {
        /// <summary>
        /// Название объявления
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Содержимое объявления
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Дата создания объявления
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Файлы объявления
        /// </summary>
        public virtual List<File> Files { get; set; }

        /// <summary>
        /// Список пользователей кому предоставленно данное объявление
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// Комментарий(ии) объявления
        /// </summary>
        public virtual List<Comment> Comments { get; set; }
    }
}