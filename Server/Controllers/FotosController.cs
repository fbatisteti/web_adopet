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
    public class FotosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FotosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Fotos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Foto>>> GetFotos()
        {
            return await _context.Fotos.ToListAsync();
        }

        // GET: api/Fotos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Foto>> GetFoto(int id)
        {
            var foto = await _context.Fotos.FindAsync(id);

            if (foto == null)
            {
                return NotFound();
            }

            return foto;
        }

        // PUT: api/Fotos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoto(int id, Foto foto)
        {
            if (id != foto.FotoId)
            {
                return BadRequest();
            }

            _context.Entry(foto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FotoExists(id))
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

        // POST: api/Fotos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Foto>> PostFoto(Foto foto)
        {
            _context.Fotos.Add(foto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoto", new { id = foto.FotoId }, foto);
        }

        // DELETE: api/Fotos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Foto>> DeleteFoto(int id)
        {
            var foto = await _context.Fotos.FindAsync(id);
            if (foto == null)
            {
                return NotFound();
            }

            _context.Fotos.Remove(foto);
            await _context.SaveChangesAsync();

            return foto;
        }

        private bool FotoExists(int id)
        {
            return _context.Fotos.Any(e => e.FotoId == id);
        }
    }
}
