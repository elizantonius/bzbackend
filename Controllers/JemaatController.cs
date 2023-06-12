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
        private readonly IRepository<Jemaat> _jemaatRepository;
        private readonly DataContext context;

        public JemaatController(IRepository<Jemaat> jemaatRepository, DataContext context)
        {
            _jemaatRepository = jemaatRepository;

        }

        [HttpGet]

        public IEnumerable<Jemaat> Get()
        {
            var result = _jemaatRepository.Get();
            return result.AsEnumerable();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var jemaat = await _jemaatRepository.GetById(id);
                ArgumentNullException.ThrowIfNull(jemaat, "Data jemaat tidak ditemukan !");
                return Ok(jemaat);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Jemaat value)
        {
            try
            {
                var result = await _jemaatRepository.Post(value);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] Jemaat value)
        {
            try
            {
                var result = await _jemaatRepository.Put(id, value);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _jemaatRepository.Delete(id);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
