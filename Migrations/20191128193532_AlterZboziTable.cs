using Microsoft.EntityFrameworkCore.Migrations;

namespace FileProcessor.Migrations
{
    public partial class AlterZboziTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pocet_objednanych_kusu",
                table: "Zbozi",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pocet_objednanych_kusu",
                table: "Zbozi");
        }
    }
}
