using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenunganController : Controller
    {
        private readonly IRenunganRepository _renunganRepository;
        private readonly DataContext context;

        public RenunganController(IRenunganRepository renunganRepository, DataContext context)
        {
            _renunganRepository = renunganRepository;
            
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Renungan>))]
        public IActionResult GetRenungans()
        {
            var renungan = _renunganRepository.GetRenungans();

            if (!ModelState.IsValid)
                BadRequest(ModelState);
            return Ok(renungan);
        }
        [HttpGet("{Renunganid}")]
        public async Task<ActionResult<Renungan>> GetById(int id)
        {
            try
            {
                var hasil = await _renunganRepository.GetById(id);
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
