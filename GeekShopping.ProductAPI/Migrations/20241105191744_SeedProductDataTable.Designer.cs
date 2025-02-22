﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20241105191744_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryName = "Categoria registro 1",
                            Description = "Descrição registro 1",
                            ImageUrl = "TesteURL registro 1",
                            Name = "Registro 1",
                            Price = 81.1m
                        },
                        new
                        {
                            Id = 2L,
                            CategoryName = "Categoria registro 2",
                            Description = "Descrição registro 2",
                            ImageUrl = "TesteURL registro 2",
                            Name = "Registro 2",
                            Price = 82.1m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "Categoria registro 3",
                            Description = "Descrição registro 3",
                            ImageUrl = "TesteURL registro 3",
                            Name = "Registro 3",
                            Price = 83.1m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Categoria registro 4",
                            Description = "Descrição registro 4",
                            ImageUrl = "TesteURL registro 4",
                            Name = "Registro 4",
                            Price = 84.1m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "Categoria registro 5",
                            Description = "Descrição registro 5",
                            ImageUrl = "TesteURL registro 5",
                            Name = "Registro 5",
                            Price = 85.1m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "Categoria registro 6",
                            Description = "Descrição registro 6",
                            ImageUrl = "TesteURL registro 6",
                            Name = "Registro 6",
                            Price = 86.1m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "Categoria registro 7",
                            Description = "Descrição registro 7",
                            ImageUrl = "TesteURL registro 7",
                            Name = "Registro 7",
                            Price = 87.1m
                        },
                        new
                        {
                            Id = 8L,
                            CategoryName = "Categoria registro 8",
                            Description = "Descrição registro 8",
                            ImageUrl = "TesteURL registro 8",
                            Name = "Registro 8",
                            Price = 88.1m
                        },
                        new
                        {
                            Id = 9L,
                            CategoryName = "Categoria registro 9",
                            Description = "Descrição registro 9",
                            ImageUrl = "TesteURL registro 9",
                            Name = "Registro 9",
                            Price = 89.1m
                        },
                        new
                        {
                            Id = 10L,
                            CategoryName = "Categoria registro 10",
                            Description = "Descrição registro 10",
                            ImageUrl = "TesteURL registro 10",
                            Name = "Registro 10",
                            Price = 90.1m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
