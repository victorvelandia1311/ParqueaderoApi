using System.ComponentModel.DataAnnotations;

namespace Parqueadero_Api.Models
{
    public class CLIENTE
    {
        [Key]
        public int id_cliente { get; set; }
        public int nombre_cliente { get; set; }
        public int apellido_cliente { get; set; }
        public int cedula_cliente { get; set; }
        public int id_vehiculo { get; set; }
        public VEHICULO VEHICULO { get; set; }




    }
}
