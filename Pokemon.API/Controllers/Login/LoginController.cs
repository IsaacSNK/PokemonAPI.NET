using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Pokemon.API.Models;
using Pokemon.API.Services;

namespace Pokemon.API.Controllers.Login
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private static List<User> appUsers = new List<User>
        {
            new User { FullName = "Isaac", Password = "12345", Username = "isaac", UserRole = "ServiceUser" }
        };

        private IConfiguration _config;
        private JWTAuthenticationService _authService;

        public LoginController(IConfiguration config, JWTAuthenticationService authService)
        {
            this._config = config;
            this._authService = authService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] User login)
        {
            User authUser = this.AuthenticateUser(login);
            if (authUser != null)
            {
                return Ok(new
                {
                    user = authUser.Username,
                    token = GenerateJWTToken(authUser)
                });
            }
            return Unauthorized();
        }

        private string GenerateJWTToken(User user)
        {
            return this._authService.GetToken(user.Username);
        }

        private User AuthenticateUser(User login)
        {
            return appUsers.SingleOrDefault(current => current.Username == login.Username && current.Password == login.Password);
        }
    }
}
