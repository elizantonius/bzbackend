﻿using AppDomain.Interfaces;
using bzbackend.Repository;
using AppDomain.Models;
using Microsoft.AspNetCore.Mvc;
//using System.Data.Entity;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   public class JemaatController : Controller
    {
        private readonly IJemaatRepository _jemaatRepository;

        public JemaatController(IJemaatRepository jemaatRepository)
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
                return Ok(tambah);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Jemaat>> Put(int id, Jemaat jemaat)
        {
            try
            {
                if(id != jemaat.Jemaatid)
                {
                    return BadRequest();
                }

                var databaru = await _jemaatRepository.Put(jemaat);
                return Ok(databaru);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Jemaat>> Deleted(int id)
        {
            var hapusdata = await _jemaatRepository.Delete(id);
            if(hapusdata == null)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
