using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veterinaria.API.Data;
using Veterinaria.Shared.Entidades;

namespace Veterinaria.API.Controllers
{
    [ApiController]
    [Route("/api/owners")]
    public class OwnersController : ControllerBase

    {
        private readonly DataContext _context;

        public OwnersController(DataContext context)
        {
            _context = context;
        }

        //Método Get- por Id
        [HttpGet()]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Owners.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Owner owner)
        {
            _context.Add(owner);
            await _context.SaveChangesAsync();
            return Ok(owner);
        }

        //Método Get- por Id
        [HttpGet("id: int")]
        public async Task<ActionResult> Get(int id)
        {
            var owner = await
            _context.Owners.SingleOrDefaultAsync(x => x.Id == id);

            if(owner == null) {
                return NotFound();
            }
            return Ok(owner);
        }

        //Método de actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Owner owner)
        {
            _context.Update(owner);
            await _context.SaveChangesAsync();
            return Ok(owner);
        }

        //Método de borrar
        [HttpDelete("id: int")]
        public async Task<ActionResult> Delete(int id)  
        {


            var FilasAfectadas = await _context.Owners

                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}
