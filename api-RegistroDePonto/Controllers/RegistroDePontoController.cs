using api_RegistroDePonto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}
