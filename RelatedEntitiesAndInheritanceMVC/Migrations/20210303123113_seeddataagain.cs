using Microsoft.EntityFrameworkCore.Migrations;

namespace RelatedEntitiesAndInheritanceMVC.Migrations
{
    public partial class seeddataagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "PropertyId", "Address", "Description", "Discriminator", "Name", "RoomCount" },
                values: new object[,]
                {
                    { 1, "USA", "5 star rated hotel", "Hotel", "Hotel Chai Palace", 0 },
                    { 2, "USA", "4 star rated hotel", "Hotel", "Hotel Taj Palace", 0 }
                });

            migrationBuilder.InsertData(
                table: "PropertyBookingWebServers",
                columns: new[] { "PropertyBookingWebServerId", "Discriminator" },
                values: new object[,]
                {
                    { 2, "AirBnb" },
                    { 3, "Expedia" },
                    { 1, "InnRoad" }
                });

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

            migrationBuilder.InsertData(
                table: "propertyBookingWebServerHasProperties",
                columns: new[] { "PropertyId", "PropertyBookingWebServerId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 1, 1 },
                    { 2, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyBookingWebServers",
                keyColumn: "PropertyBookingWebServerId",
                keyValue: 3);

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
                table: "propertyBookingWebServerHasProperties",
                keyColumns: new[] { "PropertyId", "PropertyBookingWebServerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "propertyBookingWebServerHasProperties",
                keyColumns: new[] { "PropertyId", "PropertyBookingWebServerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "propertyBookingWebServerHasProperties",
                keyColumns: new[] { "PropertyId", "PropertyBookingWebServerId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "PropertyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyBookingWebServers",
                keyColumn: "PropertyBookingWebServerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyBookingWebServers",
                keyColumn: "PropertyBookingWebServerId",
                keyValue: 1);
        }
    }
}
