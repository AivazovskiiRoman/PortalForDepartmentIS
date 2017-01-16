namespace BLL.DTO
{
    public class EmployeeDto : BaseDto<long?>
    {
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Создаем связь с моделью Пользователь
        /// </summary>
        public UserDto User { get; set; }
    }
}