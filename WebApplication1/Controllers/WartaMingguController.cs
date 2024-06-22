using AppDomain.Interfaces;
using AppDomain.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WartaMingguController :Controller
    {
         private readonly IWartaMinggu _wartamingguRepository;

            public WartaMingguController(IWartaMinggu wartamingguRepository)
            {
                _wartamingguRepository = wartamingguRepository;
            }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<WartaJemaat>))]
        public IActionResult GetWartas()
        {
            var hasil = _wartamingguRepository.GetWartas();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(hasil);
        }

        [HttpGet("{Libid}")]
        public async Task<ActionResult<WartaJemaat>> GetById(int Libid)
        {
            try
            {
                var hasil = await _wartamingguRepository.GetById(Libid);
                if (hasil == null) return NotFound();
                return hasil;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<WartaJemaat>> Post(WartaJemaat liturgiIbadah)
        {
            try
            {
                if (liturgiIbadah == null)
                    return BadRequest();
                var tambah = await _wartamingguRepository.Post(liturgiIbadah);
                return Ok(tambah);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{Libid}")]
        public async Task<ActionResult<WartaJemaat>> Put(int Libid, WartaJemaat liturgiIbadah)
        {
            try
            {
                if (Libid != liturgiIbadah.Libid)
                {
                    return BadRequest();
                }
                var baru = await _wartamingguRepository.Put(liturgiIbadah);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{Libid}")]
        public async Task<ActionResult<WartaJemaat>> Deleted(int Libid)
        {
            var hapusdata = await _wartamingguRepository.Delete(Libid);
            if (hapusdata == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
