using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Parqueadero_Api.Migrations
{
    /// <inheritdoc />
    public partial class VEHICULOS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VEHICULO");

            migrationBuilder.CreateTable(
                name: "VEHICULOS",
                columns: table => new
                {
                    id_vehiculo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipo_vehiculo = table.Column<string>(type: "text", nullable: true),
                    placa_vehiculo = table.Column<string>(type: "text", nullable: true),
                    valor_vehiculo = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICULOS", x => x.id_vehiculo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VEHICULOS");

            migrationBuilder.CreateTable(
                name: "VEHICULO",
                columns: table => new
                {
                    id_vehiculo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    placa_vehiculo = table.Column<string>(type: "text", nullable: true),
                    tipo_vehiculo = table.Column<string>(type: "text", nullable: true),
                    valor_vehiculo = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICULO", x => x.id_vehiculo);
                });
        }
    }
}
