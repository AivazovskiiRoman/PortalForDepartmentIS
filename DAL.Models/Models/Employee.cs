namespace DAL.Models
{
    /// <summary>
    /// Модель сотрудник
    /// </summary>
    public class Employee : BaseModel<long?>
    {
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Создаем связь с моделью Пользователь
        /// </summary>
        public virtual User User { get; set; }
    }
}