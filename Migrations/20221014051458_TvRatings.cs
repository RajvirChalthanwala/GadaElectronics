using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GadaElectronics.Migrations
{
    public partial class TvRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "TonyTv",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "LaunchDate",
                table: "TonyTv",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TvRatings",
                table: "TonyTv",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaunchDate",
                table: "TonyTv");

            migrationBuilder.DropColumn(
                name: "TvRatings",
                table: "TonyTv");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "TonyTv",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
