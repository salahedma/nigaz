using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraStractur.Migrations
{
    /// <inheritdoc />
    public partial class UserCatigory1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCatigory_AspNetUsers_UserId",
                table: "UserCatigory");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCatigory_catigories_CatigoryId",
                table: "UserCatigory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCatigory",
                table: "UserCatigory");

            migrationBuilder.RenameTable(
                name: "UserCatigory",
                newName: "userCatigories");

            migrationBuilder.RenameIndex(
                name: "IX_UserCatigory_UserId",
                table: "userCatigories",
                newName: "IX_userCatigories_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCatigory_CatigoryId",
                table: "userCatigories",
                newName: "IX_userCatigories_CatigoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userCatigories",
                table: "userCatigories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userCatigories_AspNetUsers_UserId",
                table: "userCatigories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userCatigories_catigories_CatigoryId",
                table: "userCatigories",
                column: "CatigoryId",
                principalTable: "catigories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userCatigories_AspNetUsers_UserId",
                table: "userCatigories");

            migrationBuilder.DropForeignKey(
                name: "FK_userCatigories_catigories_CatigoryId",
                table: "userCatigories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userCatigories",
                table: "userCatigories");

            migrationBuilder.RenameTable(
                name: "userCatigories",
                newName: "UserCatigory");

            migrationBuilder.RenameIndex(
                name: "IX_userCatigories_UserId",
                table: "UserCatigory",
                newName: "IX_UserCatigory_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_userCatigories_CatigoryId",
                table: "UserCatigory",
                newName: "IX_UserCatigory_CatigoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCatigory",
                table: "UserCatigory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCatigory_AspNetUsers_UserId",
                table: "UserCatigory",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCatigory_catigories_CatigoryId",
                table: "UserCatigory",
                column: "CatigoryId",
                principalTable: "catigories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
