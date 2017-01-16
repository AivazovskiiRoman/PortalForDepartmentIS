using System;

namespace BLL.DTO
{
    public class MessageDto : BaseDto<long?>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public MessageDto()
        {
            DateCreated = DateTime.Now;
        }

        /// <summary>
        /// Дата создания сообщения
        /// </summary>
        public DateTime DateCreated { get; private set; }

        /// <summary>
        /// Содержимое сообщения
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Отправитель сообщения
        /// </summary>
        public UserDto Sender { get; set; }

        /// <summary>
        /// Получатель сообщения
        /// </summary>
        public UserDto Recipient { get; set; }
    }
}