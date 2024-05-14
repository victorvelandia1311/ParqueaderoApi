using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Parqueadero_Api.Migrations
{
    /// <inheritdoc />
    public partial class CLIENTE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VEHICULOS",
                table: "VEHICULOS");

            migrationBuilder.RenameTable(
                name: "VEHICULOS",
                newName: "VEHICULO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VEHICULO",
                table: "VEHICULO",
                column: "id_vehiculo");

            migrationBuilder.CreateTable(
                name: "CLIENTE",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_cliente = table.Column<int>(type: "integer", nullable: false),
                    apellido_cliente = table.Column<int>(type: "integer", nullable: false),
                    cc_cliente = table.Column<int>(type: "integer", nullable: false),
                    id_vehiculo = table.Column<int>(type: "integer", nullable: false),
                    VEHICULOid_vehiculo = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTE", x => x.id_cliente);
                    table.ForeignKey(
                        name: "FK_CLIENTE_VEHICULO_VEHICULOid_vehiculo",
                        column: x => x.VEHICULOid_vehiculo,
                        principalTable: "VEHICULO",
                        principalColumn: "id_vehiculo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTE_VEHICULOid_vehiculo",
                table: "CLIENTE",
                column: "VEHICULOid_vehiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VEHICULO",
                table: "VEHICULO");

            migrationBuilder.RenameTable(
                name: "VEHICULO",
                newName: "VEHICULOS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VEHICULOS",
                table: "VEHICULOS",
                column: "id_vehiculo");
        }
    }
}
