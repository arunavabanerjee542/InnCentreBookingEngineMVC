using Microsoft.EntityFrameworkCore.Migrations;

namespace RelatedEntitiesAndInheritanceMVC.Migrations
{
    public partial class AddedManagements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "PropertyBookingWebServers",
                columns: table => new
                {
                    PropertyBookingWebServerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyBookingWebServers", x => x.PropertyBookingWebServerId);
                });

            migrationBuilder.CreateTable(
                name: "propertyBookingWebServerHasProperties",
                columns: table => new
                {
                    PropertyBookingWebServerId = table.Column<int>(nullable: false),
                    PropertyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propertyBookingWebServerHasProperties", x => new { x.PropertyId, x.PropertyBookingWebServerId });
                    table.ForeignKey(
                        name: "FK_propertyBookingWebServerHasProperties_PropertyBookingWebServers_PropertyBookingWebServerId",
                        column: x => x.PropertyBookingWebServerId,
                        principalTable: "PropertyBookingWebServers",
                        principalColumn: "PropertyBookingWebServerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_propertyBookingWebServerHasProperties_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_propertyBookingWebServerHasProperties_PropertyBookingWebServerId",
                table: "propertyBookingWebServerHasProperties",
                column: "PropertyBookingWebServerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "propertyBookingWebServerHasProperties");

            migrationBuilder.DropTable(
                name: "PropertyBookingWebServers");

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
    }
}
