using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraStractur.Migrations
{
    /// <inheritdoc />
    public partial class ss2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Count_Seats",
                table: "seats",
                newName: "Index_Seats");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Index_Seats",
                table: "seats",
                newName: "Count_Seats");
        }
    }
}
