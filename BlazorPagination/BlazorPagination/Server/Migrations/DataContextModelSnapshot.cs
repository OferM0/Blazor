﻿// <auto-generated />
using BlazorPagination.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorPagination.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorPagination.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ready Player One"
                        },
                        new
                        {
                            Id = 3,
                            Name = "1984"
                        },
                        new
                        {
                            Id = 4,
                            Name = "The Matrix Resurrections"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Diablo 2: Resurrected"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Super Nintendo Entertainment System"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Day of the Tentacle"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Back to the Future"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Toy Story"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Brave New World"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
