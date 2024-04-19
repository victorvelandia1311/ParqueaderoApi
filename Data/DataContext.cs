using Microsoft.EntityFrameworkCore;
using Parqueadero_Api.Models;

namespace Parqueadero_Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<VEHICULOS> VEHICULO { get; set; }
    }

    
}
