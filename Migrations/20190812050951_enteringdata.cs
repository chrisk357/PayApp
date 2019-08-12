using Microsoft.EntityFrameworkCore.Migrations;

namespace PayApp.Migrations
{
    public partial class enteringdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeCard_AspNetUsers_AppUserId",
                table: "TimeCard");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeCard_Location_LocationID",
                table: "TimeCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeCard",
                table: "TimeCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "TimeCard",
                newName: "TimeCards");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameIndex(
                name: "IX_TimeCard_LocationID",
                table: "TimeCards",
                newName: "IX_TimeCards_LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_TimeCard_AppUserId",
                table: "TimeCards",
                newName: "IX_TimeCards_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeCards",
                table: "TimeCards",
                column: "TimeCardID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeCards_AspNetUsers_AppUserId",
                table: "TimeCards",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeCards_Locations_LocationID",
                table: "TimeCards",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeCards_AspNetUsers_AppUserId",
                table: "TimeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeCards_Locations_LocationID",
                table: "TimeCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeCards",
                table: "TimeCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "TimeCards",
                newName: "TimeCard");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameIndex(
                name: "IX_TimeCards_LocationID",
                table: "TimeCard",
                newName: "IX_TimeCard_LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_TimeCards_AppUserId",
                table: "TimeCard",
                newName: "IX_TimeCard_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeCard",
                table: "TimeCard",
                column: "TimeCardID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeCard_AspNetUsers_AppUserId",
                table: "TimeCard",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeCard_Location_LocationID",
                table: "TimeCard",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
