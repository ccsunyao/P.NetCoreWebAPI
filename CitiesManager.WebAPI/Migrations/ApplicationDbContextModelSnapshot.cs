﻿// <auto-generated />
using System;
using CitiesManager.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CitiesManager.WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CitiesManager.WebAPI.Models.City", b =>
                {
                    b.Property<Guid>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityID");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityID = new Guid("b64dcfef-2d34-4d20-b030-70b4f44f5405"),
                            CityName = "New York"
                        },
                        new
                        {
                            CityID = new Guid("f41e12b4-2f11-4ab0-b32f-032e3aa92c8a"),
                            CityName = "Houston"
                        },
                        new
                        {
                            CityID = new Guid("dcfbe5d0-74ce-4777-8c51-b0b471b781fb"),
                            CityName = "Seattle"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
