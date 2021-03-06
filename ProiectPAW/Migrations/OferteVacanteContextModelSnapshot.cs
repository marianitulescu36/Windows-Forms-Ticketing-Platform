﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectPAW.Models;

namespace ProiectPAW.Migrations
{
    partial class OferteVacanteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("ProiectPAW.Models.OferteVacanta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCheckin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Destinatie")
                        .HasColumnType("TEXT");

                    b.Property<string>("PunctPlecare")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ServiciuId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ServiciuId");

                    b.ToTable("Oferte");
                });

            modelBuilder.Entity("ProiectPAW.Models.Servicii", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Asigurari")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cazare")
                        .HasColumnType("TEXT");

                    b.Property<string>("Circuite")
                        .HasColumnType("TEXT");

                    b.Property<string>("Transport")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Servicii");
                });

            modelBuilder.Entity("ProiectPAW.Models.OferteVacanta", b =>
                {
                    b.HasOne("ProiectPAW.Models.Servicii", "Serviciu")
                        .WithMany()
                        .HasForeignKey("ServiciuId");
                });
#pragma warning restore 612, 618
        }
    }
}
