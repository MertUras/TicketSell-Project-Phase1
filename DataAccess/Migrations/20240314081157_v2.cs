using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_GameId",
                table: "Roles",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Games_GameId",
                table: "Roles",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Games_GameId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_GameId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Roles");
        }
    }
}
