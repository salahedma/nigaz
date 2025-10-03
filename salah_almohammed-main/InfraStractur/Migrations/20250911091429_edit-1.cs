using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraStractur.Migrations
{
    /// <inheritdoc />
    public partial class edit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bus",
                table: "catigories");

            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "catigories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seats",
                table: "catigories");

            migrationBuilder.AddColumn<string>(
                name: "bus",
                table: "catigories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
