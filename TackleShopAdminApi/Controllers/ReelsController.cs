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
    public class ReelsController : ControllerBase
    {
        private readonly TackleDBContext _context;

        public ReelsController(TackleDBContext context)
        {
            _context = context;
        }

        // GET: api/Reels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reel>>> GetReels()
        {
            return await _context.Reels.ToListAsync();
        }

        // GET: api/Reels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reel>> GetReel(int id)
        {
            var reel = await _context.Reels.FindAsync(id);

            if (reel == null)
            {
                return NotFound();
            }

            return reel;
        }

        // PUT: api/Reels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReel(int id, Reel reel)
        {
            if (id != reel.ReelId)
            {
                return BadRequest();
            }

            _context.Entry(reel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReelExists(id))
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

        // POST: api/Reels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reel>> PostReel(Reel reel)
        {
            _context.Reels.Add(reel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReel", new { id = reel.ReelId }, reel);
        }

        // DELETE: api/Reels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReel(int id)
        {
            var reel = await _context.Reels.FindAsync(id);
            if (reel == null)
            {
                return NotFound();
            }

            _context.Reels.Remove(reel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReelExists(int id)
        {
            return _context.Reels.Any(e => e.ReelId == id);
        }
    }
}
