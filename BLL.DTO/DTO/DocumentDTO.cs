using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class DocumentDto : BaseDto<long?>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public DocumentDto()
        {
            DateCreated = DateTime.Now;
        }

        /// <summary>
        /// Название документа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Прикрепленный файл
        /// </summary>
        public FileDto File { get; set; }

        /// <summary>
        /// Дата создания документа
        /// </summary>
        public DateTime DateCreated { get; private set; }

        /// <summary>
        /// Список пользователей кому предоставлен данный документ
        /// </summary>
        public List<UserDto> Users = new List<UserDto>();
    }
}