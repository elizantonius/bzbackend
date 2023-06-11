using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenunganController : Controller
    {
        private readonly IRenunganRepository _renunganRepository;
        private readonly DataContext context;

        public RenunganController(IRenunganRepository renunganRepository, DataContext context)
        {
            _renunganRepository = renunganRepository;
            
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Renungan>))]
        public IActionResult GetRenungans()
        {
            var renungan = _renunganRepository.GetRenungans();

            if (!ModelState.IsValid)
                BadRequest(ModelState);
            return Ok(renungan);
        }
    }
}
