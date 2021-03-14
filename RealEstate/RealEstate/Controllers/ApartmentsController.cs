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
    }
}
