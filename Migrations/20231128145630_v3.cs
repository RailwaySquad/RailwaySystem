using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railway_Group01.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 30.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 25.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 27.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 25.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 30.0);

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DelayTime",
                value: 15);

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalStationId", "DelayTime", "Distance", "RouteId", "TravelTime" },
                values: new object[] { 4, 13, 1726, 1, 36.0 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "TravelTime" },
                values: new object[] { 2, 15, 1, 411, 8.0 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DelayTime", "DepartureStationId", "Distance", "TravelTime" },
                values: new object[] { 13, 2, 627, 12.4 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[] { 15, 1, 411, 4, 8.0 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalStationId", "DelayTime", "Distance", "RouteId", "TravelTime" },
                values: new object[] { 3, 13, 627, 4, 12.4 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "TravelTime" },
                values: new object[] { 3, 14, 1, 1038, 20.399999999999999 });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Distance", "EndStationId" },
                values: new object[] { 411, 2 });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Distance", "EndStationId", "StartStationId" },
                values: new object[] { 627, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Distance", "EndStationId", "StartStationId" },
                values: new object[] { 1038, 3, 1 });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "Distance", "EndStationId", "StartStationId" },
                values: new object[,]
                {
                    { 5, 1038, 3, 1 },
                    { 6, 1315, 4, 2 },
                    { 7, 1315, 4, 2 },
                    { 8, 688, 4, 3 },
                    { 9, 1726, 4, 1 },
                    { 10, 1726, 4, 1 },
                    { 11, 1726, 1, 4 },
                    { 12, 688, 3, 4 },
                    { 13, 1315, 2, 4 },
                    { 14, 1315, 2, 4 },
                    { 15, 627, 2, 3 },
                    { 16, 1038, 1, 3 },
                    { 17, 1038, 1, 3 },
                    { 18, 411, 1, 2 },
                    { 19, 1726, 1, 4 },
                    { 20, 1726, 1, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 2, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 12, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 12, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), "SE801" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 12, 2, 21, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 12, 2, 8, 28, 0, 0, DateTimeKind.Unspecified), "SE801" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 12, 2, 21, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 12, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), "SE801" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 15, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 12, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "SE201" });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[] { 3, 15, 1, 1038, 5, 19.5 });

            migrationBuilder.InsertData(
                table: "RouteDetailss",
                columns: new[] { "Id", "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[,]
                {
                    { 11, 3, 13, 2, 627, 6, 12.4 },
                    { 12, 4, 12, 3, 688, 6, 15.6 },
                    { 13, 4, 13, 2, 1315, 6, 28.0 },
                    { 14, 4, 13, 2, 1315, 7, 27.0 },
                    { 15, 4, 12, 3, 688, 8, 15.6 },
                    { 16, 2, 15, 1, 411, 9, 8.0 },
                    { 17, 4, 13, 2, 1315, 9, 27.0 },
                    { 18, 4, 14, 1, 1726, 9, 35.0 },
                    { 19, 3, 15, 1, 1038, 10, 18.0 },
                    { 20, 4, 12, 3, 688, 10, 14.0 },
                    { 21, 4, 14, 1, 1726, 10, 32.0 },
                    { 22, 3, 15, 4, 688, 11, 15.6 },
                    { 23, 2, 13, 3, 627, 11, 12.4 },
                    { 24, 1, 15, 2, 411, 11, 8.0 },
                    { 25, 1, 15, 4, 1726, 11, 36.0 },
                    { 26, 3, 15, 4, 688, 12, 15.6 },
                    { 27, 3, 15, 4, 688, 13, 15.6 },
                    { 28, 2, 13, 3, 627, 13, 12.4 },
                    { 29, 2, 14, 4, 1315, 13, 28.0 },
                    { 30, 2, 14, 4, 1315, 14, 27.0 },
                    { 31, 2, 13, 3, 627, 15, 12.4 },
                    { 32, 2, 13, 3, 627, 16, 12.4 },
                    { 33, 1, 15, 2, 411, 16, 8.0 },
                    { 34, 1, 14, 3, 1038, 16, 20.399999999999999 },
                    { 35, 1, 14, 3, 1038, 17, 19.5 },
                    { 36, 1, 15, 2, 411, 18, 8.0 },
                    { 37, 3, 15, 4, 688, 19, 14.0 },
                    { 38, 1, 14, 3, 1038, 19, 18.0 },
                    { 39, 1, 15, 4, 1726, 19, 32.0 },
                    { 40, 2, 15, 4, 1315, 20, 27.0 },
                    { 41, 1, 13, 2, 411, 20, 8.0 },
                    { 42, 1, 15, 4, 1726, 20, 35.0 }
                });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2023, 12, 2, 21, 12, 0, 0, DateTimeKind.Unspecified), "SE801" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 12, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 12, 2, 8, 28, 0, 0, DateTimeKind.Unspecified), "SE801" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 12, 4, 1, 30, 0, 0, DateTimeKind.Unspecified), 9, new DateTime(2023, 12, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "SE201" });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "EndAt", "RouteId", "ScheduleCompleted", "StartAt", "TrainCode" },
                values: new object[,]
                {
                    { 9, new DateTime(2023, 12, 4, 1, 30, 0, 0, DateTimeKind.Unspecified), 7, false, new DateTime(2023, 12, 2, 22, 27, 0, 0, DateTimeKind.Unspecified), "SE201" },
                    { 10, new DateTime(2023, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 10, false, new DateTime(2023, 12, 3, 7, 30, 0, 0, DateTimeKind.Unspecified), "SE401" },
                    { 11, new DateTime(2023, 12, 4, 3, 10, 0, 0, DateTimeKind.Unspecified), 5, false, new DateTime(2023, 12, 3, 7, 30, 0, 0, DateTimeKind.Unspecified), "SE401" },
                    { 12, new DateTime(2023, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 8, false, new DateTime(2023, 12, 4, 3, 25, 0, 0, DateTimeKind.Unspecified), "SE401" },
                    { 13, new DateTime(2023, 12, 3, 19, 20, 0, 0, DateTimeKind.Unspecified), 11, false, new DateTime(2023, 12, 2, 7, 20, 0, 0, DateTimeKind.Unspecified), "SE701" },
                    { 14, new DateTime(2023, 12, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), 12, false, new DateTime(2023, 12, 2, 7, 20, 0, 0, DateTimeKind.Unspecified), "SE701" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "EndAt", "RouteId", "ScheduleCompleted", "StartAt", "TrainCode" },
                values: new object[,]
                {
                    { 15, new DateTime(2023, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, false, new DateTime(2023, 12, 2, 23, 13, 0, 0, DateTimeKind.Unspecified), "SE701" },
                    { 16, new DateTime(2023, 12, 3, 19, 20, 0, 0, DateTimeKind.Unspecified), 18, false, new DateTime(2023, 12, 3, 12, 15, 0, 0, DateTimeKind.Unspecified), "SE701" },
                    { 17, new DateTime(2023, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, false, new DateTime(2023, 12, 2, 7, 20, 0, 0, DateTimeKind.Unspecified), "SE701" },
                    { 18, new DateTime(2023, 12, 3, 19, 20, 0, 0, DateTimeKind.Unspecified), 16, false, new DateTime(2023, 12, 2, 23, 13, 0, 0, DateTimeKind.Unspecified), "SE701" },
                    { 19, new DateTime(2023, 12, 4, 1, 20, 0, 0, DateTimeKind.Unspecified), 19, false, new DateTime(2023, 12, 2, 17, 20, 0, 0, DateTimeKind.Unspecified), "SE301" },
                    { 20, new DateTime(2023, 12, 3, 7, 20, 0, 0, DateTimeKind.Unspecified), 12, false, new DateTime(2023, 12, 2, 17, 20, 0, 0, DateTimeKind.Unspecified), "SE301" },
                    { 21, new DateTime(2023, 12, 4, 1, 20, 0, 0, DateTimeKind.Unspecified), 17, false, new DateTime(2023, 12, 3, 7, 34, 0, 0, DateTimeKind.Unspecified), "SE301" },
                    { 22, new DateTime(2023, 12, 4, 20, 13, 0, 0, DateTimeKind.Unspecified), 20, false, new DateTime(2023, 12, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), "SE101" },
                    { 23, new DateTime(2023, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, false, new DateTime(2023, 12, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), "SE101" },
                    { 24, new DateTime(2023, 12, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), 20, false, new DateTime(2023, 12, 4, 12, 13, 0, 0, DateTimeKind.Unspecified), "SE101" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 30.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 36.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 55.0);

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DelayTime",
                value: 13);

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalStationId", "DelayTime", "Distance", "RouteId", "TravelTime" },
                values: new object[] { 3, 10, 1038, 2, 21.399999999999999 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "TravelTime" },
                values: new object[] { 4, 12, 3, 688, 10.6 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DelayTime", "DepartureStationId", "Distance", "TravelTime" },
                values: new object[] { 10, 4, 688, 12.6 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[] { 12, 3, 627, 3, 13.6 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalStationId", "DelayTime", "Distance", "RouteId", "TravelTime" },
                values: new object[] { 1, 12, 411, 3, 8.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "TravelTime" },
                values: new object[] { 2, 12, 4, 1315, 22.600000000000001 });

            migrationBuilder.UpdateData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[] { 1, 12, 2, 411, 4, 7.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Distance", "EndStationId" },
                values: new object[] { 1726, 4 });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Distance", "EndStationId", "StartStationId" },
                values: new object[] { 1726, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Distance", "EndStationId", "StartStationId" },
                values: new object[] { 1726, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 11, 27, 19, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 26, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 11, 28, 2, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 11, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "SE601" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 11, 28, 7, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 11, 26, 19, 20, 0, 0, DateTimeKind.Unspecified), "SE201" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 11, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 11, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "SE401" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 11, 27, 20, 32, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 11, 26, 9, 30, 0, 0, DateTimeKind.Unspecified), "SE701" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 11, 29, 3, 12, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 11, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), "SE501" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 11, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 11, 26, 6, 30, 0, 0, DateTimeKind.Unspecified), "SE101" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndAt", "RouteId", "StartAt", "TrainCode" },
                values: new object[] { new DateTime(2023, 11, 27, 8, 25, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 11, 26, 7, 30, 0, 0, DateTimeKind.Unspecified), "SE301" });
        }
    }
}
