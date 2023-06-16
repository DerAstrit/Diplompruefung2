﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using spicker;

#nullable disable

namespace spicker.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("spicker.Feundschaft", b =>
                {
                    b.Property<int>("ProbandID")
                        .HasColumnType("int");

                    b.Property<int>("FreundID")
                        .HasColumnType("int");

                    b.HasKey("ProbandID", "FreundID");

                    b.HasIndex("FreundID");

                    b.ToTable("Feundschaft");
                });

            modelBuilder.Entity("spicker.Freund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Jahrgang")
                        .HasColumnType("int");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Freund");
                });

            modelBuilder.Entity("spicker.Mutter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Jahrgang")
                        .HasColumnType("int");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mutters");
                });

            modelBuilder.Entity("spicker.Pate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Jahrgang")
                        .HasColumnType("int");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pate");
                });

            modelBuilder.Entity("spicker.Proband", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Geschlecht")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Jahrgang")
                        .HasColumnType("int");

                    b.Property<int>("MutterID")
                        .HasColumnType("int");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PateId")
                        .HasColumnType("int");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MutterID");

                    b.HasIndex("PateId")
                        .IsUnique()
                        .HasFilter("[PateId] IS NOT NULL");

                    b.ToTable("Probanden");
                });

            modelBuilder.Entity("spicker.Feundschaft", b =>
                {
                    b.HasOne("spicker.Freund", "Freund")
                        .WithMany("Feundschaften")
                        .HasForeignKey("FreundID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("spicker.Proband", "Proband")
                        .WithMany("Feundschaften")
                        .HasForeignKey("ProbandID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Freund");

                    b.Navigation("Proband");
                });

            modelBuilder.Entity("spicker.Proband", b =>
                {
                    b.HasOne("spicker.Mutter", "Mutter")
                        .WithMany("Probanden")
                        .HasForeignKey("MutterID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("spicker.Pate", "Pate")
                        .WithOne("Proband")
                        .HasForeignKey("spicker.Proband", "PateId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Mutter");

                    b.Navigation("Pate");
                });

            modelBuilder.Entity("spicker.Freund", b =>
                {
                    b.Navigation("Feundschaften");
                });

            modelBuilder.Entity("spicker.Mutter", b =>
                {
                    b.Navigation("Probanden");
                });

            modelBuilder.Entity("spicker.Pate", b =>
                {
                    b.Navigation("Proband");
                });

            modelBuilder.Entity("spicker.Proband", b =>
                {
                    b.Navigation("Feundschaften");
                });
#pragma warning restore 612, 618
        }
    }
}
