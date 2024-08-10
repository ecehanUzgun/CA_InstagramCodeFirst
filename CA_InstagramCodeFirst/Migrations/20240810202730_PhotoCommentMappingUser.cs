using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CA_InstagramCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class PhotoCommentMappingUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PhotoComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoComments_UserId",
                table: "PhotoComments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoComments_Users_UserId",
                table: "PhotoComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoComments_Users_UserId",
                table: "PhotoComments");

            migrationBuilder.DropIndex(
                name: "IX_PhotoComments_UserId",
                table: "PhotoComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PhotoComments");
        }
    }
}
