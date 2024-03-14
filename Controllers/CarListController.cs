using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarListController : ControllerBase
    {
        private readonly EmployeeDBContext _context;

        public CarListController(EmployeeDBContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IEnumerable<CarList> Get()
        {
            return _context.CarLists.ToList();
        }

        [HttpGet("{id}")]
       public IEnumerable<CarList> Get(int id) {

            return _context.CarLists.Where(f => f.Id == id).ToList();
        
        }




    }
}
