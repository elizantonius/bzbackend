using AppDomain.Interfaces;
using AppDomain.Models;
using bzbackend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class JIbadahController : Controller
    {
        private readonly IJIbadahRepository _jIbadahRepository;

        public JIbadahController(IJIbadahRepository jIbadahRepository)
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

        [HttpPost]
        public async Task<ActionResult<JIbadah>> Post(JIbadah jibadah)
        {
            try
            {
                if (jibadah == null)
                    return BadRequest();
                var tambah = await _jIbadahRepository.Post(jibadah);
                return Ok(tambah);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<JIbadah>> Put(int id, JIbadah jibadah)
        {
            try
            {
                if (id != jibadah.JIbadahId)
                {
                    return BadRequest();
                }

                var databaru = await _jIbadahRepository.Put(jibadah);
                return Ok(databaru);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<JIbadah>> Deleted(int id)
        {
            var hapusdata = await _jIbadahRepository.Delete(id);
            if (hapusdata == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
