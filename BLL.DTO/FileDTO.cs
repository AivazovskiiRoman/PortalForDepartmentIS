using System;

namespace BLL.DTO
{
    public class FileDto : BaseDto<long?>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public FileDto()
        {
            DateCreated = DateTime.Now;
        }

        /// <summary>
        /// Название файла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Содержимое файла (в виде потока байтов)
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// Дата создания файла
        /// </summary>
        public DateTime DateCreated { get; private set; }
    }
}