using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using DynamicSearchWithQueryable.Data;
using DynamicSearchWithQueryable.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DynamicSearchWithQueryable.Controllers
{
    [Route("cars")]
    public class CarController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CarController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] CarSearch search)
        {
            var cars = await _context.Cars.AsQueryable().Apply(search).ToListAsync();
            return Ok(cars);
        }
    }
}