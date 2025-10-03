using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraStractur.Migrations
{
    /// <inheritdoc />
    public partial class UserCatigory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserCatigory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CatigoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAcrive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCatigory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCatigory_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCatigory_catigories_CatigoryId",
                        column: x => x.CatigoryId,
                        principalTable: "catigories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserCatigory_CatigoryId",
                table: "UserCatigory",
                column: "CatigoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCatigory_UserId",
                table: "UserCatigory",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCatigory");
        }
    }
}
