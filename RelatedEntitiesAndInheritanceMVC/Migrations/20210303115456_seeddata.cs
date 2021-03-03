using Microsoft.EntityFrameworkCore.Migrations;

namespace RelatedEntitiesAndInheritanceMVC.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "PropertyId", "Address", "Description", "Discriminator", "Name", "RoomCount" },
                values: new object[] { 1, "USA", "5 star rated hotel", "Hotel", "Hotel Chai Palace", 0 });

            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "PropertyId", "Address", "Description", "Discriminator", "Name", "RoomCount" },
                values: new object[] { 2, "USA", "4 star rated hotel", "Hotel", "Hotel Taj Palace", 0 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "HotelId", "IsAvailable" },
                values: new object[,]
                {
                    { 1, 1, true },
                    { 2, 1, true },
                    { 3, 1, true },
                    { 4, 2, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 2);
        }
    }
}
