using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesInfoController : ControllerBase
    {
        private readonly EmployeeDBContext _context;
        public EmployeesInfoController(EmployeeDBContext context) {
            _context = context;
        }


        [HttpGet]

        public IEnumerable<EmployeesInfo> GetUser()
        {
            return _context.EmployeesInfos.ToList();
        }

        [HttpGet("{id}")]

        public IEnumerable<EmployeesInfo> GetUserDetails(int id)
        {
            return _context.EmployeesInfos.Where(f => f.Id == id).ToList();
        }

        [HttpPost]

        public IActionResult Post(EmployeesInfo newUser)
        {
            _context.EmployeesInfos.Add(newUser);
            _context.SaveChanges();

            return Ok(newUser);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id) {

            if (id == null)
            {
                return NotFound("There is no userId Detected");
            }
            var deleteUser = await _context.EmployeesInfos.FindAsync(id);
            _context.EmployeesInfos.Remove(deleteUser);
           await _context.SaveChangesAsync();
            return Ok("User is Deleted");
        }
        
    }
}
