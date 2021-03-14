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
    public class HousesController : ControllerBase
    {
        private readonly IRepository<House> _houseRepo;

        public HousesController(IRepository<House> houseRepo)
        {
            _houseRepo = houseRepo;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var houses = await _houseRepo.GetAll();
            return Ok(houses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var house = await _houseRepo.GetById(id);
            return Ok(house);
        }
    }
}
