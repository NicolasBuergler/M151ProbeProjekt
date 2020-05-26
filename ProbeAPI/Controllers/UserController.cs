using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProbeAPI.Model;
using ProbeAPI.Services;

namespace ProbeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public User Login([FromBody] AuthenticatRequest authenticatRequest)
        {
            return _userService.Authenticate(authenticatRequest.Username, authenticatRequest.Password);
        }
    }
}