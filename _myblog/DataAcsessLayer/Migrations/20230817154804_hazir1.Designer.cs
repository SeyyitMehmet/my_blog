﻿// <auto-generated />
using System;
using DataAcsessLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAcsessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230817154804_hazir1")]
    partial class hazir1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entitylayer.Concrate.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogID"));

                    b.Property<string>("BlogContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BlogCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BlogImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogThumbnailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Blogstatus")
                        .HasColumnType("bit");

                    b.HasKey("BlogID");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("Entitylayer.Concrate.Footer", b =>
                {
                    b.Property<int>("FooterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FooterID"));

                    b.Property<string>("Awards")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Google")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Help")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OzluSoz")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FooterID");

                    b.ToTable("footer");
                });

            modelBuilder.Entity("Entitylayer.Concrate.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuID"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuKatagori")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuID");

                    b.ToTable("menus");
                });

            modelBuilder.Entity("Entitylayer.Concrate.NavbarYonetimi", b =>
                {
                    b.Property<int>("NavbarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NavbarID"));

                    b.Property<string>("BüyükResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hakkımda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kurslar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KüçükResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oyunlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResiminÜstYAzısı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Web")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NavbarID");

                    b.ToTable("navbar");
                });

            modelBuilder.Entity("Entitylayer.Concrate.deneme1", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"));

                    b.Property<string>("AdminMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("admins");
                });
#pragma warning restore 612, 618
        }
    }
}