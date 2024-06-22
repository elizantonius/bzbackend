using AppDomain.Interfaces;
using AppDomain.Models;
using bzbackend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SektorController : Controller
    {
        private readonly ISektor _sektor;

        public SektorController(ISektor sektor)
        {
            _sektor = sektor; 
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Sektor>))]
        public IActionResult GetSektors()
        {
            var sektor = _sektor.GetSektors();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(sektor);
        }
        [HttpGet("{Sektorid}")]
        public async Task<ActionResult<Sektor>> GetById(int id)
        {
            try
            {
                var hasil = await _sektor.GetById(id);
                if (hasil == null) return NotFound();
                return hasil;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Kesalahan saat mengambil data dari database");
            }

        }

        [HttpPost]
        public async Task<ActionResult<Sektor>> Post(Sektor sektor)
        {
            try
            {
                if (sektor == null)
                    return BadRequest();
                var tambah = await _sektor.Post(sektor);
                return Ok(tambah);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Sektor>> Put(int id , Sektor sektor)
        {
            try
            {
                if(id != sektor.Sektorid)
                {
                    return BadRequest();
                }
                var baru = await _sektor.Put(sektor);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Sektor>> Deleted(int id)
        {
            var hapusdata = await _sektor.Delete(id);
            if(hapusdata == null)
            {
                return NotFound();
            }

            return NoContent();
        }
      
    }
}
