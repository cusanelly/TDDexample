using CloudCustomers_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        //private readonly ILogger<UsersController> _logger;
        private readonly IUsersService _usersservice;
        
        public UsersController(IUsersService usersService)
        {
            _usersservice = usersService;
        }
        //public UsersController(ILogger<UsersController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> Get()
        {
            var users = await _usersservice.GetAllUsers();
            return Ok("All good");
        }
    }
}