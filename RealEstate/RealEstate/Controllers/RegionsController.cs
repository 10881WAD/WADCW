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
    public class RegionsController : ControllerBase
    {
        private readonly IRepository<Region> _regionRepo;

        public RegionsController(IRepository<Region> regionRepo)
        {
            _regionRepo = regionRepo;
        }

        public async Task<IActionResult> Get()
        {
            var regions = await _regionRepo.GetAll();
            return Ok(regions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var region = await _regionRepo.GetById(id);
            return Ok(region);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Region region)
        {
            if (region == null)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _regionRepo.Create(region);

            return Created("", region);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Region region)
        {


            var dbRegion = await _regionRepo.GetById(id);
            if (dbRegion == null)
                return NotFound();
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            await _regionRepo.Update(region);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {


            await _regionRepo.Delete(id);

            return NoContent();
        }
    }
}
