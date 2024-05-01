using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Users
    {
        [Key]
        public int? id { get; set; }

        [Required]
        public String? user { get; set; } = "";
        [Required]
        public String? address { get; set; } = "";
    }
}
