using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }



        // GET: api/<UserController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<UserController>/5
        [HttpGet("{password},{email}")]
        public UserTable Get(string password, string email)
        {
            return _userService.GetByEmailAndPassword(email, password);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserTable user)
        {
            _userService.AddUser(user);

        }

       
    }
}
