using System.ComponentModel.DataAnnotations;

namespace Parqueadero_Api.Models
{
    public class VEHICULO
    {
        [Key]
        public int id_vehiculo { get; set; }
        public string tipo_vehiculo { get; set; }
        public string placa_vehiculo { get; set; }
        public double valor_vehiculo { get; set; }
    }
}
