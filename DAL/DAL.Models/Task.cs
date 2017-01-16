using System;
using System.Collections.Generic;

namespace DAL.Models
{
    /// <summary>
    /// Модель задача
    /// </summary>
    public class Task : BaseModel<long?>
    {
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата создания задачи
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Крайний срок выпролнения задачи
        /// </summary>
        public DateTime DeadLine { get; set; }

        /// <summary>
        /// Файл(ы) задачи
        /// </summary>
        public virtual List<File> Files { get; set; }

        /// <summary>
        /// Комментарий(ии) задачи
        /// </summary>
        public virtual List<Comment> Comments { get; set; }

        /// <summary>
        /// Список пользователей кому предоставлена данная задача (Ответственные)
        /// </summary>
        public List<User> Users { get; set; }
    }
}