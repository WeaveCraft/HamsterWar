using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HamsterApp.API.Data;
using HamsterApp.Entities.Models;
using AutoMapper;
using HamsterApp.API.Static;
using HamsterApp.Entities.DTO.Hamster;

namespace HamsterApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamstersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<HamstersController> _logger;

        public HamstersController(ApplicationDbContext context, IMapper mapper, ILogger<HamstersController> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/Hamsters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HamsterReadOnlyDto>>> GetHamsters()
        {
            var hamsters = _mapper.Map<IEnumerable<HamsterReadOnlyDto>>(await _context.Hamsters.ToListAsync());
            return Ok(hamsters);
        }

        // GET: api/Hamsters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HamsterReadOnlyDto>> GetHamster(int id)
        {

            var hamster = await _context.Hamsters.FindAsync(id);

          if (hamster == null)
          {
              return NotFound();
          }

            var hamsterDto = _mapper.Map<HamsterReadOnlyDto>(hamster);
            return Ok(hamsterDto);

        }

        // PUT: api/Hamsters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHamster(int id, HamsterUpdateDto hamsterDto)
        {
            if (id != hamsterDto.Id)
            {
                return BadRequest();
            }

            var hamster = await _context.Hamsters.FindAsync(id);

            if (hamster == null)
            {
                return NotFound();
            }

            _mapper.Map(hamsterDto, hamster);
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
        public async Task<ActionResult<HamsterCreateDto>> PostHamster(HamsterCreateDto hamsterDto)
        {
                var hamster = _mapper.Map<Hamster>(hamsterDto);
                await _context.Hamsters.AddAsync(hamster);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetHamster), new { id = hamster.Id }, hamster);
            //catch (Exception ex)
            //{
            //    _logger.LogError(ex, $"Error Performing POST in {nameof(PostHamster)}", hamsterDto);

            //    return StatusCode(500, Messages.Error500Message);
            //}
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
