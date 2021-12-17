using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantMS.Data.Migrations
{
    public partial class StoreID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Store_ID",
                table: "Order",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Store_ID",
                table: "DeliveryCar",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Store_ID",
                table: "Account",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Store_ID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Store_ID",
                table: "DeliveryCar");

            migrationBuilder.DropColumn(
                name: "Store_ID",
                table: "Account");
        }
    }
}
