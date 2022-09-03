using Microsoft.EntityFrameworkCore.Migrations;

namespace LocationCollector.Migrations
{
    public partial class AddedPrsonalCodetoperson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonalCode",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalCode",
                table: "People");
        }
    }
}
