using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class JIbadahController : Controller
    {
        private readonly IJIbadahRepository _jIbadahRepository;
        private readonly DataContext context;

        public JIbadahController(IJIbadahRepository jIbadahRepository, DataContext context)
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
    }
}
