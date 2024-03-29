﻿// <auto-generated />
using GestaoDeLaboratorios.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoDeLaboratorios.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("GestaoDeLaboratorios.Models.Computadores", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataCompra")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("hd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("memoria")
                        .HasColumnType("INTEGER");

                    b.Property<string>("numeroPratrimonio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("placaMae")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("processador")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Computadores");
                });
#pragma warning restore 612, 618
        }
    }
}
