using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackR.DataContext.SQL.Migrations
{
    /// <inheritdoc />
    public partial class AddedOwnerfieldtosubtasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 12);

            migrationBuilder.AddColumn<int>(
                name: "OwnerUserId",
                table: "Subtasks",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3440), new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3910), new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3910), new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3920), new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Subtasks",
                keyColumn: "SubtaskId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OwnerUserId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3570), null, new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Subtasks",
                keyColumn: "SubtaskId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OwnerUserId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3580), null, new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Subtasks",
                keyColumn: "SubtaskId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OwnerUserId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3590), null, new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Subtasks",
                keyColumn: "SubtaskId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "OwnerUserId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3780), null, new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3520), new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3530), new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "ActivityId", "BoardId", "CreatedDate", "Issue", "SectionId", "Title", "UpdatedDate", "UserId" },
                values: new object[] { 2, 1, new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3530), "Build the frontend in blazor", 1, "Build View", new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3530), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "Salt", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3120), "3ACDE2D1E1544CD4810B91067AD50C7183A3BCB0F60C54B9412DDAF221A4BC46EB50BF2AABCCC572F8C2221B5D7434A5FA58C09C62849DDEB6D7758DC181B8EE", new byte[] { 158, 211, 216, 250, 17, 184, 56, 91, 183, 195, 255, 144, 136, 139, 15, 215, 103, 224, 86, 225, 104, 95, 81, 42, 92, 40, 144, 254, 161, 13, 45, 14, 165, 95, 254, 12, 230, 205, 103, 179, 247, 39, 216, 187, 180, 177, 59, 96, 134, 227, 80, 25, 82, 219, 138, 64, 1, 7, 7, 178, 218, 33, 38, 157 }, new DateTime(2023, 7, 13, 9, 0, 54, 861, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.CreateIndex(
                name: "IX_Subtasks_OwnerUserId",
                table: "Subtasks",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subtasks_Users_OwnerUserId",
                table: "Subtasks",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subtasks_Users_OwnerUserId",
                table: "Subtasks");

            migrationBuilder.DropIndex(
                name: "IX_Subtasks_OwnerUserId",
                table: "Subtasks");

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Subtasks");

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6110), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Subtasks",
                keyColumn: "SubtaskId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Subtasks",
                keyColumn: "SubtaskId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Subtasks",
                keyColumn: "SubtaskId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6200), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Subtasks",
                keyColumn: "SubtaskId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6150), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6160), new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "ActivityId", "BoardId", "CreatedDate", "Issue", "SectionId", "Title", "UpdatedDate", "UserId" },
                values: new object[] { 12, 1, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6160), "Build the frontend in blazor", 1, "Build View", new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(6160), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "Salt", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(5840), "515DA5D4CAE5AD5C9CF5470FF42F85D3E5F9C96AC3B8BAEB9362C6F8F4D1FE4A6F45EF5965344DDAB9D5CC31D19B307931CF9A6BF705FD015018F3201BF191DF", new byte[] { 117, 154, 129, 18, 15, 40, 209, 55, 200, 224, 144, 48, 225, 71, 239, 90, 65, 142, 1, 232, 161, 190, 90, 84, 107, 136, 158, 141, 130, 132, 234, 99, 41, 99, 107, 62, 58, 172, 212, 36, 70, 40, 1, 167, 216, 234, 179, 69, 87, 196, 141, 44, 80, 30, 137, 18, 62, 182, 110, 28, 173, 49, 228, 29 }, new DateTime(2023, 7, 7, 17, 54, 2, 410, DateTimeKind.Local).AddTicks(5870) });
        }
    }
}
