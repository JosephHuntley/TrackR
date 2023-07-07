﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackR.DataContext.SQL;

#nullable disable

namespace TrackR.DataContext.SQL.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20230707140041_Added status field")]
    partial class Addedstatusfield
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrackR.Models.SQL.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityId"));

                    b.Property<int>("BoardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Issue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ActivityId");

                    b.HasIndex("BoardId");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            ActivityId = 1,
                            BoardId = 1,
                            CreatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3450),
                            Issue = "Build the data models for SQL database",
                            Status = 1,
                            Title = "Build SQL Data Models",
                            UpdatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3450),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("TrackR.Models.SQL.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BoardId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BoardId");

                    b.ToTable("Boards");

                    b.HasData(
                        new
                        {
                            BoardId = 1,
                            CreatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3410),
                            Name = "TrackR",
                            UpdatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3420)
                        });
                });

            modelBuilder.Entity("TrackR.Models.SQL.Subtask", b =>
                {
                    b.Property<int>("SubtaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubtaskID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Issue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SubtaskID");

                    b.HasIndex("TaskId");

                    b.ToTable("Subtask");

                    b.HasData(
                        new
                        {
                            SubtaskID = 1,
                            CreatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3480),
                            Issue = "Build out the model for boards",
                            Status = 0,
                            TaskId = 1,
                            Title = "Board Model",
                            UpdatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3480)
                        },
                        new
                        {
                            SubtaskID = 2,
                            CreatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3480),
                            Issue = "Build out the model for user",
                            Status = 0,
                            TaskId = 1,
                            Title = "User Model",
                            UpdatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3490)
                        },
                        new
                        {
                            SubtaskID = 3,
                            CreatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3500),
                            Issue = "Build out the activity for boards",
                            Status = 1,
                            TaskId = 1,
                            Title = "Activity Model",
                            UpdatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3510)
                        },
                        new
                        {
                            SubtaskID = 4,
                            CreatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3510),
                            Issue = "Build out the Subtask for user",
                            Status = 2,
                            TaskId = 1,
                            Title = "Subtask Model",
                            UpdatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3510)
                        });
                });

            modelBuilder.Entity("TrackR.Models.SQL.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3050),
                            Email = "Joseph.Huntley@outlook.com",
                            FirstName = "Joseph",
                            LastName = "Huntley",
                            Password = "DA1C9E44AA2C21C0DA69A2172ECE8546444C7F7C6CF6CB166A71B7082070D692390EAD03C57F9E46F2EA9E13F5A21D1F59DB5225951516CBDB49FC36052F547E",
                            Salt = new byte[] { 133, 145, 188, 43, 227, 163, 120, 92, 15, 66, 137, 34, 173, 214, 121, 18, 248, 51, 41, 159, 105, 172, 165, 5, 38, 186, 165, 115, 169, 177, 197, 183, 149, 81, 40, 123, 146, 39, 69, 172, 206, 67, 216, 120, 190, 251, 62, 239, 161, 170, 128, 153, 103, 50, 60, 191, 102, 255, 209, 7, 129, 59, 24, 161 },
                            UpdatedDate = new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3100)
                        });
                });

            modelBuilder.Entity("TrackR.Models.SQL.Activity", b =>
                {
                    b.HasOne("TrackR.Models.SQL.Board", "Parent")
                        .WithMany("Tasks")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackR.Models.SQL.User", "Owner")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Owner");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("TrackR.Models.SQL.Subtask", b =>
                {
                    b.HasOne("TrackR.Models.SQL.Activity", "Parent")
                        .WithMany("Subtasks")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("TrackR.Models.SQL.Activity", b =>
                {
                    b.Navigation("Subtasks");
                });

            modelBuilder.Entity("TrackR.Models.SQL.Board", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
