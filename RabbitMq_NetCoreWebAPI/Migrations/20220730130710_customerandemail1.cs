using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RabbitMq_NetCoreWebAPI.Migrations
{
    public partial class customerandemail1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerTypes",
                table: "Customers",
                newName: "CustomerType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerType",
                table: "Customers",
                newName: "CustomerTypes");
        }
    }
}
