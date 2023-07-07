using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackR.DataContext.SQL.Migrations
{
    /// <inheritdoc />
    public partial class Addedstatusfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Subtask",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3410), new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3480), 0, new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3480), 0, new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3500), 1, new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3510), 2, new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3450), 1, new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "Salt", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3050), "DA1C9E44AA2C21C0DA69A2172ECE8546444C7F7C6CF6CB166A71B7082070D692390EAD03C57F9E46F2EA9E13F5A21D1F59DB5225951516CBDB49FC36052F547E", new byte[] { 133, 145, 188, 43, 227, 163, 120, 92, 15, 66, 137, 34, 173, 214, 121, 18, 248, 51, 41, 159, 105, 172, 165, 5, 38, 186, 165, 115, 169, 177, 197, 183, 149, 81, 40, 123, 146, 39, 69, 172, 206, 67, 216, 120, 190, 251, 62, 239, 161, 170, 128, 153, 103, 50, 60, 191, 102, 255, 209, 7, 129, 59, 24, 161 }, new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3100) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Subtask");

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1410), new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1580), new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1590), new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1610), new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1550), new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "Salt", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(780), "5E092899898BE3A13EC5314655F58733184C5E96C2CEE42B43D56CC69E2AB74934899C0BE1FD44B0AEAE403F74F5ACFF4191230AD17F4650AAE5229079CEB98C", new byte[] { 36, 190, 150, 169, 157, 163, 20, 109, 26, 33, 23, 136, 155, 242, 209, 82, 98, 197, 226, 221, 147, 177, 218, 66, 226, 140, 247, 40, 61, 91, 76, 157, 102, 104, 216, 209, 45, 244, 206, 161, 71, 101, 219, 142, 239, 124, 205, 253, 150, 170, 4, 87, 203, 214, 63, 109, 202, 111, 61, 99, 130, 114, 76, 36 }, new DateTime(2023, 7, 6, 19, 20, 34, 725, DateTimeKind.Local).AddTicks(860) });
        }
    }
}
