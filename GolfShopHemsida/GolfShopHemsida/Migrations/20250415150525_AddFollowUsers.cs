using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfShopHemsida.Migrations
{
    /// <inheritdoc />
    public partial class AddFollowUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FollowUser_AspNetUsers_FollowedId",
                table: "FollowUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowUser_AspNetUsers_FollowerId",
                table: "FollowUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FollowUser",
                table: "FollowUser");

            migrationBuilder.RenameTable(
                name: "FollowUser",
                newName: "FollowUsers");

            migrationBuilder.RenameIndex(
                name: "IX_FollowUser_FollowedId",
                table: "FollowUsers",
                newName: "IX_FollowUsers_FollowedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FollowUsers",
                table: "FollowUsers",
                columns: new[] { "FollowerId", "FollowedId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FollowUsers_AspNetUsers_FollowedId",
                table: "FollowUsers",
                column: "FollowedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowUsers_AspNetUsers_FollowerId",
                table: "FollowUsers",
                column: "FollowerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FollowUsers_AspNetUsers_FollowedId",
                table: "FollowUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowUsers_AspNetUsers_FollowerId",
                table: "FollowUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FollowUsers",
                table: "FollowUsers");

            migrationBuilder.RenameTable(
                name: "FollowUsers",
                newName: "FollowUser");

            migrationBuilder.RenameIndex(
                name: "IX_FollowUsers_FollowedId",
                table: "FollowUser",
                newName: "IX_FollowUser_FollowedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FollowUser",
                table: "FollowUser",
                columns: new[] { "FollowerId", "FollowedId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FollowUser_AspNetUsers_FollowedId",
                table: "FollowUser",
                column: "FollowedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowUser_AspNetUsers_FollowerId",
                table: "FollowUser",
                column: "FollowerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
