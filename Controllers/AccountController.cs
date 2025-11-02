using APIGenerationProject.DTOs;
using APIGenerationProject.Models.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APIGenerationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly UserManager<ApplicationUser> userManager;
        public AccountController(UserManager<ApplicationUser> userManager, IConfiguration config)
        {
            this.userManager = userManager;
            this.config = config;

            
        }
    
        [HttpPost("Register")]
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
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO) {
            if (ModelState.IsValid == true) {
                ApplicationUser User= await userManager.FindByNameAsync(loginDTO.UserName);
                if(User != null)
                {//Claims Token
                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name,User.UserName));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier,User.Id));
                    claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
                    claims.Add(new Claim(ClaimTypes.Role, "Admin"));

                    //get Role
                    var Roles = await userManager.GetRolesAsync(User);
                    foreach (var Role in Roles) {
                        claims.Add(new Claim(ClaimTypes.Role, Role));
                        
                    
                    }
                    SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Secret"]));
                    SigningCredentials signingCred =  new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


                    bool IsFound = await userManager.CheckPasswordAsync(User, loginDTO.Password);
                    JwtSecurityToken jwtToken = new JwtSecurityToken(
                        issuer: config["JWT:ValidIssuer"], //Provider API
                        audience: config["JWT:ValidAudience"],//url consumer
                        claims:claims,
                        expires: DateTime.UtcNow.AddHours(2),
                        //make Signtaure for Token  by key
                        signingCredentials: signingCred

                        );
                    return Ok(new
                    {
                        token=new  JwtSecurityTokenHandler().WriteToken(jwtToken),
                        expirations=jwtToken.ValidTo


                    }
                        );

                }
            }
            return Unauthorized();
        
        }


    }

    
}
