using api_RegistroDePonto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;

namespace api_RegistroDePonto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroDePontoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RegistroDePontoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.RegistroDePonto.ToListAsync();
            return Ok(model);
        }

        [HttpPost]
        public async Task<ActionResult> Create(RegistroDePonto model)
        {
            if (model.EntradaTarde >= model.EntradaTarde || model.EntradaTarde >= model.SaidaTarde)
            {
                return BadRequest(new { Message = "Inconsistência no lançamento das horas, confira o lançamento!" });
            }

            _context.RegistroDePonto.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = model.Id, model });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var model = await _context.RegistroDePonto
                .FirstOrDefaultAsync(c => c.Id == id);

            if (model == null) NotFound();

            return Ok(model);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, RegistroDePonto model)
        {
           if (id != model.Id) return BadRequest();

            var modelDb = await _context.RegistroDePonto.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (modelDb == null) NotFound();
            _context.RegistroDePonto.Update(model);
            await _context.SaveChangesAsync();
           
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _context.RegistroDePonto.FindAsync(id);

            if (model == null) NotFound();

            _context.RegistroDePonto.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();



        }
    }
}
