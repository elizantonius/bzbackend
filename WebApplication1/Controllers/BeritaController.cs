using AppDomain.Interfaces;
using AppDomain.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeritaController : Controller
    {
        private readonly IBeritaRepository _beritaRepository;
        public BeritaController(IBeritaRepository beritaRepository  )
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

        [HttpPost]
        public async Task<ActionResult<Berita>> Post(Berita berita)
        {
            try
            {
                if (berita == null)
                    return BadRequest();
                var tambah = await _beritaRepository.Post(berita);
                return Ok(tambah);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Berita>> Put(int id, Berita berita)
        {
            try
            {
                if(id != berita.Beritaid)
                {
                    return BadRequest();
                }
                var baru = await _beritaRepository.Put(berita);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Berita>> Deleted(int id)
        {
            var hapusdata = await _beritaRepository.Delete(id);
            if(hapusdata == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
