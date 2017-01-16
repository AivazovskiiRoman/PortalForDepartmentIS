using System;
using System.Collections.Generic;

namespace DAL.Models
{
    /// <summary>
    /// Модель документа
    /// </summary>
    public class Document : BaseModel<long?>
    {
        /// <summary>
        /// Название документа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Прикрепленный файл
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Дата создания документа
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Список пользователей кому предоставлен данный документ
        /// </summary>
        public List<User> Users { get; set; }
    }
}
