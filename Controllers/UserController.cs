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
    }
}
