using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly IRepository<Apartment> _apartmentRepo;


        public ApartmentsController(IRepository<Apartment> apartmentRepo)
        {
            _apartmentRepo = apartmentRepo;
        }

        public async Task<IActionResult> Get()
        {
            var apartments = await _apartmentRepo.GetAll();
            return Ok(apartments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var apartment = await _apartmentRepo.GetById(id);
            return Ok(apartment);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Apartment apartment)
        {
            if (apartment == null)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _apartmentRepo.Create(apartment);
            return Created("", apartment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Apartment apartment)
        {


            var dbApartment = await _apartmentRepo.GetById(id);
            if (dbApartment == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _apartmentRepo.Update(apartment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {


            await _apartmentRepo.Delete(id);

            return NoContent();
        }
    }
}
