using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PayApp.Migrations
{
    public partial class updateddatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ShiftDate",
                table: "TimeCard",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ShiftDate",
                table: "TimeCard",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));
        }
    }
}
