using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcsessLayer.Migrations
{
    /// <inheritdoc />
    public partial class KullaniciBLogEK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KullaniciID",
                table: "blogEks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "kullanicimKullaniciID",
                table: "blogEks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "adminBlogaEKs",
                columns: table => new
                {
                    AdminBlogEkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminBlogEkContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminBlogEkResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminBlogEkTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminBlogaEKs", x => x.AdminBlogEkID);
                    table.ForeignKey(
                        name: "FK_adminBlogaEKs_blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "blogs",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kullanicilars",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanicilars", x => x.KullaniciID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogEks_kullanicimKullaniciID",
                table: "blogEks",
                column: "kullanicimKullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_adminBlogaEKs_BlogID",
                table: "adminBlogaEKs",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_blogEks_kullanicilars_kullanicimKullaniciID",
                table: "blogEks",
                column: "kullanicimKullaniciID",
                principalTable: "kullanicilars",
                principalColumn: "KullaniciID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogEks_kullanicilars_kullanicimKullaniciID",
                table: "blogEks");

            migrationBuilder.DropTable(
                name: "adminBlogaEKs");

            migrationBuilder.DropTable(
                name: "kullanicilars");

            migrationBuilder.DropIndex(
                name: "IX_blogEks_kullanicimKullaniciID",
                table: "blogEks");

            migrationBuilder.DropColumn(
                name: "KullaniciID",
                table: "blogEks");

            migrationBuilder.DropColumn(
                name: "kullanicimKullaniciID",
                table: "blogEks");
        }
    }
}
