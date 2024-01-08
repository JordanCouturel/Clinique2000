﻿// <auto-generated />
using System;
using Clinique2000_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clinique2000_DataAccess.Migrations
{
    [DbContext(typeof(CliniqueDbContext))]
    [Migration("20231229053913_modifierPatient")]
    partial class modifierPatient
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Clinique2000_Core.Models.Personne", b =>
                {
                    b.Property<int>("PersonneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonneId"), 1L, 1);

                    b.Property<string>("Courriel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("PersonneId");

                    b.ToTable("Personne", (string)null);
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Patient", b =>
                {
                    b.HasBaseType("Clinique2000_Core.Models.Personne");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("GoogleNameIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("MotDePasseConfirmation")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("NAM")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.ToTable("Patient", (string)null);
                });

            modelBuilder.Entity("Clinique2000_Core.Models.PatientACharge", b =>
                {
                    b.HasBaseType("Clinique2000_Core.Models.Personne");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("NAM")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("PatientAChargeId")
                        .HasColumnType("int");

                    b.Property<int?>("PatientPersonneId")
                        .HasColumnType("int");

                    b.HasIndex("PatientPersonneId");

                    b.ToTable("PatientACharge", (string)null);
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Patient", b =>
                {
                    b.HasOne("Clinique2000_Core.Models.Personne", null)
                        .WithOne()
                        .HasForeignKey("Clinique2000_Core.Models.Patient", "PersonneId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinique2000_Core.Models.PatientACharge", b =>
                {
                    b.HasOne("Clinique2000_Core.Models.Patient", null)
                        .WithMany("PatientsACharge")
                        .HasForeignKey("PatientPersonneId");

                    b.HasOne("Clinique2000_Core.Models.Personne", null)
                        .WithOne()
                        .HasForeignKey("Clinique2000_Core.Models.PatientACharge", "PersonneId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Patient", b =>
                {
                    b.Navigation("PatientsACharge");
                });
#pragma warning restore 612, 618
        }
    }
}