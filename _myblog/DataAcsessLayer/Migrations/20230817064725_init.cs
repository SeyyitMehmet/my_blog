using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcsessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Blogstatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "footer",
                columns: table => new
                {
                    FooterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Awards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Help = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OzluSoz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Google = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_footer", x => x.FooterID);
                });

            migrationBuilder.CreateTable(
                name: "menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuKatagori = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menus", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "navbar",
                columns: table => new
                {
                    NavbarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hakkımda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kurslar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oyunlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Web = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResiminÜstYAzısı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BüyükResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KüçükResim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_navbar", x => x.NavbarID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "footer");

            migrationBuilder.DropTable(
                name: "menus");

            migrationBuilder.DropTable(
                name: "navbar");
        }
    }
}
