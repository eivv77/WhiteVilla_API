﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhiteVilla_VillaAPI.Data;

#nullable disable

namespace WhiteVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220920172410_AddVillaNumberToDb")]
    partial class AddVillaNumberToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WhiteVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "The best",
                            CreatedDate = new DateTime(2022, 9, 20, 21, 24, 10, 178, DateTimeKind.Local).AddTicks(4145),
                            Details = "The First villa in our project",
                            ImgUrl = "",
                            Name = "First",
                            Occupancy = 1,
                            Rate = 10.0,
                            Sqft = 100,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "The best",
                            CreatedDate = new DateTime(2022, 9, 20, 21, 24, 10, 178, DateTimeKind.Local).AddTicks(4155),
                            Details = "The Second villa in our project",
                            ImgUrl = "",
                            Name = "Second",
                            Occupancy = 2,
                            Rate = 10.0,
                            Sqft = 200,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "The best",
                            CreatedDate = new DateTime(2022, 9, 20, 21, 24, 10, 178, DateTimeKind.Local).AddTicks(4156),
                            Details = "The Third villa in our project",
                            ImgUrl = "",
                            Name = "Third",
                            Occupancy = 3,
                            Rate = 10.0,
                            Sqft = 300,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "The best",
                            CreatedDate = new DateTime(2022, 9, 20, 21, 24, 10, 178, DateTimeKind.Local).AddTicks(4157),
                            Details = "The Fourth villa in our project",
                            ImgUrl = "",
                            Name = "Fourth",
                            Occupancy = 4,
                            Rate = 10.0,
                            Sqft = 400,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "The best",
                            CreatedDate = new DateTime(2022, 9, 20, 21, 24, 10, 178, DateTimeKind.Local).AddTicks(4159),
                            Details = "The Fifth villa in our project",
                            ImgUrl = "",
                            Name = "Fifth",
                            Occupancy = 5,
                            Rate = 10.0,
                            Sqft = 500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WhiteVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("VillaNo");

                    b.ToTable("VillaNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}