﻿// <auto-generated />
using System;
using ABPosSolutions.TechnicalTest.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ABPosSolutions.TechnicalTest.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220430042308_Insert_SeedData")]
    partial class Insert_SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ABPosSolutions.TechnicalTest.Domain.Building", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("BuildingName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Buildings");

                    b.HasData(
                        new
                        {
                            Id = "3bcf902f-399e-4a52-af6d-5a30dc702fc0",
                            Address = "Building 2",
                            BuildingName = "Building 2",
                            CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                            CreatedDate = new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(6804)
                        },
                        new
                        {
                            Id = "54f97371-d8a2-4201-b076-95d5f0bcc136",
                            Address = "Building 1",
                            BuildingName = "Building 1",
                            CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                            CreatedDate = new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(6813)
                        });
                });

            modelBuilder.Entity("ABPosSolutions.TechnicalTest.Domain.Inspection", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InspectionTypeId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("InspectionTypeId");

                    b.HasIndex("StatusId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("ABPosSolutions.TechnicalTest.Domain.InspectionType", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BuildingId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("InspectionTypes");

                    b.HasData(
                        new
                        {
                            Id = "24C2BF02-EECF-4C23-8459-43B4F0A96019",
                            BuildingId = "3bcf902f-399e-4a52-af6d-5a30dc702fc0",
                            CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                            CreatedDate = new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(7073),
                            TypeName = "Technical Inspection"
                        },
                        new
                        {
                            Id = "63F6CB37-A46F-450C-A5B7-63497088E594",
                            BuildingId = "54f97371-d8a2-4201-b076-95d5f0bcc136",
                            CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                            CreatedDate = new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(7078),
                            TypeName = "Formal Inspection"
                        });
                });

            modelBuilder.Entity("ABPosSolutions.TechnicalTest.Domain.Status", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = "030CD480-A2CD-4986-B186-7281D3CE2153",
                            CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                            CreatedDate = new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(7214),
                            StatusName = "Unsatisfactory"
                        },
                        new
                        {
                            Id = "9A5851E2-A057-4477-9A0F-038928B17F83",
                            CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                            CreatedDate = new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(7219),
                            StatusName = "Satisfactory"
                        });
                });

            modelBuilder.Entity("ABPosSolutions.TechnicalTest.Domain.Inspection", b =>
                {
                    b.HasOne("ABPosSolutions.TechnicalTest.Domain.InspectionType", "InspectionType")
                        .WithMany("Inspections")
                        .HasForeignKey("InspectionTypeId");

                    b.HasOne("ABPosSolutions.TechnicalTest.Domain.Status", "Status")
                        .WithMany("Inspections")
                        .HasForeignKey("StatusId");

                    b.Navigation("InspectionType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ABPosSolutions.TechnicalTest.Domain.InspectionType", b =>
                {
                    b.HasOne("ABPosSolutions.TechnicalTest.Domain.Building", "Building")
                        .WithMany("InspectionTypes")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("ABPosSolutions.TechnicalTest.Domain.Building", b =>
                {
                    b.Navigation("InspectionTypes");
                });

            modelBuilder.Entity("ABPosSolutions.TechnicalTest.Domain.InspectionType", b =>
                {
                    b.Navigation("Inspections");
                });

            modelBuilder.Entity("ABPosSolutions.TechnicalTest.Domain.Status", b =>
                {
                    b.Navigation("Inspections");
                });
#pragma warning restore 612, 618
        }
    }
}
