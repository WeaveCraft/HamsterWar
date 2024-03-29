﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HamsterApp.API.Data;
using HamsterApp.Entities.Models;
using AutoMapper;
using HamsterApp.API.Static;
using HamsterApp.Entities.DTO.Hamster;
using Microsoft.AspNetCore.Authorization;

namespace HamsterApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize] //Not needed becouse we add [Authorize] for the specific Method that requires Authentication. 
    public class HamstersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<HamstersController> _logger;
        public List<Hamster> Hamsters { get; set; } = new List<Hamster>();


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
            try
            {
                var hamsters = await _context.Hamsters.ToListAsync();
                var hamstersDto = _mapper.Map<List<HamsterReadOnlyDto>>(hamsters);
                return Ok(hamstersDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error Performing GET in {nameof(GetHamsters)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }
        [HttpGet("GetFiveWinners")]
        public async Task<ActionResult<IEnumerable<HamsterReadOnlyDto>>> GetFiveHinners()
        {
            try
            {
                var hamsters = await _context.Hamsters.ToListAsync();
                var five = hamsters.OrderByDescending(u => u.Wins).Take(5);
                return Ok(five);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error Performing GET in {nameof(GetHamsters)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }
        [HttpGet("GetFiveLosers")]
        public async Task<ActionResult<IEnumerable<HamsterReadOnlyDto>>> GetLoserHamsters()
        {
            try
            {
                var hamsters = await _context.Hamsters.ToListAsync();
                var five = hamsters.OrderByDescending(u => u.Losses).Take(5);
                return Ok(five);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error Performing GET in {nameof(GetHamsters)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        // GET: api/Hamsters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HamsterReadOnlyDto>> GetHamster(int id)
        {
            try
            {
                var hamster = await _context.Hamsters.FindAsync(id);

                if (hamster == null)
                {
                    _logger.LogWarning($"Record {nameof(GetHamster)} was not found.\nId: {id}");
                    return NotFound();
                }

                var hamsterDto = _mapper.Map<HamsterReadOnlyDto>(hamster);
                return Ok(hamsterDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error performing GET in {nameof(GetHamsters)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }
        [HttpGet("GetTwoRandom")]
        public async Task<ActionResult<IEnumerable<HamsterDetailsDto>>> GetTwoRandomHamsters()
        {
            try
            {
                var hamsters = await _context.Hamsters.ToListAsync();
                hamsters = await _context.Hamsters.OrderBy(h => Guid.NewGuid()).Take(2).ToListAsync();
                var hamstersDto = _mapper.Map<IEnumerable<HamsterDetailsDto>>(hamsters);
                return Ok(hamstersDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error Performing GET(GetTwoRandom) in {nameof(PostHamster)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }
        [HttpGet("GetOneRandom")]
        public async Task<ActionResult<IEnumerable<HamsterDetailsDto>>> GetRandomHamster()
        {
            try
            {
                var hamsters = await _context.Hamsters.ToListAsync();
                hamsters = await _context.Hamsters.OrderBy(h => Guid.NewGuid()).Take(1).ToListAsync();
                var hamstersDto = _mapper.Map<IEnumerable<HamsterDetailsDto>>(hamsters);
                return Ok(hamstersDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error Performing GET(GetOneRandom) in {nameof(PostHamster)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        // PUT: api/Hamsters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutHamster(int id, HamsterUpdateDto hamsterDto)
        {
            if (id != hamsterDto.Id)
            {
                _logger.LogWarning($"Update Id invalid in {nameof(GetHamsters)} with Id {id}");
                return BadRequest();
            }

            var hamster = await _context.Hamsters.FindAsync(id);

            if (hamster == null)
            {
                _logger.LogWarning($"Record {nameof(GetHamsters)} was not found with Id {id}");
                return NotFound();
            }

            _mapper.Map(hamsterDto, hamster);
            _context.Entry(hamster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!HamsterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, $"Error performing PUT in {nameof(GetHamster)}");
                    return StatusCode(500, Messages.Error500Message);
                }
            }

            return NoContent();
        }
        [HttpPut("Increment")]
        public async Task<IActionResult> Increment(int id)
        {
            var hamsterFound = _context.Hamsters.Find(id);

            try
            {
                if (hamsterFound == null)
                {
                    return BadRequest("Hamster not found");
                }
                else
                {
                    hamsterFound.Name = hamsterFound.Name;
                    hamsterFound.Age = hamsterFound.Age;
                    hamsterFound.Loves = hamsterFound.Loves;
                    hamsterFound.Games++;
                    hamsterFound.Wins++;
                    hamsterFound.Losses = hamsterFound.Losses;
                    _context.Update(hamsterFound);
                    _context.SaveChanges();
                    return Accepted(hamsterFound);
                }

            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, $"Error performing PUT in {nameof(GetHamster)}");
                throw;
            }
        }

        [HttpPut("Decrement")]
        public async Task<IActionResult> Decrement(int id)
        {
            var hamsterFound = _context.Hamsters.Find(id);

            try
            {
                if (hamsterFound == null)
                {
                    return BadRequest("Hamster not found");
                }
                else
                {
                    hamsterFound.Name = hamsterFound.Name;
                    hamsterFound.Age = hamsterFound.Age;
                    hamsterFound.Loves = hamsterFound.Loves;
                    hamsterFound.Games++;
                    hamsterFound.Wins = hamsterFound.Wins;
                    hamsterFound.Losses++;
                    _context.Update(hamsterFound);
                    _context.SaveChanges();
                    return Accepted(hamsterFound);
                }

            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, $"Error performing PUT in {nameof(GetHamster)}");
                throw;
            }
        }
        // POST: api/Hamsters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<HamsterCreateDto>> PostHamster(HamsterCreateDto hamsterDto)
        {
            try
            {
                var hamster = _mapper.Map<Hamster>(hamsterDto);
                await _context.Hamsters.AddAsync(hamster);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetHamster), new { id = hamster.Id }, hamster);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error Performing POST in {nameof(PostHamster)}", hamsterDto);
                return StatusCode(500, Messages.Error500Message);
            }
        }

        // DELETE: api/Hamsters/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteHamster(int id)
        {
            try
            {
                if (_context.Hamsters == null)
                {
                    _logger.LogWarning($"{nameof(Hamster)} record was not found in {nameof(DeleteHamster)} with Id: {id}");
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
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error performing DELETE in {nameof(DeleteHamster)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        private bool HamsterExists(int id)
        {
            return (_context.Hamsters?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
