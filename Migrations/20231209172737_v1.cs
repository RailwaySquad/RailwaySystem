using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railway_Group01.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Trip",
                table: "BookingDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 9, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 31, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 31, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 31, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 31, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 31, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 31, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 31, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 31, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 31, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 31, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 31, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 12, 31, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 30, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 30, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 30, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 31, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 31, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 31, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 31, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 31, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 1, 31, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 19, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 19, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 19, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 20, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 21, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 20, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 21, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 20, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 21, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 22, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 23, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 22, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 23, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 22, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 23, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 24, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 25, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 24, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 25, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 24, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 25, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 26, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 27, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 26, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 27, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 26, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 27, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 28, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 29, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 28, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 29, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 28, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 29, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 1, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 2, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 1, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 2, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 1, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 2, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 3, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 4, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 3, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 4, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 3, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 4, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 5, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 6, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 5, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 6, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 5, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 6, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 7, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 8, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 7, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 8, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 7, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 8, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 9, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 10, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 9, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 10, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 9, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 10, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1155,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 11, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1156,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 12, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1157,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 11, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 12, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 11, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 12, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 13, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 14, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1169,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1170,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1171,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 13, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1172,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 14, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1173,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1174,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1175,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 13, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1176,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 14, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1177,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1178,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1179,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 15, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1180,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 16, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1181,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1182,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1183,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 15, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1184,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 16, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1185,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1186,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1187,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 15, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1188,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 16, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1189,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1190,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1191,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 17, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1192,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 7, 52, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 18, 0, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1193,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1194,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1195,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 17, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 42, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 18, 8, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 17, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 20, 2, 5, 34, 930, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 3, 18, 16, 27, 34, 930, DateTimeKind.Local).AddTicks(8515) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trip",
                table: "BookingDetails");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 8, 31, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 8, 31, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 9, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 9, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 31, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 31, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 31, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 31, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 31, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 10, 31, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 31, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 31, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 31, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 31, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 31, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 12, 31, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 30, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 1, 31, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 30, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 31, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 30, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 31, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 31, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 31, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 31, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 1, 31, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 18, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 19, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 19, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 19, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 20, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 21, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 20, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 21, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 22, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 20, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 21, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 21, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 22, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 23, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 22, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 23, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 24, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 22, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 23, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 23, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 24, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 25, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 24, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 25, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 26, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 24, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 25, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 25, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 26, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 27, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 26, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 27, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 26, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 27, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 27, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 28, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 2, 29, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 28, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 29, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 28, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 29, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 2, 29, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 1, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 2, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 1, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 2, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 3, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 1, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 2, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 2, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 3, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 4, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 3, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 4, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 5, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 3, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 4, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 4, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 5, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 6, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 5, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 6, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 5, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 6, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 6, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 7, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 8, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 7, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 8, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 9, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 7, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 8, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 8, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 9, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 9, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 10, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 11, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 9, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 10, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1155,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 10, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1156,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 11, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1157,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 11, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 12, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 11, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 12, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 12, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 13, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1169,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1170,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1171,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 14, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 13, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1172,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 14, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1173,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1174,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1175,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 15, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 13, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1176,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 14, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1177,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1178,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1179,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 14, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1180,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 15, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1181,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1182,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1183,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 16, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 15, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1184,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 16, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1185,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1186,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1187,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 15, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1188,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 16, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1189,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1190,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1191,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 16, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1192,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 6, 36, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 17, 23, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1193,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1194,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1195,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 17, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 16, 26, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 18, 7, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 19, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 17, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "Arrival", "Departure" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 49, 13, 559, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 3, 18, 15, 11, 13, 559, DateTimeKind.Local).AddTicks(8079) });
        }
    }
}
