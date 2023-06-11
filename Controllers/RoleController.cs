using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private readonly IRole _rolerepository;
        private readonly DataContext context;

        public RoleController(IRole rolerepository, DataContext context)
        {
            _rolerepository = rolerepository;
            
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Role>))]

        public IActionResult GetRoles()
        {
            var role = _rolerepository.GetRoles();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(role);
        }

    }
}
