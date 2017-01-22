using System;

namespace DAL.Models
{
    /// <summary>
    /// Модель для комментария
    /// </summary>
    public class Comment : BaseModel<long?>
    {
        /// <summary>
        /// Дата создания комментария
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Содержимое комментария
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Автор комментария
        /// </summary>
        public virtual User Author { get; set; }

        /// <summary>
        /// Задача для кот был оставлен комментарий
        /// </summary>
        public virtual Task Task { get; set; }
    }
}
