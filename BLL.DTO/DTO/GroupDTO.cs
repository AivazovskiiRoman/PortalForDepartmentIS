using System.Collections.Generic;

namespace BLL.DTO
{
    public class GroupDto : BaseDto<long?>
    {
        /// <summary>
        /// Название группы
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список пользователей данной группы
        /// </summary>
        public List<UserDto> Users = new List<UserDto>();
    }
}