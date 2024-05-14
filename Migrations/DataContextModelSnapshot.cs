﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Parqueadero_Api.Data;

#nullable disable

namespace Parqueadero_Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Parqueadero_Api.Models.CLIENTE", b =>
                {
                    b.Property<int>("id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_cliente"));

                    b.Property<int?>("VEHICULOid_vehiculo")
                        .HasColumnType("integer");

                    b.Property<string>("apellido_cliente")
                        .HasColumnType("text");

                    b.Property<int>("cedula_cliente")
                        .HasColumnType("integer");

                    b.Property<int>("id_vehiculo")
                        .HasColumnType("integer");

                    b.Property<string>("nombre_cliente")
                        .HasColumnType("text");

                    b.HasKey("id_cliente");

                    b.HasIndex("VEHICULOid_vehiculo");

                    b.ToTable("CLIENTE");
                });

            modelBuilder.Entity("Parqueadero_Api.Models.VEHICULO", b =>
                {
                    b.Property<int>("id_vehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_vehiculo"));

                    b.Property<string>("placa_vehiculo")
                        .HasColumnType("text");

                    b.Property<string>("tipo_vehiculo")
                        .HasColumnType("text");

                    b.Property<double>("valor_vehiculo")
                        .HasColumnType("double precision");

                    b.HasKey("id_vehiculo");

                    b.ToTable("VEHICULO");
                });

            modelBuilder.Entity("Parqueadero_Api.Models.CLIENTE", b =>
                {
                    b.HasOne("Parqueadero_Api.Models.VEHICULO", "VEHICULO")
                        .WithMany("CLIENTE")
                        .HasForeignKey("VEHICULOid_vehiculo");

                    b.Navigation("VEHICULO");
                });

            modelBuilder.Entity("Parqueadero_Api.Models.VEHICULO", b =>
                {
                    b.Navigation("CLIENTE");
                });
#pragma warning restore 612, 618
        }
    }
}
