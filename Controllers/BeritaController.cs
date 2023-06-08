using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeritaController : Controller
    {
        private readonly IBeritaRepository _beritaRepository;
        private readonly DataContext context;
        public BeritaController(IBeritaRepository beritaRepository, DataContext context  )
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
    }
}
