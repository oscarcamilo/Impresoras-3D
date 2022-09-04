﻿// <auto-generated />
using System;
using Impresora3d.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Impresora3d.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220903230052_Ini2")]
    partial class Ini2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Impresora3d.App.Dominio.Seguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seguros");
                });
#pragma warning restore 612, 618
        }
    }
}
