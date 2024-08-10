using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CA_InstagramCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class PhotoCommentMappingPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "PhotoComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoComments_PhotoId",
                table: "PhotoComments",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoComments_Photos_PhotoId",
                table: "PhotoComments",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoComments_Photos_PhotoId",
                table: "PhotoComments");

            migrationBuilder.DropIndex(
                name: "IX_PhotoComments_PhotoId",
                table: "PhotoComments");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "PhotoComments");
        }
    }
}
