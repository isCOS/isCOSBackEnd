﻿// <auto-generated />
using System;
using ApiCos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiCos.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20231121134016_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiCos.Models.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VatNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.HasKey("Id");

                    b.HasIndex("BusinessName")
                        .IsUnique();

                    b.HasIndex("VatNumber")
                        .IsUnique();

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.GasStationPrice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("FuelType")
                        .HasColumnType("text");

                    b.Property<bool>("IsSelf")
                        .HasColumnType("boolean");

                    b.Property<int>("GasStationRegistryId")
                        .HasColumnType("integer");

                    b.Property<string>("LastUpdate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id", "FuelType", "IsSelf");

                    b.HasIndex("GasStationRegistryId");

                    b.ToTable("GasStationPrices");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.GasStationRegistry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<string>("GasProvider")
                        .HasColumnType("text");

                    b.Property<string>("GasStationName")
                        .HasColumnType("text");

                    b.Property<double?>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GasStationRegistries");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("DateBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<int>("EngineDisplacement")
                        .HasColumnType("integer");

                    b.Property<float>("ExtraUrbanConsumption")
                        .HasColumnType("real");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Km")
                        .HasColumnType("double precision");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LitersTank")
                        .HasColumnType("integer");

                    b.Property<float>("MaxLoad")
                        .HasColumnType("real");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("UrbanConsumption")
                        .HasColumnType("real");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("LicensePlate")
                        .IsUnique();

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.Verification", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Token")
                        .HasColumnType("integer");

                    b.HasKey("UserId");

                    b.ToTable("Verification");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.Company", b =>
                {
                    b.OwnsOne("ApiCos.Models.Common.Address", "Address", b1 =>
                        {
                            b1.Property<int>("CompanyId")
                                .HasColumnType("integer");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("StreetNumber")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("CompanyId");

                            b1.ToTable("Companies");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("ApiCos.Models.Entities.GasStationPrice", b =>
                {
                    b.HasOne("ApiCos.Models.Entities.GasStationRegistry", "GasStationRegistry")
                        .WithMany("GasStationPrices")
                        .HasForeignKey("GasStationRegistryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GasStationRegistry");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.User", b =>
                {
                    b.HasOne("ApiCos.Models.Entities.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ApiCos.Models.Common.DrivingLicense", "DrivingLicense", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("integer");

                            b1.Property<DateOnly>("DeadLine")
                                .HasColumnType("date");

                            b1.Property<string>("Type")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("ApiCos.Models.Common.Password", "PasswordEncrypted", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("integer");

                            b1.Property<byte[]>("PasswordHash")
                                .IsRequired()
                                .HasColumnType("bytea");

                            b1.Property<byte[]>("PasswordSalt")
                                .IsRequired()
                                .HasColumnType("bytea");

                            b1.Property<bool>("Validated")
                                .HasColumnType("boolean");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Company");

                    b.Navigation("DrivingLicense")
                        .IsRequired();

                    b.Navigation("PasswordEncrypted")
                        .IsRequired();
                });

            modelBuilder.Entity("ApiCos.Models.Entities.Vehicle", b =>
                {
                    b.HasOne("ApiCos.Models.Entities.Company", "Company")
                        .WithMany("Vehicles")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.Verification", b =>
                {
                    b.HasOne("ApiCos.Models.Entities.User", "User")
                        .WithOne("Verification")
                        .HasForeignKey("ApiCos.Models.Entities.Verification", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.Company", b =>
                {
                    b.Navigation("Users");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.GasStationRegistry", b =>
                {
                    b.Navigation("GasStationPrices");
                });

            modelBuilder.Entity("ApiCos.Models.Entities.User", b =>
                {
                    b.Navigation("Verification");
                });
#pragma warning restore 612, 618
        }
    }
}
