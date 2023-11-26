﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railway_Group01.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefundRules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaxRefundAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOfDivision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    TrainCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRunning = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.TrainCode);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartStationId = table.Column<int>(type: "int", nullable: false),
                    EndStationId = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Stations_EndStationId",
                        column: x => x.EndStationId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Routes_Stations_StartStationId",
                        column: x => x.StartStationId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Coachs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfCompartment = table.Column<int>(type: "int", nullable: false),
                    NoOfSeat = table.Column<int>(type: "int", nullable: false),
                    SeatAvailable = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coachs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coachs_Trains_TrainCode",
                        column: x => x.TrainCode,
                        principalTable: "Trains",
                        principalColumn: "TrainCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    CIDNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.CIDNo);
                    table.ForeignKey(
                        name: "FK_Passengers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    DistanceRange = table.Column<int>(type: "int", nullable: false),
                    TypeOfClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfTrain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fares_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RouteDetailss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureStationId = table.Column<int>(type: "int", nullable: false),
                    ArrivalStationId = table.Column<int>(type: "int", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    TravelTime = table.Column<double>(type: "float", nullable: false),
                    DelayTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteDetailss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RouteDetailss_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouteDetailss_Stations_ArrivalStationId",
                        column: x => x.ArrivalStationId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RouteDetailss_Stations_DepartureStationId",
                        column: x => x.DepartureStationId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduleCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Trains_TrainCode",
                        column: x => x.TrainCode,
                        principalTable: "Trains",
                        principalColumn: "TrainCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PassengerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    PNRNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompartmentNo = table.Column<int>(type: "int", nullable: false),
                    SeatNo = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduleId = table.Column<int>(type: "int", nullable: true),
                    CoachId = table.Column<int>(type: "int", nullable: true),
                    CIDNo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.PNRNo);
                    table.ForeignKey(
                        name: "FK_Tickets_Coachs_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coachs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_CIDNo",
                        column: x => x.CIDNo,
                        principalTable: "Passengers",
                        principalColumn: "CIDNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Refunds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: true),
                    TransactionId = table.Column<int>(type: "int", nullable: true),
                    RefundRuleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refunds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refunds_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refunds_RefundRules_RefundRuleId",
                        column: x => x.RefundRuleId,
                        principalTable: "RefundRules",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Refunds_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookingDetailss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PNRNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetailss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDetailss_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingDetailss_Tickets_PNRNo",
                        column: x => x.PNRNo,
                        principalTable: "Tickets",
                        principalColumn: "PNRNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suggestions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PNRNo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Tickets_PNRNo",
                        column: x => x.PNRNo,
                        principalTable: "Tickets",
                        principalColumn: "PNRNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetailss_BookingId",
                table: "BookingDetailss",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetailss_PNRNo",
                table: "BookingDetailss",
                column: "PNRNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Coachs_TrainCode",
                table: "Coachs",
                column: "TrainCode");

            migrationBuilder.CreateIndex(
                name: "IX_Fares_RouteId",
                table: "Fares",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_PNRNo",
                table: "Feedbacks",
                column: "PNRNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_UserId",
                table: "Passengers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_BookingId",
                table: "Refunds",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_RefundRuleId",
                table: "Refunds",
                column: "RefundRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_TransactionId",
                table: "Refunds",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RouteDetailss_ArrivalStationId",
                table: "RouteDetailss",
                column: "ArrivalStationId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteDetailss_DepartureStationId",
                table: "RouteDetailss",
                column: "DepartureStationId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteDetailss_RouteId",
                table: "RouteDetailss",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_EndStationId",
                table: "Routes",
                column: "EndStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_StartStationId",
                table: "Routes",
                column: "StartStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_RouteId",
                table: "Schedules",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TrainCode",
                table: "Schedules",
                column: "TrainCode");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CIDNo",
                table: "Tickets",
                column: "CIDNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CoachId",
                table: "Tickets",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScheduleId",
                table: "Tickets",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BookingId",
                table: "Transactions",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingDetailss");

            migrationBuilder.DropTable(
                name: "Fares");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Refunds");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "RouteDetailss");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "RefundRules");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Coachs");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Trains");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
