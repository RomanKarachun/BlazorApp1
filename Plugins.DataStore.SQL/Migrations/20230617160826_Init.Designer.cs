﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugins.DataStore.SQL;

namespace Plugins.DataStore.SQL.Migrations
{
    [DbContext(typeof(MarketContext))]
    [Migration("20230617160826_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Desription №1",
                            Name = "Category №1"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Desription №2",
                            Name = "Category №2"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Desription №3",
                            Name = "Category №3"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Desription №4",
                            Name = "Category №4"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "Desription №5",
                            Name = "Category №5"
                        },
                        new
                        {
                            CategoryId = 6,
                            Description = "Desription №6",
                            Name = "Category №6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
