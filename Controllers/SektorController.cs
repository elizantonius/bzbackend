using bzbackend.Data;
using bzbackend.Interfaces;
using bzbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace bzbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SektorController : Controller
    {
        private readonly ISektor _sektorrepository;
        private readonly DataContext context;

        public SektorController(ISektor sektorrepository, DataContext context)
        {
            _sektorrepository = sektorrepository;
            
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Sektor>))]

        public IActionResult GetSektors()
        {
            var sektor = _sektorrepository.GetSektors();

            if (!ModelState.IsValid)
                BadRequest(ModelState);
            return Ok(sektor);
        }
    }
}
