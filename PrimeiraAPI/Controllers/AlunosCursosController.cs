using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Data;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosCursosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlunosCursosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AlunosCursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlunoCursos>>> GetAlunosCursos()
        {
            return await _context.AlunosCursos.ToListAsync();
        }

        // GET: api/AlunosCursos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlunoCursos>> GetAlunoCursos(Guid id)
        {
            var alunoCursos = await _context.AlunosCursos.FindAsync(id);

            if (alunoCursos == null)
            {
                return NotFound();
            }

            return alunoCursos;
        }

        // PUT: api/AlunosCursos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlunoCursos(Guid id, AlunoCursos alunoCursos)
        {
            if (id != alunoCursos.AlunoCursosId)
            {
                return BadRequest();
            }

            _context.Entry(alunoCursos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlunoCursosExists(id))
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

        // POST: api/AlunosCursos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlunoCursos>> PostAlunoCursos(AlunoCursos alunoCursos)
        {
            _context.AlunosCursos.Add(alunoCursos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlunoCursos", new { id = alunoCursos.AlunoCursosId }, alunoCursos);
        }

        // DELETE: api/AlunosCursos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlunoCursos(Guid id)
        {
            var alunoCursos = await _context.AlunosCursos.FindAsync(id);
            if (alunoCursos == null)
            {
                return NotFound();
            }

            _context.AlunosCursos.Remove(alunoCursos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlunoCursosExists(Guid id)
        {
            return _context.AlunosCursos.Any(e => e.AlunoCursosId == id);
        }
    }
}
