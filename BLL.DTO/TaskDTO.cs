using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class TaskDto : BaseDto<long?>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public TaskDto()
        {
            DateCreated = DateTime.Now;
        }

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
        public DateTime DateCreated { get; private set; }

        /// <summary>
        /// Крайний срок выпролнения задачи
        /// </summary>
        public DateTime DeadLine { get; set; }

        /// <summary>
        /// Файл(ы) задачи
        /// </summary>
        public List<FileDto> Files = new List<FileDto>();

        /// <summary>
        /// Комментарий(ии) задачи
        /// </summary>
        public List<CommentDto> Comments = new List<CommentDto>();

        /// <summary>
        /// Список пользователей кому предоставлена данная задача (Ответственные)
        /// </summary>
        public List<UserDto> Users = new List<UserDto>();
    }
}