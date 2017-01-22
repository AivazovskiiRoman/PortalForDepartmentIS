using System.ComponentModel.DataAnnotations;

namespace PortalForDepartmentIS.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}