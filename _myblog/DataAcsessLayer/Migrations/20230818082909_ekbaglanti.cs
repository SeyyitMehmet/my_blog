using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcsessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ekbaglanti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogEks",
                columns: table => new
                {
                    BlogEkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogEkContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogEkResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogEkTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogEks", x => x.BlogEkID);
                    table.ForeignKey(
                        name: "FK_blogEks_blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "blogs",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogEks_BlogID",
                table: "blogEks",
                column: "BlogID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogEks");
        }
    }
}
