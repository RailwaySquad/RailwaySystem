using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railway_Group01.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingDetails_Booking_BookingId",
                table: "BookingDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingDetails_Tickets_PNRNo",
                table: "BookingDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Coach_Train_TrainCode",
                table: "Coach");

            migrationBuilder.DropForeignKey(
                name: "FK_Fare_Route_RouteId",
                table: "Fare");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Tickets_PNRNo",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Users_UserId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_Booking_BookingId",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_RefundRule_RefundRuleId",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Refund_Transaction_TransactionId",
                table: "Refund");

            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_EndStationId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_Route_Station_StartStationId",
                table: "Route");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteDetails_Route_RouteId",
                table: "RouteDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteDetails_Station_ArrivalStationId",
                table: "RouteDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteDetails_Station_DepartureStationId",
                table: "RouteDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Route_RouteId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Train_TrainCode",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Coach_CoachId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Schedule_ScheduleId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Booking_BookingId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Train",
                table: "Train");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Station",
                table: "Station");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RouteDetails",
                table: "RouteDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Route",
                table: "Route");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundRule",
                table: "RefundRule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refund",
                table: "Refund");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feedback",
                table: "Feedback");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fare",
                table: "Fare");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coach",
                table: "Coach");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingDetails",
                table: "BookingDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Train");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Station");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Station");

            migrationBuilder.DropColumn(
                name: "DistanceFrom",
                table: "Fare");

            migrationBuilder.DropColumn(
                name: "TypeOfCoach",
                table: "Fare");

            migrationBuilder.DropColumn(
                name: "AvailableSeats",
                table: "Coach");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Coach");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "Train",
                newName: "Trains");

            migrationBuilder.RenameTable(
                name: "Station",
                newName: "Stations");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "Schedules");

            migrationBuilder.RenameTable(
                name: "RouteDetails",
                newName: "RouteDetailss");

            migrationBuilder.RenameTable(
                name: "Route",
                newName: "Routes");

            migrationBuilder.RenameTable(
                name: "RefundRule",
                newName: "RefundRules");

            migrationBuilder.RenameTable(
                name: "Refund",
                newName: "Refunds");

            migrationBuilder.RenameTable(
                name: "Feedback",
                newName: "Feedbacks");

            migrationBuilder.RenameTable(
                name: "Fare",
                newName: "Fares");

            migrationBuilder.RenameTable(
                name: "Coach",
                newName: "Coachs");

            migrationBuilder.RenameTable(
                name: "BookingDetails",
                newName: "BookingDetailss");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_BookingId",
                table: "Transactions",
                newName: "IX_Transactions_BookingId");

            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "Schedules",
                newName: "ScheduleCompleted");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_TrainCode",
                table: "Schedules",
                newName: "IX_Schedules_TrainCode");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_RouteId",
                table: "Schedules",
                newName: "IX_Schedules_RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_RouteDetails_RouteId",
                table: "RouteDetailss",
                newName: "IX_RouteDetailss_RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_RouteDetails_DepartureStationId",
                table: "RouteDetailss",
                newName: "IX_RouteDetailss_DepartureStationId");

            migrationBuilder.RenameIndex(
                name: "IX_RouteDetails_ArrivalStationId",
                table: "RouteDetailss",
                newName: "IX_RouteDetailss_ArrivalStationId");

            migrationBuilder.RenameIndex(
                name: "IX_Route_StartStationId",
                table: "Routes",
                newName: "IX_Routes_StartStationId");

            migrationBuilder.RenameIndex(
                name: "IX_Route_EndStationId",
                table: "Routes",
                newName: "IX_Routes_EndStationId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_TransactionId",
                table: "Refunds",
                newName: "IX_Refunds_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_RefundRuleId",
                table: "Refunds",
                newName: "IX_Refunds_RefundRuleId");

            migrationBuilder.RenameIndex(
                name: "IX_Refund_BookingId",
                table: "Refunds",
                newName: "IX_Refunds_BookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_UserId",
                table: "Feedbacks",
                newName: "IX_Feedbacks_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_PNRNo",
                table: "Feedbacks",
                newName: "IX_Feedbacks_PNRNo");

            migrationBuilder.RenameColumn(
                name: "DistanceTo",
                table: "Fares",
                newName: "DistanceRange");

            migrationBuilder.RenameIndex(
                name: "IX_Fare_RouteId",
                table: "Fares",
                newName: "IX_Fares_RouteId");

            migrationBuilder.RenameColumn(
                name: "NoOfSeats",
                table: "Coachs",
                newName: "SeatAvailable");

            migrationBuilder.RenameColumn(
                name: "NoOfCompartments",
                table: "Coachs",
                newName: "NoOfSeat");

            migrationBuilder.RenameColumn(
                name: "CoachNo",
                table: "Coachs",
                newName: "NoOfCompartment");

            migrationBuilder.RenameIndex(
                name: "IX_Coach_TrainCode",
                table: "Coachs",
                newName: "IX_Coachs_TrainCode");

            migrationBuilder.RenameIndex(
                name: "IX_BookingDetails_PNRNo",
                table: "BookingDetailss",
                newName: "IX_BookingDetailss_PNRNo");

            migrationBuilder.RenameIndex(
                name: "IX_BookingDetails_BookingId",
                table: "BookingDetailss",
                newName: "IX_BookingDetailss_BookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_UserId",
                table: "Bookings",
                newName: "IX_Bookings_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeCode",
                table: "Trains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Zone",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Stations",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StationCode",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StationName",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TrainCode",
                table: "Schedules",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartAt",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndAt",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TravelTime",
                table: "RouteDetailss",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "RouteDetailss",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartureStationId",
                table: "RouteDetailss",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArrivalStationId",
                table: "RouteDetailss",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StartStationId",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EndStationId",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfTrain",
                table: "Fares",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "Fares",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Fares",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfClass",
                table: "Fares",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TrainCode",
                table: "Coachs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Coachs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Coachs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypeCode",
                table: "Coachs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trains",
                table: "Trains",
                column: "TrainCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stations",
                table: "Stations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RouteDetailss",
                table: "RouteDetailss",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Routes",
                table: "Routes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundRules",
                table: "RefundRules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refunds",
                table: "Refunds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feedbacks",
                table: "Feedbacks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fares",
                table: "Fares",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coachs",
                table: "Coachs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingDetailss",
                table: "BookingDetailss",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "NameOfDivision", "StationCode", "StationName", "ZipCode", "Zone" },
                values: new object[,]
                {
                    { 1, "Ho Chi Minh City", "SGO", "Sai Gon", 700000, "Southern" },
                    { 2, "Khanh Hoa Province", "NTR", "Nha Trang", 650000, "Central" },
                    { 3, "Thua Thien Hue Province", "HUE", "Hue", 530000, "Central" },
                    { 4, "Hanoi Capital", "HNO", "Ha Noi", 700000, "North" }
                });

            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "TrainCode", "Description", "IsRunning", "Name", "TypeCode" },
                values: new object[,]
                {
                    { "SE101", "Train SE1 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE1", "F" },
                    { "SE102", "Train SE1 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE1", "F" },
                    { "SE201", "Train SE2 is a fast train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE2", "F" },
                    { "SE202", "Train SE2 is a fast train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE2", "F" },
                    { "SE301", "The SE3 train is the fastest and most beautiful train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE3", "SF" },
                    { "SE302", "The SE3 train is the fastest and most beautiful train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE3", "SF" },
                    { "SE401", "Train SE4 is the fastest and most beautiful train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE4", "SF" },
                    { "SE402", "Train SE4 is the fastest and most beautiful train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE4", "SF" },
                    { "SE501", "Train SE5 is a slow train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE5", "S" },
                    { "SE502", "Train SE5 is a slow train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE5", "S" },
                    { "SE601", "Train SE6 is a slow train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE6", "S" },
                    { "SE602", "Train SE6 is a slow train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE6", "S" },
                    { "SE701", "Train SE7 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE7", "F" },
                    { "SE702", "Train SE7 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE7", "F" },
                    { "SE801", "Train SE8 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE8", "F" },
                    { "SE802", "Train SE8 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers.", true, "SE8", "F" }
                });

            migrationBuilder.InsertData(
                table: "Coachs",
                columns: new[] { "Id", "Description", "Name", "NoOfCompartment", "NoOfSeat", "SeatAvailable", "TrainCode", "TypeCode" },
                values: new object[,]
                {
                    { 1, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 8, "SE101", "AC1" },
                    { 2, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 2, "SE101", "AC1" },
                    { 3, "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious", "Class A", 4, 2, 4, "SE101", "AC2" },
                    { 4, "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs", "Class B", 6, 2, 12, "SE101", "AC3" },
                    { 5, "more comfor and amenities\nhigher fare", "Class C", 6, 6, 20, "SE101", "SL" },
                    { 6, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 64, "SE101", "GE" },
                    { 7, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 8, "SE201", "AC1" },
                    { 8, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 10, "SE201", "AC2" },
                    { 9, "more comfor and amenities\\nhigher fare", "Class C", 6, 6, 12, "SE201", "SL" },
                    { 10, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 3, "SE201", "GE" },
                    { 11, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 2, "SE201", "GE" },
                    { 12, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 8, "SE301", "AC1" },
                    { 13, "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious", "Class A", 4, 2, 8, "SE301", "AC2" },
                    { 14, "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs", "Class B", 6, 2, 12, "SE301", "AC3" },
                    { 15, "more comfor and amenities\\nhigher fare", "Class C", 6, 6, 22, "SE301", "SL" },
                    { 16, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 22, "SE301", "GE" },
                    { 17, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 8, "SE401", "AC1" },
                    { 18, "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious", "Class A", 4, 2, 8, "SE401", "AC2" },
                    { 19, "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs", "Class B", 6, 2, 12, "SE401", "AC3" },
                    { 20, "more comfor and amenities\\nhigher fare", "Class C", 6, 6, 20, "SE401", "SL" },
                    { 21, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 24, "SE401", "GE" },
                    { 22, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 2, "SE501", "AC1" },
                    { 23, "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious", "Class A", 4, 2, 3, "SE501", "AC2" },
                    { 24, "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs", "Class B", 6, 2, 10, "SE501", "AC3" },
                    { 25, "more comfor and amenities\\nhigher fare", "Class C", 6, 6, 17, "SE501", "SL" },
                    { 26, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 13, "SE501", "GE" },
                    { 27, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 7, "SE601", "AC1" },
                    { 28, "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious", "Class A", 4, 2, 6, "SE601", "AC2" },
                    { 29, "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs", "Class B", 6, 2, 10, "SE601", "AC3" },
                    { 30, "more comfor and amenities\\nhigher fare", "Class C", 6, 6, 20, "SE601", "SL" },
                    { 31, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 12, "SE601", "GE" },
                    { 32, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 13, "SE601", "GE" },
                    { 33, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 8, "SE701", "AC1" },
                    { 34, "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious", "Class A", 4, 2, 8, "SE701", "AC2" },
                    { 35, "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs", "Class B", 6, 2, 11, "SE701", "AC3" },
                    { 36, "more comfor and amenities\\nhigher fare", "Class C", 6, 6, 22, "SE701", "SL" },
                    { 37, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 16, "SE701", "GE" },
                    { 38, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 28, "SE701", "GE" },
                    { 39, "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog", "Class S", 4, 2, 8, "SE801", "AC1" },
                    { 40, "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious", "Class A", 4, 2, 8, "SE801", "AC2" },
                    { 41, "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs", "Class B", 6, 2, 11, "SE801", "AC3" },
                    { 42, "more comfor and amenities\\nhigher fare", "Class C", 6, 6, 10, "SE801", "SL" }
                });

            migrationBuilder.InsertData(
                table: "Coachs",
                columns: new[] { "Id", "Description", "Name", "NoOfCompartment", "NoOfSeat", "SeatAvailable", "TrainCode", "TypeCode" },
                values: new object[,]
                {
                    { 43, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 16, "SE801", "GE" },
                    { 44, "basic amenities\nbudget-friendly\nbench-type seats\nmore people", "Class D", 4, 16, 22, "SE801", "GE" }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "Distance", "EndStationId", "StartStationId" },
                values: new object[,]
                {
                    { 1, 1726, 4, 1 },
                    { 2, 1726, 4, 1 },
                    { 3, 1726, 1, 4 },
                    { 4, 1726, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Fares",
                columns: new[] { "Id", "DistanceRange", "Price", "RouteId", "TypeOfClass", "TypeOfTrain" },
                values: new object[,]
                {
                    { 1, 12000, 500000, 1, "AC1", "SF" },
                    { 2, 12000, 300000, 1, "AC2", "SF" },
                    { 3, 12000, 200000, 1, "AC3", "SF" },
                    { 4, 12000, 100000, 1, "SL", "SF" },
                    { 5, 12000, 50000, 1, "GE", "SF" },
                    { 6, 12000, 400000, 1, "AC1", "F" },
                    { 7, 12000, 200000, 1, "AC2", "F" },
                    { 8, 12000, 150000, 1, "AC3", "F" },
                    { 9, 12000, 80000, 1, "SL", "F" },
                    { 10, 12000, 40000, 1, "GE", "F" },
                    { 11, 12000, 360000, 1, "AC1", "S" },
                    { 12, 12000, 180000, 1, "AC2", "S" },
                    { 13, 12000, 120000, 1, "AC3", "S" },
                    { 14, 12000, 60000, 1, "SL", "S" },
                    { 15, 12000, 30000, 1, "GE", "S" },
                    { 16, 18000, 550000, 2, "AC1", "SF" },
                    { 17, 18000, 350000, 2, "AC2", "SF" },
                    { 18, 18000, 250000, 2, "AC3", "SF" },
                    { 19, 18000, 150000, 2, "SL", "SF" },
                    { 20, 18000, 55000, 2, "GE", "SF" },
                    { 21, 18000, 450000, 2, "AC1", "F" },
                    { 22, 18000, 250000, 2, "AC2", "F" },
                    { 23, 18000, 200000, 2, "AC3", "F" },
                    { 24, 18000, 85000, 2, "SL", "F" },
                    { 25, 18000, 45000, 2, "GE", "F" },
                    { 26, 18000, 390000, 2, "AC1", "S" },
                    { 27, 18000, 200000, 2, "AC2", "S" },
                    { 28, 18000, 160000, 2, "AC3", "S" },
                    { 29, 18000, 65000, 2, "SL", "S" },
                    { 30, 18000, 35000, 2, "GE", "S" },
                    { 31, 12000, 500000, 3, "AC1", "SF" },
                    { 32, 12000, 300000, 3, "AC2", "SF" },
                    { 33, 12000, 200000, 3, "AC3", "SF" },
                    { 34, 12000, 100000, 3, "SL", "SF" },
                    { 35, 12000, 50000, 3, "GE", "SF" },
                    { 36, 12000, 400000, 3, "AC1", "F" },
                    { 37, 12000, 200000, 3, "AC2", "F" },
                    { 38, 12000, 150000, 3, "AC3", "F" },
                    { 39, 12000, 80000, 3, "SL", "F" },
                    { 40, 12000, 40000, 3, "GE", "F" },
                    { 41, 12000, 360000, 3, "AC1", "S" },
                    { 42, 12000, 180000, 3, "AC2", "S" }
                });

            migrationBuilder.InsertData(
                table: "Fares",
                columns: new[] { "Id", "DistanceRange", "Price", "RouteId", "TypeOfClass", "TypeOfTrain" },
                values: new object[,]
                {
                    { 43, 12000, 120000, 3, "AC3", "S" },
                    { 44, 12000, 60000, 3, "SL", "S" },
                    { 45, 12000, 30000, 3, "GE", "S" },
                    { 46, 18000, 550000, 4, "AC1", "SF" },
                    { 47, 18000, 350000, 4, "AC2", "SF" },
                    { 48, 18000, 250000, 4, "AC3", "SF" },
                    { 49, 18000, 150000, 4, "SL", "SF" },
                    { 50, 18000, 55000, 4, "GE", "SF" },
                    { 51, 18000, 450000, 4, "AC1", "F" },
                    { 52, 18000, 250000, 4, "AC2", "F" },
                    { 53, 18000, 200000, 4, "AC3", "F" },
                    { 54, 18000, 85000, 4, "SL", "F" },
                    { 55, 18000, 45000, 4, "GE", "F" },
                    { 56, 18000, 390000, 4, "AC1", "S" },
                    { 57, 18000, 200000, 4, "AC2", "S" },
                    { 58, 18000, 160000, 4, "AC3", "S" },
                    { 59, 18000, 65000, 4, "SL", "S" },
                    { 60, 18000, 35000, 4, "GE", "S" }
                });

            migrationBuilder.InsertData(
                table: "RouteDetailss",
                columns: new[] { "Id", "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[,]
                {
                    { 1, 2, 13, 1, 411, 1, 8.0 },
                    { 2, 3, 13, 2, 627, 1, 12.4 },
                    { 3, 4, 12, 3, 688, 1, 15.6 },
                    { 4, 3, 10, 1, 1038, 2, 21.399999999999999 },
                    { 5, 4, 12, 3, 688, 2, 10.6 },
                    { 6, 3, 10, 4, 688, 3, 12.6 },
                    { 7, 2, 12, 3, 627, 3, 13.6 },
                    { 8, 1, 12, 2, 411, 3, 8.5999999999999996 },
                    { 9, 2, 12, 4, 1315, 4, 22.600000000000001 },
                    { 10, 1, 12, 2, 411, 4, 7.5999999999999996 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "EndAt", "RouteId", "ScheduleCompleted", "StartAt", "TrainCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 27, 19, 12, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2023, 11, 26, 6, 0, 0, 0, DateTimeKind.Unspecified), "SE801" },
                    { 2, new DateTime(2023, 11, 28, 2, 30, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2023, 11, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "SE601" },
                    { 3, new DateTime(2023, 11, 28, 7, 10, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2023, 11, 26, 19, 20, 0, 0, DateTimeKind.Unspecified), "SE201" },
                    { 4, new DateTime(2023, 11, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, false, new DateTime(2023, 11, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "SE401" },
                    { 5, new DateTime(2023, 11, 27, 20, 32, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(2023, 11, 26, 9, 30, 0, 0, DateTimeKind.Unspecified), "SE701" },
                    { 6, new DateTime(2023, 11, 29, 3, 12, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(2023, 11, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), "SE501" },
                    { 7, new DateTime(2023, 11, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), 3, false, new DateTime(2023, 11, 26, 6, 30, 0, 0, DateTimeKind.Unspecified), "SE101" },
                    { 8, new DateTime(2023, 11, 27, 8, 25, 0, 0, DateTimeKind.Unspecified), 4, false, new DateTime(2023, 11, 26, 7, 30, 0, 0, DateTimeKind.Unspecified), "SE301" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BookingDetailss_Bookings_BookingId",
                table: "BookingDetailss",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingDetailss_Tickets_PNRNo",
                table: "BookingDetailss",
                column: "PNRNo",
                principalTable: "Tickets",
                principalColumn: "PNRNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Coachs_Trains_TrainCode",
                table: "Coachs",
                column: "TrainCode",
                principalTable: "Trains",
                principalColumn: "TrainCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fares_Routes_RouteId",
                table: "Fares",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Tickets_PNRNo",
                table: "Feedbacks",
                column: "PNRNo",
                principalTable: "Tickets",
                principalColumn: "PNRNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Users_UserId",
                table: "Feedbacks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_Bookings_BookingId",
                table: "Refunds",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_RefundRules_RefundRuleId",
                table: "Refunds",
                column: "RefundRuleId",
                principalTable: "RefundRules",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_Transactions_TransactionId",
                table: "Refunds",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RouteDetailss_Routes_RouteId",
                table: "RouteDetailss",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RouteDetailss_Stations_ArrivalStationId",
                table: "RouteDetailss",
                column: "ArrivalStationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RouteDetailss_Stations_DepartureStationId",
                table: "RouteDetailss",
                column: "DepartureStationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Stations_EndStationId",
                table: "Routes",
                column: "EndStationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Stations_StartStationId",
                table: "Routes",
                column: "StartStationId",
                principalTable: "Stations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Routes_RouteId",
                table: "Schedules",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Trains_TrainCode",
                table: "Schedules",
                column: "TrainCode",
                principalTable: "Trains",
                principalColumn: "TrainCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Coachs_CoachId",
                table: "Tickets",
                column: "CoachId",
                principalTable: "Coachs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Schedules_ScheduleId",
                table: "Tickets",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Bookings_BookingId",
                table: "Transactions",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingDetailss_Bookings_BookingId",
                table: "BookingDetailss");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingDetailss_Tickets_PNRNo",
                table: "BookingDetailss");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Coachs_Trains_TrainCode",
                table: "Coachs");

            migrationBuilder.DropForeignKey(
                name: "FK_Fares_Routes_RouteId",
                table: "Fares");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Tickets_PNRNo",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Users_UserId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_Bookings_BookingId",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_RefundRules_RefundRuleId",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_Transactions_TransactionId",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteDetailss_Routes_RouteId",
                table: "RouteDetailss");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteDetailss_Stations_ArrivalStationId",
                table: "RouteDetailss");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteDetailss_Stations_DepartureStationId",
                table: "RouteDetailss");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Stations_EndStationId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Stations_StartStationId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Routes_RouteId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Trains_TrainCode",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Coachs_CoachId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Schedules_ScheduleId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Bookings_BookingId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trains",
                table: "Trains");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stations",
                table: "Stations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Routes",
                table: "Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RouteDetailss",
                table: "RouteDetailss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refunds",
                table: "Refunds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundRules",
                table: "RefundRules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feedbacks",
                table: "Feedbacks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fares",
                table: "Fares");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coachs",
                table: "Coachs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingDetailss",
                table: "BookingDetailss");

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RouteDetailss",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE102");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE202");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE302");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE402");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE502");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE602");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE702");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE802");

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE101");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE201");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE301");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE401");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE501");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE601");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE701");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainCode",
                keyValue: "SE801");

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "TypeCode",
                table: "Trains");

            migrationBuilder.DropColumn(
                name: "StationCode",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "StationName",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "TypeOfClass",
                table: "Fares");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Coachs");

            migrationBuilder.DropColumn(
                name: "TypeCode",
                table: "Coachs");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "Trains",
                newName: "Train");

            migrationBuilder.RenameTable(
                name: "Stations",
                newName: "Station");

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "Schedule");

            migrationBuilder.RenameTable(
                name: "Routes",
                newName: "Route");

            migrationBuilder.RenameTable(
                name: "RouteDetailss",
                newName: "RouteDetails");

            migrationBuilder.RenameTable(
                name: "Refunds",
                newName: "Refund");

            migrationBuilder.RenameTable(
                name: "RefundRules",
                newName: "RefundRule");

            migrationBuilder.RenameTable(
                name: "Feedbacks",
                newName: "Feedback");

            migrationBuilder.RenameTable(
                name: "Fares",
                newName: "Fare");

            migrationBuilder.RenameTable(
                name: "Coachs",
                newName: "Coach");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameTable(
                name: "BookingDetailss",
                newName: "BookingDetails");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_BookingId",
                table: "Transaction",
                newName: "IX_Transaction_BookingId");

            migrationBuilder.RenameColumn(
                name: "ScheduleCompleted",
                table: "Schedule",
                newName: "IsCompleted");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_TrainCode",
                table: "Schedule",
                newName: "IX_Schedule_TrainCode");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_RouteId",
                table: "Schedule",
                newName: "IX_Schedule_RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_Routes_StartStationId",
                table: "Route",
                newName: "IX_Route_StartStationId");

            migrationBuilder.RenameIndex(
                name: "IX_Routes_EndStationId",
                table: "Route",
                newName: "IX_Route_EndStationId");

            migrationBuilder.RenameIndex(
                name: "IX_RouteDetailss_RouteId",
                table: "RouteDetails",
                newName: "IX_RouteDetails_RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_RouteDetailss_DepartureStationId",
                table: "RouteDetails",
                newName: "IX_RouteDetails_DepartureStationId");

            migrationBuilder.RenameIndex(
                name: "IX_RouteDetailss_ArrivalStationId",
                table: "RouteDetails",
                newName: "IX_RouteDetails_ArrivalStationId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_TransactionId",
                table: "Refund",
                newName: "IX_Refund_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_RefundRuleId",
                table: "Refund",
                newName: "IX_Refund_RefundRuleId");

            migrationBuilder.RenameIndex(
                name: "IX_Refunds_BookingId",
                table: "Refund",
                newName: "IX_Refund_BookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedback",
                newName: "IX_Feedback_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_PNRNo",
                table: "Feedback",
                newName: "IX_Feedback_PNRNo");

            migrationBuilder.RenameColumn(
                name: "DistanceRange",
                table: "Fare",
                newName: "DistanceTo");

            migrationBuilder.RenameIndex(
                name: "IX_Fares_RouteId",
                table: "Fare",
                newName: "IX_Fare_RouteId");

            migrationBuilder.RenameColumn(
                name: "SeatAvailable",
                table: "Coach",
                newName: "NoOfSeats");

            migrationBuilder.RenameColumn(
                name: "NoOfSeat",
                table: "Coach",
                newName: "NoOfCompartments");

            migrationBuilder.RenameColumn(
                name: "NoOfCompartment",
                table: "Coach",
                newName: "CoachNo");

            migrationBuilder.RenameIndex(
                name: "IX_Coachs_TrainCode",
                table: "Coach",
                newName: "IX_Coach_TrainCode");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_UserId",
                table: "Booking",
                newName: "IX_Booking_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingDetailss_PNRNo",
                table: "BookingDetails",
                newName: "IX_BookingDetails_PNRNo");

            migrationBuilder.RenameIndex(
                name: "IX_BookingDetailss_BookingId",
                table: "BookingDetails",
                newName: "IX_BookingDetails_BookingId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Train",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Train",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Zone",
                table: "Station",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Station",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Station",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Station",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainCode",
                table: "Schedule",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartAt",
                table: "Schedule",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "Schedule",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndAt",
                table: "Schedule",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "StartStationId",
                table: "Route",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EndStationId",
                table: "Route",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TravelTime",
                table: "RouteDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "RouteDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartureStationId",
                table: "RouteDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArrivalStationId",
                table: "RouteDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfTrain",
                table: "Fare",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "Fare",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Fare",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DistanceFrom",
                table: "Fare",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfCoach",
                table: "Fare",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainCode",
                table: "Coach",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Coach",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AvailableSeats",
                table: "Coach",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Coach",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Train",
                table: "Train",
                column: "TrainCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Station",
                table: "Station",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Route",
                table: "Route",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RouteDetails",
                table: "RouteDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refund",
                table: "Refund",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundRule",
                table: "RefundRule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feedback",
                table: "Feedback",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fare",
                table: "Fare",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coach",
                table: "Coach",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingDetails",
                table: "BookingDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingDetails_Booking_BookingId",
                table: "BookingDetails",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingDetails_Tickets_PNRNo",
                table: "BookingDetails",
                column: "PNRNo",
                principalTable: "Tickets",
                principalColumn: "PNRNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coach_Train_TrainCode",
                table: "Coach",
                column: "TrainCode",
                principalTable: "Train",
                principalColumn: "TrainCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Fare_Route_RouteId",
                table: "Fare",
                column: "RouteId",
                principalTable: "Route",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Tickets_PNRNo",
                table: "Feedback",
                column: "PNRNo",
                principalTable: "Tickets",
                principalColumn: "PNRNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Users_UserId",
                table: "Feedback",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_Booking_BookingId",
                table: "Refund",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_RefundRule_RefundRuleId",
                table: "Refund",
                column: "RefundRuleId",
                principalTable: "RefundRule",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refund_Transaction_TransactionId",
                table: "Refund",
                column: "TransactionId",
                principalTable: "Transaction",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Route_Station_EndStationId",
                table: "Route",
                column: "EndStationId",
                principalTable: "Station",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Route_Station_StartStationId",
                table: "Route",
                column: "StartStationId",
                principalTable: "Station",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RouteDetails_Route_RouteId",
                table: "RouteDetails",
                column: "RouteId",
                principalTable: "Route",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RouteDetails_Station_ArrivalStationId",
                table: "RouteDetails",
                column: "ArrivalStationId",
                principalTable: "Station",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RouteDetails_Station_DepartureStationId",
                table: "RouteDetails",
                column: "DepartureStationId",
                principalTable: "Station",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Route_RouteId",
                table: "Schedule",
                column: "RouteId",
                principalTable: "Route",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Train_TrainCode",
                table: "Schedule",
                column: "TrainCode",
                principalTable: "Train",
                principalColumn: "TrainCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Coach_CoachId",
                table: "Tickets",
                column: "CoachId",
                principalTable: "Coach",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Schedule_ScheduleId",
                table: "Tickets",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Booking_BookingId",
                table: "Transaction",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id");
        }
    }
}
