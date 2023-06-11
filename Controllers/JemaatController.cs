using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetJemaats()
        {
            var jemaat = _jemaatRepository.GetJemaats();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(jemaat);
        }
    }
}
