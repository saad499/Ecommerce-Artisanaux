﻿// <auto-generated />
using Artisanaux.Services.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Artisanaux.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221208090829_remplissageBD")]
    partial class remplissageBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Artisanaux.Services.ProductAPI.Models.Productcs", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduct"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("IdProduct");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            IdProduct = 1,
                            CategoryName = "category1",
                            ImageURL = "https://artisanans.blob.core.windows.net/artisanans/1.jpg",
                            Price = 15.0,
                            ProductName = "ChaiseBoisMassive"
                        },
                        new
                        {
                            IdProduct = 2,
                            CategoryName = "category1",
                            ImageURL = "https://artisanans.blob.core.windows.net/artisanans/1.jpg",
                            Price = 15.0,
                            ProductName = "Chaise"
                        },
                        new
                        {
                            IdProduct = 3,
                            CategoryName = "category1",
                            ImageURL = "https://artisanans.blob.core.windows.net/artisanans/1.jpg",
                            Price = 15.0,
                            ProductName = "Bois"
                        },
                        new
                        {
                            IdProduct = 4,
                            CategoryName = "category1",
                            ImageURL = "https://artisanans.blob.core.windows.net/artisanans/1.jpg",
                            Price = 15.0,
                            ProductName = "Massive"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
