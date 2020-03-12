﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SegundoParcial.Data;

namespace SegundoParcial.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200311235855_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("SegundoParcial.Models.Llamadas", b =>
                {
                    b.Property<int>("LlamadaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LlamadaId");

                    b.ToTable("llamadas");
                });

            modelBuilder.Entity("SegundoParcial.Models.LlamadasDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LlamadaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Problema")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Solucion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DetalleId");

                    b.ToTable("llamadasDetalle");
                });

            modelBuilder.Entity("SegundoParcial.Models.LlamadasDetalle", b =>
                {
                    b.HasOne("SegundoParcial.Models.Llamadas", null)
                        .WithMany("Detalles")
                        .HasForeignKey("DetalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
