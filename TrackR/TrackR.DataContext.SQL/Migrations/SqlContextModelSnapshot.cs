﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackR.DataContext.SQL;

#nullable disable

namespace TrackR.DataContext.SQL.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6080),
                            Issue = "Build the data models for SQL database",
                            Status = 1,
                            Title = "Build SQL Data Models",
                            UpdatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6080),
                            UserId = 1
                        },
                        new
                        {
                            ActivityId = 12,
                            BoardId = 1,
                            CreatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6080),
                            Issue = "Build the frontend in blazor",
                            Status = 0,
                            Title = "Build View",
                            UpdatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6090),
                            UserId = 1
                        },
                        new
                        {
                            ActivityId = 3,
                            BoardId = 1,
                            CreatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6090),
                            Issue = "Build the db context for SQL database",
                            Status = 2,
                            Title = "Build SQL Data Context",
                            UpdatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6100),
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
                            CreatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(5960),
                            Name = "TrackR",
                            UpdatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6030)
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
                            CreatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6140),
                            Issue = "Build out the model for boards",
                            Status = 0,
                            TaskId = 1,
                            Title = "Board Model",
                            UpdatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6140)
                        },
                        new
                        {
                            SubtaskID = 2,
                            CreatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6140),
                            Issue = "Build out the model for user",
                            Status = 0,
                            TaskId = 1,
                            Title = "User Model",
                            UpdatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6150)
                        },
                        new
                        {
                            SubtaskID = 3,
                            CreatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6150),
                            Issue = "Build out the activity for boards",
                            Status = 1,
                            TaskId = 1,
                            Title = "Activity Model",
                            UpdatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6230)
                        },
                        new
                        {
                            SubtaskID = 4,
                            CreatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6240),
                            Issue = "Build out the Subtask for user",
                            Status = 2,
                            TaskId = 1,
                            Title = "Subtask Model",
                            UpdatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6240)
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
                            CreatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(5670),
                            Email = "Joseph.Huntley@outlook.com",
                            FirstName = "Joseph",
                            LastName = "Huntley",
                            Password = "4A68242455116F0090288DC50AFA1ADA0261D7CAF76CBFB3A533AFAD27BB88DFCAB8367E38D26E0D423889C3D4C3CD856FBFF96C2B2131C0F4EA5D4C0DD22E9E",
                            Salt = new byte[] { 50, 147, 138, 145, 155, 248, 69, 164, 249, 18, 235, 192, 3, 82, 187, 36, 206, 26, 119, 243, 47, 201, 89, 114, 172, 136, 16, 9, 211, 134, 130, 110, 4, 17, 159, 211, 208, 93, 227, 51, 135, 5, 233, 93, 133, 67, 139, 221, 102, 231, 175, 228, 242, 50, 146, 126, 178, 30, 58, 35, 235, 33, 173, 41 },
                            UpdatedDate = new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(5740)
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
