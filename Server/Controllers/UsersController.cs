using BrowserTravel.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BrowserTravel.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IConfiguration _configuration;

        public UsersController (
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IConfiguration configuration
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        /// <summary>
        /// Santiago Perea 2022-Mar-03
        /// Method to create a user
        /// </summary>    
        /// <param name="UserInfo"></param>       
        /// <returns> session token</returns>
        [HttpPost("Create")]
        public async Task<ActionResult<UserToken>> PostLogin([FromBody] UserInfo model)
        {
            var user = new IdentityUser
            {
                UserName = model.email,
                Email = model.email
            };
            var resut = await _userManager.CreateAsync(user, model.Password);
            if (resut.Succeeded)
                return BuildToken(model);
            else
                return BadRequest("Username or password invalid");
        }

        /// <summary>
        /// Santiago Perea 2022-Mar-03
        /// Method to login a user
        /// </summary>    
        /// <param name="UserInfo"></param>       
        /// <returns> session token</returns>
        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] UserInfo model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.email, model.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
                return BuildToken(model);
            else
                return Unauthorized("Invalid Login");

        }

        /// <summary>
        /// Santiago Perea 2022-Mar-03
        /// Method to create JWT token
        /// </summary>    
        /// <param name="UserInfo"></param>       
        /// <returns> session token</returns>
        private UserToken BuildToken(UserInfo userInfo)
        {
            var claims = new List<Claim>()
            {
                 new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.email),
                 new Claim(ClaimTypes.Name,userInfo.email),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
             };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddYears(1);
            var token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiration,
                signingCredentials: creds
               );
            return new UserToken()
            {
                Token = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration,
            };
        }
    }
}
