using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practiceWebAPI.DataBase;
using practiceWebAPI.Model_file;

namespace practiceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeOfProfessionsController : ControllerBase
    {
        private readonly DataContext _context;

        public TypeOfProfessionsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/TypeOfProfessions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeOfProfessions>>> GetTypeOfProfessions()
        {
            return await _context.TypeOfProfessions.ToListAsync();
        }

        // GET: api/TypeOfProfessions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeOfProfessions>> GetTypeOfProfessions(int id)
        {
            var typeOfProfessions = await _context.TypeOfProfessions.FindAsync(id);

            if (typeOfProfessions == null)
            {
                return NotFound();
            }

            return typeOfProfessions;
        }

        // PUT: api/TypeOfProfessions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeOfProfessions(int id, TypeOfProfessions typeOfProfessions)
        {
            if (id != typeOfProfessions.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeOfProfessions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOfProfessionsExists(id))
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

        // POST: api/TypeOfProfessions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeOfProfessions>> PostTypeOfProfessions(TypeOfProfessions typeOfProfessions)
        {
            _context.TypeOfProfessions.Add(typeOfProfessions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeOfProfessions", new { id = typeOfProfessions.Id }, typeOfProfessions);
        }

        // DELETE: api/TypeOfProfessions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeOfProfessions(int id)
        {
            var typeOfProfessions = await _context.TypeOfProfessions.FindAsync(id);
            if (typeOfProfessions == null)
            {
                return NotFound();
            }

            _context.TypeOfProfessions.Remove(typeOfProfessions);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeOfProfessionsExists(int id)
        {
            return _context.TypeOfProfessions.Any(e => e.Id == id);
        }
    }
}
