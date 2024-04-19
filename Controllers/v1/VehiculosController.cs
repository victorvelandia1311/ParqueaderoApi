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
        public async Task<ActionResult<List<VEHICULOS>>> Get()
        {
           return await context.VEHICULO.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> PostVehiculos(VEHICULOS vehiculo)
        {
            context.Add(vehiculo);
            await context.SaveChangesAsync();
            return Ok ("Se creo correctamente un registro");
        }

        [HttpPut("{id_vehiculo:int}")]
        public async Task<ActionResult> EditVehiculos(VEHICULOS vehiculo, int id_vehiculo)
        {
            if(vehiculo.id_vehiculo != id_vehiculo)
            {
                return BadRequest("No coincide con el Id de la URL");
            }

            context.Update(vehiculo);
            await context.SaveChangesAsync();
            return Ok ("Se ha actualizado correctamente");
        }
    }
}
