using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Parqueadero_Api.Data;
using Parqueadero_Api.Models;

namespace Parqueadero_Api.Controllers.v1
{
    [ApiController]
    [Route("api/v1/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly DataContext context;

        public ClientesController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<CLIENTE>>> Get()
        {
            return await context.CLIENTE.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> PostCliente(CLIENTE cliente)
        {
            context.Add(cliente);
            await context.SaveChangesAsync();
            return Ok("Se creo correctamente un registro");
        }

        [HttpPut("{id_cliente:int}")]
        public async Task<ActionResult> EditCliente(CLIENTE cliente, int id_cliente)
        {
            if (cliente.id_vehiculo != id_cliente)
            {
                return BadRequest("No coincide con el Id de la URL");
            }

            context.Update(cliente);
            await context.SaveChangesAsync();
            return Ok("Se ha actualizado correctamente");
        }
        [HttpDelete("{id_cliente:int}")]
        public async Task<ActionResult> DeleteCliente(int id_cliente)
        {
            var db_cliente = await context.CLIENTE.AnyAsync(c => c.id_cliente == id_cliente);

            if (!db_cliente)
            {
                return NotFound("No existe el cliente con ese código");
            }

            context.Remove(new CLIENTE() { id_cliente = id_cliente });
            await context.SaveChangesAsync();
            return Ok("Se ha eliminado el cliente correctamente");
        }
    }
}

