using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackR.DataContext.SQL.Migrations
{
    /// <inheritdoc />
    public partial class AddedfurtherTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(5960), new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6150), new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6080), new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "ActivityId", "BoardId", "CreatedDate", "Issue", "Status", "Title", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6090), "Build the db context for SQL database", 2, "Build SQL Data Context", new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6100), 1 },
                    { 12, 1, new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6080), "Build the frontend in blazor", 0, "Build View", new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(6090), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "Salt", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(5670), "4A68242455116F0090288DC50AFA1ADA0261D7CAF76CBFB3A533AFAD27BB88DFCAB8367E38D26E0D423889C3D4C3CD856FBFF96C2B2131C0F4EA5D4C0DD22E9E", new byte[] { 50, 147, 138, 145, 155, 248, 69, 164, 249, 18, 235, 192, 3, 82, 187, 36, 206, 26, 119, 243, 47, 201, 89, 114, 172, 136, 16, 9, 211, 134, 130, 110, 4, 17, 159, 211, 208, 93, 227, 51, 135, 5, 233, 93, 133, 67, 139, 221, 102, 231, 175, 228, 242, 50, 146, 126, 178, 30, 58, 35, 235, 33, 173, 41 }, new DateTime(2023, 7, 7, 11, 51, 25, 353, DateTimeKind.Local).AddTicks(5740) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 12);

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3500), new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Subtask",
                keyColumn: "SubtaskID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "Salt", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3050), "DA1C9E44AA2C21C0DA69A2172ECE8546444C7F7C6CF6CB166A71B7082070D692390EAD03C57F9E46F2EA9E13F5A21D1F59DB5225951516CBDB49FC36052F547E", new byte[] { 133, 145, 188, 43, 227, 163, 120, 92, 15, 66, 137, 34, 173, 214, 121, 18, 248, 51, 41, 159, 105, 172, 165, 5, 38, 186, 165, 115, 169, 177, 197, 183, 149, 81, 40, 123, 146, 39, 69, 172, 206, 67, 216, 120, 190, 251, 62, 239, 161, 170, 128, 153, 103, 50, 60, 191, 102, 255, 209, 7, 129, 59, 24, 161 }, new DateTime(2023, 7, 7, 10, 0, 41, 872, DateTimeKind.Local).AddTicks(3100) });
        }
    }
}
