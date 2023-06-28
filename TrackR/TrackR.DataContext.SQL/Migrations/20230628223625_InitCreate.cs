using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackR.DataContext.SQL.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
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
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subtask",
                columns: table => new
                {
                    SubtaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subtask", x => x.SubtaskId);
                    table.ForeignKey(
                        name: "FK_Subtask_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "BoardId", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2080), "TrackR", new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "FirstName", "LastName", "Password", "Salt", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(1660), "Joseph.Huntley@outlook.com", "Joseph", "Huntley", "EE644E5589252771C567F22655CB7F73F18284D9BB2E7F3A99BB094E2638AE21863CFBE2E3CD29A2782B03FCAB34C382A4E571897B0D6B708F7058B50DCA7BAE", new byte[] { 170, 217, 79, 195, 142, 186, 217, 184, 222, 127, 13, 240, 56, 89, 112, 197, 160, 44, 234, 23, 203, 191, 74, 130, 208, 101, 208, 118, 62, 129, 81, 222, 60, 243, 45, 7, 237, 33, 29, 57, 2, 166, 180, 77, 213, 194, 226, 68, 118, 16, 84, 16, 249, 100, 128, 145, 213, 252, 8, 142, 217, 101, 196, 66 }, new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "BoardId", "CreatedDate", "Issue", "Title", "UpdatedDate", "UserId" },
                values: new object[] { 1, 1, new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2120), "Build the data models for SQL database", "Build SQL Data Models", new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2120), 1 });

            migrationBuilder.InsertData(
                table: "Subtask",
                columns: new[] { "SubtaskId", "CreatedDate", "Issue", "TaskId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2150), "Build out the model for boards", 1, "Board Model", new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2150) },
                    { 2, new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2150), "Build out the model for user", 1, "User Model", new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2150) },
                    { 3, new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2160), "Build out the activity for boards", 1, "Activity Model", new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2170) },
                    { 4, new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2170), "Build out the Subtask for user", 1, "Subtask Model", new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2180) }
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
