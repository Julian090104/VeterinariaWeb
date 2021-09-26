﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Veterinaria.App.Dominio.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("IdDueno")
                        .HasColumnType("int");

                    b.Property<int>("IdPlanVacunacion")
                        .HasColumnType("int");

                    b.Property<int>("IdVacuna")
                        .HasColumnType("int");

                    b.Property<int>("IdVeterinario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animales");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDueno")
                        .HasColumnType("int");

                    b.Property<int>("IdVeterinario")
                        .HasColumnType("int");

                    b.Property<string>("MotivoConsulta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoConsulta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Diagnostico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DescripcionDiagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDiagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDiagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Diagnosticos");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ContenidoHistoriaClinica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHistoriaClinica")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAnimal")
                        .HasColumnType("int");

                    b.Property<int>("IdDiagnostico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.PlanVacunacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlanesVacunaciones");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Vacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contraindicaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaVacuna")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreVacuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProteccionContra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vacunas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Administrador", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Dueno", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.HasDiscriminator().HasValue("Dueno");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });
#pragma warning restore 612, 618
        }
    }
}