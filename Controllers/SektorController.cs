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
        private readonly IRepository<Sektor> _sektorRepository;
        private readonly DataContext context;

        public SektorController(IRepository<Sektor> sektorrepository, DataContext context)
        {
            _sektorRepository = sektorrepository;
        }

        [HttpGet]

        public IEnumerable<Sektor> Get()
        {
            var result = _sektorRepository.Get();
            return result.AsEnumerable();
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var sektor = await _sektorRepository.GetById(id);
                ArgumentNullException.ThrowIfNull(sektor, "Data sektor tidak ditemukan!");
                return Ok(sektor);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] Sektor value)
        {
            try
            {
                var result = await _sektorRepository.Post(value);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] Sektor value)
        {
            try
            {
                var result = await _sektorRepository.Put(id, value);
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
                var result = await _sektorRepository.Delete(id);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
