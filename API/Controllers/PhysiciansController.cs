using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class PhysiciansController : BaseApiController
    {
        private readonly DataContext _context;

        public PhysiciansController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] //api/physicians
        public async Task<ActionResult<List<Physician>>> GetPhysicians()
        {
            return await _context.Physicians.ToListAsync();
        }

        [HttpGet("{id}")] //api/physicians/fsfsfs
        public async Task<ActionResult<Physician>> GetPhysician(Guid id)
        {
            return await _context.Physicians.FindAsync(id);
        }
    }
}