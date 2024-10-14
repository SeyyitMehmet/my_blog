using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcsessLayer.Migrations
{
    /// <inheritdoc />
    public partial class hazir1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "menus",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "menus");
        }
    }
}
