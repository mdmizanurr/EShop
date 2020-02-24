using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Migrations
{
    public partial class Customer_ClientsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Clients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Code");
        }
    }
}
