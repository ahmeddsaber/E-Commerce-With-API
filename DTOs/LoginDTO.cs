using System.ComponentModel.DataAnnotations;

namespace APIGenerationProject.DTOs
{
    public class LoginDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
