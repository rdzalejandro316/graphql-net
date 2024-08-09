﻿// <auto-generated />
using System;
using FooBar.Infrastructure.DataSource;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FooBar.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240809004354_Inicio")]
    partial class Inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FooBar.Domain.Entities.Voter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Voter");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ed75dac-9949-4e7a-9f00-e771c8168324"),
                            DateOfBirth = new DateTime(2024, 8, 8, 19, 43, 54, 442, DateTimeKind.Local).AddTicks(6423),
                            Nid = "1033796537",
                            Origin = "Colombia"
                        },
                        new
                        {
                            Id = new Guid("fffe8346-47be-48b1-8a8f-9f4ce9dcbf10"),
                            DateOfBirth = new DateTime(2024, 8, 8, 19, 43, 54, 442, DateTimeKind.Local).AddTicks(6469),
                            Nid = "1033796537",
                            Origin = "Peru"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}