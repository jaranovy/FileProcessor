﻿// <auto-generated />
using FileProcessor.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FileProcessor.Migrations
{
    [DbContext(typeof(FileProcessorDbContext))]
    [Migration("20191128183638_CreateFileProcessorDb")]
    partial class CreateFileProcessorDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FileProcessor.Model.Zbozi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nazev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pocet_kusu_skladem")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Zbozi");
                });
#pragma warning restore 612, 618
        }
    }
}
