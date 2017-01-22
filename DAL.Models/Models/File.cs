using System;

namespace DAL.Models
{
    /// <summary>
    /// Модель файла
    /// </summary>
    public class File : BaseModel<long?>
    {
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
        public DateTime DateCreated { get; set; }
    }
}