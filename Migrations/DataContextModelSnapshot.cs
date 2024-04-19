﻿// <auto-generated />
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

            modelBuilder.Entity("Parqueadero_Api.Models.VEHICULOS", b =>
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
#pragma warning restore 612, 618
        }
    }
}
