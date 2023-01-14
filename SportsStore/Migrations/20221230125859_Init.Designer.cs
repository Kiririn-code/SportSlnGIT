﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SportStore.Models;

namespace SportStore.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20221230125859_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SportStore.Models.CartLine", b =>
                {
                    b.Property<int>("CartLineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("OrderID")
                        .HasColumnType("integer");

                    b.Property<long?>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("CartLineID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("SportStore.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("GiftWarp")
                        .HasColumnType("boolean");

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Line2")
                        .HasColumnType("text");

                    b.Property<string>("Line3")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Shipped")
                        .HasColumnType("boolean");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Zip")
                        .HasColumnType("text");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SportStore.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SportStore.Models.CartLine", b =>
                {
                    b.HasOne("SportStore.Models.Order", null)
                        .WithMany("Lines")
                        .HasForeignKey("OrderID");

                    b.HasOne("SportStore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");
                });
#pragma warning restore 612, 618
        }
    }
}