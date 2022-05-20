using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HamsterApp.API.Data;
using HamsterApp.Entities.Models;

namespace HamsterApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamstersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HamstersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Hamsters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hamster>>> GetHamsters()
        {
          if (_context.Hamsters == null)
          {
              return NotFound();
          }
            return await _context.Hamsters.ToListAsync();
        }

        // GET: api/Hamsters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hamster>> GetHamster(int id)
        {
          if (_context.Hamsters == null)
          {
              return NotFound();
          }
            var hamster = await _context.Hamsters.FindAsync(id);

            if (hamster == null)
            {
                return NotFound();
            }

            return hamster;
        }

        // PUT: api/Hamsters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHamster(int id, Hamster hamster)
        {
            if (id != hamster.Id)
            {
                return BadRequest();
            }

            _context.Entry(hamster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HamsterExists(id))
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

        // POST: api/Hamsters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hamster>> PostHamster(Hamster hamster)
        {
          if (_context.Hamsters == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Hamsters'  is null.");
          }
            _context.Hamsters.Add(hamster);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HamsterExists(hamster.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHamster", new { id = hamster.Id }, hamster);
        }

        // DELETE: api/Hamsters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHamster(int id)
        {
            if (_context.Hamsters == null)
            {
                return NotFound();
            }
            var hamster = await _context.Hamsters.FindAsync(id);
            if (hamster == null)
            {
                return NotFound();
            }

            _context.Hamsters.Remove(hamster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HamsterExists(int id)
        {
            return (_context.Hamsters?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
