﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackRecordAPI.Models;

namespace TrackRecordAPI.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20210105055950_ChangedTrackRecordColumnName")]
    partial class ChangedTrackRecordColumnName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TrackRecordAPI.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<bool>("IsUpdated")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("LastName");

                    b.Property<int>("StudentAge")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("tblStudent");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            DOB = new DateTime(2021, 1, 5, 5, 59, 49, 847, DateTimeKind.Utc).AddTicks(7632),
                            FirstName = "Ritesh",
                            IsUpdated = false,
                            LastName = "Joshi",
                            StudentAge = 22
                        },
                        new
                        {
                            StudentId = 2,
                            DOB = new DateTime(2021, 1, 5, 5, 59, 49, 847, DateTimeKind.Utc).AddTicks(8471),
                            FirstName = "Amit",
                            IsUpdated = false,
                            LastName = "Joshi",
                            StudentAge = 20
                        });
                });

            modelBuilder.Entity("TrackRecordAPI.Models.TrackRecord", b =>
                {
                    b.Property<int>("TrackingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TID")
                        .UseIdentityColumn();

                    b.Property<string>("OldValue")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("OldValue");

                    b.Property<string>("UpdatedColumn")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("UpdatedColumn");

                    b.Property<TimeSpan>("UpdatedTime")
                        .HasColumnType("time");

                    b.Property<string>("UpdatedValue")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("TrackingId");

                    b.ToTable("tblTrackRecord");
                });
#pragma warning restore 612, 618
        }
    }
}
