using APIGenerationProject.DTOs;
using APIGenerationProject.Models.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIGenerationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        public AccountController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;

            
        }
        [HttpPost]
        [HttpPost]
        public async Task<IActionResult> Registeration(AccountDTO accountDTO)
        {
            if (accountDTO == null)
            {
                return BadRequest("Account Not Found");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           
            ApplicationUser user = new ApplicationUser
            {
                UserName = accountDTO.Username,
                Email = accountDTO.Email
            };

            IdentityResult result = await userManager.CreateAsync(user, accountDTO.Password);

            if (result.Succeeded)
            {
                return Ok("Account Added Successfully");
            }
            else
            {
            
                List<string> errors = new List<string>();

                foreach (var error in result.Errors)
                {
                    errors.Add(error.Description);
                }

                return BadRequest(errors);
            }
            
        }

    }
}
