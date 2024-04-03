﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_RegistroDePonto.Models;

#nullable disable

namespace api_RegistroDePonto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240403153334_M00")]
    partial class M00
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("api_RegistroDePonto.Models.RegistroDePonto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EntradaManha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EntradaTarde")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SaidaManha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SaidaTarde")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Registro");
                });
#pragma warning restore 612, 618
        }
    }
}