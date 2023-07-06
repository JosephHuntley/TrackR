using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackR.DataContext.SQL.Migrations
{
    /// <inheritdoc />
    public partial class ActivityuserIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4500), new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4510), new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "Salt", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(3780), "7D563D3BE377EDCD2DB4D6EC647EA24F75ED6D9B1B7A42D8D179DCA17A0B88CE0D47ADFA21071066A1C7B44803C8DB92827566CB88232E3AC28BD9086BC09E25", new byte[] { 163, 187, 159, 165, 33, 162, 153, 91, 34, 97, 3, 151, 51, 148, 193, 99, 43, 30, 23, 17, 97, 200, 116, 108, 252, 115, 215, 110, 0, 146, 93, 174, 249, 129, 245, 49, 75, 73, 248, 0, 53, 200, 133, 71, 135, 154, 206, 43, 166, 181, 114, 19, 234, 24, 13, 123, 251, 110, 59, 243, 252, 51, 112, 152 }, new DateTime(2023, 7, 6, 17, 24, 25, 899, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2080), new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2150), new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2150), new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "Salt", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(1660), "EE644E5589252771C567F22655CB7F73F18284D9BB2E7F3A99BB094E2638AE21863CFBE2E3CD29A2782B03FCAB34C382A4E571897B0D6B708F7058B50DCA7BAE", new byte[] { 170, 217, 79, 195, 142, 186, 217, 184, 222, 127, 13, 240, 56, 89, 112, 197, 160, 44, 234, 23, 203, 191, 74, 130, 208, 101, 208, 118, 62, 129, 81, 222, 60, 243, 45, 7, 237, 33, 29, 57, 2, 166, 180, 77, 213, 194, 226, 68, 118, 16, 84, 16, 249, 100, 128, 145, 213, 252, 8, 142, 217, 101, 196, 66 }, new DateTime(2023, 6, 28, 18, 36, 25, 463, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
