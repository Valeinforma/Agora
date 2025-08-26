using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.DataContext;
using Service.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposInscripcionesCapacitacionesController : ControllerBase
    {
        private readonly AgoraContext _context;

        public TiposInscripcionesCapacitacionesController(AgoraContext context)
        {
            _context = context;
        }

        // GET: api/TiposInscripcionesCapacitaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoInscripcionCapacitacion>>> GetTiposInscripcionesCapacitaciones()
        {
            return await _context.TiposInscripcionesCapacitaciones.Include(t => t.Capacitacion).Include(t => t.TipoInscripcion).ToListAsync();
        }

        // GET: api/TiposInscripcionesCapacitaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoInscripcionCapacitacion>> GetTipoInscripcionCapacitacion(int id)
        {
            var tipoInscripcionCapacitacion = await _context.TiposInscripcionesCapacitaciones.FindAsync(id);

            if (tipoInscripcionCapacitacion == null)
            {
                return NotFound();
            }

            return tipoInscripcionCapacitacion;
        }

        // PUT: api/TiposInscripcionesCapacitaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoInscripcionCapacitacion(int id, TipoInscripcionCapacitacion tipoInscripcionCapacitacion)
        {
            if (id != tipoInscripcionCapacitacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoInscripcionCapacitacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoInscripcionCapacitacionExists(id))
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

        // POST: api/TiposInscripcionesCapacitaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoInscripcionCapacitacion>> PostTipoInscripcionCapacitacion(TipoInscripcionCapacitacion tipoInscripcionCapacitacion)
        {
            _context.TiposInscripcionesCapacitaciones.Add(tipoInscripcionCapacitacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoInscripcionCapacitacion", new { id = tipoInscripcionCapacitacion.Id }, tipoInscripcionCapacitacion);
        }

        // DELETE: api/TiposInscripcionesCapacitaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoInscripcionCapacitacion(int id)
        {
            var tipoInscripcionCapacitacion = await _context.TiposInscripcionesCapacitaciones.FindAsync(id);
            if (tipoInscripcionCapacitacion == null)
            {
                return NotFound();
            }
            tipoInscripcionCapacitacion.IsDeleted = true;
            _context.TiposInscripcionesCapacitaciones.Update(tipoInscripcionCapacitacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreCapacitacion(int id)
        {
            var capacitacion = await _context.Capacitaciones.IgnoreQueryFilters
                ().FirstOrDefaultAsync(c => c.Id.Equals(id));
            if (capacitacion == null)
            {
                return NotFound();
            }
            capacitacion.IsDeleted = false;
            _context.Capacitaciones.Update(capacitacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // GET: api/Capacitaciones
        [HttpGet("deleteds/")]
        public async Task<ActionResult<IEnumerable<Capacitacion>>> GetCapacitacionesDeleteds()
        {
            return await _context.Capacitaciones.IgnoreQueryFilters().Where(c => c.IsDeleted).ToListAsync();
        }

        private bool TipoInscripcionCapacitacionExists(int id)
        {
            return _context.TiposInscripcionesCapacitaciones.Any(e => e.Id == id);
        }
    }
}
