using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Repository;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   public class JemaatController : Controller
    {
        private readonly IJemaatRepository _jemaatRepository;
        private readonly DataContext context;

        public JemaatController(IJemaatRepository jemaatRepository, DataContext context)
        {
            _jemaatRepository = jemaatRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Jemaat>))]
        public IActionResult GetJemaat()
        {
            var jemaats = _jemaatRepository.GetJemaat();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(jemaats);
        }


        [HttpPost]
        public async Task<ActionResult<Jemaat>> Post(Jemaat jemaat)
        {
            try
            {
                if (jemaat == null)
                    return BadRequest();
                var tambah = await _jemaatRepository.Post(jemaat);
                return CreatedAtAction(nameof(GetJemaat), new { id = tambah.Jemaatid}, Post);
            } catch (Exception) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Terjadi kesalahan saat membuat catatan Jemaat baru");
            }
        }

    }
}
