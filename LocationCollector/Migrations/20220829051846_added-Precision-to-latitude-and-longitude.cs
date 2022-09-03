using Microsoft.EntityFrameworkCore.Migrations;

namespace LocationCollector.Migrations
{
    public partial class addedPrecisiontolatitudeandlongitude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "People",
                type: "decimal(18,14)",
                precision: 18,
                scale: 14,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "People",
                type: "decimal(18,14)",
                precision: 18,
                scale: 14,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "People",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,14)",
                oldPrecision: 18,
                oldScale: 14);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "People",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,14)",
                oldPrecision: 18,
                oldScale: 14);
        }
    }
}
