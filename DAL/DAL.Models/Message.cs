using System;

namespace DAL.Models
{
    /// <summary>
    /// Модель сообщения
    /// </summary>
    public class Message : BaseModel<long?>
    {
        /// <summary>
        /// Дата создания сообщения
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Содержимое сообщения
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Отправитель сообщения
        /// </summary>
        public virtual User Sender { get; set; }

        /// <summary>
        /// Получатель сообщения
        /// </summary>
        public virtual User Recipient { get; set; }


    }
}