using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HamsterApp.API.Data;
using HamsterApp.Entities.Models;
using AutoMapper;
using HamsterApp.Entities.DTO.Match;
using AutoMapper.QueryableExtensions;

namespace HamsterApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MatchesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Matches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MatchReadOnlyDto>>> GetMatches()
        {
            var matches = await _context.Matches
                .Include(u => u.Hamster)
                .ProjectTo<MatchReadOnlyDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            //var matchDtos = _mapper.Map<IEnumerable<MatchReadOnlyDto>>(matches);
            return Ok(matches);
        }

        // GET: api/Matches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MatchDetailDto>> GetMatch(int id)
        {
            var match = await _context.Matches
                  .Include(u => u.Hamster)
                  .ProjectTo<MatchReadOnlyDto>(_mapper.ConfigurationProvider)
                  .FirstOrDefaultAsync(u => u.Id == id);

            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

        // PUT: api/Matches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatch(int id, MatchUpdateDto matchDto)
        {
            if (id != matchDto.Id)
            {
                return BadRequest();
            }

            var match = await _context.Matches.FindAsync(id);

            if (match == null)
            {
                return NotFound();
            }

            _mapper.Map(matchDto, match);
            _context.Entry(match).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! await MatchExistsAsync(id))
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

        // POST: api/Matches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Match>> PostMatch(MatchCreateDto matchDto)
        {
            var match = _mapper.Map<Match>(matchDto);
            _context.Matches.Add(match);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMatch), new { id = match.Id }, match);

        }

        // DELETE: api/Matches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatch(int id)
        {
            var match = await _context.Matches.FindAsync(id);
            if (match == null)
            {
                return NotFound();
            }
            _context.Matches.Remove(match);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private async Task<bool> MatchExistsAsync(int id)
        {
            return await _context.Matches.AnyAsync(e => e.Id == id);
        }
    }
}
