using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using bzbackend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersRepository : Controller
    {
        private readonly IRepository<Users> _usersRepository;
        private readonly DataContext context;

        public UsersRepository(IRepository<Users> usersrepository, DataContext context)
        {
            _usersRepository = usersrepository;
        }

        [HttpGet]

        public IEnumerable<Users> Get()
        {
            var result = _usersRepository.Get();
            return result.AsEnumerable();
        }


        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var users = await _usersRepository.GetById(id);
                ArgumentNullException.ThrowIfNull(users, "Data User/Pengguna tidak ditemukan!");
                return Ok(users);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] Users value)
        {
            try
            {
                var result = await _usersRepository.Post(value);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] Users value)
        {
            try
            {
                var result = await _usersRepository.Put(id, value);
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
                var result = await _usersRepository.Delete(id);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
