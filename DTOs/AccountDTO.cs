using Azure.Identity;
using Microsoft.AspNetCore.Server.HttpSys;
using System.ComponentModel.DataAnnotations;

namespace APIGenerationProject.DTOs
{
    public class AccountDTO
    {
        [Required (ErrorMessage ="UserName Is Required")]

        public string Username {  get; set; }
        [Required(ErrorMessage ="Paassword is Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = " Confirm Paassword")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required] 
        
        public string Email { get; set; }

    }
}
