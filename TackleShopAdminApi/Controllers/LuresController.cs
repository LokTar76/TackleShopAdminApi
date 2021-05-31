using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TackleShopAdminApi.Models;

namespace TackleShopAdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LuresController : ControllerBase
    {
        private readonly TackleDBContext _context;

        public LuresController(TackleDBContext context)
        {
            _context = context;
        }

        // GET: api/Lures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lure>>> GetLures()
        {
            return await _context.Lures.ToListAsync();
        }

        // GET: api/Lures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lure>> GetLure(int id)
        {
            var lure = await _context.Lures.FindAsync(id);

            if (lure == null)
            {
                return NotFound();
            }

            return lure;
        }

        // PUT: api/Lures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLure(int id, Lure lure)
        {
            if (id != lure.LureId)
            {
                return BadRequest();
            }

            _context.Entry(lure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LureExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Lures
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Lure>> PostLure(Lure lure)
        {
            _context.Lures.Add(lure);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLure", new { id = lure.LureId }, lure);
        }

        // DELETE: api/Lures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLure(int id)
        {
            var lure = await _context.Lures.FindAsync(id);
            if (lure == null)
            {
                return NotFound();
            }

            _context.Lures.Remove(lure);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LureExists(int id)
        {
            return _context.Lures.Any(e => e.LureId == id);
        }
    }
}
