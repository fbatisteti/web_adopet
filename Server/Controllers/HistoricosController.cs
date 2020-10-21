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
    public class HistoricosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HistoricosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Historicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Historico>>> GetHistoricos()
        {
            return await _context.Historicos.ToListAsync();
        }

        // GET: api/Historicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Historico>> GetHistorico(int id)
        {
            var historico = await _context.Historicos.FindAsync(id);

            if (historico == null)
            {
                return NotFound();
            }

            return historico;
        }

        // PUT: api/Historicos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistorico(int id, Historico historico)
        {
            if (id != historico.HistoricoId)
            {
                return BadRequest();
            }

            _context.Entry(historico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoricoExists(id))
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

        // POST: api/Historicos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Historico>> PostHistorico(Historico historico)
        {
            _context.Historicos.Add(historico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistorico", new { id = historico.HistoricoId }, historico);
        }

        // DELETE: api/Historicos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Historico>> DeleteHistorico(int id)
        {
            var historico = await _context.Historicos.FindAsync(id);
            if (historico == null)
            {
                return NotFound();
            }

            _context.Historicos.Remove(historico);
            await _context.SaveChangesAsync();

            return historico;
        }

        private bool HistoricoExists(int id)
        {
            return _context.Historicos.Any(e => e.HistoricoId == id);
        }
    }
}
