using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUsers _usersrepository;
        private readonly DataContext context;

        public UserController(IUsers usersrepository, DataContext context)
        {
            _usersrepository = usersrepository;
            
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Users>))]

        public IActionResult GetUsers()
        {
            var user = _usersrepository.GetUsers();

            if (!ModelState.IsValid)
                BadRequest(ModelState);
            return Ok(user);
        }
    }
}
