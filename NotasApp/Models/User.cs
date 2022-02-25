using System.ComponentModel.DataAnnotations;

namespace NotasApp.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
