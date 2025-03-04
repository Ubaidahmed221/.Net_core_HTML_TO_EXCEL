﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationHTML_TO_EXCEL_EXPORT;

#nullable disable

namespace WebApplicationHTML_TO_EXCEL_EXPORT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplicationHTML_TO_EXCEL_EXPORT.Entities.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Email = "kamal@gmail.com",
                            Name = "kamal",
                            PhoneNO = "03123454546"
                        },
                        new
                        {
                            ID = 2,
                            Email = "Nofile@gmail.com",
                            Name = "Nofile",
                            PhoneNO = "03126785643"
                        },
                        new
                        {
                            ID = 3,
                            Email = "Ashir@gmail.com",
                            Name = "Ashir",
                            PhoneNO = "03123456785"
                        },
                        new
                        {
                            ID = 4,
                            Email = "jawad@gmail.com",
                            Name = "jawad",
                            PhoneNO = "03123489754"
                        },
                        new
                        {
                            ID = 5,
                            Email = "jawaid@gmail.com",
                            Name = "jawaid",
                            PhoneNO = "031575367906"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
