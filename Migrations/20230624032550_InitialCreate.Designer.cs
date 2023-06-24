﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SlimeTAP.RazorPages.Data;

#nullable disable

namespace SlimeTAP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230624032550_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("slimeTAP.Models.UsuarioModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Diamante")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Gema")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Moeda")
                        .HasColumnType("REAL");

                    b.Property<float?>("Multiplicador")
                        .HasColumnType("REAL");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Upgrade1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Upgrade2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UsuarioNome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
