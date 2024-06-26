using AppDomain.Interfaces;
using AppDomain.Models;
using AppDomain.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class KepalaKeluargaController : Controller
    {
        private readonly IKeluarga _kepalaKeluarga;

        public KepalaKeluargaController(IKeluarga kepalaKeluarga)
        {
            _kepalaKeluarga = kepalaKeluarga;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Keluarga>))]
        public IActionResult GetKkel()
        {
            var kkel = _kepalaKeluarga.GetKkels();
            if(!ModelState.IsValid){
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet("{Kkelid}")]
        public async Task<ActionResult<Keluarga>> GetById(int Kkelid)
        {
            try
            {
                var hasil = await _kepalaKeluarga.GetById(Kkelid);
                if(hasil == null) return NotFound();
                return hasil;
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Kesalahan saat mengambil data dari database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Keluarga>> Post(Keluarga kkel)
        {
            try
            {
                if(kkel == null)
                    return BadRequest();
                var tambah = await _kepalaKeluarga.Post(kkel);
                return Ok(tambah);
                
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("{Kkelid}")]
        public async Task<ActionResult<Keluarga>> Put(int Kkelid, Keluarga kkel)
        {
            try
            {
                if(Kkelid != kkel.Id)
                {
                    return BadRequest();
                }
                var databaru = await _kepalaKeluarga.Update(kkel);
                return Ok(databaru);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("{Kkelid}")]
        public async Task<ActionResult<Keluarga>> Deleted(int Kkelid)
        {
            var hapusdata = await _kepalaKeluarga.Delete(Kkelid);
            if(hapusdata == null)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}