using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Parqueadero_Api.Data;
using Parqueadero_Api.Models;

namespace Parqueadero_Api.Controllers.v1
{
    [ApiController]
    [Route("api/v1/vehiculos")]
    public class VehiculosController: ControllerBase
    {
        private readonly DataContext context;

        public VehiculosController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<VEHICULO>>> Get()
        {
           return await context.VEHICULOS.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> PostVehiculos(VEHICULO vehiculo)
        {
            context.Add(vehiculo);
            await context.SaveChangesAsync();
            return Ok ("Se creo correctamente un registro");
        }

        [HttpPut("{id_vehiculo:int}")]
        public async Task<ActionResult> EditVehiculos(VEHICULO vehiculo, int id_vehiculo)
        {
            if(vehiculo.id_vehiculo != id_vehiculo)
            {
                return BadRequest("No coincide con el Id de la URL");
            }

            context.Update(vehiculo);
            await context.SaveChangesAsync();
            return Ok ("Se ha actualizado correctamente");
        }
        [HttpDelete("{id_vehiculo:int}")]
        public async Task<ActionResult> DeleteVehiculos(int id_vehiculo)
        {
            var db_vehiculos = await context.VEHICULOS.AnyAsync(c => c.id_vehiculo == id_vehiculo);

            if(!db_vehiculos)
            {
                return NotFound("No existe ese vehículo con ese código");
            }

            context.Remove(new VEHICULO() {id_vehiculo = id_vehiculo});
            await context.SaveChangesAsync();
            return Ok("Se ha eliminado el vehículo correctamente");
        }
    }
}
