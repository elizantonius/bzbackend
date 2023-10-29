using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using bzbackend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RoleController : Controller
    {
        private readonly IRole _role;
        private readonly DataContext context;

        public RoleController(IRole role, DataContext context)
        {
            _role = role;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Role>))]

        public IActionResult GetRoles()
        {
            var role = _role.GetRoles();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(role);

        }

        [HttpGet("{RoleId}")]
        public async Task<ActionResult<Role>> GetRoleId(int id)
        {
            try
            {
                var hasil = await _role.GetRoleId(id);
                if (hasil == null) return NotFound();
                return hasil;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Kesalahan saat mengambil data dari database");
            }
        }
        

    }
}
