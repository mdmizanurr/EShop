using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Migrations
{
    public partial class Shop_Product_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Shops_ShopId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ShopId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "DokanId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_DokanId",
                table: "Products",
                column: "DokanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Shops_DokanId",
                table: "Products",
                column: "DokanId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Shops_DokanId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DokanId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DokanId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ShopId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShopId",
                table: "Products",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Shops_ShopId",
                table: "Products",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
