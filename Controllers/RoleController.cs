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
        public IActionResult Get()
        {
            var role = _role.GetRoles();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(role);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> GetById(int id)
        {
            try
            {
                var hasil = await _role.GetById(id);
                if (hasil == null) return NotFound();
                return hasil;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Kesalahan saat mengambil data dari database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Role>> Post(Role role)
        {
            try
            {
                if (role == null)
                    return BadRequest();

                var addRole = await _role.AddRole(role);

                return Ok(addRole);
            }
            catch (Exception ex)
            {
                return BadRequest (ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Role>> Put(int id, Role role)
        {
            
            try
            {
              if(id != role.Roleid)
            {
                return BadRequest();
            }
           var baru = await _role.Update(role);
           return Ok(baru);

            }
            catch(Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Role>> Deleted(int id)
        {
            var hapusdata = await _role.DeleteRole(id);
            if(hapusdata == null)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}
