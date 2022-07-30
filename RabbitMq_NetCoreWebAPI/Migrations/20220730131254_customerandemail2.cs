using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RabbitMq_NetCoreWebAPI.Migrations
{
    public partial class customerandemail2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Products_ProductInfoProductId",
                table: "Emails");

            migrationBuilder.DropIndex(
                name: "IX_Emails_ProductInfoProductId",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "ProductInfoProductId",
                table: "Emails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductInfoProductId",
                table: "Emails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ProductInfoProductId",
                table: "Emails",
                column: "ProductInfoProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Products_ProductInfoProductId",
                table: "Emails",
                column: "ProductInfoProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
