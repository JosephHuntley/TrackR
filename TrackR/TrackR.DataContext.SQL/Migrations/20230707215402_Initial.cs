using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackR.DataContext.SQL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                name: "Sections",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionId);
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
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    BoardId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                        name: "FK_Tasks_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "SectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Subtasks",
                columns: table => new
                {
                    SubtaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subtasks", x => x.SubtaskId);
                    table.ForeignKey(
                        name: "FK_Subtasks_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "SectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subtasks_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "ActivityId");
                });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "BoardId", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6110), "TrackR", new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "SectionId", "CreatedDate", "Name", "Position", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6230), "TODO", 1, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6230) },
                    { 2, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6230), "Doing", 2, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6230) },
                    { 3, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6240), "Done", 3, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6240) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "FirstName", "LastName", "Password", "Salt", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(5840), "Joseph.Huntley@outlook.com", "Joseph", "Huntley", "515DA5D4CAE5AD5C9CF5470FF42F85D3E5F9C96AC3B8BAEB9362C6F8F4D1FE4A6F45EF5965344DDAB9D5CC31D19B307931CF9A6BF705FD015018F3201BF191DF", new byte[] { 117, 154, 129, 18, 15, 40, 209, 55, 200, 224, 144, 48, 225, 71, 239, 90, 65, 142, 1, 232, 161, 190, 90, 84, 107, 136, 158, 141, 130, 132, 234, 99, 41, 99, 107, 62, 58, 172, 212, 36, 70, 40, 1, 167, 216, 234, 179, 69, 87, 196, 141, 44, 80, 30, 137, 18, 62, 182, 110, 28, 173, 49, 228, 29 }, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "ActivityId", "BoardId", "CreatedDate", "Issue", "SectionId", "Title", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6150), "Build the data models for SQL database", 2, "Build SQL Data Models", new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6150), 1 },
                    { 3, 1, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6160), "Build the db context for SQL database", 3, "Build SQL Data Context", new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6160), 1 },
                    { 12, 1, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6160), "Build the frontend in blazor", 1, "Build View", new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6160), 1 }
                });

            migrationBuilder.InsertData(
                table: "Subtasks",
                columns: new[] { "SubtaskId", "Completed", "CreatedDate", "Issue", "SectionId", "TaskId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6190), "Build out the model for boards", 3, 1, "Board Model", new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6190) },
                    { 2, false, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6190), "Build out the model for user", 2, 1, "User Model", new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6200) },
                    { 3, false, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6200), "Build out the activity for boards", 1, 1, "Activity Model", new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6210) },
                    { 4, true, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6210), "Build out the Subtask for user", 3, 1, "Subtask Model", new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6210) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subtasks_SectionId",
                table: "Subtasks",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Subtasks_TaskId",
                table: "Subtasks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_BoardId",
                table: "Tasks",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_SectionId",
                table: "Tasks",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subtasks");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
