using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeritaController : Controller
    {
        private readonly IBeritaRepository _beritaRepository;
        private readonly DataContext context;
        public BeritaController(IBeritaRepository beritaRepository, DataContext context  )
        {
            _beritaRepository = beritaRepository;

        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Berita>))]
        public IActionResult GetBeritas()
        {
            var bertas = _beritaRepository.GetBeritas();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(bertas);
        }

        [HttpGet("{BeritaId}")]
        public async Task<ActionResult<Berita>> GetById(int id)
        {
            try
            {
                var hasil = await _beritaRepository.GetById(id);
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
