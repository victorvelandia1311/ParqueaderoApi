using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parqueadero_Api.Migrations
{
    /// <inheritdoc />
    public partial class Clientev2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cc_cliente",
                table: "CLIENTE",
                newName: "cedula_cliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cedula_cliente",
                table: "CLIENTE",
                newName: "cc_cliente");
        }
    }
}
