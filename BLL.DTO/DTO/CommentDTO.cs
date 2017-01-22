using System;

namespace BLL.DTO
{
    public class CommentDto : BaseDto<long?>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public CommentDto()
        {
            DateCreated = DateTime.Now;
        }

        /// <summary>
        /// Дата создания комментария
        /// </summary>
        public DateTime DateCreated { get; private set; }

        /// <summary>
        /// Содержимое комментария
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Автор комментария
        /// </summary>
        public virtual UserDto Author { get; set; }

        /// <summary>
        /// Задача для кот был оставлен комментарий
        /// </summary>
        public virtual TaskDto Task { get; set; }
    }
}
