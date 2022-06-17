﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prototype.Models;

#nullable disable

namespace Prototype.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20220616185507_NewTest")]
    partial class NewTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Prototype.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Adults")
                        .HasColumnType("int")
                        .HasColumnName("adults_cap");

                    b.Property<int>("Beds")
                        .HasColumnType("int")
                        .HasColumnName("beds_cap");

                    b.Property<int>("Children")
                        .HasColumnType("int")
                        .HasColumnName("children_cap");

                    b.Property<decimal?>("Daily")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("description");

                    b.Property<string>("Localization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<float?>("Rate")
                        .HasColumnType("real");

                    b.Property<int?>("SquareFeet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
