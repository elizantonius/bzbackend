using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using bzbackend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SektorController : Controller
    {
        private readonly ISektor _sektor;
        private readonly DataContext context;

        public SektorController(ISektor sektor, DataContext context)
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
      
    }
}
