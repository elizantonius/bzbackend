using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using bzbackend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUsers _usersRepository;
        private readonly DataContext context;

        public UsersController(IUsers usersrepository, DataContext context)
        {
            _usersRepository = usersrepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Users>))]
        public IActionResult GetUsers()
        {
            var pengguna = _usersRepository.GetUsers();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pengguna);
        }
        [HttpGet("{Usersid}")]
        public async Task<ActionResult<Users>> GetById(int id)
        {
            try
            {
                var hasil = await _usersRepository.GetById(id);
                if (hasil == null) return NotFound();
                return hasil;

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Kesalahan saat mengambil data dari database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Users>> Post(Users users)
        {
            try
            {
                if (users == null)
                    return BadRequest();
                var tambah = await _usersRepository.Post(users);
                return Ok(tambah);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Users>> Put(int id, Users users)
        {
            try
            {
                if(id != users.Usersid)
                {
                    return BadRequest();
                }

                var databaru = await _usersRepository.Put(users);
                return Ok(databaru);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Users>> Deleted(int id)
        {
            var hapusdata = await _usersRepository.Delete(id);
            if(hapusdata == null)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
