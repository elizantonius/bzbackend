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
        private readonly IRepository<Role> _roleRepository;
        private readonly DataContext context;

        public RoleController(IRepository<Role> roleRepository, DataContext context)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
       
        public IEnumerable<Role> Get() 
        {
            var result = _roleRepository.Get();
            return result.AsEnumerable();
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id) 
        {
            try
            {
                var role = await _roleRepository.GetById(id);
                ArgumentNullException.ThrowIfNull(role, "Data Role tidak ditemukan");
                return Ok(role);
            }
            catch(System.Exception ex) 
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] Role value )
        {
            try
            {
                var result = await _roleRepository.Post(value);
                return Ok(result);
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] Role value)
        {
            try
            {
                var result = await _roleRepository.Put(id, value);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _roleRepository.Delete(id);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
