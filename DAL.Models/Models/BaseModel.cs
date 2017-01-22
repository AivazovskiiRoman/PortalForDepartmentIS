namespace DAL.Models
{
    /// <summary>
    /// Базовая модель для всех сущностей
    /// </summary>
    /// <typeparam name="T">Тип первичного ключа</typeparam>
    public abstract class BaseModel<T>
    {
        public T Id { get; set; }
    }
}
