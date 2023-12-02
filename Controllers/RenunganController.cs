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

        [HttpPost]
        public async Task<ActionResult<Renungan>> Post(Renungan renungan)
        {
            try
            {
                if (renungan == null)
                    return BadRequest();
                var tambah = await _renunganRepository.Post(renungan);
                return Ok(tambah);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Renungan>> Put(int id, Renungan renungan)
        {
            try
            {
                if(id != renungan.Renunganid)
                {
                    return BadRequest();
                }
                var databaru = await _renunganRepository.Put(renungan);
                return Ok(databaru);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Renungan>> Deleted(int id)
        {
            var hapusdata = await _renunganRepository.Delete(id);
            if(hapusdata == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
