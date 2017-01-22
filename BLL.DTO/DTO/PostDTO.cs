using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class PostDto : BaseDto<long?>
    {
        /// <summary>
        /// ID объявления
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название объявления
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Содержимое объявления
        /// </summary>
        public string Content { get; set; }

        ///// <summary>
        ///// Дата создания объявления
        ///// </summary>
        //public DateTime DateCreated { get; set; }

        ///// <summary>
        ///// Файлы объявления
        ///// </summary>
        //public List<FileDto> Files = new List<FileDto>();

        ///// <summary>
        ///// Список пользователей кому предоставленно данное объявление
        ///// </summary>
        //public List<UserDto> Users = new List<UserDto>();

        ///// <summary>
        ///// Комментарий(ии) объявления
        ///// </summary>
        //public List<CommentDto> Comments = new List<CommentDto>();
    }
}