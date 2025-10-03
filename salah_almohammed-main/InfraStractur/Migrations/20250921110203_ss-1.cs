using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraStractur.Migrations
{
    /// <inheritdoc />
    public partial class ss1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "seats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Count_Seats = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CatigoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsAcrive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_seats_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_seats_catigories_CatigoryId",
                        column: x => x.CatigoryId,
                        principalTable: "catigories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_seats_CatigoryId",
                table: "seats",
                column: "CatigoryId");

            migrationBuilder.CreateIndex(
                name: "IX_seats_UserId",
                table: "seats",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "seats");
        }
    }
}
