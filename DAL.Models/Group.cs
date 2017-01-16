using System.Collections.Generic;

namespace DAL.Models
{
    /// <summary>
    /// Группа
    /// </summary>
    public class Group : BaseModel<long?>
    {
        /// <summary>
        /// Название группы
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список пользователей данной группы
        /// </summary>
        public virtual List<User> Users { get; set; }
    }
}