namespace BLL.DTO
{
    public class UserDto
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Информация о пользователе
        /// </summary>
        public string About { get; set; }

        /// <summary>
        /// Фото пользователя
        /// </summary>
        public byte[] Photo { get; set; }
    }
}