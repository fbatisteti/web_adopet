using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_adopet.Server;
using web_adopet.Shared;

namespace web_adopet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RacasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Racas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Raca>>> GetRacas()
        {
            return await _context.Racas.ToListAsync();
        }

        // GET: api/Racas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Raca>> GetRaca(int id)
        {
            var raca = await _context.Racas.FindAsync(id);

            if (raca == null)
            {
                return NotFound();
            }

            return raca;
        }

        // PUT: api/Racas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaca(int id, Raca raca)
        {
            if (id != raca.RacaId)
            {
                return BadRequest();
            }

            _context.Entry(raca).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RacaExists(id))
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

        // POST: api/Racas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Raca>> PostRaca(Raca raca)
        {
            _context.Racas.Add(raca);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRaca", new { id = raca.RacaId }, raca);
        }

        // DELETE: api/Racas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Raca>> DeleteRaca(int id)
        {
            var raca = await _context.Racas.FindAsync(id);
            if (raca == null)
            {
                return NotFound();
            }

            _context.Racas.Remove(raca);
            await _context.SaveChangesAsync();

            return raca;
        }

        private bool RacaExists(int id)
        {
            return _context.Racas.Any(e => e.RacaId == id);
        }
    }
}
