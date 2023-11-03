using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using bzbackend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RoleController : ControllerBase
    {
        private readonly IRole _role;
        private readonly DataContext context;

        public RoleController(IRole role, DataContext context)
        {
            _role = role;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Role>))]
        public IActionResult GetRole()
        {
            var role = _role.GetRoles();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(role);
        }

    }
}
