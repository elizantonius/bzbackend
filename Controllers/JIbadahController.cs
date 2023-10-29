using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class JIbadahController : Controller
    {
        private readonly IJIbadahRepository _jIbadahRepository;
        private readonly DataContext context;

        public JIbadahController(IJIbadahRepository jIbadahRepository, DataContext context)
        {
            _jIbadahRepository = jIbadahRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<JIbadah>))]
        public IActionResult GetJIbadahs() {

            var jib = _jIbadahRepository.GetJIbadahs();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(jib);
        }

        [HttpGet("{JIbadahId}")]
        public async Task<ActionResult<JIbadah>> GetById(int id)
        {
            try
            {
                var hasil = await _jIbadahRepository.GetById(id);
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
