using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackR.DataContext.SQL.Migrations
{
    /// <inheritdoc />
    public partial class Initcreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    BoardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.BoardId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Tasks_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "BoardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Subtask",
                columns: table => new
                {
                    SubtaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subtask", x => x.SubtaskID);
                    table.ForeignKey(
                        name: "FK_Subtask_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "BoardId", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1410), "TrackR", new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "FirstName", "LastName", "Password", "Salt", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(780), "Joseph.Huntley@outlook.com", "Joseph", "Huntley", "5E092899898BE3A13EC5314655F58733184C5E96C2CEE42B43D56CC69E2AB74934899C0BE1FD44B0AEAE403F74F5ACFF4191230AD17F4650AAE5229079CEB98C", new byte[] { 36, 190, 150, 169, 157, 163, 20, 109, 26, 33, 23, 136, 155, 242, 209, 82, 98, 197, 226, 221, 147, 177, 218, 66, 226, 140, 247, 40, 61, 91, 76, 157, 102, 104, 216, 209, 45, 244, 206, 161, 71, 101, 219, 142, 239, 124, 205, 253, 150, 170, 4, 87, 203, 214, 63, 109, 202, 111, 61, 99, 130, 114, 76, 36 }, new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "ActivityId", "BoardId", "CreatedDate", "Issue", "Title", "UpdatedDate", "UserId" },
                values: new object[] { 1, 1, new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1550), "Build the data models for SQL database", "Build SQL Data Models", new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1550), 1 });

            migrationBuilder.InsertData(
                table: "Subtask",
                columns: new[] { "SubtaskID", "CreatedDate", "Issue", "TaskId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1580), "Build out the model for boards", 1, "Board Model", new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1580) },
                    { 2, new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1590), "Build out the model for user", 1, "User Model", new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1590) },
                    { 3, new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1610), "Build out the activity for boards", 1, "Activity Model", new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1610) },
                    { 4, new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1620), "Build out the Subtask for user", 1, "Subtask Model", new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1620) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subtask_TaskId",
                table: "Subtask",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_BoardId",
                table: "Tasks",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subtask");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
