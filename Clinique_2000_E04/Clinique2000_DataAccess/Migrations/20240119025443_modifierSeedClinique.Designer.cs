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
    [Migration("20240119025443_modifierSeedClinique")]
    partial class modifierSeedClinique
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Clinique2000_Core.Models.Adresse", b =>
                {
                    b.Property<int>("AdresseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdresseID"), 1L, 1);

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Rue")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("AdresseID");

                    b.ToTable("Adresses");

                    b.HasData(
                        new
                        {
                            AdresseID = 1,
                            CodePostal = "H1H 1H1",
                            Numero = "7-756",
                            Pays = "Canada",
                            Province = "Québec",
                            Rue = "rue de la Clinique",
                            Ville = "Montréal"
                        },
                        new
                        {
                            AdresseID = 2,
                            CodePostal = "A1A 1A1",
                            Numero = "2-66",
                            Pays = "Canada",
                            Province = "Québec",
                            Rue = "rue de la Cegep",
                            Ville = "Longueuil"
                        });
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Clinique", b =>
                {
                    b.Property<int>("CliniqueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CliniqueID"), 1L, 1);

                    b.Property<int>("AdresseID")
                        .HasColumnType("int");

                    b.Property<string>("Courriel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreateurID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EstActive")
                        .HasColumnType("bit");

                    b.Property<TimeSpan?>("HeureFermeture")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("HeureOuverture")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<string>("NomClinique")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("TempsMoyenConsultation")
                        .HasColumnType("int");

                    b.HasKey("CliniqueID");

                    b.HasIndex("AdresseID")
                        .IsUnique();

                    b.HasIndex("CreateurID");

                    b.ToTable("Cliniques");

                    b.HasData(
                        new
                        {
                            CliniqueID = 1,
                            AdresseID = 1,
                            Courriel = "test@clinique2000.com",
                            CreateurID = "7cc96785-8933-4eac-8d7f-a289b28df222",
                            DateCreation = new DateTime(2024, 1, 18, 21, 54, 42, 744, DateTimeKind.Local).AddTicks(1470),
                            EstActive = true,
                            HeureFermeture = new TimeSpan(0, 17, 0, 0, 0),
                            HeureOuverture = new TimeSpan(0, 8, 0, 0, 0),
                            NomClinique = "CliniqueA",
                            TempsMoyenConsultation = 30
                        },
                        new
                        {
                            CliniqueID = 2,
                            AdresseID = 2,
                            Courriel = "Test2@test.com",
                            CreateurID = "7cc96785-8933-4eac-8d7f-a289b28df222",
                            DateCreation = new DateTime(2024, 1, 18, 21, 54, 42, 744, DateTimeKind.Local).AddTicks(1520),
                            EstActive = true,
                            HeureFermeture = new TimeSpan(0, 17, 0, 0, 0),
                            HeureOuverture = new TimeSpan(0, 8, 0, 0, 0),
                            NomClinique = "CliniqueB",
                            TempsMoyenConsultation = 30
                        });
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Consultation", b =>
                {
                    b.Property<int>("ConsultationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsultationID"), 1L, 1);

                    b.Property<DateTime>("HeureDateDebutPrevue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HeureDateDebutReele")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HeureDateFinPrevue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HeureDateFinReele")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("PlageHoraireID")
                        .HasColumnType("int");

                    b.Property<int>("StatutConsultation")
                        .HasColumnType("int");

                    b.HasKey("ConsultationID");

                    b.HasIndex("PatientID");

                    b.HasIndex("PlageHoraireID");

                    b.ToTable("Consultations");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.ListeAttente", b =>
                {
                    b.Property<int>("ListeAttenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ListeAttenteID"), 1L, 1);

                    b.Property<int>("CliniqueID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEffectivite")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DureeConsultationMinutes")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("HeureFermeture")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HeureOuverture")
                        .HasColumnType("time");

                    b.Property<bool>("IsOuverte")
                        .HasColumnType("bit");

                    b.Property<int>("NbMedecinsDispo")
                        .HasColumnType("int");

                    b.HasKey("ListeAttenteID");

                    b.HasIndex("CliniqueID");

                    b.ToTable("ListeAttentes");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAM")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PatientId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.PatientACharge", b =>
                {
                    b.Property<int>("PatientAChargeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientAChargeId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("NAM")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("PatientAChargeId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientACharges");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.PlageHoraire", b =>
                {
                    b.Property<int>("PlageHoraireID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlageHoraireID"), 1L, 1);

                    b.Property<DateTime>("HeureDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HeureFin")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListeAttenteID")
                        .HasColumnType("int");

                    b.HasKey("PlageHoraireID");

                    b.HasIndex("ListeAttenteID");

                    b.ToTable("PlagesHoraires");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Clinique2000_Core.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "7cc96785-8933-4eac-8d7f-a289b28df222",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8212d9d5-a9da-4889-8d1a-e0c6e9d7ded6",
                            Email = "bitcav@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "BITCAV@GMAIL.COM",
                            NormalizedUserName = "BITCAV@GMAIL.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8d66cb4b-adbc-412c-978a-25abb3a6a6ff",
                            TwoFactorEnabled = false,
                            UserName = "bit@gmail.com"
                        });
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Clinique", b =>
                {
                    b.HasOne("Clinique2000_Core.Models.Adresse", "Adresse")
                        .WithOne("Clinique")
                        .HasForeignKey("Clinique2000_Core.Models.Clinique", "AdresseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinique2000_Core.Models.ApplicationUser", "Createur")
                        .WithMany()
                        .HasForeignKey("CreateurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adresse");

                    b.Navigation("Createur");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Consultation", b =>
                {
                    b.HasOne("Clinique2000_Core.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID");

                    b.HasOne("Clinique2000_Core.Models.PlageHoraire", "PlageHorarie")
                        .WithMany("Consultations")
                        .HasForeignKey("PlageHoraireID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("PlageHorarie");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.ListeAttente", b =>
                {
                    b.HasOne("Clinique2000_Core.Models.Clinique", "Clinique")
                        .WithMany("ListeAttente")
                        .HasForeignKey("CliniqueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinique");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Patient", b =>
                {
                    b.HasOne("Clinique2000_Core.Models.ApplicationUser", "User")
                        .WithOne("Patient")
                        .HasForeignKey("Clinique2000_Core.Models.Patient", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.PatientACharge", b =>
                {
                    b.HasOne("Clinique2000_Core.Models.Patient", "Patient")
                        .WithMany("PatientsACharge")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.PlageHoraire", b =>
                {
                    b.HasOne("Clinique2000_Core.Models.ListeAttente", "ListeAttente")
                        .WithMany("PlagesHoraires")
                        .HasForeignKey("ListeAttenteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListeAttente");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Adresse", b =>
                {
                    b.Navigation("Clinique")
                        .IsRequired();
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Clinique", b =>
                {
                    b.Navigation("ListeAttente");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.ListeAttente", b =>
                {
                    b.Navigation("PlagesHoraires");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.Patient", b =>
                {
                    b.Navigation("PatientsACharge");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.PlageHoraire", b =>
                {
                    b.Navigation("Consultations");
                });

            modelBuilder.Entity("Clinique2000_Core.Models.ApplicationUser", b =>
                {
                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
