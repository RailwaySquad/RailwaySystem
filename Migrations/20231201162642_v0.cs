using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railway_Group01.Migrations
{
    public partial class v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoachClasses",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachClasses", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "RefundRules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidFrom = table.Column<int>(type: "int", nullable: false),
                    ValidTo = table.Column<int>(type: "int", nullable: false),
                    RefundAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameOfDivision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainTypes",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainTypes", x => x.Code);
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Routes_Stations_StartStationId",
                        column: x => x.StartStationId,
                        principalTable: "Stations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PassengerTypes",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TypeCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Discount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerTypes", x => x.Code);
                    table.ForeignKey(
                        name: "FK_PassengerTypes_TrainTypes_TypeCode",
                        column: x => x.TypeCode,
                        principalTable: "TrainTypes",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TypeCode = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    IsRunning = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Trains_TrainTypes_TypeCode",
                        column: x => x.TypeCode,
                        principalTable: "TrainTypes",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Suggestions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: true),
                    ClassCode = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    TrainTypeCode = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fares_CoachClasses_ClassCode",
                        column: x => x.ClassCode,
                        principalTable: "CoachClasses",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Fares_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fares_TrainTypes_TrainTypeCode",
                        column: x => x.TrainTypeCode,
                        principalTable: "TrainTypes",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "RouteDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureStationId = table.Column<int>(type: "int", nullable: false),
                    ArrivalStationId = table.Column<int>(type: "int", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    TravelTime = table.Column<int>(type: "int", nullable: false),
                    DelayTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RouteDetails_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouteDetails_Stations_ArrivalStationId",
                        column: x => x.ArrivalStationId,
                        principalTable: "Stations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RouteDetails_Stations_DepartureStationId",
                        column: x => x.DepartureStationId,
                        principalTable: "Stations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PassengerTypeCode = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Passengers_PassengerTypes_PassengerTypeCode",
                        column: x => x.PassengerTypeCode,
                        principalTable: "PassengerTypes",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Passengers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoachNo = table.Column<int>(type: "int", nullable: false),
                    NoOfCompartments = table.Column<int>(type: "int", nullable: false),
                    NoOfSeats = table.Column<int>(type: "int", nullable: false),
                    ClassCode = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    TrainCode = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coaches_CoachClasses_ClassCode",
                        column: x => x.ClassCode,
                        principalTable: "CoachClasses",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Coaches_Trains_TrainCode",
                        column: x => x.TrainCode,
                        principalTable: "Trains",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFinished = table.Column<bool>(type: "bit", nullable: false),
                    TrainCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatNo = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    CompartmentNo = table.Column<int>(type: "int", nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seat_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDetails_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingDetails_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    PNRNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FareId = table.Column<int>(type: "int", nullable: true),
                    ScheduleId = table.Column<int>(type: "int", nullable: true),
                    PassengerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BookingDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.PNRNo);
                    table.ForeignKey(
                        name: "FK_Tickets_BookingDetails_BookingDetailId",
                        column: x => x.BookingDetailId,
                        principalTable: "BookingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Fares_FareId",
                        column: x => x.FareId,
                        principalTable: "Fares",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_PassengerID",
                        column: x => x.PassengerID,
                        principalTable: "Passengers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cancellings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receiver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefundRuleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PNRNo = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancellings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cancellings_RefundRules_RefundRuleId",
                        column: x => x.RefundRuleId,
                        principalTable: "RefundRules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cancellings_Tickets_PNRNo",
                        column: x => x.PNRNo,
                        principalTable: "Tickets",
                        principalColumn: "PNRNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cancellings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Receiver = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: true),
                    CancellingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_Cancellings_CancellingId",
                        column: x => x.CancellingId,
                        principalTable: "Cancellings",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CoachClasses",
                columns: new[] { "Code", "Name" },
                values: new object[,]
                {
                    { "AC1", "AC First Class" },
                    { "AC2", "AC Second Class" },
                    { "AC3", "AC Third Class" },
                    { "GE", "General Class" },
                    { "SL", "Sleeper Class" }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Code", "Name", "NameOfDivision", "ZipCode", "Zone" },
                values: new object[,]
                {
                    { 1, "SGO", "Sai Gon", "Ho Chi Minh City", 0, 3 },
                    { 2, "BHO", "Bien Hoa", "Dong Nai Province", 0, 3 },
                    { 3, "LKA", "Phan Thiet", "Binh Thuan Province", 0, 2 },
                    { 4, "NTR", "Nha Trang", "Khanh Hoa Province", 0, 2 },
                    { 5, "THO", "Tuy Hoa", "Phu Yen Province", 0, 2 },
                    { 6, "QNG", "Quang Ngai", "Quang Ngai Province", 0, 2 },
                    { 7, "DNG", "Da Nang", "Da Nang Province", 0, 2 },
                    { 8, "HUE", "Hue", "Thua Thien Hue Province", 0, 2 },
                    { 9, "VIN", "Vinh", "Vinh Province", 0, 3 },
                    { 10, "NBI", "Ninh Binh", "Ninh Binh Province", 0, 3 },
                    { 11, "HNO", "Ha Noi", "Hanoi Capital", 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "TrainTypes",
                columns: new[] { "Code", "Name" },
                values: new object[,]
                {
                    { "F", "Fast Train" },
                    { "S", "Slow Train" },
                    { "SF", "Super Fast Train" }
                });

            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "Code", "IsRunning", "TypeCode" },
                values: new object[,]
                {
                    { "SE101", false, "F" },
                    { "SE102", false, "F" },
                    { "SE201", false, "F" },
                    { "SE202", false, "F" },
                    { "SE301", false, "SF" },
                    { "SE302", false, "SF" },
                    { "SE401", false, "SF" },
                    { "SE402", false, "SF" },
                    { "SE501", false, "S" },
                    { "SE502", false, "S" },
                    { "SE601", false, "S" },
                    { "SE602", false, "S" },
                    { "SE701", false, "F" },
                    { "SE702", false, "F" },
                    { "SE801", false, "F" },
                    { "SE802", false, "F" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "ClassCode", "CoachNo", "NoOfCompartments", "NoOfSeats", "TrainCode" },
                values: new object[,]
                {
                    { 1, "AC1", 1, 7, 28, "SE101" },
                    { 2, "AC1", 2, 7, 28, "SE101" },
                    { 3, "AC2", 3, 7, 28, "SE101" },
                    { 4, "AC2", 4, 7, 28, "SE101" },
                    { 5, "AC3", 5, 7, 42, "SE101" },
                    { 6, "AC3", 6, 7, 42, "SE101" },
                    { 7, "SL", 7, 0, 32, "SE101" },
                    { 8, "SL", 8, 0, 32, "SE101" },
                    { 9, "GE", 9, 0, 62, "SE101" },
                    { 10, "GE", 10, 0, 62, "SE101" },
                    { 11, "AC1", 1, 7, 28, "SE102" },
                    { 12, "AC1", 2, 7, 28, "SE102" },
                    { 13, "AC2", 3, 7, 28, "SE102" },
                    { 14, "AC2", 4, 7, 28, "SE102" },
                    { 15, "AC3", 5, 7, 42, "SE102" },
                    { 16, "AC3", 6, 7, 42, "SE102" },
                    { 17, "SL", 7, 0, 32, "SE102" },
                    { 18, "SL", 8, 0, 32, "SE102" },
                    { 19, "GE", 9, 0, 62, "SE102" },
                    { 20, "GE", 10, 0, 62, "SE102" },
                    { 21, "AC1", 1, 7, 28, "SE201" },
                    { 22, "AC1", 2, 7, 28, "SE201" },
                    { 23, "AC2", 3, 7, 28, "SE201" },
                    { 24, "AC2", 4, 7, 28, "SE201" },
                    { 25, "AC3", 5, 7, 42, "SE201" },
                    { 26, "AC3", 6, 7, 42, "SE201" },
                    { 27, "SL", 7, 0, 32, "SE201" },
                    { 28, "SL", 8, 0, 32, "SE201" },
                    { 29, "GE", 9, 0, 62, "SE201" },
                    { 30, "GE", 10, 0, 62, "SE201" },
                    { 31, "AC1", 1, 7, 28, "SE202" },
                    { 32, "AC1", 2, 7, 28, "SE202" },
                    { 33, "AC2", 3, 7, 28, "SE202" },
                    { 34, "AC2", 4, 7, 28, "SE202" },
                    { 35, "AC3", 5, 7, 42, "SE202" },
                    { 36, "AC3", 6, 7, 42, "SE202" },
                    { 37, "SL", 7, 0, 32, "SE202" },
                    { 38, "SL", 8, 0, 32, "SE202" },
                    { 39, "GE", 9, 0, 62, "SE202" },
                    { 40, "GE", 10, 0, 62, "SE202" },
                    { 41, "AC1", 1, 7, 28, "SE301" },
                    { 42, "AC1", 2, 7, 28, "SE301" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "ClassCode", "CoachNo", "NoOfCompartments", "NoOfSeats", "TrainCode" },
                values: new object[,]
                {
                    { 43, "AC2", 3, 7, 28, "SE301" },
                    { 44, "AC2", 4, 7, 28, "SE301" },
                    { 45, "AC3", 5, 7, 42, "SE301" },
                    { 46, "AC3", 6, 7, 42, "SE301" },
                    { 47, "SL", 7, 0, 32, "SE301" },
                    { 48, "SL", 8, 0, 32, "SE301" },
                    { 49, "GE", 9, 0, 62, "SE301" },
                    { 50, "GE", 10, 0, 62, "SE301" },
                    { 51, "AC1", 1, 7, 28, "SE302" },
                    { 52, "AC1", 2, 7, 28, "SE302" },
                    { 53, "AC2", 3, 7, 28, "SE302" },
                    { 54, "AC2", 4, 7, 28, "SE302" },
                    { 55, "AC3", 5, 7, 42, "SE302" },
                    { 56, "AC3", 6, 7, 42, "SE302" },
                    { 57, "SL", 7, 0, 32, "SE302" },
                    { 58, "SL", 8, 0, 32, "SE302" },
                    { 59, "GE", 9, 0, 62, "SE302" },
                    { 60, "GE", 10, 0, 62, "SE302" },
                    { 61, "AC1", 1, 7, 28, "SE401" },
                    { 62, "AC1", 2, 7, 28, "SE401" },
                    { 63, "AC2", 3, 7, 28, "SE401" },
                    { 64, "AC2", 4, 7, 28, "SE401" },
                    { 65, "AC3", 5, 7, 42, "SE401" },
                    { 66, "AC3", 6, 7, 42, "SE401" },
                    { 67, "SL", 7, 0, 32, "SE401" },
                    { 68, "SL", 8, 0, 32, "SE401" },
                    { 69, "GE", 9, 0, 62, "SE401" },
                    { 70, "GE", 10, 0, 62, "SE401" },
                    { 71, "AC1", 1, 7, 28, "SE402" },
                    { 72, "AC1", 2, 7, 28, "SE402" },
                    { 73, "AC2", 3, 7, 28, "SE402" },
                    { 74, "AC2", 4, 7, 28, "SE402" },
                    { 75, "AC3", 5, 7, 42, "SE402" },
                    { 76, "AC3", 6, 7, 42, "SE402" },
                    { 77, "SL", 7, 0, 32, "SE402" },
                    { 78, "SL", 8, 0, 32, "SE402" },
                    { 79, "GE", 9, 0, 62, "SE402" },
                    { 80, "GE", 10, 0, 62, "SE402" },
                    { 81, "AC1", 1, 7, 28, "SE501" },
                    { 82, "AC1", 2, 7, 28, "SE501" },
                    { 83, "AC2", 3, 7, 28, "SE501" },
                    { 84, "AC2", 4, 7, 28, "SE501" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "ClassCode", "CoachNo", "NoOfCompartments", "NoOfSeats", "TrainCode" },
                values: new object[,]
                {
                    { 85, "AC3", 5, 7, 42, "SE501" },
                    { 86, "AC3", 6, 7, 42, "SE501" },
                    { 87, "SL", 7, 0, 32, "SE501" },
                    { 88, "SL", 8, 0, 32, "SE501" },
                    { 89, "GE", 9, 0, 62, "SE501" },
                    { 90, "GE", 10, 0, 62, "SE501" },
                    { 91, "AC1", 1, 7, 28, "SE502" },
                    { 92, "AC1", 2, 7, 28, "SE502" },
                    { 93, "AC2", 3, 7, 28, "SE502" },
                    { 94, "AC2", 4, 7, 28, "SE502" },
                    { 95, "AC3", 5, 7, 42, "SE502" },
                    { 96, "AC3", 6, 7, 42, "SE502" },
                    { 97, "SL", 7, 0, 32, "SE502" },
                    { 98, "SL", 8, 0, 32, "SE502" },
                    { 99, "GE", 9, 0, 62, "SE502" },
                    { 100, "GE", 10, 0, 62, "SE502" },
                    { 101, "AC1", 1, 7, 28, "SE601" },
                    { 102, "AC1", 2, 7, 28, "SE601" },
                    { 103, "AC2", 3, 7, 28, "SE601" },
                    { 104, "AC2", 4, 7, 28, "SE601" },
                    { 105, "AC3", 5, 7, 42, "SE601" },
                    { 106, "AC3", 6, 7, 42, "SE601" },
                    { 107, "SL", 7, 0, 32, "SE601" },
                    { 108, "SL", 8, 0, 32, "SE601" },
                    { 109, "GE", 9, 0, 62, "SE601" },
                    { 110, "GE", 10, 0, 62, "SE601" },
                    { 111, "AC1", 1, 7, 28, "SE602" },
                    { 112, "AC1", 2, 7, 28, "SE602" },
                    { 113, "AC2", 3, 7, 28, "SE602" },
                    { 114, "AC2", 4, 7, 28, "SE602" },
                    { 115, "AC3", 5, 7, 42, "SE602" },
                    { 116, "AC3", 6, 7, 42, "SE602" },
                    { 117, "SL", 7, 0, 32, "SE602" },
                    { 118, "SL", 8, 0, 32, "SE602" },
                    { 119, "GE", 9, 0, 62, "SE602" },
                    { 120, "GE", 10, 0, 62, "SE602" },
                    { 121, "AC1", 1, 7, 28, "SE701" },
                    { 122, "AC1", 2, 7, 28, "SE701" },
                    { 123, "AC2", 3, 7, 28, "SE701" },
                    { 124, "AC2", 4, 7, 28, "SE701" },
                    { 125, "AC3", 5, 7, 42, "SE701" },
                    { 126, "AC3", 6, 7, 42, "SE701" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "ClassCode", "CoachNo", "NoOfCompartments", "NoOfSeats", "TrainCode" },
                values: new object[,]
                {
                    { 127, "SL", 7, 0, 32, "SE701" },
                    { 128, "SL", 8, 0, 32, "SE701" },
                    { 129, "GE", 9, 0, 62, "SE701" },
                    { 130, "GE", 10, 0, 62, "SE701" },
                    { 131, "AC1", 1, 7, 28, "SE702" },
                    { 132, "AC1", 2, 7, 28, "SE702" },
                    { 133, "AC2", 3, 7, 28, "SE702" },
                    { 134, "AC2", 4, 7, 28, "SE702" },
                    { 135, "AC3", 5, 7, 42, "SE702" },
                    { 136, "AC3", 6, 7, 42, "SE702" },
                    { 137, "SL", 7, 0, 32, "SE702" },
                    { 138, "SL", 8, 0, 32, "SE702" },
                    { 139, "GE", 9, 0, 62, "SE702" },
                    { 140, "GE", 10, 0, 62, "SE702" },
                    { 141, "AC1", 1, 7, 28, "SE801" },
                    { 142, "AC1", 2, 7, 28, "SE801" },
                    { 143, "AC2", 3, 7, 28, "SE801" },
                    { 144, "AC2", 4, 7, 28, "SE801" },
                    { 145, "AC3", 5, 7, 42, "SE801" },
                    { 146, "AC3", 6, 7, 42, "SE801" },
                    { 147, "SL", 7, 0, 32, "SE801" },
                    { 148, "SL", 8, 0, 32, "SE801" },
                    { 149, "GE", 9, 0, 62, "SE801" },
                    { 150, "GE", 10, 0, 62, "SE801" },
                    { 151, "AC1", 1, 7, 28, "SE802" },
                    { 152, "AC1", 2, 7, 28, "SE802" },
                    { 153, "AC2", 3, 7, 28, "SE802" },
                    { 154, "AC2", 4, 7, 28, "SE802" },
                    { 155, "AC3", 5, 7, 42, "SE802" },
                    { 156, "AC3", 6, 7, 42, "SE802" },
                    { 157, "SL", 7, 0, 32, "SE802" },
                    { 158, "SL", 8, 0, 32, "SE802" },
                    { 159, "GE", 9, 0, 62, "SE802" },
                    { 160, "GE", 10, 0, 62, "SE802" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1, false, 1, 1, 1 },
                    { 2, false, 1, 1, 2 },
                    { 3, false, 1, 1, 3 },
                    { 4, false, 1, 1, 4 },
                    { 5, false, 1, 2, 5 },
                    { 6, false, 1, 2, 6 },
                    { 7, false, 1, 2, 7 },
                    { 8, false, 1, 2, 8 },
                    { 9, false, 1, 3, 9 },
                    { 10, false, 1, 3, 10 },
                    { 11, false, 1, 3, 11 },
                    { 12, false, 1, 3, 12 },
                    { 13, false, 1, 4, 13 },
                    { 14, false, 1, 4, 14 },
                    { 15, false, 1, 4, 15 },
                    { 16, false, 1, 4, 16 },
                    { 17, false, 1, 5, 17 },
                    { 18, false, 1, 5, 18 },
                    { 19, false, 1, 5, 19 },
                    { 20, false, 1, 5, 20 },
                    { 21, false, 1, 6, 21 },
                    { 22, false, 1, 6, 22 },
                    { 23, false, 1, 6, 23 },
                    { 24, false, 1, 6, 24 },
                    { 25, false, 1, 7, 25 },
                    { 26, false, 1, 7, 26 },
                    { 27, false, 1, 7, 27 },
                    { 28, false, 1, 7, 28 },
                    { 29, false, 2, 1, 1 },
                    { 30, false, 2, 1, 2 },
                    { 31, false, 2, 1, 3 },
                    { 32, false, 2, 1, 4 },
                    { 33, false, 2, 2, 5 },
                    { 34, false, 2, 2, 6 },
                    { 35, false, 2, 2, 7 },
                    { 36, false, 2, 2, 8 },
                    { 37, false, 2, 3, 9 },
                    { 38, false, 2, 3, 10 },
                    { 39, false, 2, 3, 11 },
                    { 40, false, 2, 3, 12 },
                    { 41, false, 2, 4, 13 },
                    { 42, false, 2, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 43, false, 2, 4, 15 },
                    { 44, false, 2, 4, 16 },
                    { 45, false, 2, 5, 17 },
                    { 46, false, 2, 5, 18 },
                    { 47, false, 2, 5, 19 },
                    { 48, false, 2, 5, 20 },
                    { 49, false, 2, 6, 21 },
                    { 50, false, 2, 6, 22 },
                    { 51, false, 2, 6, 23 },
                    { 52, false, 2, 6, 24 },
                    { 53, false, 2, 7, 25 },
                    { 54, false, 2, 7, 26 },
                    { 55, false, 2, 7, 27 },
                    { 56, false, 2, 7, 28 },
                    { 57, false, 3, 1, 1 },
                    { 58, false, 3, 1, 2 },
                    { 59, false, 3, 1, 3 },
                    { 60, false, 3, 1, 4 },
                    { 61, false, 3, 2, 5 },
                    { 62, false, 3, 2, 6 },
                    { 63, false, 3, 2, 7 },
                    { 64, false, 3, 2, 8 },
                    { 65, false, 3, 3, 9 },
                    { 66, false, 3, 3, 10 },
                    { 67, false, 3, 3, 11 },
                    { 68, false, 3, 3, 12 },
                    { 69, false, 3, 4, 13 },
                    { 70, false, 3, 4, 14 },
                    { 71, false, 3, 4, 15 },
                    { 72, false, 3, 4, 16 },
                    { 73, false, 3, 5, 17 },
                    { 74, false, 3, 5, 18 },
                    { 75, false, 3, 5, 19 },
                    { 76, false, 3, 5, 20 },
                    { 77, false, 3, 6, 21 },
                    { 78, false, 3, 6, 22 },
                    { 79, false, 3, 6, 23 },
                    { 80, false, 3, 6, 24 },
                    { 81, false, 3, 7, 25 },
                    { 82, false, 3, 7, 26 },
                    { 83, false, 3, 7, 27 },
                    { 84, false, 3, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 85, false, 4, 1, 1 },
                    { 86, false, 4, 1, 2 },
                    { 87, false, 4, 1, 3 },
                    { 88, false, 4, 1, 4 },
                    { 89, false, 4, 2, 5 },
                    { 90, false, 4, 2, 6 },
                    { 91, false, 4, 2, 7 },
                    { 92, false, 4, 2, 8 },
                    { 93, false, 4, 3, 9 },
                    { 94, false, 4, 3, 10 },
                    { 95, false, 4, 3, 11 },
                    { 96, false, 4, 3, 12 },
                    { 97, false, 4, 4, 13 },
                    { 98, false, 4, 4, 14 },
                    { 99, false, 4, 4, 15 },
                    { 100, false, 4, 4, 16 },
                    { 101, false, 4, 5, 17 },
                    { 102, false, 4, 5, 18 },
                    { 103, false, 4, 5, 19 },
                    { 104, false, 4, 5, 20 },
                    { 105, false, 4, 6, 21 },
                    { 106, false, 4, 6, 22 },
                    { 107, false, 4, 6, 23 },
                    { 108, false, 4, 6, 24 },
                    { 109, false, 4, 7, 25 },
                    { 110, false, 4, 7, 26 },
                    { 111, false, 4, 7, 27 },
                    { 112, false, 4, 7, 28 },
                    { 113, false, 5, 1, 1 },
                    { 114, false, 5, 1, 2 },
                    { 115, false, 5, 1, 3 },
                    { 116, false, 5, 1, 4 },
                    { 117, false, 5, 1, 5 },
                    { 118, false, 5, 1, 6 },
                    { 119, false, 5, 2, 7 },
                    { 120, false, 5, 2, 8 },
                    { 121, false, 5, 2, 9 },
                    { 122, false, 5, 2, 10 },
                    { 123, false, 5, 2, 11 },
                    { 124, false, 5, 2, 12 },
                    { 125, false, 5, 3, 13 },
                    { 126, false, 5, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 127, false, 5, 3, 15 },
                    { 128, false, 5, 3, 16 },
                    { 129, false, 5, 3, 17 },
                    { 130, false, 5, 3, 18 },
                    { 131, false, 5, 4, 19 },
                    { 132, false, 5, 4, 20 },
                    { 133, false, 5, 4, 21 },
                    { 134, false, 5, 4, 22 },
                    { 135, false, 5, 4, 23 },
                    { 136, false, 5, 4, 24 },
                    { 137, false, 5, 5, 25 },
                    { 138, false, 5, 5, 26 },
                    { 139, false, 5, 5, 27 },
                    { 140, false, 5, 5, 28 },
                    { 141, false, 5, 5, 29 },
                    { 142, false, 5, 5, 30 },
                    { 143, false, 5, 6, 31 },
                    { 144, false, 5, 6, 32 },
                    { 145, false, 5, 6, 33 },
                    { 146, false, 5, 6, 34 },
                    { 147, false, 5, 6, 35 },
                    { 148, false, 5, 6, 36 },
                    { 149, false, 5, 7, 37 },
                    { 150, false, 5, 7, 38 },
                    { 151, false, 5, 7, 39 },
                    { 152, false, 5, 7, 40 },
                    { 153, false, 5, 7, 41 },
                    { 154, false, 5, 7, 42 },
                    { 155, false, 6, 1, 1 },
                    { 156, false, 6, 1, 2 },
                    { 157, false, 6, 1, 3 },
                    { 158, false, 6, 1, 4 },
                    { 159, false, 6, 1, 5 },
                    { 160, false, 6, 1, 6 },
                    { 161, false, 6, 2, 7 },
                    { 162, false, 6, 2, 8 },
                    { 163, false, 6, 2, 9 },
                    { 164, false, 6, 2, 10 },
                    { 165, false, 6, 2, 11 },
                    { 166, false, 6, 2, 12 },
                    { 167, false, 6, 3, 13 },
                    { 168, false, 6, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 169, false, 6, 3, 15 },
                    { 170, false, 6, 3, 16 },
                    { 171, false, 6, 3, 17 },
                    { 172, false, 6, 3, 18 },
                    { 173, false, 6, 4, 19 },
                    { 174, false, 6, 4, 20 },
                    { 175, false, 6, 4, 21 },
                    { 176, false, 6, 4, 22 },
                    { 177, false, 6, 4, 23 },
                    { 178, false, 6, 4, 24 },
                    { 179, false, 6, 5, 25 },
                    { 180, false, 6, 5, 26 },
                    { 181, false, 6, 5, 27 },
                    { 182, false, 6, 5, 28 },
                    { 183, false, 6, 5, 29 },
                    { 184, false, 6, 5, 30 },
                    { 185, false, 6, 6, 31 },
                    { 186, false, 6, 6, 32 },
                    { 187, false, 6, 6, 33 },
                    { 188, false, 6, 6, 34 },
                    { 189, false, 6, 6, 35 },
                    { 190, false, 6, 6, 36 },
                    { 191, false, 6, 7, 37 },
                    { 192, false, 6, 7, 38 },
                    { 193, false, 6, 7, 39 },
                    { 194, false, 6, 7, 40 },
                    { 195, false, 6, 7, 41 },
                    { 196, false, 6, 7, 42 },
                    { 197, false, 11, 1, 1 },
                    { 198, false, 11, 1, 2 },
                    { 199, false, 11, 1, 3 },
                    { 200, false, 11, 1, 4 },
                    { 201, false, 11, 2, 5 },
                    { 202, false, 11, 2, 6 },
                    { 203, false, 11, 2, 7 },
                    { 204, false, 11, 2, 8 },
                    { 205, false, 11, 3, 9 },
                    { 206, false, 11, 3, 10 },
                    { 207, false, 11, 3, 11 },
                    { 208, false, 11, 3, 12 },
                    { 209, false, 11, 4, 13 },
                    { 210, false, 11, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 211, false, 11, 4, 15 },
                    { 212, false, 11, 4, 16 },
                    { 213, false, 11, 5, 17 },
                    { 214, false, 11, 5, 18 },
                    { 215, false, 11, 5, 19 },
                    { 216, false, 11, 5, 20 },
                    { 217, false, 11, 6, 21 },
                    { 218, false, 11, 6, 22 },
                    { 219, false, 11, 6, 23 },
                    { 220, false, 11, 6, 24 },
                    { 221, false, 11, 7, 25 },
                    { 222, false, 11, 7, 26 },
                    { 223, false, 11, 7, 27 },
                    { 224, false, 11, 7, 28 },
                    { 225, false, 12, 1, 1 },
                    { 226, false, 12, 1, 2 },
                    { 227, false, 12, 1, 3 },
                    { 228, false, 12, 1, 4 },
                    { 229, false, 12, 2, 5 },
                    { 230, false, 12, 2, 6 },
                    { 231, false, 12, 2, 7 },
                    { 232, false, 12, 2, 8 },
                    { 233, false, 12, 3, 9 },
                    { 234, false, 12, 3, 10 },
                    { 235, false, 12, 3, 11 },
                    { 236, false, 12, 3, 12 },
                    { 237, false, 12, 4, 13 },
                    { 238, false, 12, 4, 14 },
                    { 239, false, 12, 4, 15 },
                    { 240, false, 12, 4, 16 },
                    { 241, false, 12, 5, 17 },
                    { 242, false, 12, 5, 18 },
                    { 243, false, 12, 5, 19 },
                    { 244, false, 12, 5, 20 },
                    { 245, false, 12, 6, 21 },
                    { 246, false, 12, 6, 22 },
                    { 247, false, 12, 6, 23 },
                    { 248, false, 12, 6, 24 },
                    { 249, false, 12, 7, 25 },
                    { 250, false, 12, 7, 26 },
                    { 251, false, 12, 7, 27 },
                    { 252, false, 12, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 253, false, 13, 1, 1 },
                    { 254, false, 13, 1, 2 },
                    { 255, false, 13, 1, 3 },
                    { 256, false, 13, 1, 4 },
                    { 257, false, 13, 2, 5 },
                    { 258, false, 13, 2, 6 },
                    { 259, false, 13, 2, 7 },
                    { 260, false, 13, 2, 8 },
                    { 261, false, 13, 3, 9 },
                    { 262, false, 13, 3, 10 },
                    { 263, false, 13, 3, 11 },
                    { 264, false, 13, 3, 12 },
                    { 265, false, 13, 4, 13 },
                    { 266, false, 13, 4, 14 },
                    { 267, false, 13, 4, 15 },
                    { 268, false, 13, 4, 16 },
                    { 269, false, 13, 5, 17 },
                    { 270, false, 13, 5, 18 },
                    { 271, false, 13, 5, 19 },
                    { 272, false, 13, 5, 20 },
                    { 273, false, 13, 6, 21 },
                    { 274, false, 13, 6, 22 },
                    { 275, false, 13, 6, 23 },
                    { 276, false, 13, 6, 24 },
                    { 277, false, 13, 7, 25 },
                    { 278, false, 13, 7, 26 },
                    { 279, false, 13, 7, 27 },
                    { 280, false, 13, 7, 28 },
                    { 281, false, 14, 1, 1 },
                    { 282, false, 14, 1, 2 },
                    { 283, false, 14, 1, 3 },
                    { 284, false, 14, 1, 4 },
                    { 285, false, 14, 2, 5 },
                    { 286, false, 14, 2, 6 },
                    { 287, false, 14, 2, 7 },
                    { 288, false, 14, 2, 8 },
                    { 289, false, 14, 3, 9 },
                    { 290, false, 14, 3, 10 },
                    { 291, false, 14, 3, 11 },
                    { 292, false, 14, 3, 12 },
                    { 293, false, 14, 4, 13 },
                    { 294, false, 14, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 295, false, 14, 4, 15 },
                    { 296, false, 14, 4, 16 },
                    { 297, false, 14, 5, 17 },
                    { 298, false, 14, 5, 18 },
                    { 299, false, 14, 5, 19 },
                    { 300, false, 14, 5, 20 },
                    { 301, false, 14, 6, 21 },
                    { 302, false, 14, 6, 22 },
                    { 303, false, 14, 6, 23 },
                    { 304, false, 14, 6, 24 },
                    { 305, false, 14, 7, 25 },
                    { 306, false, 14, 7, 26 },
                    { 307, false, 14, 7, 27 },
                    { 308, false, 14, 7, 28 },
                    { 309, false, 15, 1, 1 },
                    { 310, false, 15, 1, 2 },
                    { 311, false, 15, 1, 3 },
                    { 312, false, 15, 1, 4 },
                    { 313, false, 15, 1, 5 },
                    { 314, false, 15, 1, 6 },
                    { 315, false, 15, 2, 7 },
                    { 316, false, 15, 2, 8 },
                    { 317, false, 15, 2, 9 },
                    { 318, false, 15, 2, 10 },
                    { 319, false, 15, 2, 11 },
                    { 320, false, 15, 2, 12 },
                    { 321, false, 15, 3, 13 },
                    { 322, false, 15, 3, 14 },
                    { 323, false, 15, 3, 15 },
                    { 324, false, 15, 3, 16 },
                    { 325, false, 15, 3, 17 },
                    { 326, false, 15, 3, 18 },
                    { 327, false, 15, 4, 19 },
                    { 328, false, 15, 4, 20 },
                    { 329, false, 15, 4, 21 },
                    { 330, false, 15, 4, 22 },
                    { 331, false, 15, 4, 23 },
                    { 332, false, 15, 4, 24 },
                    { 333, false, 15, 5, 25 },
                    { 334, false, 15, 5, 26 },
                    { 335, false, 15, 5, 27 },
                    { 336, false, 15, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 337, false, 15, 5, 29 },
                    { 338, false, 15, 5, 30 },
                    { 339, false, 15, 6, 31 },
                    { 340, false, 15, 6, 32 },
                    { 341, false, 15, 6, 33 },
                    { 342, false, 15, 6, 34 },
                    { 343, false, 15, 6, 35 },
                    { 344, false, 15, 6, 36 },
                    { 345, false, 15, 7, 37 },
                    { 346, false, 15, 7, 38 },
                    { 347, false, 15, 7, 39 },
                    { 348, false, 15, 7, 40 },
                    { 349, false, 15, 7, 41 },
                    { 350, false, 15, 7, 42 },
                    { 351, false, 16, 1, 1 },
                    { 352, false, 16, 1, 2 },
                    { 353, false, 16, 1, 3 },
                    { 354, false, 16, 1, 4 },
                    { 355, false, 16, 1, 5 },
                    { 356, false, 16, 1, 6 },
                    { 357, false, 16, 2, 7 },
                    { 358, false, 16, 2, 8 },
                    { 359, false, 16, 2, 9 },
                    { 360, false, 16, 2, 10 },
                    { 361, false, 16, 2, 11 },
                    { 362, false, 16, 2, 12 },
                    { 363, false, 16, 3, 13 },
                    { 364, false, 16, 3, 14 },
                    { 365, false, 16, 3, 15 },
                    { 366, false, 16, 3, 16 },
                    { 367, false, 16, 3, 17 },
                    { 368, false, 16, 3, 18 },
                    { 369, false, 16, 4, 19 },
                    { 370, false, 16, 4, 20 },
                    { 371, false, 16, 4, 21 },
                    { 372, false, 16, 4, 22 },
                    { 373, false, 16, 4, 23 },
                    { 374, false, 16, 4, 24 },
                    { 375, false, 16, 5, 25 },
                    { 376, false, 16, 5, 26 },
                    { 377, false, 16, 5, 27 },
                    { 378, false, 16, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 379, false, 16, 5, 29 },
                    { 380, false, 16, 5, 30 },
                    { 381, false, 16, 6, 31 },
                    { 382, false, 16, 6, 32 },
                    { 383, false, 16, 6, 33 },
                    { 384, false, 16, 6, 34 },
                    { 385, false, 16, 6, 35 },
                    { 386, false, 16, 6, 36 },
                    { 387, false, 16, 7, 37 },
                    { 388, false, 16, 7, 38 },
                    { 389, false, 16, 7, 39 },
                    { 390, false, 16, 7, 40 },
                    { 391, false, 16, 7, 41 },
                    { 392, false, 16, 7, 42 },
                    { 393, false, 21, 1, 1 },
                    { 394, false, 21, 1, 2 },
                    { 395, false, 21, 1, 3 },
                    { 396, false, 21, 1, 4 },
                    { 397, false, 21, 2, 5 },
                    { 398, false, 21, 2, 6 },
                    { 399, false, 21, 2, 7 },
                    { 400, false, 21, 2, 8 },
                    { 401, false, 21, 3, 9 },
                    { 402, false, 21, 3, 10 },
                    { 403, false, 21, 3, 11 },
                    { 404, false, 21, 3, 12 },
                    { 405, false, 21, 4, 13 },
                    { 406, false, 21, 4, 14 },
                    { 407, false, 21, 4, 15 },
                    { 408, false, 21, 4, 16 },
                    { 409, false, 21, 5, 17 },
                    { 410, false, 21, 5, 18 },
                    { 411, false, 21, 5, 19 },
                    { 412, false, 21, 5, 20 },
                    { 413, false, 21, 6, 21 },
                    { 414, false, 21, 6, 22 },
                    { 415, false, 21, 6, 23 },
                    { 416, false, 21, 6, 24 },
                    { 417, false, 21, 7, 25 },
                    { 418, false, 21, 7, 26 },
                    { 419, false, 21, 7, 27 },
                    { 420, false, 21, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 421, false, 22, 1, 1 },
                    { 422, false, 22, 1, 2 },
                    { 423, false, 22, 1, 3 },
                    { 424, false, 22, 1, 4 },
                    { 425, false, 22, 2, 5 },
                    { 426, false, 22, 2, 6 },
                    { 427, false, 22, 2, 7 },
                    { 428, false, 22, 2, 8 },
                    { 429, false, 22, 3, 9 },
                    { 430, false, 22, 3, 10 },
                    { 431, false, 22, 3, 11 },
                    { 432, false, 22, 3, 12 },
                    { 433, false, 22, 4, 13 },
                    { 434, false, 22, 4, 14 },
                    { 435, false, 22, 4, 15 },
                    { 436, false, 22, 4, 16 },
                    { 437, false, 22, 5, 17 },
                    { 438, false, 22, 5, 18 },
                    { 439, false, 22, 5, 19 },
                    { 440, false, 22, 5, 20 },
                    { 441, false, 22, 6, 21 },
                    { 442, false, 22, 6, 22 },
                    { 443, false, 22, 6, 23 },
                    { 444, false, 22, 6, 24 },
                    { 445, false, 22, 7, 25 },
                    { 446, false, 22, 7, 26 },
                    { 447, false, 22, 7, 27 },
                    { 448, false, 22, 7, 28 },
                    { 449, false, 23, 1, 1 },
                    { 450, false, 23, 1, 2 },
                    { 451, false, 23, 1, 3 },
                    { 452, false, 23, 1, 4 },
                    { 453, false, 23, 2, 5 },
                    { 454, false, 23, 2, 6 },
                    { 455, false, 23, 2, 7 },
                    { 456, false, 23, 2, 8 },
                    { 457, false, 23, 3, 9 },
                    { 458, false, 23, 3, 10 },
                    { 459, false, 23, 3, 11 },
                    { 460, false, 23, 3, 12 },
                    { 461, false, 23, 4, 13 },
                    { 462, false, 23, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 463, false, 23, 4, 15 },
                    { 464, false, 23, 4, 16 },
                    { 465, false, 23, 5, 17 },
                    { 466, false, 23, 5, 18 },
                    { 467, false, 23, 5, 19 },
                    { 468, false, 23, 5, 20 },
                    { 469, false, 23, 6, 21 },
                    { 470, false, 23, 6, 22 },
                    { 471, false, 23, 6, 23 },
                    { 472, false, 23, 6, 24 },
                    { 473, false, 23, 7, 25 },
                    { 474, false, 23, 7, 26 },
                    { 475, false, 23, 7, 27 },
                    { 476, false, 23, 7, 28 },
                    { 477, false, 24, 1, 1 },
                    { 478, false, 24, 1, 2 },
                    { 479, false, 24, 1, 3 },
                    { 480, false, 24, 1, 4 },
                    { 481, false, 24, 2, 5 },
                    { 482, false, 24, 2, 6 },
                    { 483, false, 24, 2, 7 },
                    { 484, false, 24, 2, 8 },
                    { 485, false, 24, 3, 9 },
                    { 486, false, 24, 3, 10 },
                    { 487, false, 24, 3, 11 },
                    { 488, false, 24, 3, 12 },
                    { 489, false, 24, 4, 13 },
                    { 490, false, 24, 4, 14 },
                    { 491, false, 24, 4, 15 },
                    { 492, false, 24, 4, 16 },
                    { 493, false, 24, 5, 17 },
                    { 494, false, 24, 5, 18 },
                    { 495, false, 24, 5, 19 },
                    { 496, false, 24, 5, 20 },
                    { 497, false, 24, 6, 21 },
                    { 498, false, 24, 6, 22 },
                    { 499, false, 24, 6, 23 },
                    { 500, false, 24, 6, 24 },
                    { 501, false, 24, 7, 25 },
                    { 502, false, 24, 7, 26 },
                    { 503, false, 24, 7, 27 },
                    { 504, false, 24, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 505, false, 25, 1, 1 },
                    { 506, false, 25, 1, 2 },
                    { 507, false, 25, 1, 3 },
                    { 508, false, 25, 1, 4 },
                    { 509, false, 25, 1, 5 },
                    { 510, false, 25, 1, 6 },
                    { 511, false, 25, 2, 7 },
                    { 512, false, 25, 2, 8 },
                    { 513, false, 25, 2, 9 },
                    { 514, false, 25, 2, 10 },
                    { 515, false, 25, 2, 11 },
                    { 516, false, 25, 2, 12 },
                    { 517, false, 25, 3, 13 },
                    { 518, false, 25, 3, 14 },
                    { 519, false, 25, 3, 15 },
                    { 520, false, 25, 3, 16 },
                    { 521, false, 25, 3, 17 },
                    { 522, false, 25, 3, 18 },
                    { 523, false, 25, 4, 19 },
                    { 524, false, 25, 4, 20 },
                    { 525, false, 25, 4, 21 },
                    { 526, false, 25, 4, 22 },
                    { 527, false, 25, 4, 23 },
                    { 528, false, 25, 4, 24 },
                    { 529, false, 25, 5, 25 },
                    { 530, false, 25, 5, 26 },
                    { 531, false, 25, 5, 27 },
                    { 532, false, 25, 5, 28 },
                    { 533, false, 25, 5, 29 },
                    { 534, false, 25, 5, 30 },
                    { 535, false, 25, 6, 31 },
                    { 536, false, 25, 6, 32 },
                    { 537, false, 25, 6, 33 },
                    { 538, false, 25, 6, 34 },
                    { 539, false, 25, 6, 35 },
                    { 540, false, 25, 6, 36 },
                    { 541, false, 25, 7, 37 },
                    { 542, false, 25, 7, 38 },
                    { 543, false, 25, 7, 39 },
                    { 544, false, 25, 7, 40 },
                    { 545, false, 25, 7, 41 },
                    { 546, false, 25, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 547, false, 26, 1, 1 },
                    { 548, false, 26, 1, 2 },
                    { 549, false, 26, 1, 3 },
                    { 550, false, 26, 1, 4 },
                    { 551, false, 26, 1, 5 },
                    { 552, false, 26, 1, 6 },
                    { 553, false, 26, 2, 7 },
                    { 554, false, 26, 2, 8 },
                    { 555, false, 26, 2, 9 },
                    { 556, false, 26, 2, 10 },
                    { 557, false, 26, 2, 11 },
                    { 558, false, 26, 2, 12 },
                    { 559, false, 26, 3, 13 },
                    { 560, false, 26, 3, 14 },
                    { 561, false, 26, 3, 15 },
                    { 562, false, 26, 3, 16 },
                    { 563, false, 26, 3, 17 },
                    { 564, false, 26, 3, 18 },
                    { 565, false, 26, 4, 19 },
                    { 566, false, 26, 4, 20 },
                    { 567, false, 26, 4, 21 },
                    { 568, false, 26, 4, 22 },
                    { 569, false, 26, 4, 23 },
                    { 570, false, 26, 4, 24 },
                    { 571, false, 26, 5, 25 },
                    { 572, false, 26, 5, 26 },
                    { 573, false, 26, 5, 27 },
                    { 574, false, 26, 5, 28 },
                    { 575, false, 26, 5, 29 },
                    { 576, false, 26, 5, 30 },
                    { 577, false, 26, 6, 31 },
                    { 578, false, 26, 6, 32 },
                    { 579, false, 26, 6, 33 },
                    { 580, false, 26, 6, 34 },
                    { 581, false, 26, 6, 35 },
                    { 582, false, 26, 6, 36 },
                    { 583, false, 26, 7, 37 },
                    { 584, false, 26, 7, 38 },
                    { 585, false, 26, 7, 39 },
                    { 586, false, 26, 7, 40 },
                    { 587, false, 26, 7, 41 },
                    { 588, false, 26, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 589, false, 31, 1, 1 },
                    { 590, false, 31, 1, 2 },
                    { 591, false, 31, 1, 3 },
                    { 592, false, 31, 1, 4 },
                    { 593, false, 31, 2, 5 },
                    { 594, false, 31, 2, 6 },
                    { 595, false, 31, 2, 7 },
                    { 596, false, 31, 2, 8 },
                    { 597, false, 31, 3, 9 },
                    { 598, false, 31, 3, 10 },
                    { 599, false, 31, 3, 11 },
                    { 600, false, 31, 3, 12 },
                    { 601, false, 31, 4, 13 },
                    { 602, false, 31, 4, 14 },
                    { 603, false, 31, 4, 15 },
                    { 604, false, 31, 4, 16 },
                    { 605, false, 31, 5, 17 },
                    { 606, false, 31, 5, 18 },
                    { 607, false, 31, 5, 19 },
                    { 608, false, 31, 5, 20 },
                    { 609, false, 31, 6, 21 },
                    { 610, false, 31, 6, 22 },
                    { 611, false, 31, 6, 23 },
                    { 612, false, 31, 6, 24 },
                    { 613, false, 31, 7, 25 },
                    { 614, false, 31, 7, 26 },
                    { 615, false, 31, 7, 27 },
                    { 616, false, 31, 7, 28 },
                    { 617, false, 32, 1, 1 },
                    { 618, false, 32, 1, 2 },
                    { 619, false, 32, 1, 3 },
                    { 620, false, 32, 1, 4 },
                    { 621, false, 32, 2, 5 },
                    { 622, false, 32, 2, 6 },
                    { 623, false, 32, 2, 7 },
                    { 624, false, 32, 2, 8 },
                    { 625, false, 32, 3, 9 },
                    { 626, false, 32, 3, 10 },
                    { 627, false, 32, 3, 11 },
                    { 628, false, 32, 3, 12 },
                    { 629, false, 32, 4, 13 },
                    { 630, false, 32, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 631, false, 32, 4, 15 },
                    { 632, false, 32, 4, 16 },
                    { 633, false, 32, 5, 17 },
                    { 634, false, 32, 5, 18 },
                    { 635, false, 32, 5, 19 },
                    { 636, false, 32, 5, 20 },
                    { 637, false, 32, 6, 21 },
                    { 638, false, 32, 6, 22 },
                    { 639, false, 32, 6, 23 },
                    { 640, false, 32, 6, 24 },
                    { 641, false, 32, 7, 25 },
                    { 642, false, 32, 7, 26 },
                    { 643, false, 32, 7, 27 },
                    { 644, false, 32, 7, 28 },
                    { 645, false, 33, 1, 1 },
                    { 646, false, 33, 1, 2 },
                    { 647, false, 33, 1, 3 },
                    { 648, false, 33, 1, 4 },
                    { 649, false, 33, 2, 5 },
                    { 650, false, 33, 2, 6 },
                    { 651, false, 33, 2, 7 },
                    { 652, false, 33, 2, 8 },
                    { 653, false, 33, 3, 9 },
                    { 654, false, 33, 3, 10 },
                    { 655, false, 33, 3, 11 },
                    { 656, false, 33, 3, 12 },
                    { 657, false, 33, 4, 13 },
                    { 658, false, 33, 4, 14 },
                    { 659, false, 33, 4, 15 },
                    { 660, false, 33, 4, 16 },
                    { 661, false, 33, 5, 17 },
                    { 662, false, 33, 5, 18 },
                    { 663, false, 33, 5, 19 },
                    { 664, false, 33, 5, 20 },
                    { 665, false, 33, 6, 21 },
                    { 666, false, 33, 6, 22 },
                    { 667, false, 33, 6, 23 },
                    { 668, false, 33, 6, 24 },
                    { 669, false, 33, 7, 25 },
                    { 670, false, 33, 7, 26 },
                    { 671, false, 33, 7, 27 },
                    { 672, false, 33, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 673, false, 34, 1, 1 },
                    { 674, false, 34, 1, 2 },
                    { 675, false, 34, 1, 3 },
                    { 676, false, 34, 1, 4 },
                    { 677, false, 34, 2, 5 },
                    { 678, false, 34, 2, 6 },
                    { 679, false, 34, 2, 7 },
                    { 680, false, 34, 2, 8 },
                    { 681, false, 34, 3, 9 },
                    { 682, false, 34, 3, 10 },
                    { 683, false, 34, 3, 11 },
                    { 684, false, 34, 3, 12 },
                    { 685, false, 34, 4, 13 },
                    { 686, false, 34, 4, 14 },
                    { 687, false, 34, 4, 15 },
                    { 688, false, 34, 4, 16 },
                    { 689, false, 34, 5, 17 },
                    { 690, false, 34, 5, 18 },
                    { 691, false, 34, 5, 19 },
                    { 692, false, 34, 5, 20 },
                    { 693, false, 34, 6, 21 },
                    { 694, false, 34, 6, 22 },
                    { 695, false, 34, 6, 23 },
                    { 696, false, 34, 6, 24 },
                    { 697, false, 34, 7, 25 },
                    { 698, false, 34, 7, 26 },
                    { 699, false, 34, 7, 27 },
                    { 700, false, 34, 7, 28 },
                    { 701, false, 35, 1, 1 },
                    { 702, false, 35, 1, 2 },
                    { 703, false, 35, 1, 3 },
                    { 704, false, 35, 1, 4 },
                    { 705, false, 35, 1, 5 },
                    { 706, false, 35, 1, 6 },
                    { 707, false, 35, 2, 7 },
                    { 708, false, 35, 2, 8 },
                    { 709, false, 35, 2, 9 },
                    { 710, false, 35, 2, 10 },
                    { 711, false, 35, 2, 11 },
                    { 712, false, 35, 2, 12 },
                    { 713, false, 35, 3, 13 },
                    { 714, false, 35, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 715, false, 35, 3, 15 },
                    { 716, false, 35, 3, 16 },
                    { 717, false, 35, 3, 17 },
                    { 718, false, 35, 3, 18 },
                    { 719, false, 35, 4, 19 },
                    { 720, false, 35, 4, 20 },
                    { 721, false, 35, 4, 21 },
                    { 722, false, 35, 4, 22 },
                    { 723, false, 35, 4, 23 },
                    { 724, false, 35, 4, 24 },
                    { 725, false, 35, 5, 25 },
                    { 726, false, 35, 5, 26 },
                    { 727, false, 35, 5, 27 },
                    { 728, false, 35, 5, 28 },
                    { 729, false, 35, 5, 29 },
                    { 730, false, 35, 5, 30 },
                    { 731, false, 35, 6, 31 },
                    { 732, false, 35, 6, 32 },
                    { 733, false, 35, 6, 33 },
                    { 734, false, 35, 6, 34 },
                    { 735, false, 35, 6, 35 },
                    { 736, false, 35, 6, 36 },
                    { 737, false, 35, 7, 37 },
                    { 738, false, 35, 7, 38 },
                    { 739, false, 35, 7, 39 },
                    { 740, false, 35, 7, 40 },
                    { 741, false, 35, 7, 41 },
                    { 742, false, 35, 7, 42 },
                    { 743, false, 36, 1, 1 },
                    { 744, false, 36, 1, 2 },
                    { 745, false, 36, 1, 3 },
                    { 746, false, 36, 1, 4 },
                    { 747, false, 36, 1, 5 },
                    { 748, false, 36, 1, 6 },
                    { 749, false, 36, 2, 7 },
                    { 750, false, 36, 2, 8 },
                    { 751, false, 36, 2, 9 },
                    { 752, false, 36, 2, 10 },
                    { 753, false, 36, 2, 11 },
                    { 754, false, 36, 2, 12 },
                    { 755, false, 36, 3, 13 },
                    { 756, false, 36, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 757, false, 36, 3, 15 },
                    { 758, false, 36, 3, 16 },
                    { 759, false, 36, 3, 17 },
                    { 760, false, 36, 3, 18 },
                    { 761, false, 36, 4, 19 },
                    { 762, false, 36, 4, 20 },
                    { 763, false, 36, 4, 21 },
                    { 764, false, 36, 4, 22 },
                    { 765, false, 36, 4, 23 },
                    { 766, false, 36, 4, 24 },
                    { 767, false, 36, 5, 25 },
                    { 768, false, 36, 5, 26 },
                    { 769, false, 36, 5, 27 },
                    { 770, false, 36, 5, 28 },
                    { 771, false, 36, 5, 29 },
                    { 772, false, 36, 5, 30 },
                    { 773, false, 36, 6, 31 },
                    { 774, false, 36, 6, 32 },
                    { 775, false, 36, 6, 33 },
                    { 776, false, 36, 6, 34 },
                    { 777, false, 36, 6, 35 },
                    { 778, false, 36, 6, 36 },
                    { 779, false, 36, 7, 37 },
                    { 780, false, 36, 7, 38 },
                    { 781, false, 36, 7, 39 },
                    { 782, false, 36, 7, 40 },
                    { 783, false, 36, 7, 41 },
                    { 784, false, 36, 7, 42 },
                    { 785, false, 41, 1, 1 },
                    { 786, false, 41, 1, 2 },
                    { 787, false, 41, 1, 3 },
                    { 788, false, 41, 1, 4 },
                    { 789, false, 41, 2, 5 },
                    { 790, false, 41, 2, 6 },
                    { 791, false, 41, 2, 7 },
                    { 792, false, 41, 2, 8 },
                    { 793, false, 41, 3, 9 },
                    { 794, false, 41, 3, 10 },
                    { 795, false, 41, 3, 11 },
                    { 796, false, 41, 3, 12 },
                    { 797, false, 41, 4, 13 },
                    { 798, false, 41, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 799, false, 41, 4, 15 },
                    { 800, false, 41, 4, 16 },
                    { 801, false, 41, 5, 17 },
                    { 802, false, 41, 5, 18 },
                    { 803, false, 41, 5, 19 },
                    { 804, false, 41, 5, 20 },
                    { 805, false, 41, 6, 21 },
                    { 806, false, 41, 6, 22 },
                    { 807, false, 41, 6, 23 },
                    { 808, false, 41, 6, 24 },
                    { 809, false, 41, 7, 25 },
                    { 810, false, 41, 7, 26 },
                    { 811, false, 41, 7, 27 },
                    { 812, false, 41, 7, 28 },
                    { 813, false, 42, 1, 1 },
                    { 814, false, 42, 1, 2 },
                    { 815, false, 42, 1, 3 },
                    { 816, false, 42, 1, 4 },
                    { 817, false, 42, 2, 5 },
                    { 818, false, 42, 2, 6 },
                    { 819, false, 42, 2, 7 },
                    { 820, false, 42, 2, 8 },
                    { 821, false, 42, 3, 9 },
                    { 822, false, 42, 3, 10 },
                    { 823, false, 42, 3, 11 },
                    { 824, false, 42, 3, 12 },
                    { 825, false, 42, 4, 13 },
                    { 826, false, 42, 4, 14 },
                    { 827, false, 42, 4, 15 },
                    { 828, false, 42, 4, 16 },
                    { 829, false, 42, 5, 17 },
                    { 830, false, 42, 5, 18 },
                    { 831, false, 42, 5, 19 },
                    { 832, false, 42, 5, 20 },
                    { 833, false, 42, 6, 21 },
                    { 834, false, 42, 6, 22 },
                    { 835, false, 42, 6, 23 },
                    { 836, false, 42, 6, 24 },
                    { 837, false, 42, 7, 25 },
                    { 838, false, 42, 7, 26 },
                    { 839, false, 42, 7, 27 },
                    { 840, false, 42, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 841, false, 43, 1, 1 },
                    { 842, false, 43, 1, 2 },
                    { 843, false, 43, 1, 3 },
                    { 844, false, 43, 1, 4 },
                    { 845, false, 43, 2, 5 },
                    { 846, false, 43, 2, 6 },
                    { 847, false, 43, 2, 7 },
                    { 848, false, 43, 2, 8 },
                    { 849, false, 43, 3, 9 },
                    { 850, false, 43, 3, 10 },
                    { 851, false, 43, 3, 11 },
                    { 852, false, 43, 3, 12 },
                    { 853, false, 43, 4, 13 },
                    { 854, false, 43, 4, 14 },
                    { 855, false, 43, 4, 15 },
                    { 856, false, 43, 4, 16 },
                    { 857, false, 43, 5, 17 },
                    { 858, false, 43, 5, 18 },
                    { 859, false, 43, 5, 19 },
                    { 860, false, 43, 5, 20 },
                    { 861, false, 43, 6, 21 },
                    { 862, false, 43, 6, 22 },
                    { 863, false, 43, 6, 23 },
                    { 864, false, 43, 6, 24 },
                    { 865, false, 43, 7, 25 },
                    { 866, false, 43, 7, 26 },
                    { 867, false, 43, 7, 27 },
                    { 868, false, 43, 7, 28 },
                    { 869, false, 44, 1, 1 },
                    { 870, false, 44, 1, 2 },
                    { 871, false, 44, 1, 3 },
                    { 872, false, 44, 1, 4 },
                    { 873, false, 44, 2, 5 },
                    { 874, false, 44, 2, 6 },
                    { 875, false, 44, 2, 7 },
                    { 876, false, 44, 2, 8 },
                    { 877, false, 44, 3, 9 },
                    { 878, false, 44, 3, 10 },
                    { 879, false, 44, 3, 11 },
                    { 880, false, 44, 3, 12 },
                    { 881, false, 44, 4, 13 },
                    { 882, false, 44, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 883, false, 44, 4, 15 },
                    { 884, false, 44, 4, 16 },
                    { 885, false, 44, 5, 17 },
                    { 886, false, 44, 5, 18 },
                    { 887, false, 44, 5, 19 },
                    { 888, false, 44, 5, 20 },
                    { 889, false, 44, 6, 21 },
                    { 890, false, 44, 6, 22 },
                    { 891, false, 44, 6, 23 },
                    { 892, false, 44, 6, 24 },
                    { 893, false, 44, 7, 25 },
                    { 894, false, 44, 7, 26 },
                    { 895, false, 44, 7, 27 },
                    { 896, false, 44, 7, 28 },
                    { 897, false, 45, 1, 1 },
                    { 898, false, 45, 1, 2 },
                    { 899, false, 45, 1, 3 },
                    { 900, false, 45, 1, 4 },
                    { 901, false, 45, 1, 5 },
                    { 902, false, 45, 1, 6 },
                    { 903, false, 45, 2, 7 },
                    { 904, false, 45, 2, 8 },
                    { 905, false, 45, 2, 9 },
                    { 906, false, 45, 2, 10 },
                    { 907, false, 45, 2, 11 },
                    { 908, false, 45, 2, 12 },
                    { 909, false, 45, 3, 13 },
                    { 910, false, 45, 3, 14 },
                    { 911, false, 45, 3, 15 },
                    { 912, false, 45, 3, 16 },
                    { 913, false, 45, 3, 17 },
                    { 914, false, 45, 3, 18 },
                    { 915, false, 45, 4, 19 },
                    { 916, false, 45, 4, 20 },
                    { 917, false, 45, 4, 21 },
                    { 918, false, 45, 4, 22 },
                    { 919, false, 45, 4, 23 },
                    { 920, false, 45, 4, 24 },
                    { 921, false, 45, 5, 25 },
                    { 922, false, 45, 5, 26 },
                    { 923, false, 45, 5, 27 },
                    { 924, false, 45, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 925, false, 45, 5, 29 },
                    { 926, false, 45, 5, 30 },
                    { 927, false, 45, 6, 31 },
                    { 928, false, 45, 6, 32 },
                    { 929, false, 45, 6, 33 },
                    { 930, false, 45, 6, 34 },
                    { 931, false, 45, 6, 35 },
                    { 932, false, 45, 6, 36 },
                    { 933, false, 45, 7, 37 },
                    { 934, false, 45, 7, 38 },
                    { 935, false, 45, 7, 39 },
                    { 936, false, 45, 7, 40 },
                    { 937, false, 45, 7, 41 },
                    { 938, false, 45, 7, 42 },
                    { 939, false, 46, 1, 1 },
                    { 940, false, 46, 1, 2 },
                    { 941, false, 46, 1, 3 },
                    { 942, false, 46, 1, 4 },
                    { 943, false, 46, 1, 5 },
                    { 944, false, 46, 1, 6 },
                    { 945, false, 46, 2, 7 },
                    { 946, false, 46, 2, 8 },
                    { 947, false, 46, 2, 9 },
                    { 948, false, 46, 2, 10 },
                    { 949, false, 46, 2, 11 },
                    { 950, false, 46, 2, 12 },
                    { 951, false, 46, 3, 13 },
                    { 952, false, 46, 3, 14 },
                    { 953, false, 46, 3, 15 },
                    { 954, false, 46, 3, 16 },
                    { 955, false, 46, 3, 17 },
                    { 956, false, 46, 3, 18 },
                    { 957, false, 46, 4, 19 },
                    { 958, false, 46, 4, 20 },
                    { 959, false, 46, 4, 21 },
                    { 960, false, 46, 4, 22 },
                    { 961, false, 46, 4, 23 },
                    { 962, false, 46, 4, 24 },
                    { 963, false, 46, 5, 25 },
                    { 964, false, 46, 5, 26 },
                    { 965, false, 46, 5, 27 },
                    { 966, false, 46, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 967, false, 46, 5, 29 },
                    { 968, false, 46, 5, 30 },
                    { 969, false, 46, 6, 31 },
                    { 970, false, 46, 6, 32 },
                    { 971, false, 46, 6, 33 },
                    { 972, false, 46, 6, 34 },
                    { 973, false, 46, 6, 35 },
                    { 974, false, 46, 6, 36 },
                    { 975, false, 46, 7, 37 },
                    { 976, false, 46, 7, 38 },
                    { 977, false, 46, 7, 39 },
                    { 978, false, 46, 7, 40 },
                    { 979, false, 46, 7, 41 },
                    { 980, false, 46, 7, 42 },
                    { 981, false, 51, 1, 1 },
                    { 982, false, 51, 1, 2 },
                    { 983, false, 51, 1, 3 },
                    { 984, false, 51, 1, 4 },
                    { 985, false, 51, 2, 5 },
                    { 986, false, 51, 2, 6 },
                    { 987, false, 51, 2, 7 },
                    { 988, false, 51, 2, 8 },
                    { 989, false, 51, 3, 9 },
                    { 990, false, 51, 3, 10 },
                    { 991, false, 51, 3, 11 },
                    { 992, false, 51, 3, 12 },
                    { 993, false, 51, 4, 13 },
                    { 994, false, 51, 4, 14 },
                    { 995, false, 51, 4, 15 },
                    { 996, false, 51, 4, 16 },
                    { 997, false, 51, 5, 17 },
                    { 998, false, 51, 5, 18 },
                    { 999, false, 51, 5, 19 },
                    { 1000, false, 51, 5, 20 },
                    { 1001, false, 51, 6, 21 },
                    { 1002, false, 51, 6, 22 },
                    { 1003, false, 51, 6, 23 },
                    { 1004, false, 51, 6, 24 },
                    { 1005, false, 51, 7, 25 },
                    { 1006, false, 51, 7, 26 },
                    { 1007, false, 51, 7, 27 },
                    { 1008, false, 51, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1009, false, 52, 1, 1 },
                    { 1010, false, 52, 1, 2 },
                    { 1011, false, 52, 1, 3 },
                    { 1012, false, 52, 1, 4 },
                    { 1013, false, 52, 2, 5 },
                    { 1014, false, 52, 2, 6 },
                    { 1015, false, 52, 2, 7 },
                    { 1016, false, 52, 2, 8 },
                    { 1017, false, 52, 3, 9 },
                    { 1018, false, 52, 3, 10 },
                    { 1019, false, 52, 3, 11 },
                    { 1020, false, 52, 3, 12 },
                    { 1021, false, 52, 4, 13 },
                    { 1022, false, 52, 4, 14 },
                    { 1023, false, 52, 4, 15 },
                    { 1024, false, 52, 4, 16 },
                    { 1025, false, 52, 5, 17 },
                    { 1026, false, 52, 5, 18 },
                    { 1027, false, 52, 5, 19 },
                    { 1028, false, 52, 5, 20 },
                    { 1029, false, 52, 6, 21 },
                    { 1030, false, 52, 6, 22 },
                    { 1031, false, 52, 6, 23 },
                    { 1032, false, 52, 6, 24 },
                    { 1033, false, 52, 7, 25 },
                    { 1034, false, 52, 7, 26 },
                    { 1035, false, 52, 7, 27 },
                    { 1036, false, 52, 7, 28 },
                    { 1037, false, 53, 1, 1 },
                    { 1038, false, 53, 1, 2 },
                    { 1039, false, 53, 1, 3 },
                    { 1040, false, 53, 1, 4 },
                    { 1041, false, 53, 2, 5 },
                    { 1042, false, 53, 2, 6 },
                    { 1043, false, 53, 2, 7 },
                    { 1044, false, 53, 2, 8 },
                    { 1045, false, 53, 3, 9 },
                    { 1046, false, 53, 3, 10 },
                    { 1047, false, 53, 3, 11 },
                    { 1048, false, 53, 3, 12 },
                    { 1049, false, 53, 4, 13 },
                    { 1050, false, 53, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1051, false, 53, 4, 15 },
                    { 1052, false, 53, 4, 16 },
                    { 1053, false, 53, 5, 17 },
                    { 1054, false, 53, 5, 18 },
                    { 1055, false, 53, 5, 19 },
                    { 1056, false, 53, 5, 20 },
                    { 1057, false, 53, 6, 21 },
                    { 1058, false, 53, 6, 22 },
                    { 1059, false, 53, 6, 23 },
                    { 1060, false, 53, 6, 24 },
                    { 1061, false, 53, 7, 25 },
                    { 1062, false, 53, 7, 26 },
                    { 1063, false, 53, 7, 27 },
                    { 1064, false, 53, 7, 28 },
                    { 1065, false, 54, 1, 1 },
                    { 1066, false, 54, 1, 2 },
                    { 1067, false, 54, 1, 3 },
                    { 1068, false, 54, 1, 4 },
                    { 1069, false, 54, 2, 5 },
                    { 1070, false, 54, 2, 6 },
                    { 1071, false, 54, 2, 7 },
                    { 1072, false, 54, 2, 8 },
                    { 1073, false, 54, 3, 9 },
                    { 1074, false, 54, 3, 10 },
                    { 1075, false, 54, 3, 11 },
                    { 1076, false, 54, 3, 12 },
                    { 1077, false, 54, 4, 13 },
                    { 1078, false, 54, 4, 14 },
                    { 1079, false, 54, 4, 15 },
                    { 1080, false, 54, 4, 16 },
                    { 1081, false, 54, 5, 17 },
                    { 1082, false, 54, 5, 18 },
                    { 1083, false, 54, 5, 19 },
                    { 1084, false, 54, 5, 20 },
                    { 1085, false, 54, 6, 21 },
                    { 1086, false, 54, 6, 22 },
                    { 1087, false, 54, 6, 23 },
                    { 1088, false, 54, 6, 24 },
                    { 1089, false, 54, 7, 25 },
                    { 1090, false, 54, 7, 26 },
                    { 1091, false, 54, 7, 27 },
                    { 1092, false, 54, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1093, false, 55, 1, 1 },
                    { 1094, false, 55, 1, 2 },
                    { 1095, false, 55, 1, 3 },
                    { 1096, false, 55, 1, 4 },
                    { 1097, false, 55, 1, 5 },
                    { 1098, false, 55, 1, 6 },
                    { 1099, false, 55, 2, 7 },
                    { 1100, false, 55, 2, 8 },
                    { 1101, false, 55, 2, 9 },
                    { 1102, false, 55, 2, 10 },
                    { 1103, false, 55, 2, 11 },
                    { 1104, false, 55, 2, 12 },
                    { 1105, false, 55, 3, 13 },
                    { 1106, false, 55, 3, 14 },
                    { 1107, false, 55, 3, 15 },
                    { 1108, false, 55, 3, 16 },
                    { 1109, false, 55, 3, 17 },
                    { 1110, false, 55, 3, 18 },
                    { 1111, false, 55, 4, 19 },
                    { 1112, false, 55, 4, 20 },
                    { 1113, false, 55, 4, 21 },
                    { 1114, false, 55, 4, 22 },
                    { 1115, false, 55, 4, 23 },
                    { 1116, false, 55, 4, 24 },
                    { 1117, false, 55, 5, 25 },
                    { 1118, false, 55, 5, 26 },
                    { 1119, false, 55, 5, 27 },
                    { 1120, false, 55, 5, 28 },
                    { 1121, false, 55, 5, 29 },
                    { 1122, false, 55, 5, 30 },
                    { 1123, false, 55, 6, 31 },
                    { 1124, false, 55, 6, 32 },
                    { 1125, false, 55, 6, 33 },
                    { 1126, false, 55, 6, 34 },
                    { 1127, false, 55, 6, 35 },
                    { 1128, false, 55, 6, 36 },
                    { 1129, false, 55, 7, 37 },
                    { 1130, false, 55, 7, 38 },
                    { 1131, false, 55, 7, 39 },
                    { 1132, false, 55, 7, 40 },
                    { 1133, false, 55, 7, 41 },
                    { 1134, false, 55, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1135, false, 56, 1, 1 },
                    { 1136, false, 56, 1, 2 },
                    { 1137, false, 56, 1, 3 },
                    { 1138, false, 56, 1, 4 },
                    { 1139, false, 56, 1, 5 },
                    { 1140, false, 56, 1, 6 },
                    { 1141, false, 56, 2, 7 },
                    { 1142, false, 56, 2, 8 },
                    { 1143, false, 56, 2, 9 },
                    { 1144, false, 56, 2, 10 },
                    { 1145, false, 56, 2, 11 },
                    { 1146, false, 56, 2, 12 },
                    { 1147, false, 56, 3, 13 },
                    { 1148, false, 56, 3, 14 },
                    { 1149, false, 56, 3, 15 },
                    { 1150, false, 56, 3, 16 },
                    { 1151, false, 56, 3, 17 },
                    { 1152, false, 56, 3, 18 },
                    { 1153, false, 56, 4, 19 },
                    { 1154, false, 56, 4, 20 },
                    { 1155, false, 56, 4, 21 },
                    { 1156, false, 56, 4, 22 },
                    { 1157, false, 56, 4, 23 },
                    { 1158, false, 56, 4, 24 },
                    { 1159, false, 56, 5, 25 },
                    { 1160, false, 56, 5, 26 },
                    { 1161, false, 56, 5, 27 },
                    { 1162, false, 56, 5, 28 },
                    { 1163, false, 56, 5, 29 },
                    { 1164, false, 56, 5, 30 },
                    { 1165, false, 56, 6, 31 },
                    { 1166, false, 56, 6, 32 },
                    { 1167, false, 56, 6, 33 },
                    { 1168, false, 56, 6, 34 },
                    { 1169, false, 56, 6, 35 },
                    { 1170, false, 56, 6, 36 },
                    { 1171, false, 56, 7, 37 },
                    { 1172, false, 56, 7, 38 },
                    { 1173, false, 56, 7, 39 },
                    { 1174, false, 56, 7, 40 },
                    { 1175, false, 56, 7, 41 },
                    { 1176, false, 56, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1177, false, 61, 1, 1 },
                    { 1178, false, 61, 1, 2 },
                    { 1179, false, 61, 1, 3 },
                    { 1180, false, 61, 1, 4 },
                    { 1181, false, 61, 2, 5 },
                    { 1182, false, 61, 2, 6 },
                    { 1183, false, 61, 2, 7 },
                    { 1184, false, 61, 2, 8 },
                    { 1185, false, 61, 3, 9 },
                    { 1186, false, 61, 3, 10 },
                    { 1187, false, 61, 3, 11 },
                    { 1188, false, 61, 3, 12 },
                    { 1189, false, 61, 4, 13 },
                    { 1190, false, 61, 4, 14 },
                    { 1191, false, 61, 4, 15 },
                    { 1192, false, 61, 4, 16 },
                    { 1193, false, 61, 5, 17 },
                    { 1194, false, 61, 5, 18 },
                    { 1195, false, 61, 5, 19 },
                    { 1196, false, 61, 5, 20 },
                    { 1197, false, 61, 6, 21 },
                    { 1198, false, 61, 6, 22 },
                    { 1199, false, 61, 6, 23 },
                    { 1200, false, 61, 6, 24 },
                    { 1201, false, 61, 7, 25 },
                    { 1202, false, 61, 7, 26 },
                    { 1203, false, 61, 7, 27 },
                    { 1204, false, 61, 7, 28 },
                    { 1205, false, 62, 1, 1 },
                    { 1206, false, 62, 1, 2 },
                    { 1207, false, 62, 1, 3 },
                    { 1208, false, 62, 1, 4 },
                    { 1209, false, 62, 2, 5 },
                    { 1210, false, 62, 2, 6 },
                    { 1211, false, 62, 2, 7 },
                    { 1212, false, 62, 2, 8 },
                    { 1213, false, 62, 3, 9 },
                    { 1214, false, 62, 3, 10 },
                    { 1215, false, 62, 3, 11 },
                    { 1216, false, 62, 3, 12 },
                    { 1217, false, 62, 4, 13 },
                    { 1218, false, 62, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1219, false, 62, 4, 15 },
                    { 1220, false, 62, 4, 16 },
                    { 1221, false, 62, 5, 17 },
                    { 1222, false, 62, 5, 18 },
                    { 1223, false, 62, 5, 19 },
                    { 1224, false, 62, 5, 20 },
                    { 1225, false, 62, 6, 21 },
                    { 1226, false, 62, 6, 22 },
                    { 1227, false, 62, 6, 23 },
                    { 1228, false, 62, 6, 24 },
                    { 1229, false, 62, 7, 25 },
                    { 1230, false, 62, 7, 26 },
                    { 1231, false, 62, 7, 27 },
                    { 1232, false, 62, 7, 28 },
                    { 1233, false, 63, 1, 1 },
                    { 1234, false, 63, 1, 2 },
                    { 1235, false, 63, 1, 3 },
                    { 1236, false, 63, 1, 4 },
                    { 1237, false, 63, 2, 5 },
                    { 1238, false, 63, 2, 6 },
                    { 1239, false, 63, 2, 7 },
                    { 1240, false, 63, 2, 8 },
                    { 1241, false, 63, 3, 9 },
                    { 1242, false, 63, 3, 10 },
                    { 1243, false, 63, 3, 11 },
                    { 1244, false, 63, 3, 12 },
                    { 1245, false, 63, 4, 13 },
                    { 1246, false, 63, 4, 14 },
                    { 1247, false, 63, 4, 15 },
                    { 1248, false, 63, 4, 16 },
                    { 1249, false, 63, 5, 17 },
                    { 1250, false, 63, 5, 18 },
                    { 1251, false, 63, 5, 19 },
                    { 1252, false, 63, 5, 20 },
                    { 1253, false, 63, 6, 21 },
                    { 1254, false, 63, 6, 22 },
                    { 1255, false, 63, 6, 23 },
                    { 1256, false, 63, 6, 24 },
                    { 1257, false, 63, 7, 25 },
                    { 1258, false, 63, 7, 26 },
                    { 1259, false, 63, 7, 27 },
                    { 1260, false, 63, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1261, false, 64, 1, 1 },
                    { 1262, false, 64, 1, 2 },
                    { 1263, false, 64, 1, 3 },
                    { 1264, false, 64, 1, 4 },
                    { 1265, false, 64, 2, 5 },
                    { 1266, false, 64, 2, 6 },
                    { 1267, false, 64, 2, 7 },
                    { 1268, false, 64, 2, 8 },
                    { 1269, false, 64, 3, 9 },
                    { 1270, false, 64, 3, 10 },
                    { 1271, false, 64, 3, 11 },
                    { 1272, false, 64, 3, 12 },
                    { 1273, false, 64, 4, 13 },
                    { 1274, false, 64, 4, 14 },
                    { 1275, false, 64, 4, 15 },
                    { 1276, false, 64, 4, 16 },
                    { 1277, false, 64, 5, 17 },
                    { 1278, false, 64, 5, 18 },
                    { 1279, false, 64, 5, 19 },
                    { 1280, false, 64, 5, 20 },
                    { 1281, false, 64, 6, 21 },
                    { 1282, false, 64, 6, 22 },
                    { 1283, false, 64, 6, 23 },
                    { 1284, false, 64, 6, 24 },
                    { 1285, false, 64, 7, 25 },
                    { 1286, false, 64, 7, 26 },
                    { 1287, false, 64, 7, 27 },
                    { 1288, false, 64, 7, 28 },
                    { 1289, false, 65, 1, 1 },
                    { 1290, false, 65, 1, 2 },
                    { 1291, false, 65, 1, 3 },
                    { 1292, false, 65, 1, 4 },
                    { 1293, false, 65, 1, 5 },
                    { 1294, false, 65, 1, 6 },
                    { 1295, false, 65, 2, 7 },
                    { 1296, false, 65, 2, 8 },
                    { 1297, false, 65, 2, 9 },
                    { 1298, false, 65, 2, 10 },
                    { 1299, false, 65, 2, 11 },
                    { 1300, false, 65, 2, 12 },
                    { 1301, false, 65, 3, 13 },
                    { 1302, false, 65, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1303, false, 65, 3, 15 },
                    { 1304, false, 65, 3, 16 },
                    { 1305, false, 65, 3, 17 },
                    { 1306, false, 65, 3, 18 },
                    { 1307, false, 65, 4, 19 },
                    { 1308, false, 65, 4, 20 },
                    { 1309, false, 65, 4, 21 },
                    { 1310, false, 65, 4, 22 },
                    { 1311, false, 65, 4, 23 },
                    { 1312, false, 65, 4, 24 },
                    { 1313, false, 65, 5, 25 },
                    { 1314, false, 65, 5, 26 },
                    { 1315, false, 65, 5, 27 },
                    { 1316, false, 65, 5, 28 },
                    { 1317, false, 65, 5, 29 },
                    { 1318, false, 65, 5, 30 },
                    { 1319, false, 65, 6, 31 },
                    { 1320, false, 65, 6, 32 },
                    { 1321, false, 65, 6, 33 },
                    { 1322, false, 65, 6, 34 },
                    { 1323, false, 65, 6, 35 },
                    { 1324, false, 65, 6, 36 },
                    { 1325, false, 65, 7, 37 },
                    { 1326, false, 65, 7, 38 },
                    { 1327, false, 65, 7, 39 },
                    { 1328, false, 65, 7, 40 },
                    { 1329, false, 65, 7, 41 },
                    { 1330, false, 65, 7, 42 },
                    { 1331, false, 66, 1, 1 },
                    { 1332, false, 66, 1, 2 },
                    { 1333, false, 66, 1, 3 },
                    { 1334, false, 66, 1, 4 },
                    { 1335, false, 66, 1, 5 },
                    { 1336, false, 66, 1, 6 },
                    { 1337, false, 66, 2, 7 },
                    { 1338, false, 66, 2, 8 },
                    { 1339, false, 66, 2, 9 },
                    { 1340, false, 66, 2, 10 },
                    { 1341, false, 66, 2, 11 },
                    { 1342, false, 66, 2, 12 },
                    { 1343, false, 66, 3, 13 },
                    { 1344, false, 66, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1345, false, 66, 3, 15 },
                    { 1346, false, 66, 3, 16 },
                    { 1347, false, 66, 3, 17 },
                    { 1348, false, 66, 3, 18 },
                    { 1349, false, 66, 4, 19 },
                    { 1350, false, 66, 4, 20 },
                    { 1351, false, 66, 4, 21 },
                    { 1352, false, 66, 4, 22 },
                    { 1353, false, 66, 4, 23 },
                    { 1354, false, 66, 4, 24 },
                    { 1355, false, 66, 5, 25 },
                    { 1356, false, 66, 5, 26 },
                    { 1357, false, 66, 5, 27 },
                    { 1358, false, 66, 5, 28 },
                    { 1359, false, 66, 5, 29 },
                    { 1360, false, 66, 5, 30 },
                    { 1361, false, 66, 6, 31 },
                    { 1362, false, 66, 6, 32 },
                    { 1363, false, 66, 6, 33 },
                    { 1364, false, 66, 6, 34 },
                    { 1365, false, 66, 6, 35 },
                    { 1366, false, 66, 6, 36 },
                    { 1367, false, 66, 7, 37 },
                    { 1368, false, 66, 7, 38 },
                    { 1369, false, 66, 7, 39 },
                    { 1370, false, 66, 7, 40 },
                    { 1371, false, 66, 7, 41 },
                    { 1372, false, 66, 7, 42 },
                    { 1373, false, 71, 1, 1 },
                    { 1374, false, 71, 1, 2 },
                    { 1375, false, 71, 1, 3 },
                    { 1376, false, 71, 1, 4 },
                    { 1377, false, 71, 2, 5 },
                    { 1378, false, 71, 2, 6 },
                    { 1379, false, 71, 2, 7 },
                    { 1380, false, 71, 2, 8 },
                    { 1381, false, 71, 3, 9 },
                    { 1382, false, 71, 3, 10 },
                    { 1383, false, 71, 3, 11 },
                    { 1384, false, 71, 3, 12 },
                    { 1385, false, 71, 4, 13 },
                    { 1386, false, 71, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1387, false, 71, 4, 15 },
                    { 1388, false, 71, 4, 16 },
                    { 1389, false, 71, 5, 17 },
                    { 1390, false, 71, 5, 18 },
                    { 1391, false, 71, 5, 19 },
                    { 1392, false, 71, 5, 20 },
                    { 1393, false, 71, 6, 21 },
                    { 1394, false, 71, 6, 22 },
                    { 1395, false, 71, 6, 23 },
                    { 1396, false, 71, 6, 24 },
                    { 1397, false, 71, 7, 25 },
                    { 1398, false, 71, 7, 26 },
                    { 1399, false, 71, 7, 27 },
                    { 1400, false, 71, 7, 28 },
                    { 1401, false, 72, 1, 1 },
                    { 1402, false, 72, 1, 2 },
                    { 1403, false, 72, 1, 3 },
                    { 1404, false, 72, 1, 4 },
                    { 1405, false, 72, 2, 5 },
                    { 1406, false, 72, 2, 6 },
                    { 1407, false, 72, 2, 7 },
                    { 1408, false, 72, 2, 8 },
                    { 1409, false, 72, 3, 9 },
                    { 1410, false, 72, 3, 10 },
                    { 1411, false, 72, 3, 11 },
                    { 1412, false, 72, 3, 12 },
                    { 1413, false, 72, 4, 13 },
                    { 1414, false, 72, 4, 14 },
                    { 1415, false, 72, 4, 15 },
                    { 1416, false, 72, 4, 16 },
                    { 1417, false, 72, 5, 17 },
                    { 1418, false, 72, 5, 18 },
                    { 1419, false, 72, 5, 19 },
                    { 1420, false, 72, 5, 20 },
                    { 1421, false, 72, 6, 21 },
                    { 1422, false, 72, 6, 22 },
                    { 1423, false, 72, 6, 23 },
                    { 1424, false, 72, 6, 24 },
                    { 1425, false, 72, 7, 25 },
                    { 1426, false, 72, 7, 26 },
                    { 1427, false, 72, 7, 27 },
                    { 1428, false, 72, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1429, false, 73, 1, 1 },
                    { 1430, false, 73, 1, 2 },
                    { 1431, false, 73, 1, 3 },
                    { 1432, false, 73, 1, 4 },
                    { 1433, false, 73, 2, 5 },
                    { 1434, false, 73, 2, 6 },
                    { 1435, false, 73, 2, 7 },
                    { 1436, false, 73, 2, 8 },
                    { 1437, false, 73, 3, 9 },
                    { 1438, false, 73, 3, 10 },
                    { 1439, false, 73, 3, 11 },
                    { 1440, false, 73, 3, 12 },
                    { 1441, false, 73, 4, 13 },
                    { 1442, false, 73, 4, 14 },
                    { 1443, false, 73, 4, 15 },
                    { 1444, false, 73, 4, 16 },
                    { 1445, false, 73, 5, 17 },
                    { 1446, false, 73, 5, 18 },
                    { 1447, false, 73, 5, 19 },
                    { 1448, false, 73, 5, 20 },
                    { 1449, false, 73, 6, 21 },
                    { 1450, false, 73, 6, 22 },
                    { 1451, false, 73, 6, 23 },
                    { 1452, false, 73, 6, 24 },
                    { 1453, false, 73, 7, 25 },
                    { 1454, false, 73, 7, 26 },
                    { 1455, false, 73, 7, 27 },
                    { 1456, false, 73, 7, 28 },
                    { 1457, false, 74, 1, 1 },
                    { 1458, false, 74, 1, 2 },
                    { 1459, false, 74, 1, 3 },
                    { 1460, false, 74, 1, 4 },
                    { 1461, false, 74, 2, 5 },
                    { 1462, false, 74, 2, 6 },
                    { 1463, false, 74, 2, 7 },
                    { 1464, false, 74, 2, 8 },
                    { 1465, false, 74, 3, 9 },
                    { 1466, false, 74, 3, 10 },
                    { 1467, false, 74, 3, 11 },
                    { 1468, false, 74, 3, 12 },
                    { 1469, false, 74, 4, 13 },
                    { 1470, false, 74, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1471, false, 74, 4, 15 },
                    { 1472, false, 74, 4, 16 },
                    { 1473, false, 74, 5, 17 },
                    { 1474, false, 74, 5, 18 },
                    { 1475, false, 74, 5, 19 },
                    { 1476, false, 74, 5, 20 },
                    { 1477, false, 74, 6, 21 },
                    { 1478, false, 74, 6, 22 },
                    { 1479, false, 74, 6, 23 },
                    { 1480, false, 74, 6, 24 },
                    { 1481, false, 74, 7, 25 },
                    { 1482, false, 74, 7, 26 },
                    { 1483, false, 74, 7, 27 },
                    { 1484, false, 74, 7, 28 },
                    { 1485, false, 75, 1, 1 },
                    { 1486, false, 75, 1, 2 },
                    { 1487, false, 75, 1, 3 },
                    { 1488, false, 75, 1, 4 },
                    { 1489, false, 75, 1, 5 },
                    { 1490, false, 75, 1, 6 },
                    { 1491, false, 75, 2, 7 },
                    { 1492, false, 75, 2, 8 },
                    { 1493, false, 75, 2, 9 },
                    { 1494, false, 75, 2, 10 },
                    { 1495, false, 75, 2, 11 },
                    { 1496, false, 75, 2, 12 },
                    { 1497, false, 75, 3, 13 },
                    { 1498, false, 75, 3, 14 },
                    { 1499, false, 75, 3, 15 },
                    { 1500, false, 75, 3, 16 },
                    { 1501, false, 75, 3, 17 },
                    { 1502, false, 75, 3, 18 },
                    { 1503, false, 75, 4, 19 },
                    { 1504, false, 75, 4, 20 },
                    { 1505, false, 75, 4, 21 },
                    { 1506, false, 75, 4, 22 },
                    { 1507, false, 75, 4, 23 },
                    { 1508, false, 75, 4, 24 },
                    { 1509, false, 75, 5, 25 },
                    { 1510, false, 75, 5, 26 },
                    { 1511, false, 75, 5, 27 },
                    { 1512, false, 75, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1513, false, 75, 5, 29 },
                    { 1514, false, 75, 5, 30 },
                    { 1515, false, 75, 6, 31 },
                    { 1516, false, 75, 6, 32 },
                    { 1517, false, 75, 6, 33 },
                    { 1518, false, 75, 6, 34 },
                    { 1519, false, 75, 6, 35 },
                    { 1520, false, 75, 6, 36 },
                    { 1521, false, 75, 7, 37 },
                    { 1522, false, 75, 7, 38 },
                    { 1523, false, 75, 7, 39 },
                    { 1524, false, 75, 7, 40 },
                    { 1525, false, 75, 7, 41 },
                    { 1526, false, 75, 7, 42 },
                    { 1527, false, 76, 1, 1 },
                    { 1528, false, 76, 1, 2 },
                    { 1529, false, 76, 1, 3 },
                    { 1530, false, 76, 1, 4 },
                    { 1531, false, 76, 1, 5 },
                    { 1532, false, 76, 1, 6 },
                    { 1533, false, 76, 2, 7 },
                    { 1534, false, 76, 2, 8 },
                    { 1535, false, 76, 2, 9 },
                    { 1536, false, 76, 2, 10 },
                    { 1537, false, 76, 2, 11 },
                    { 1538, false, 76, 2, 12 },
                    { 1539, false, 76, 3, 13 },
                    { 1540, false, 76, 3, 14 },
                    { 1541, false, 76, 3, 15 },
                    { 1542, false, 76, 3, 16 },
                    { 1543, false, 76, 3, 17 },
                    { 1544, false, 76, 3, 18 },
                    { 1545, false, 76, 4, 19 },
                    { 1546, false, 76, 4, 20 },
                    { 1547, false, 76, 4, 21 },
                    { 1548, false, 76, 4, 22 },
                    { 1549, false, 76, 4, 23 },
                    { 1550, false, 76, 4, 24 },
                    { 1551, false, 76, 5, 25 },
                    { 1552, false, 76, 5, 26 },
                    { 1553, false, 76, 5, 27 },
                    { 1554, false, 76, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1555, false, 76, 5, 29 },
                    { 1556, false, 76, 5, 30 },
                    { 1557, false, 76, 6, 31 },
                    { 1558, false, 76, 6, 32 },
                    { 1559, false, 76, 6, 33 },
                    { 1560, false, 76, 6, 34 },
                    { 1561, false, 76, 6, 35 },
                    { 1562, false, 76, 6, 36 },
                    { 1563, false, 76, 7, 37 },
                    { 1564, false, 76, 7, 38 },
                    { 1565, false, 76, 7, 39 },
                    { 1566, false, 76, 7, 40 },
                    { 1567, false, 76, 7, 41 },
                    { 1568, false, 76, 7, 42 },
                    { 1569, false, 81, 1, 1 },
                    { 1570, false, 81, 1, 2 },
                    { 1571, false, 81, 1, 3 },
                    { 1572, false, 81, 1, 4 },
                    { 1573, false, 81, 2, 5 },
                    { 1574, false, 81, 2, 6 },
                    { 1575, false, 81, 2, 7 },
                    { 1576, false, 81, 2, 8 },
                    { 1577, false, 81, 3, 9 },
                    { 1578, false, 81, 3, 10 },
                    { 1579, false, 81, 3, 11 },
                    { 1580, false, 81, 3, 12 },
                    { 1581, false, 81, 4, 13 },
                    { 1582, false, 81, 4, 14 },
                    { 1583, false, 81, 4, 15 },
                    { 1584, false, 81, 4, 16 },
                    { 1585, false, 81, 5, 17 },
                    { 1586, false, 81, 5, 18 },
                    { 1587, false, 81, 5, 19 },
                    { 1588, false, 81, 5, 20 },
                    { 1589, false, 81, 6, 21 },
                    { 1590, false, 81, 6, 22 },
                    { 1591, false, 81, 6, 23 },
                    { 1592, false, 81, 6, 24 },
                    { 1593, false, 81, 7, 25 },
                    { 1594, false, 81, 7, 26 },
                    { 1595, false, 81, 7, 27 },
                    { 1596, false, 81, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1597, false, 82, 1, 1 },
                    { 1598, false, 82, 1, 2 },
                    { 1599, false, 82, 1, 3 },
                    { 1600, false, 82, 1, 4 },
                    { 1601, false, 82, 2, 5 },
                    { 1602, false, 82, 2, 6 },
                    { 1603, false, 82, 2, 7 },
                    { 1604, false, 82, 2, 8 },
                    { 1605, false, 82, 3, 9 },
                    { 1606, false, 82, 3, 10 },
                    { 1607, false, 82, 3, 11 },
                    { 1608, false, 82, 3, 12 },
                    { 1609, false, 82, 4, 13 },
                    { 1610, false, 82, 4, 14 },
                    { 1611, false, 82, 4, 15 },
                    { 1612, false, 82, 4, 16 },
                    { 1613, false, 82, 5, 17 },
                    { 1614, false, 82, 5, 18 },
                    { 1615, false, 82, 5, 19 },
                    { 1616, false, 82, 5, 20 },
                    { 1617, false, 82, 6, 21 },
                    { 1618, false, 82, 6, 22 },
                    { 1619, false, 82, 6, 23 },
                    { 1620, false, 82, 6, 24 },
                    { 1621, false, 82, 7, 25 },
                    { 1622, false, 82, 7, 26 },
                    { 1623, false, 82, 7, 27 },
                    { 1624, false, 82, 7, 28 },
                    { 1625, false, 83, 1, 1 },
                    { 1626, false, 83, 1, 2 },
                    { 1627, false, 83, 1, 3 },
                    { 1628, false, 83, 1, 4 },
                    { 1629, false, 83, 2, 5 },
                    { 1630, false, 83, 2, 6 },
                    { 1631, false, 83, 2, 7 },
                    { 1632, false, 83, 2, 8 },
                    { 1633, false, 83, 3, 9 },
                    { 1634, false, 83, 3, 10 },
                    { 1635, false, 83, 3, 11 },
                    { 1636, false, 83, 3, 12 },
                    { 1637, false, 83, 4, 13 },
                    { 1638, false, 83, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1639, false, 83, 4, 15 },
                    { 1640, false, 83, 4, 16 },
                    { 1641, false, 83, 5, 17 },
                    { 1642, false, 83, 5, 18 },
                    { 1643, false, 83, 5, 19 },
                    { 1644, false, 83, 5, 20 },
                    { 1645, false, 83, 6, 21 },
                    { 1646, false, 83, 6, 22 },
                    { 1647, false, 83, 6, 23 },
                    { 1648, false, 83, 6, 24 },
                    { 1649, false, 83, 7, 25 },
                    { 1650, false, 83, 7, 26 },
                    { 1651, false, 83, 7, 27 },
                    { 1652, false, 83, 7, 28 },
                    { 1653, false, 84, 1, 1 },
                    { 1654, false, 84, 1, 2 },
                    { 1655, false, 84, 1, 3 },
                    { 1656, false, 84, 1, 4 },
                    { 1657, false, 84, 2, 5 },
                    { 1658, false, 84, 2, 6 },
                    { 1659, false, 84, 2, 7 },
                    { 1660, false, 84, 2, 8 },
                    { 1661, false, 84, 3, 9 },
                    { 1662, false, 84, 3, 10 },
                    { 1663, false, 84, 3, 11 },
                    { 1664, false, 84, 3, 12 },
                    { 1665, false, 84, 4, 13 },
                    { 1666, false, 84, 4, 14 },
                    { 1667, false, 84, 4, 15 },
                    { 1668, false, 84, 4, 16 },
                    { 1669, false, 84, 5, 17 },
                    { 1670, false, 84, 5, 18 },
                    { 1671, false, 84, 5, 19 },
                    { 1672, false, 84, 5, 20 },
                    { 1673, false, 84, 6, 21 },
                    { 1674, false, 84, 6, 22 },
                    { 1675, false, 84, 6, 23 },
                    { 1676, false, 84, 6, 24 },
                    { 1677, false, 84, 7, 25 },
                    { 1678, false, 84, 7, 26 },
                    { 1679, false, 84, 7, 27 },
                    { 1680, false, 84, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1681, false, 85, 1, 1 },
                    { 1682, false, 85, 1, 2 },
                    { 1683, false, 85, 1, 3 },
                    { 1684, false, 85, 1, 4 },
                    { 1685, false, 85, 1, 5 },
                    { 1686, false, 85, 1, 6 },
                    { 1687, false, 85, 2, 7 },
                    { 1688, false, 85, 2, 8 },
                    { 1689, false, 85, 2, 9 },
                    { 1690, false, 85, 2, 10 },
                    { 1691, false, 85, 2, 11 },
                    { 1692, false, 85, 2, 12 },
                    { 1693, false, 85, 3, 13 },
                    { 1694, false, 85, 3, 14 },
                    { 1695, false, 85, 3, 15 },
                    { 1696, false, 85, 3, 16 },
                    { 1697, false, 85, 3, 17 },
                    { 1698, false, 85, 3, 18 },
                    { 1699, false, 85, 4, 19 },
                    { 1700, false, 85, 4, 20 },
                    { 1701, false, 85, 4, 21 },
                    { 1702, false, 85, 4, 22 },
                    { 1703, false, 85, 4, 23 },
                    { 1704, false, 85, 4, 24 },
                    { 1705, false, 85, 5, 25 },
                    { 1706, false, 85, 5, 26 },
                    { 1707, false, 85, 5, 27 },
                    { 1708, false, 85, 5, 28 },
                    { 1709, false, 85, 5, 29 },
                    { 1710, false, 85, 5, 30 },
                    { 1711, false, 85, 6, 31 },
                    { 1712, false, 85, 6, 32 },
                    { 1713, false, 85, 6, 33 },
                    { 1714, false, 85, 6, 34 },
                    { 1715, false, 85, 6, 35 },
                    { 1716, false, 85, 6, 36 },
                    { 1717, false, 85, 7, 37 },
                    { 1718, false, 85, 7, 38 },
                    { 1719, false, 85, 7, 39 },
                    { 1720, false, 85, 7, 40 },
                    { 1721, false, 85, 7, 41 },
                    { 1722, false, 85, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1723, false, 86, 1, 1 },
                    { 1724, false, 86, 1, 2 },
                    { 1725, false, 86, 1, 3 },
                    { 1726, false, 86, 1, 4 },
                    { 1727, false, 86, 1, 5 },
                    { 1728, false, 86, 1, 6 },
                    { 1729, false, 86, 2, 7 },
                    { 1730, false, 86, 2, 8 },
                    { 1731, false, 86, 2, 9 },
                    { 1732, false, 86, 2, 10 },
                    { 1733, false, 86, 2, 11 },
                    { 1734, false, 86, 2, 12 },
                    { 1735, false, 86, 3, 13 },
                    { 1736, false, 86, 3, 14 },
                    { 1737, false, 86, 3, 15 },
                    { 1738, false, 86, 3, 16 },
                    { 1739, false, 86, 3, 17 },
                    { 1740, false, 86, 3, 18 },
                    { 1741, false, 86, 4, 19 },
                    { 1742, false, 86, 4, 20 },
                    { 1743, false, 86, 4, 21 },
                    { 1744, false, 86, 4, 22 },
                    { 1745, false, 86, 4, 23 },
                    { 1746, false, 86, 4, 24 },
                    { 1747, false, 86, 5, 25 },
                    { 1748, false, 86, 5, 26 },
                    { 1749, false, 86, 5, 27 },
                    { 1750, false, 86, 5, 28 },
                    { 1751, false, 86, 5, 29 },
                    { 1752, false, 86, 5, 30 },
                    { 1753, false, 86, 6, 31 },
                    { 1754, false, 86, 6, 32 },
                    { 1755, false, 86, 6, 33 },
                    { 1756, false, 86, 6, 34 },
                    { 1757, false, 86, 6, 35 },
                    { 1758, false, 86, 6, 36 },
                    { 1759, false, 86, 7, 37 },
                    { 1760, false, 86, 7, 38 },
                    { 1761, false, 86, 7, 39 },
                    { 1762, false, 86, 7, 40 },
                    { 1763, false, 86, 7, 41 },
                    { 1764, false, 86, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1765, false, 91, 1, 1 },
                    { 1766, false, 91, 1, 2 },
                    { 1767, false, 91, 1, 3 },
                    { 1768, false, 91, 1, 4 },
                    { 1769, false, 91, 2, 5 },
                    { 1770, false, 91, 2, 6 },
                    { 1771, false, 91, 2, 7 },
                    { 1772, false, 91, 2, 8 },
                    { 1773, false, 91, 3, 9 },
                    { 1774, false, 91, 3, 10 },
                    { 1775, false, 91, 3, 11 },
                    { 1776, false, 91, 3, 12 },
                    { 1777, false, 91, 4, 13 },
                    { 1778, false, 91, 4, 14 },
                    { 1779, false, 91, 4, 15 },
                    { 1780, false, 91, 4, 16 },
                    { 1781, false, 91, 5, 17 },
                    { 1782, false, 91, 5, 18 },
                    { 1783, false, 91, 5, 19 },
                    { 1784, false, 91, 5, 20 },
                    { 1785, false, 91, 6, 21 },
                    { 1786, false, 91, 6, 22 },
                    { 1787, false, 91, 6, 23 },
                    { 1788, false, 91, 6, 24 },
                    { 1789, false, 91, 7, 25 },
                    { 1790, false, 91, 7, 26 },
                    { 1791, false, 91, 7, 27 },
                    { 1792, false, 91, 7, 28 },
                    { 1793, false, 92, 1, 1 },
                    { 1794, false, 92, 1, 2 },
                    { 1795, false, 92, 1, 3 },
                    { 1796, false, 92, 1, 4 },
                    { 1797, false, 92, 2, 5 },
                    { 1798, false, 92, 2, 6 },
                    { 1799, false, 92, 2, 7 },
                    { 1800, false, 92, 2, 8 },
                    { 1801, false, 92, 3, 9 },
                    { 1802, false, 92, 3, 10 },
                    { 1803, false, 92, 3, 11 },
                    { 1804, false, 92, 3, 12 },
                    { 1805, false, 92, 4, 13 },
                    { 1806, false, 92, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1807, false, 92, 4, 15 },
                    { 1808, false, 92, 4, 16 },
                    { 1809, false, 92, 5, 17 },
                    { 1810, false, 92, 5, 18 },
                    { 1811, false, 92, 5, 19 },
                    { 1812, false, 92, 5, 20 },
                    { 1813, false, 92, 6, 21 },
                    { 1814, false, 92, 6, 22 },
                    { 1815, false, 92, 6, 23 },
                    { 1816, false, 92, 6, 24 },
                    { 1817, false, 92, 7, 25 },
                    { 1818, false, 92, 7, 26 },
                    { 1819, false, 92, 7, 27 },
                    { 1820, false, 92, 7, 28 },
                    { 1821, false, 93, 1, 1 },
                    { 1822, false, 93, 1, 2 },
                    { 1823, false, 93, 1, 3 },
                    { 1824, false, 93, 1, 4 },
                    { 1825, false, 93, 2, 5 },
                    { 1826, false, 93, 2, 6 },
                    { 1827, false, 93, 2, 7 },
                    { 1828, false, 93, 2, 8 },
                    { 1829, false, 93, 3, 9 },
                    { 1830, false, 93, 3, 10 },
                    { 1831, false, 93, 3, 11 },
                    { 1832, false, 93, 3, 12 },
                    { 1833, false, 93, 4, 13 },
                    { 1834, false, 93, 4, 14 },
                    { 1835, false, 93, 4, 15 },
                    { 1836, false, 93, 4, 16 },
                    { 1837, false, 93, 5, 17 },
                    { 1838, false, 93, 5, 18 },
                    { 1839, false, 93, 5, 19 },
                    { 1840, false, 93, 5, 20 },
                    { 1841, false, 93, 6, 21 },
                    { 1842, false, 93, 6, 22 },
                    { 1843, false, 93, 6, 23 },
                    { 1844, false, 93, 6, 24 },
                    { 1845, false, 93, 7, 25 },
                    { 1846, false, 93, 7, 26 },
                    { 1847, false, 93, 7, 27 },
                    { 1848, false, 93, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1849, false, 94, 1, 1 },
                    { 1850, false, 94, 1, 2 },
                    { 1851, false, 94, 1, 3 },
                    { 1852, false, 94, 1, 4 },
                    { 1853, false, 94, 2, 5 },
                    { 1854, false, 94, 2, 6 },
                    { 1855, false, 94, 2, 7 },
                    { 1856, false, 94, 2, 8 },
                    { 1857, false, 94, 3, 9 },
                    { 1858, false, 94, 3, 10 },
                    { 1859, false, 94, 3, 11 },
                    { 1860, false, 94, 3, 12 },
                    { 1861, false, 94, 4, 13 },
                    { 1862, false, 94, 4, 14 },
                    { 1863, false, 94, 4, 15 },
                    { 1864, false, 94, 4, 16 },
                    { 1865, false, 94, 5, 17 },
                    { 1866, false, 94, 5, 18 },
                    { 1867, false, 94, 5, 19 },
                    { 1868, false, 94, 5, 20 },
                    { 1869, false, 94, 6, 21 },
                    { 1870, false, 94, 6, 22 },
                    { 1871, false, 94, 6, 23 },
                    { 1872, false, 94, 6, 24 },
                    { 1873, false, 94, 7, 25 },
                    { 1874, false, 94, 7, 26 },
                    { 1875, false, 94, 7, 27 },
                    { 1876, false, 94, 7, 28 },
                    { 1877, false, 95, 1, 1 },
                    { 1878, false, 95, 1, 2 },
                    { 1879, false, 95, 1, 3 },
                    { 1880, false, 95, 1, 4 },
                    { 1881, false, 95, 1, 5 },
                    { 1882, false, 95, 1, 6 },
                    { 1883, false, 95, 2, 7 },
                    { 1884, false, 95, 2, 8 },
                    { 1885, false, 95, 2, 9 },
                    { 1886, false, 95, 2, 10 },
                    { 1887, false, 95, 2, 11 },
                    { 1888, false, 95, 2, 12 },
                    { 1889, false, 95, 3, 13 },
                    { 1890, false, 95, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1891, false, 95, 3, 15 },
                    { 1892, false, 95, 3, 16 },
                    { 1893, false, 95, 3, 17 },
                    { 1894, false, 95, 3, 18 },
                    { 1895, false, 95, 4, 19 },
                    { 1896, false, 95, 4, 20 },
                    { 1897, false, 95, 4, 21 },
                    { 1898, false, 95, 4, 22 },
                    { 1899, false, 95, 4, 23 },
                    { 1900, false, 95, 4, 24 },
                    { 1901, false, 95, 5, 25 },
                    { 1902, false, 95, 5, 26 },
                    { 1903, false, 95, 5, 27 },
                    { 1904, false, 95, 5, 28 },
                    { 1905, false, 95, 5, 29 },
                    { 1906, false, 95, 5, 30 },
                    { 1907, false, 95, 6, 31 },
                    { 1908, false, 95, 6, 32 },
                    { 1909, false, 95, 6, 33 },
                    { 1910, false, 95, 6, 34 },
                    { 1911, false, 95, 6, 35 },
                    { 1912, false, 95, 6, 36 },
                    { 1913, false, 95, 7, 37 },
                    { 1914, false, 95, 7, 38 },
                    { 1915, false, 95, 7, 39 },
                    { 1916, false, 95, 7, 40 },
                    { 1917, false, 95, 7, 41 },
                    { 1918, false, 95, 7, 42 },
                    { 1919, false, 96, 1, 1 },
                    { 1920, false, 96, 1, 2 },
                    { 1921, false, 96, 1, 3 },
                    { 1922, false, 96, 1, 4 },
                    { 1923, false, 96, 1, 5 },
                    { 1924, false, 96, 1, 6 },
                    { 1925, false, 96, 2, 7 },
                    { 1926, false, 96, 2, 8 },
                    { 1927, false, 96, 2, 9 },
                    { 1928, false, 96, 2, 10 },
                    { 1929, false, 96, 2, 11 },
                    { 1930, false, 96, 2, 12 },
                    { 1931, false, 96, 3, 13 },
                    { 1932, false, 96, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1933, false, 96, 3, 15 },
                    { 1934, false, 96, 3, 16 },
                    { 1935, false, 96, 3, 17 },
                    { 1936, false, 96, 3, 18 },
                    { 1937, false, 96, 4, 19 },
                    { 1938, false, 96, 4, 20 },
                    { 1939, false, 96, 4, 21 },
                    { 1940, false, 96, 4, 22 },
                    { 1941, false, 96, 4, 23 },
                    { 1942, false, 96, 4, 24 },
                    { 1943, false, 96, 5, 25 },
                    { 1944, false, 96, 5, 26 },
                    { 1945, false, 96, 5, 27 },
                    { 1946, false, 96, 5, 28 },
                    { 1947, false, 96, 5, 29 },
                    { 1948, false, 96, 5, 30 },
                    { 1949, false, 96, 6, 31 },
                    { 1950, false, 96, 6, 32 },
                    { 1951, false, 96, 6, 33 },
                    { 1952, false, 96, 6, 34 },
                    { 1953, false, 96, 6, 35 },
                    { 1954, false, 96, 6, 36 },
                    { 1955, false, 96, 7, 37 },
                    { 1956, false, 96, 7, 38 },
                    { 1957, false, 96, 7, 39 },
                    { 1958, false, 96, 7, 40 },
                    { 1959, false, 96, 7, 41 },
                    { 1960, false, 96, 7, 42 },
                    { 1961, false, 101, 1, 1 },
                    { 1962, false, 101, 1, 2 },
                    { 1963, false, 101, 1, 3 },
                    { 1964, false, 101, 1, 4 },
                    { 1965, false, 101, 2, 5 },
                    { 1966, false, 101, 2, 6 },
                    { 1967, false, 101, 2, 7 },
                    { 1968, false, 101, 2, 8 },
                    { 1969, false, 101, 3, 9 },
                    { 1970, false, 101, 3, 10 },
                    { 1971, false, 101, 3, 11 },
                    { 1972, false, 101, 3, 12 },
                    { 1973, false, 101, 4, 13 },
                    { 1974, false, 101, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1975, false, 101, 4, 15 },
                    { 1976, false, 101, 4, 16 },
                    { 1977, false, 101, 5, 17 },
                    { 1978, false, 101, 5, 18 },
                    { 1979, false, 101, 5, 19 },
                    { 1980, false, 101, 5, 20 },
                    { 1981, false, 101, 6, 21 },
                    { 1982, false, 101, 6, 22 },
                    { 1983, false, 101, 6, 23 },
                    { 1984, false, 101, 6, 24 },
                    { 1985, false, 101, 7, 25 },
                    { 1986, false, 101, 7, 26 },
                    { 1987, false, 101, 7, 27 },
                    { 1988, false, 101, 7, 28 },
                    { 1989, false, 102, 1, 1 },
                    { 1990, false, 102, 1, 2 },
                    { 1991, false, 102, 1, 3 },
                    { 1992, false, 102, 1, 4 },
                    { 1993, false, 102, 2, 5 },
                    { 1994, false, 102, 2, 6 },
                    { 1995, false, 102, 2, 7 },
                    { 1996, false, 102, 2, 8 },
                    { 1997, false, 102, 3, 9 },
                    { 1998, false, 102, 3, 10 },
                    { 1999, false, 102, 3, 11 },
                    { 2000, false, 102, 3, 12 },
                    { 2001, false, 102, 4, 13 },
                    { 2002, false, 102, 4, 14 },
                    { 2003, false, 102, 4, 15 },
                    { 2004, false, 102, 4, 16 },
                    { 2005, false, 102, 5, 17 },
                    { 2006, false, 102, 5, 18 },
                    { 2007, false, 102, 5, 19 },
                    { 2008, false, 102, 5, 20 },
                    { 2009, false, 102, 6, 21 },
                    { 2010, false, 102, 6, 22 },
                    { 2011, false, 102, 6, 23 },
                    { 2012, false, 102, 6, 24 },
                    { 2013, false, 102, 7, 25 },
                    { 2014, false, 102, 7, 26 },
                    { 2015, false, 102, 7, 27 },
                    { 2016, false, 102, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2017, false, 103, 1, 1 },
                    { 2018, false, 103, 1, 2 },
                    { 2019, false, 103, 1, 3 },
                    { 2020, false, 103, 1, 4 },
                    { 2021, false, 103, 2, 5 },
                    { 2022, false, 103, 2, 6 },
                    { 2023, false, 103, 2, 7 },
                    { 2024, false, 103, 2, 8 },
                    { 2025, false, 103, 3, 9 },
                    { 2026, false, 103, 3, 10 },
                    { 2027, false, 103, 3, 11 },
                    { 2028, false, 103, 3, 12 },
                    { 2029, false, 103, 4, 13 },
                    { 2030, false, 103, 4, 14 },
                    { 2031, false, 103, 4, 15 },
                    { 2032, false, 103, 4, 16 },
                    { 2033, false, 103, 5, 17 },
                    { 2034, false, 103, 5, 18 },
                    { 2035, false, 103, 5, 19 },
                    { 2036, false, 103, 5, 20 },
                    { 2037, false, 103, 6, 21 },
                    { 2038, false, 103, 6, 22 },
                    { 2039, false, 103, 6, 23 },
                    { 2040, false, 103, 6, 24 },
                    { 2041, false, 103, 7, 25 },
                    { 2042, false, 103, 7, 26 },
                    { 2043, false, 103, 7, 27 },
                    { 2044, false, 103, 7, 28 },
                    { 2045, false, 104, 1, 1 },
                    { 2046, false, 104, 1, 2 },
                    { 2047, false, 104, 1, 3 },
                    { 2048, false, 104, 1, 4 },
                    { 2049, false, 104, 2, 5 },
                    { 2050, false, 104, 2, 6 },
                    { 2051, false, 104, 2, 7 },
                    { 2052, false, 104, 2, 8 },
                    { 2053, false, 104, 3, 9 },
                    { 2054, false, 104, 3, 10 },
                    { 2055, false, 104, 3, 11 },
                    { 2056, false, 104, 3, 12 },
                    { 2057, false, 104, 4, 13 },
                    { 2058, false, 104, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2059, false, 104, 4, 15 },
                    { 2060, false, 104, 4, 16 },
                    { 2061, false, 104, 5, 17 },
                    { 2062, false, 104, 5, 18 },
                    { 2063, false, 104, 5, 19 },
                    { 2064, false, 104, 5, 20 },
                    { 2065, false, 104, 6, 21 },
                    { 2066, false, 104, 6, 22 },
                    { 2067, false, 104, 6, 23 },
                    { 2068, false, 104, 6, 24 },
                    { 2069, false, 104, 7, 25 },
                    { 2070, false, 104, 7, 26 },
                    { 2071, false, 104, 7, 27 },
                    { 2072, false, 104, 7, 28 },
                    { 2073, false, 105, 1, 1 },
                    { 2074, false, 105, 1, 2 },
                    { 2075, false, 105, 1, 3 },
                    { 2076, false, 105, 1, 4 },
                    { 2077, false, 105, 1, 5 },
                    { 2078, false, 105, 1, 6 },
                    { 2079, false, 105, 2, 7 },
                    { 2080, false, 105, 2, 8 },
                    { 2081, false, 105, 2, 9 },
                    { 2082, false, 105, 2, 10 },
                    { 2083, false, 105, 2, 11 },
                    { 2084, false, 105, 2, 12 },
                    { 2085, false, 105, 3, 13 },
                    { 2086, false, 105, 3, 14 },
                    { 2087, false, 105, 3, 15 },
                    { 2088, false, 105, 3, 16 },
                    { 2089, false, 105, 3, 17 },
                    { 2090, false, 105, 3, 18 },
                    { 2091, false, 105, 4, 19 },
                    { 2092, false, 105, 4, 20 },
                    { 2093, false, 105, 4, 21 },
                    { 2094, false, 105, 4, 22 },
                    { 2095, false, 105, 4, 23 },
                    { 2096, false, 105, 4, 24 },
                    { 2097, false, 105, 5, 25 },
                    { 2098, false, 105, 5, 26 },
                    { 2099, false, 105, 5, 27 },
                    { 2100, false, 105, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2101, false, 105, 5, 29 },
                    { 2102, false, 105, 5, 30 },
                    { 2103, false, 105, 6, 31 },
                    { 2104, false, 105, 6, 32 },
                    { 2105, false, 105, 6, 33 },
                    { 2106, false, 105, 6, 34 },
                    { 2107, false, 105, 6, 35 },
                    { 2108, false, 105, 6, 36 },
                    { 2109, false, 105, 7, 37 },
                    { 2110, false, 105, 7, 38 },
                    { 2111, false, 105, 7, 39 },
                    { 2112, false, 105, 7, 40 },
                    { 2113, false, 105, 7, 41 },
                    { 2114, false, 105, 7, 42 },
                    { 2115, false, 106, 1, 1 },
                    { 2116, false, 106, 1, 2 },
                    { 2117, false, 106, 1, 3 },
                    { 2118, false, 106, 1, 4 },
                    { 2119, false, 106, 1, 5 },
                    { 2120, false, 106, 1, 6 },
                    { 2121, false, 106, 2, 7 },
                    { 2122, false, 106, 2, 8 },
                    { 2123, false, 106, 2, 9 },
                    { 2124, false, 106, 2, 10 },
                    { 2125, false, 106, 2, 11 },
                    { 2126, false, 106, 2, 12 },
                    { 2127, false, 106, 3, 13 },
                    { 2128, false, 106, 3, 14 },
                    { 2129, false, 106, 3, 15 },
                    { 2130, false, 106, 3, 16 },
                    { 2131, false, 106, 3, 17 },
                    { 2132, false, 106, 3, 18 },
                    { 2133, false, 106, 4, 19 },
                    { 2134, false, 106, 4, 20 },
                    { 2135, false, 106, 4, 21 },
                    { 2136, false, 106, 4, 22 },
                    { 2137, false, 106, 4, 23 },
                    { 2138, false, 106, 4, 24 },
                    { 2139, false, 106, 5, 25 },
                    { 2140, false, 106, 5, 26 },
                    { 2141, false, 106, 5, 27 },
                    { 2142, false, 106, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2143, false, 106, 5, 29 },
                    { 2144, false, 106, 5, 30 },
                    { 2145, false, 106, 6, 31 },
                    { 2146, false, 106, 6, 32 },
                    { 2147, false, 106, 6, 33 },
                    { 2148, false, 106, 6, 34 },
                    { 2149, false, 106, 6, 35 },
                    { 2150, false, 106, 6, 36 },
                    { 2151, false, 106, 7, 37 },
                    { 2152, false, 106, 7, 38 },
                    { 2153, false, 106, 7, 39 },
                    { 2154, false, 106, 7, 40 },
                    { 2155, false, 106, 7, 41 },
                    { 2156, false, 106, 7, 42 },
                    { 2157, false, 111, 1, 1 },
                    { 2158, false, 111, 1, 2 },
                    { 2159, false, 111, 1, 3 },
                    { 2160, false, 111, 1, 4 },
                    { 2161, false, 111, 2, 5 },
                    { 2162, false, 111, 2, 6 },
                    { 2163, false, 111, 2, 7 },
                    { 2164, false, 111, 2, 8 },
                    { 2165, false, 111, 3, 9 },
                    { 2166, false, 111, 3, 10 },
                    { 2167, false, 111, 3, 11 },
                    { 2168, false, 111, 3, 12 },
                    { 2169, false, 111, 4, 13 },
                    { 2170, false, 111, 4, 14 },
                    { 2171, false, 111, 4, 15 },
                    { 2172, false, 111, 4, 16 },
                    { 2173, false, 111, 5, 17 },
                    { 2174, false, 111, 5, 18 },
                    { 2175, false, 111, 5, 19 },
                    { 2176, false, 111, 5, 20 },
                    { 2177, false, 111, 6, 21 },
                    { 2178, false, 111, 6, 22 },
                    { 2179, false, 111, 6, 23 },
                    { 2180, false, 111, 6, 24 },
                    { 2181, false, 111, 7, 25 },
                    { 2182, false, 111, 7, 26 },
                    { 2183, false, 111, 7, 27 },
                    { 2184, false, 111, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2185, false, 112, 1, 1 },
                    { 2186, false, 112, 1, 2 },
                    { 2187, false, 112, 1, 3 },
                    { 2188, false, 112, 1, 4 },
                    { 2189, false, 112, 2, 5 },
                    { 2190, false, 112, 2, 6 },
                    { 2191, false, 112, 2, 7 },
                    { 2192, false, 112, 2, 8 },
                    { 2193, false, 112, 3, 9 },
                    { 2194, false, 112, 3, 10 },
                    { 2195, false, 112, 3, 11 },
                    { 2196, false, 112, 3, 12 },
                    { 2197, false, 112, 4, 13 },
                    { 2198, false, 112, 4, 14 },
                    { 2199, false, 112, 4, 15 },
                    { 2200, false, 112, 4, 16 },
                    { 2201, false, 112, 5, 17 },
                    { 2202, false, 112, 5, 18 },
                    { 2203, false, 112, 5, 19 },
                    { 2204, false, 112, 5, 20 },
                    { 2205, false, 112, 6, 21 },
                    { 2206, false, 112, 6, 22 },
                    { 2207, false, 112, 6, 23 },
                    { 2208, false, 112, 6, 24 },
                    { 2209, false, 112, 7, 25 },
                    { 2210, false, 112, 7, 26 },
                    { 2211, false, 112, 7, 27 },
                    { 2212, false, 112, 7, 28 },
                    { 2213, false, 113, 1, 1 },
                    { 2214, false, 113, 1, 2 },
                    { 2215, false, 113, 1, 3 },
                    { 2216, false, 113, 1, 4 },
                    { 2217, false, 113, 2, 5 },
                    { 2218, false, 113, 2, 6 },
                    { 2219, false, 113, 2, 7 },
                    { 2220, false, 113, 2, 8 },
                    { 2221, false, 113, 3, 9 },
                    { 2222, false, 113, 3, 10 },
                    { 2223, false, 113, 3, 11 },
                    { 2224, false, 113, 3, 12 },
                    { 2225, false, 113, 4, 13 },
                    { 2226, false, 113, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2227, false, 113, 4, 15 },
                    { 2228, false, 113, 4, 16 },
                    { 2229, false, 113, 5, 17 },
                    { 2230, false, 113, 5, 18 },
                    { 2231, false, 113, 5, 19 },
                    { 2232, false, 113, 5, 20 },
                    { 2233, false, 113, 6, 21 },
                    { 2234, false, 113, 6, 22 },
                    { 2235, false, 113, 6, 23 },
                    { 2236, false, 113, 6, 24 },
                    { 2237, false, 113, 7, 25 },
                    { 2238, false, 113, 7, 26 },
                    { 2239, false, 113, 7, 27 },
                    { 2240, false, 113, 7, 28 },
                    { 2241, false, 114, 1, 1 },
                    { 2242, false, 114, 1, 2 },
                    { 2243, false, 114, 1, 3 },
                    { 2244, false, 114, 1, 4 },
                    { 2245, false, 114, 2, 5 },
                    { 2246, false, 114, 2, 6 },
                    { 2247, false, 114, 2, 7 },
                    { 2248, false, 114, 2, 8 },
                    { 2249, false, 114, 3, 9 },
                    { 2250, false, 114, 3, 10 },
                    { 2251, false, 114, 3, 11 },
                    { 2252, false, 114, 3, 12 },
                    { 2253, false, 114, 4, 13 },
                    { 2254, false, 114, 4, 14 },
                    { 2255, false, 114, 4, 15 },
                    { 2256, false, 114, 4, 16 },
                    { 2257, false, 114, 5, 17 },
                    { 2258, false, 114, 5, 18 },
                    { 2259, false, 114, 5, 19 },
                    { 2260, false, 114, 5, 20 },
                    { 2261, false, 114, 6, 21 },
                    { 2262, false, 114, 6, 22 },
                    { 2263, false, 114, 6, 23 },
                    { 2264, false, 114, 6, 24 },
                    { 2265, false, 114, 7, 25 },
                    { 2266, false, 114, 7, 26 },
                    { 2267, false, 114, 7, 27 },
                    { 2268, false, 114, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2269, false, 115, 1, 1 },
                    { 2270, false, 115, 1, 2 },
                    { 2271, false, 115, 1, 3 },
                    { 2272, false, 115, 1, 4 },
                    { 2273, false, 115, 1, 5 },
                    { 2274, false, 115, 1, 6 },
                    { 2275, false, 115, 2, 7 },
                    { 2276, false, 115, 2, 8 },
                    { 2277, false, 115, 2, 9 },
                    { 2278, false, 115, 2, 10 },
                    { 2279, false, 115, 2, 11 },
                    { 2280, false, 115, 2, 12 },
                    { 2281, false, 115, 3, 13 },
                    { 2282, false, 115, 3, 14 },
                    { 2283, false, 115, 3, 15 },
                    { 2284, false, 115, 3, 16 },
                    { 2285, false, 115, 3, 17 },
                    { 2286, false, 115, 3, 18 },
                    { 2287, false, 115, 4, 19 },
                    { 2288, false, 115, 4, 20 },
                    { 2289, false, 115, 4, 21 },
                    { 2290, false, 115, 4, 22 },
                    { 2291, false, 115, 4, 23 },
                    { 2292, false, 115, 4, 24 },
                    { 2293, false, 115, 5, 25 },
                    { 2294, false, 115, 5, 26 },
                    { 2295, false, 115, 5, 27 },
                    { 2296, false, 115, 5, 28 },
                    { 2297, false, 115, 5, 29 },
                    { 2298, false, 115, 5, 30 },
                    { 2299, false, 115, 6, 31 },
                    { 2300, false, 115, 6, 32 },
                    { 2301, false, 115, 6, 33 },
                    { 2302, false, 115, 6, 34 },
                    { 2303, false, 115, 6, 35 },
                    { 2304, false, 115, 6, 36 },
                    { 2305, false, 115, 7, 37 },
                    { 2306, false, 115, 7, 38 },
                    { 2307, false, 115, 7, 39 },
                    { 2308, false, 115, 7, 40 },
                    { 2309, false, 115, 7, 41 },
                    { 2310, false, 115, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2311, false, 116, 1, 1 },
                    { 2312, false, 116, 1, 2 },
                    { 2313, false, 116, 1, 3 },
                    { 2314, false, 116, 1, 4 },
                    { 2315, false, 116, 1, 5 },
                    { 2316, false, 116, 1, 6 },
                    { 2317, false, 116, 2, 7 },
                    { 2318, false, 116, 2, 8 },
                    { 2319, false, 116, 2, 9 },
                    { 2320, false, 116, 2, 10 },
                    { 2321, false, 116, 2, 11 },
                    { 2322, false, 116, 2, 12 },
                    { 2323, false, 116, 3, 13 },
                    { 2324, false, 116, 3, 14 },
                    { 2325, false, 116, 3, 15 },
                    { 2326, false, 116, 3, 16 },
                    { 2327, false, 116, 3, 17 },
                    { 2328, false, 116, 3, 18 },
                    { 2329, false, 116, 4, 19 },
                    { 2330, false, 116, 4, 20 },
                    { 2331, false, 116, 4, 21 },
                    { 2332, false, 116, 4, 22 },
                    { 2333, false, 116, 4, 23 },
                    { 2334, false, 116, 4, 24 },
                    { 2335, false, 116, 5, 25 },
                    { 2336, false, 116, 5, 26 },
                    { 2337, false, 116, 5, 27 },
                    { 2338, false, 116, 5, 28 },
                    { 2339, false, 116, 5, 29 },
                    { 2340, false, 116, 5, 30 },
                    { 2341, false, 116, 6, 31 },
                    { 2342, false, 116, 6, 32 },
                    { 2343, false, 116, 6, 33 },
                    { 2344, false, 116, 6, 34 },
                    { 2345, false, 116, 6, 35 },
                    { 2346, false, 116, 6, 36 },
                    { 2347, false, 116, 7, 37 },
                    { 2348, false, 116, 7, 38 },
                    { 2349, false, 116, 7, 39 },
                    { 2350, false, 116, 7, 40 },
                    { 2351, false, 116, 7, 41 },
                    { 2352, false, 116, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2353, false, 121, 1, 1 },
                    { 2354, false, 121, 1, 2 },
                    { 2355, false, 121, 1, 3 },
                    { 2356, false, 121, 1, 4 },
                    { 2357, false, 121, 2, 5 },
                    { 2358, false, 121, 2, 6 },
                    { 2359, false, 121, 2, 7 },
                    { 2360, false, 121, 2, 8 },
                    { 2361, false, 121, 3, 9 },
                    { 2362, false, 121, 3, 10 },
                    { 2363, false, 121, 3, 11 },
                    { 2364, false, 121, 3, 12 },
                    { 2365, false, 121, 4, 13 },
                    { 2366, false, 121, 4, 14 },
                    { 2367, false, 121, 4, 15 },
                    { 2368, false, 121, 4, 16 },
                    { 2369, false, 121, 5, 17 },
                    { 2370, false, 121, 5, 18 },
                    { 2371, false, 121, 5, 19 },
                    { 2372, false, 121, 5, 20 },
                    { 2373, false, 121, 6, 21 },
                    { 2374, false, 121, 6, 22 },
                    { 2375, false, 121, 6, 23 },
                    { 2376, false, 121, 6, 24 },
                    { 2377, false, 121, 7, 25 },
                    { 2378, false, 121, 7, 26 },
                    { 2379, false, 121, 7, 27 },
                    { 2380, false, 121, 7, 28 },
                    { 2381, false, 122, 1, 1 },
                    { 2382, false, 122, 1, 2 },
                    { 2383, false, 122, 1, 3 },
                    { 2384, false, 122, 1, 4 },
                    { 2385, false, 122, 2, 5 },
                    { 2386, false, 122, 2, 6 },
                    { 2387, false, 122, 2, 7 },
                    { 2388, false, 122, 2, 8 },
                    { 2389, false, 122, 3, 9 },
                    { 2390, false, 122, 3, 10 },
                    { 2391, false, 122, 3, 11 },
                    { 2392, false, 122, 3, 12 },
                    { 2393, false, 122, 4, 13 },
                    { 2394, false, 122, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2395, false, 122, 4, 15 },
                    { 2396, false, 122, 4, 16 },
                    { 2397, false, 122, 5, 17 },
                    { 2398, false, 122, 5, 18 },
                    { 2399, false, 122, 5, 19 },
                    { 2400, false, 122, 5, 20 },
                    { 2401, false, 122, 6, 21 },
                    { 2402, false, 122, 6, 22 },
                    { 2403, false, 122, 6, 23 },
                    { 2404, false, 122, 6, 24 },
                    { 2405, false, 122, 7, 25 },
                    { 2406, false, 122, 7, 26 },
                    { 2407, false, 122, 7, 27 },
                    { 2408, false, 122, 7, 28 },
                    { 2409, false, 123, 1, 1 },
                    { 2410, false, 123, 1, 2 },
                    { 2411, false, 123, 1, 3 },
                    { 2412, false, 123, 1, 4 },
                    { 2413, false, 123, 2, 5 },
                    { 2414, false, 123, 2, 6 },
                    { 2415, false, 123, 2, 7 },
                    { 2416, false, 123, 2, 8 },
                    { 2417, false, 123, 3, 9 },
                    { 2418, false, 123, 3, 10 },
                    { 2419, false, 123, 3, 11 },
                    { 2420, false, 123, 3, 12 },
                    { 2421, false, 123, 4, 13 },
                    { 2422, false, 123, 4, 14 },
                    { 2423, false, 123, 4, 15 },
                    { 2424, false, 123, 4, 16 },
                    { 2425, false, 123, 5, 17 },
                    { 2426, false, 123, 5, 18 },
                    { 2427, false, 123, 5, 19 },
                    { 2428, false, 123, 5, 20 },
                    { 2429, false, 123, 6, 21 },
                    { 2430, false, 123, 6, 22 },
                    { 2431, false, 123, 6, 23 },
                    { 2432, false, 123, 6, 24 },
                    { 2433, false, 123, 7, 25 },
                    { 2434, false, 123, 7, 26 },
                    { 2435, false, 123, 7, 27 },
                    { 2436, false, 123, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2437, false, 124, 1, 1 },
                    { 2438, false, 124, 1, 2 },
                    { 2439, false, 124, 1, 3 },
                    { 2440, false, 124, 1, 4 },
                    { 2441, false, 124, 2, 5 },
                    { 2442, false, 124, 2, 6 },
                    { 2443, false, 124, 2, 7 },
                    { 2444, false, 124, 2, 8 },
                    { 2445, false, 124, 3, 9 },
                    { 2446, false, 124, 3, 10 },
                    { 2447, false, 124, 3, 11 },
                    { 2448, false, 124, 3, 12 },
                    { 2449, false, 124, 4, 13 },
                    { 2450, false, 124, 4, 14 },
                    { 2451, false, 124, 4, 15 },
                    { 2452, false, 124, 4, 16 },
                    { 2453, false, 124, 5, 17 },
                    { 2454, false, 124, 5, 18 },
                    { 2455, false, 124, 5, 19 },
                    { 2456, false, 124, 5, 20 },
                    { 2457, false, 124, 6, 21 },
                    { 2458, false, 124, 6, 22 },
                    { 2459, false, 124, 6, 23 },
                    { 2460, false, 124, 6, 24 },
                    { 2461, false, 124, 7, 25 },
                    { 2462, false, 124, 7, 26 },
                    { 2463, false, 124, 7, 27 },
                    { 2464, false, 124, 7, 28 },
                    { 2465, false, 125, 1, 1 },
                    { 2466, false, 125, 1, 2 },
                    { 2467, false, 125, 1, 3 },
                    { 2468, false, 125, 1, 4 },
                    { 2469, false, 125, 1, 5 },
                    { 2470, false, 125, 1, 6 },
                    { 2471, false, 125, 2, 7 },
                    { 2472, false, 125, 2, 8 },
                    { 2473, false, 125, 2, 9 },
                    { 2474, false, 125, 2, 10 },
                    { 2475, false, 125, 2, 11 },
                    { 2476, false, 125, 2, 12 },
                    { 2477, false, 125, 3, 13 },
                    { 2478, false, 125, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2479, false, 125, 3, 15 },
                    { 2480, false, 125, 3, 16 },
                    { 2481, false, 125, 3, 17 },
                    { 2482, false, 125, 3, 18 },
                    { 2483, false, 125, 4, 19 },
                    { 2484, false, 125, 4, 20 },
                    { 2485, false, 125, 4, 21 },
                    { 2486, false, 125, 4, 22 },
                    { 2487, false, 125, 4, 23 },
                    { 2488, false, 125, 4, 24 },
                    { 2489, false, 125, 5, 25 },
                    { 2490, false, 125, 5, 26 },
                    { 2491, false, 125, 5, 27 },
                    { 2492, false, 125, 5, 28 },
                    { 2493, false, 125, 5, 29 },
                    { 2494, false, 125, 5, 30 },
                    { 2495, false, 125, 6, 31 },
                    { 2496, false, 125, 6, 32 },
                    { 2497, false, 125, 6, 33 },
                    { 2498, false, 125, 6, 34 },
                    { 2499, false, 125, 6, 35 },
                    { 2500, false, 125, 6, 36 },
                    { 2501, false, 125, 7, 37 },
                    { 2502, false, 125, 7, 38 },
                    { 2503, false, 125, 7, 39 },
                    { 2504, false, 125, 7, 40 },
                    { 2505, false, 125, 7, 41 },
                    { 2506, false, 125, 7, 42 },
                    { 2507, false, 126, 1, 1 },
                    { 2508, false, 126, 1, 2 },
                    { 2509, false, 126, 1, 3 },
                    { 2510, false, 126, 1, 4 },
                    { 2511, false, 126, 1, 5 },
                    { 2512, false, 126, 1, 6 },
                    { 2513, false, 126, 2, 7 },
                    { 2514, false, 126, 2, 8 },
                    { 2515, false, 126, 2, 9 },
                    { 2516, false, 126, 2, 10 },
                    { 2517, false, 126, 2, 11 },
                    { 2518, false, 126, 2, 12 },
                    { 2519, false, 126, 3, 13 },
                    { 2520, false, 126, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2521, false, 126, 3, 15 },
                    { 2522, false, 126, 3, 16 },
                    { 2523, false, 126, 3, 17 },
                    { 2524, false, 126, 3, 18 },
                    { 2525, false, 126, 4, 19 },
                    { 2526, false, 126, 4, 20 },
                    { 2527, false, 126, 4, 21 },
                    { 2528, false, 126, 4, 22 },
                    { 2529, false, 126, 4, 23 },
                    { 2530, false, 126, 4, 24 },
                    { 2531, false, 126, 5, 25 },
                    { 2532, false, 126, 5, 26 },
                    { 2533, false, 126, 5, 27 },
                    { 2534, false, 126, 5, 28 },
                    { 2535, false, 126, 5, 29 },
                    { 2536, false, 126, 5, 30 },
                    { 2537, false, 126, 6, 31 },
                    { 2538, false, 126, 6, 32 },
                    { 2539, false, 126, 6, 33 },
                    { 2540, false, 126, 6, 34 },
                    { 2541, false, 126, 6, 35 },
                    { 2542, false, 126, 6, 36 },
                    { 2543, false, 126, 7, 37 },
                    { 2544, false, 126, 7, 38 },
                    { 2545, false, 126, 7, 39 },
                    { 2546, false, 126, 7, 40 },
                    { 2547, false, 126, 7, 41 },
                    { 2548, false, 126, 7, 42 },
                    { 2549, false, 131, 1, 1 },
                    { 2550, false, 131, 1, 2 },
                    { 2551, false, 131, 1, 3 },
                    { 2552, false, 131, 1, 4 },
                    { 2553, false, 131, 2, 5 },
                    { 2554, false, 131, 2, 6 },
                    { 2555, false, 131, 2, 7 },
                    { 2556, false, 131, 2, 8 },
                    { 2557, false, 131, 3, 9 },
                    { 2558, false, 131, 3, 10 },
                    { 2559, false, 131, 3, 11 },
                    { 2560, false, 131, 3, 12 },
                    { 2561, false, 131, 4, 13 },
                    { 2562, false, 131, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2563, false, 131, 4, 15 },
                    { 2564, false, 131, 4, 16 },
                    { 2565, false, 131, 5, 17 },
                    { 2566, false, 131, 5, 18 },
                    { 2567, false, 131, 5, 19 },
                    { 2568, false, 131, 5, 20 },
                    { 2569, false, 131, 6, 21 },
                    { 2570, false, 131, 6, 22 },
                    { 2571, false, 131, 6, 23 },
                    { 2572, false, 131, 6, 24 },
                    { 2573, false, 131, 7, 25 },
                    { 2574, false, 131, 7, 26 },
                    { 2575, false, 131, 7, 27 },
                    { 2576, false, 131, 7, 28 },
                    { 2577, false, 132, 1, 1 },
                    { 2578, false, 132, 1, 2 },
                    { 2579, false, 132, 1, 3 },
                    { 2580, false, 132, 1, 4 },
                    { 2581, false, 132, 2, 5 },
                    { 2582, false, 132, 2, 6 },
                    { 2583, false, 132, 2, 7 },
                    { 2584, false, 132, 2, 8 },
                    { 2585, false, 132, 3, 9 },
                    { 2586, false, 132, 3, 10 },
                    { 2587, false, 132, 3, 11 },
                    { 2588, false, 132, 3, 12 },
                    { 2589, false, 132, 4, 13 },
                    { 2590, false, 132, 4, 14 },
                    { 2591, false, 132, 4, 15 },
                    { 2592, false, 132, 4, 16 },
                    { 2593, false, 132, 5, 17 },
                    { 2594, false, 132, 5, 18 },
                    { 2595, false, 132, 5, 19 },
                    { 2596, false, 132, 5, 20 },
                    { 2597, false, 132, 6, 21 },
                    { 2598, false, 132, 6, 22 },
                    { 2599, false, 132, 6, 23 },
                    { 2600, false, 132, 6, 24 },
                    { 2601, false, 132, 7, 25 },
                    { 2602, false, 132, 7, 26 },
                    { 2603, false, 132, 7, 27 },
                    { 2604, false, 132, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2605, false, 133, 1, 1 },
                    { 2606, false, 133, 1, 2 },
                    { 2607, false, 133, 1, 3 },
                    { 2608, false, 133, 1, 4 },
                    { 2609, false, 133, 2, 5 },
                    { 2610, false, 133, 2, 6 },
                    { 2611, false, 133, 2, 7 },
                    { 2612, false, 133, 2, 8 },
                    { 2613, false, 133, 3, 9 },
                    { 2614, false, 133, 3, 10 },
                    { 2615, false, 133, 3, 11 },
                    { 2616, false, 133, 3, 12 },
                    { 2617, false, 133, 4, 13 },
                    { 2618, false, 133, 4, 14 },
                    { 2619, false, 133, 4, 15 },
                    { 2620, false, 133, 4, 16 },
                    { 2621, false, 133, 5, 17 },
                    { 2622, false, 133, 5, 18 },
                    { 2623, false, 133, 5, 19 },
                    { 2624, false, 133, 5, 20 },
                    { 2625, false, 133, 6, 21 },
                    { 2626, false, 133, 6, 22 },
                    { 2627, false, 133, 6, 23 },
                    { 2628, false, 133, 6, 24 },
                    { 2629, false, 133, 7, 25 },
                    { 2630, false, 133, 7, 26 },
                    { 2631, false, 133, 7, 27 },
                    { 2632, false, 133, 7, 28 },
                    { 2633, false, 134, 1, 1 },
                    { 2634, false, 134, 1, 2 },
                    { 2635, false, 134, 1, 3 },
                    { 2636, false, 134, 1, 4 },
                    { 2637, false, 134, 2, 5 },
                    { 2638, false, 134, 2, 6 },
                    { 2639, false, 134, 2, 7 },
                    { 2640, false, 134, 2, 8 },
                    { 2641, false, 134, 3, 9 },
                    { 2642, false, 134, 3, 10 },
                    { 2643, false, 134, 3, 11 },
                    { 2644, false, 134, 3, 12 },
                    { 2645, false, 134, 4, 13 },
                    { 2646, false, 134, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2647, false, 134, 4, 15 },
                    { 2648, false, 134, 4, 16 },
                    { 2649, false, 134, 5, 17 },
                    { 2650, false, 134, 5, 18 },
                    { 2651, false, 134, 5, 19 },
                    { 2652, false, 134, 5, 20 },
                    { 2653, false, 134, 6, 21 },
                    { 2654, false, 134, 6, 22 },
                    { 2655, false, 134, 6, 23 },
                    { 2656, false, 134, 6, 24 },
                    { 2657, false, 134, 7, 25 },
                    { 2658, false, 134, 7, 26 },
                    { 2659, false, 134, 7, 27 },
                    { 2660, false, 134, 7, 28 },
                    { 2661, false, 135, 1, 1 },
                    { 2662, false, 135, 1, 2 },
                    { 2663, false, 135, 1, 3 },
                    { 2664, false, 135, 1, 4 },
                    { 2665, false, 135, 1, 5 },
                    { 2666, false, 135, 1, 6 },
                    { 2667, false, 135, 2, 7 },
                    { 2668, false, 135, 2, 8 },
                    { 2669, false, 135, 2, 9 },
                    { 2670, false, 135, 2, 10 },
                    { 2671, false, 135, 2, 11 },
                    { 2672, false, 135, 2, 12 },
                    { 2673, false, 135, 3, 13 },
                    { 2674, false, 135, 3, 14 },
                    { 2675, false, 135, 3, 15 },
                    { 2676, false, 135, 3, 16 },
                    { 2677, false, 135, 3, 17 },
                    { 2678, false, 135, 3, 18 },
                    { 2679, false, 135, 4, 19 },
                    { 2680, false, 135, 4, 20 },
                    { 2681, false, 135, 4, 21 },
                    { 2682, false, 135, 4, 22 },
                    { 2683, false, 135, 4, 23 },
                    { 2684, false, 135, 4, 24 },
                    { 2685, false, 135, 5, 25 },
                    { 2686, false, 135, 5, 26 },
                    { 2687, false, 135, 5, 27 },
                    { 2688, false, 135, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2689, false, 135, 5, 29 },
                    { 2690, false, 135, 5, 30 },
                    { 2691, false, 135, 6, 31 },
                    { 2692, false, 135, 6, 32 },
                    { 2693, false, 135, 6, 33 },
                    { 2694, false, 135, 6, 34 },
                    { 2695, false, 135, 6, 35 },
                    { 2696, false, 135, 6, 36 },
                    { 2697, false, 135, 7, 37 },
                    { 2698, false, 135, 7, 38 },
                    { 2699, false, 135, 7, 39 },
                    { 2700, false, 135, 7, 40 },
                    { 2701, false, 135, 7, 41 },
                    { 2702, false, 135, 7, 42 },
                    { 2703, false, 136, 1, 1 },
                    { 2704, false, 136, 1, 2 },
                    { 2705, false, 136, 1, 3 },
                    { 2706, false, 136, 1, 4 },
                    { 2707, false, 136, 1, 5 },
                    { 2708, false, 136, 1, 6 },
                    { 2709, false, 136, 2, 7 },
                    { 2710, false, 136, 2, 8 },
                    { 2711, false, 136, 2, 9 },
                    { 2712, false, 136, 2, 10 },
                    { 2713, false, 136, 2, 11 },
                    { 2714, false, 136, 2, 12 },
                    { 2715, false, 136, 3, 13 },
                    { 2716, false, 136, 3, 14 },
                    { 2717, false, 136, 3, 15 },
                    { 2718, false, 136, 3, 16 },
                    { 2719, false, 136, 3, 17 },
                    { 2720, false, 136, 3, 18 },
                    { 2721, false, 136, 4, 19 },
                    { 2722, false, 136, 4, 20 },
                    { 2723, false, 136, 4, 21 },
                    { 2724, false, 136, 4, 22 },
                    { 2725, false, 136, 4, 23 },
                    { 2726, false, 136, 4, 24 },
                    { 2727, false, 136, 5, 25 },
                    { 2728, false, 136, 5, 26 },
                    { 2729, false, 136, 5, 27 },
                    { 2730, false, 136, 5, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2731, false, 136, 5, 29 },
                    { 2732, false, 136, 5, 30 },
                    { 2733, false, 136, 6, 31 },
                    { 2734, false, 136, 6, 32 },
                    { 2735, false, 136, 6, 33 },
                    { 2736, false, 136, 6, 34 },
                    { 2737, false, 136, 6, 35 },
                    { 2738, false, 136, 6, 36 },
                    { 2739, false, 136, 7, 37 },
                    { 2740, false, 136, 7, 38 },
                    { 2741, false, 136, 7, 39 },
                    { 2742, false, 136, 7, 40 },
                    { 2743, false, 136, 7, 41 },
                    { 2744, false, 136, 7, 42 },
                    { 2745, false, 141, 1, 1 },
                    { 2746, false, 141, 1, 2 },
                    { 2747, false, 141, 1, 3 },
                    { 2748, false, 141, 1, 4 },
                    { 2749, false, 141, 2, 5 },
                    { 2750, false, 141, 2, 6 },
                    { 2751, false, 141, 2, 7 },
                    { 2752, false, 141, 2, 8 },
                    { 2753, false, 141, 3, 9 },
                    { 2754, false, 141, 3, 10 },
                    { 2755, false, 141, 3, 11 },
                    { 2756, false, 141, 3, 12 },
                    { 2757, false, 141, 4, 13 },
                    { 2758, false, 141, 4, 14 },
                    { 2759, false, 141, 4, 15 },
                    { 2760, false, 141, 4, 16 },
                    { 2761, false, 141, 5, 17 },
                    { 2762, false, 141, 5, 18 },
                    { 2763, false, 141, 5, 19 },
                    { 2764, false, 141, 5, 20 },
                    { 2765, false, 141, 6, 21 },
                    { 2766, false, 141, 6, 22 },
                    { 2767, false, 141, 6, 23 },
                    { 2768, false, 141, 6, 24 },
                    { 2769, false, 141, 7, 25 },
                    { 2770, false, 141, 7, 26 },
                    { 2771, false, 141, 7, 27 },
                    { 2772, false, 141, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2773, false, 142, 1, 1 },
                    { 2774, false, 142, 1, 2 },
                    { 2775, false, 142, 1, 3 },
                    { 2776, false, 142, 1, 4 },
                    { 2777, false, 142, 2, 5 },
                    { 2778, false, 142, 2, 6 },
                    { 2779, false, 142, 2, 7 },
                    { 2780, false, 142, 2, 8 },
                    { 2781, false, 142, 3, 9 },
                    { 2782, false, 142, 3, 10 },
                    { 2783, false, 142, 3, 11 },
                    { 2784, false, 142, 3, 12 },
                    { 2785, false, 142, 4, 13 },
                    { 2786, false, 142, 4, 14 },
                    { 2787, false, 142, 4, 15 },
                    { 2788, false, 142, 4, 16 },
                    { 2789, false, 142, 5, 17 },
                    { 2790, false, 142, 5, 18 },
                    { 2791, false, 142, 5, 19 },
                    { 2792, false, 142, 5, 20 },
                    { 2793, false, 142, 6, 21 },
                    { 2794, false, 142, 6, 22 },
                    { 2795, false, 142, 6, 23 },
                    { 2796, false, 142, 6, 24 },
                    { 2797, false, 142, 7, 25 },
                    { 2798, false, 142, 7, 26 },
                    { 2799, false, 142, 7, 27 },
                    { 2800, false, 142, 7, 28 },
                    { 2801, false, 143, 1, 1 },
                    { 2802, false, 143, 1, 2 },
                    { 2803, false, 143, 1, 3 },
                    { 2804, false, 143, 1, 4 },
                    { 2805, false, 143, 2, 5 },
                    { 2806, false, 143, 2, 6 },
                    { 2807, false, 143, 2, 7 },
                    { 2808, false, 143, 2, 8 },
                    { 2809, false, 143, 3, 9 },
                    { 2810, false, 143, 3, 10 },
                    { 2811, false, 143, 3, 11 },
                    { 2812, false, 143, 3, 12 },
                    { 2813, false, 143, 4, 13 },
                    { 2814, false, 143, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2815, false, 143, 4, 15 },
                    { 2816, false, 143, 4, 16 },
                    { 2817, false, 143, 5, 17 },
                    { 2818, false, 143, 5, 18 },
                    { 2819, false, 143, 5, 19 },
                    { 2820, false, 143, 5, 20 },
                    { 2821, false, 143, 6, 21 },
                    { 2822, false, 143, 6, 22 },
                    { 2823, false, 143, 6, 23 },
                    { 2824, false, 143, 6, 24 },
                    { 2825, false, 143, 7, 25 },
                    { 2826, false, 143, 7, 26 },
                    { 2827, false, 143, 7, 27 },
                    { 2828, false, 143, 7, 28 },
                    { 2829, false, 144, 1, 1 },
                    { 2830, false, 144, 1, 2 },
                    { 2831, false, 144, 1, 3 },
                    { 2832, false, 144, 1, 4 },
                    { 2833, false, 144, 2, 5 },
                    { 2834, false, 144, 2, 6 },
                    { 2835, false, 144, 2, 7 },
                    { 2836, false, 144, 2, 8 },
                    { 2837, false, 144, 3, 9 },
                    { 2838, false, 144, 3, 10 },
                    { 2839, false, 144, 3, 11 },
                    { 2840, false, 144, 3, 12 },
                    { 2841, false, 144, 4, 13 },
                    { 2842, false, 144, 4, 14 },
                    { 2843, false, 144, 4, 15 },
                    { 2844, false, 144, 4, 16 },
                    { 2845, false, 144, 5, 17 },
                    { 2846, false, 144, 5, 18 },
                    { 2847, false, 144, 5, 19 },
                    { 2848, false, 144, 5, 20 },
                    { 2849, false, 144, 6, 21 },
                    { 2850, false, 144, 6, 22 },
                    { 2851, false, 144, 6, 23 },
                    { 2852, false, 144, 6, 24 },
                    { 2853, false, 144, 7, 25 },
                    { 2854, false, 144, 7, 26 },
                    { 2855, false, 144, 7, 27 },
                    { 2856, false, 144, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2857, false, 145, 1, 1 },
                    { 2858, false, 145, 1, 2 },
                    { 2859, false, 145, 1, 3 },
                    { 2860, false, 145, 1, 4 },
                    { 2861, false, 145, 1, 5 },
                    { 2862, false, 145, 1, 6 },
                    { 2863, false, 145, 2, 7 },
                    { 2864, false, 145, 2, 8 },
                    { 2865, false, 145, 2, 9 },
                    { 2866, false, 145, 2, 10 },
                    { 2867, false, 145, 2, 11 },
                    { 2868, false, 145, 2, 12 },
                    { 2869, false, 145, 3, 13 },
                    { 2870, false, 145, 3, 14 },
                    { 2871, false, 145, 3, 15 },
                    { 2872, false, 145, 3, 16 },
                    { 2873, false, 145, 3, 17 },
                    { 2874, false, 145, 3, 18 },
                    { 2875, false, 145, 4, 19 },
                    { 2876, false, 145, 4, 20 },
                    { 2877, false, 145, 4, 21 },
                    { 2878, false, 145, 4, 22 },
                    { 2879, false, 145, 4, 23 },
                    { 2880, false, 145, 4, 24 },
                    { 2881, false, 145, 5, 25 },
                    { 2882, false, 145, 5, 26 },
                    { 2883, false, 145, 5, 27 },
                    { 2884, false, 145, 5, 28 },
                    { 2885, false, 145, 5, 29 },
                    { 2886, false, 145, 5, 30 },
                    { 2887, false, 145, 6, 31 },
                    { 2888, false, 145, 6, 32 },
                    { 2889, false, 145, 6, 33 },
                    { 2890, false, 145, 6, 34 },
                    { 2891, false, 145, 6, 35 },
                    { 2892, false, 145, 6, 36 },
                    { 2893, false, 145, 7, 37 },
                    { 2894, false, 145, 7, 38 },
                    { 2895, false, 145, 7, 39 },
                    { 2896, false, 145, 7, 40 },
                    { 2897, false, 145, 7, 41 },
                    { 2898, false, 145, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2899, false, 146, 1, 1 },
                    { 2900, false, 146, 1, 2 },
                    { 2901, false, 146, 1, 3 },
                    { 2902, false, 146, 1, 4 },
                    { 2903, false, 146, 1, 5 },
                    { 2904, false, 146, 1, 6 },
                    { 2905, false, 146, 2, 7 },
                    { 2906, false, 146, 2, 8 },
                    { 2907, false, 146, 2, 9 },
                    { 2908, false, 146, 2, 10 },
                    { 2909, false, 146, 2, 11 },
                    { 2910, false, 146, 2, 12 },
                    { 2911, false, 146, 3, 13 },
                    { 2912, false, 146, 3, 14 },
                    { 2913, false, 146, 3, 15 },
                    { 2914, false, 146, 3, 16 },
                    { 2915, false, 146, 3, 17 },
                    { 2916, false, 146, 3, 18 },
                    { 2917, false, 146, 4, 19 },
                    { 2918, false, 146, 4, 20 },
                    { 2919, false, 146, 4, 21 },
                    { 2920, false, 146, 4, 22 },
                    { 2921, false, 146, 4, 23 },
                    { 2922, false, 146, 4, 24 },
                    { 2923, false, 146, 5, 25 },
                    { 2924, false, 146, 5, 26 },
                    { 2925, false, 146, 5, 27 },
                    { 2926, false, 146, 5, 28 },
                    { 2927, false, 146, 5, 29 },
                    { 2928, false, 146, 5, 30 },
                    { 2929, false, 146, 6, 31 },
                    { 2930, false, 146, 6, 32 },
                    { 2931, false, 146, 6, 33 },
                    { 2932, false, 146, 6, 34 },
                    { 2933, false, 146, 6, 35 },
                    { 2934, false, 146, 6, 36 },
                    { 2935, false, 146, 7, 37 },
                    { 2936, false, 146, 7, 38 },
                    { 2937, false, 146, 7, 39 },
                    { 2938, false, 146, 7, 40 },
                    { 2939, false, 146, 7, 41 },
                    { 2940, false, 146, 7, 42 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2941, false, 151, 1, 1 },
                    { 2942, false, 151, 1, 2 },
                    { 2943, false, 151, 1, 3 },
                    { 2944, false, 151, 1, 4 },
                    { 2945, false, 151, 2, 5 },
                    { 2946, false, 151, 2, 6 },
                    { 2947, false, 151, 2, 7 },
                    { 2948, false, 151, 2, 8 },
                    { 2949, false, 151, 3, 9 },
                    { 2950, false, 151, 3, 10 },
                    { 2951, false, 151, 3, 11 },
                    { 2952, false, 151, 3, 12 },
                    { 2953, false, 151, 4, 13 },
                    { 2954, false, 151, 4, 14 },
                    { 2955, false, 151, 4, 15 },
                    { 2956, false, 151, 4, 16 },
                    { 2957, false, 151, 5, 17 },
                    { 2958, false, 151, 5, 18 },
                    { 2959, false, 151, 5, 19 },
                    { 2960, false, 151, 5, 20 },
                    { 2961, false, 151, 6, 21 },
                    { 2962, false, 151, 6, 22 },
                    { 2963, false, 151, 6, 23 },
                    { 2964, false, 151, 6, 24 },
                    { 2965, false, 151, 7, 25 },
                    { 2966, false, 151, 7, 26 },
                    { 2967, false, 151, 7, 27 },
                    { 2968, false, 151, 7, 28 },
                    { 2969, false, 152, 1, 1 },
                    { 2970, false, 152, 1, 2 },
                    { 2971, false, 152, 1, 3 },
                    { 2972, false, 152, 1, 4 },
                    { 2973, false, 152, 2, 5 },
                    { 2974, false, 152, 2, 6 },
                    { 2975, false, 152, 2, 7 },
                    { 2976, false, 152, 2, 8 },
                    { 2977, false, 152, 3, 9 },
                    { 2978, false, 152, 3, 10 },
                    { 2979, false, 152, 3, 11 },
                    { 2980, false, 152, 3, 12 },
                    { 2981, false, 152, 4, 13 },
                    { 2982, false, 152, 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2983, false, 152, 4, 15 },
                    { 2984, false, 152, 4, 16 },
                    { 2985, false, 152, 5, 17 },
                    { 2986, false, 152, 5, 18 },
                    { 2987, false, 152, 5, 19 },
                    { 2988, false, 152, 5, 20 },
                    { 2989, false, 152, 6, 21 },
                    { 2990, false, 152, 6, 22 },
                    { 2991, false, 152, 6, 23 },
                    { 2992, false, 152, 6, 24 },
                    { 2993, false, 152, 7, 25 },
                    { 2994, false, 152, 7, 26 },
                    { 2995, false, 152, 7, 27 },
                    { 2996, false, 152, 7, 28 },
                    { 2997, false, 153, 1, 1 },
                    { 2998, false, 153, 1, 2 },
                    { 2999, false, 153, 1, 3 },
                    { 3000, false, 153, 1, 4 },
                    { 3001, false, 153, 2, 5 },
                    { 3002, false, 153, 2, 6 },
                    { 3003, false, 153, 2, 7 },
                    { 3004, false, 153, 2, 8 },
                    { 3005, false, 153, 3, 9 },
                    { 3006, false, 153, 3, 10 },
                    { 3007, false, 153, 3, 11 },
                    { 3008, false, 153, 3, 12 },
                    { 3009, false, 153, 4, 13 },
                    { 3010, false, 153, 4, 14 },
                    { 3011, false, 153, 4, 15 },
                    { 3012, false, 153, 4, 16 },
                    { 3013, false, 153, 5, 17 },
                    { 3014, false, 153, 5, 18 },
                    { 3015, false, 153, 5, 19 },
                    { 3016, false, 153, 5, 20 },
                    { 3017, false, 153, 6, 21 },
                    { 3018, false, 153, 6, 22 },
                    { 3019, false, 153, 6, 23 },
                    { 3020, false, 153, 6, 24 },
                    { 3021, false, 153, 7, 25 },
                    { 3022, false, 153, 7, 26 },
                    { 3023, false, 153, 7, 27 },
                    { 3024, false, 153, 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 3025, false, 154, 1, 1 },
                    { 3026, false, 154, 1, 2 },
                    { 3027, false, 154, 1, 3 },
                    { 3028, false, 154, 1, 4 },
                    { 3029, false, 154, 2, 5 },
                    { 3030, false, 154, 2, 6 },
                    { 3031, false, 154, 2, 7 },
                    { 3032, false, 154, 2, 8 },
                    { 3033, false, 154, 3, 9 },
                    { 3034, false, 154, 3, 10 },
                    { 3035, false, 154, 3, 11 },
                    { 3036, false, 154, 3, 12 },
                    { 3037, false, 154, 4, 13 },
                    { 3038, false, 154, 4, 14 },
                    { 3039, false, 154, 4, 15 },
                    { 3040, false, 154, 4, 16 },
                    { 3041, false, 154, 5, 17 },
                    { 3042, false, 154, 5, 18 },
                    { 3043, false, 154, 5, 19 },
                    { 3044, false, 154, 5, 20 },
                    { 3045, false, 154, 6, 21 },
                    { 3046, false, 154, 6, 22 },
                    { 3047, false, 154, 6, 23 },
                    { 3048, false, 154, 6, 24 },
                    { 3049, false, 154, 7, 25 },
                    { 3050, false, 154, 7, 26 },
                    { 3051, false, 154, 7, 27 },
                    { 3052, false, 154, 7, 28 },
                    { 3053, false, 155, 1, 1 },
                    { 3054, false, 155, 1, 2 },
                    { 3055, false, 155, 1, 3 },
                    { 3056, false, 155, 1, 4 },
                    { 3057, false, 155, 1, 5 },
                    { 3058, false, 155, 1, 6 },
                    { 3059, false, 155, 2, 7 },
                    { 3060, false, 155, 2, 8 },
                    { 3061, false, 155, 2, 9 },
                    { 3062, false, 155, 2, 10 },
                    { 3063, false, 155, 2, 11 },
                    { 3064, false, 155, 2, 12 },
                    { 3065, false, 155, 3, 13 },
                    { 3066, false, 155, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 3067, false, 155, 3, 15 },
                    { 3068, false, 155, 3, 16 },
                    { 3069, false, 155, 3, 17 },
                    { 3070, false, 155, 3, 18 },
                    { 3071, false, 155, 4, 19 },
                    { 3072, false, 155, 4, 20 },
                    { 3073, false, 155, 4, 21 },
                    { 3074, false, 155, 4, 22 },
                    { 3075, false, 155, 4, 23 },
                    { 3076, false, 155, 4, 24 },
                    { 3077, false, 155, 5, 25 },
                    { 3078, false, 155, 5, 26 },
                    { 3079, false, 155, 5, 27 },
                    { 3080, false, 155, 5, 28 },
                    { 3081, false, 155, 5, 29 },
                    { 3082, false, 155, 5, 30 },
                    { 3083, false, 155, 6, 31 },
                    { 3084, false, 155, 6, 32 },
                    { 3085, false, 155, 6, 33 },
                    { 3086, false, 155, 6, 34 },
                    { 3087, false, 155, 6, 35 },
                    { 3088, false, 155, 6, 36 },
                    { 3089, false, 155, 7, 37 },
                    { 3090, false, 155, 7, 38 },
                    { 3091, false, 155, 7, 39 },
                    { 3092, false, 155, 7, 40 },
                    { 3093, false, 155, 7, 41 },
                    { 3094, false, 155, 7, 42 },
                    { 3095, false, 156, 1, 1 },
                    { 3096, false, 156, 1, 2 },
                    { 3097, false, 156, 1, 3 },
                    { 3098, false, 156, 1, 4 },
                    { 3099, false, 156, 1, 5 },
                    { 3100, false, 156, 1, 6 },
                    { 3101, false, 156, 2, 7 },
                    { 3102, false, 156, 2, 8 },
                    { 3103, false, 156, 2, 9 },
                    { 3104, false, 156, 2, 10 },
                    { 3105, false, 156, 2, 11 },
                    { 3106, false, 156, 2, 12 },
                    { 3107, false, 156, 3, 13 },
                    { 3108, false, 156, 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 3109, false, 156, 3, 15 },
                    { 3110, false, 156, 3, 16 },
                    { 3111, false, 156, 3, 17 },
                    { 3112, false, 156, 3, 18 },
                    { 3113, false, 156, 4, 19 },
                    { 3114, false, 156, 4, 20 },
                    { 3115, false, 156, 4, 21 },
                    { 3116, false, 156, 4, 22 },
                    { 3117, false, 156, 4, 23 },
                    { 3118, false, 156, 4, 24 },
                    { 3119, false, 156, 5, 25 },
                    { 3120, false, 156, 5, 26 },
                    { 3121, false, 156, 5, 27 },
                    { 3122, false, 156, 5, 28 },
                    { 3123, false, 156, 5, 29 },
                    { 3124, false, 156, 5, 30 },
                    { 3125, false, 156, 6, 31 },
                    { 3126, false, 156, 6, 32 },
                    { 3127, false, 156, 6, 33 },
                    { 3128, false, 156, 6, 34 },
                    { 3129, false, 156, 6, 35 },
                    { 3130, false, 156, 6, 36 },
                    { 3131, false, 156, 7, 37 },
                    { 3132, false, 156, 7, 38 },
                    { 3133, false, 156, 7, 39 },
                    { 3134, false, 156, 7, 40 },
                    { 3135, false, 156, 7, 41 },
                    { 3136, false, 156, 7, 42 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_BookingId",
                table: "BookingDetails",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_SeatId",
                table: "BookingDetails",
                column: "SeatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cancellings_PNRNo",
                table: "Cancellings",
                column: "PNRNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cancellings_RefundRuleId",
                table: "Cancellings",
                column: "RefundRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Cancellings_UserId",
                table: "Cancellings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_ClassCode",
                table: "Coaches",
                column: "ClassCode");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_TrainCode",
                table: "Coaches",
                column: "TrainCode");

            migrationBuilder.CreateIndex(
                name: "IX_Fares_ClassCode",
                table: "Fares",
                column: "ClassCode");

            migrationBuilder.CreateIndex(
                name: "IX_Fares_RouteId",
                table: "Fares",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Fares_TrainTypeCode",
                table: "Fares",
                column: "TrainTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_PassengerTypeCode",
                table: "Passengers",
                column: "PassengerTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_UserId",
                table: "Passengers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerTypes_TypeCode",
                table: "PassengerTypes",
                column: "TypeCode");

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
                name: "IX_RouteDetails_ArrivalStationId",
                table: "RouteDetails",
                column: "ArrivalStationId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteDetails_DepartureStationId",
                table: "RouteDetails",
                column: "DepartureStationId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteDetails_RouteId",
                table: "RouteDetails",
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
                name: "IX_Seat_CoachId",
                table: "Seat",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BookingDetailId",
                table: "Tickets",
                column: "BookingDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FareId",
                table: "Tickets",
                column: "FareId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PassengerID",
                table: "Tickets",
                column: "PassengerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScheduleId",
                table: "Tickets",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Trains_TypeCode",
                table: "Trains",
                column: "TypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BookingId",
                table: "Transactions",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CancellingId",
                table: "Transactions",
                column: "CancellingId");

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
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "RouteDetails");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Cancellings");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "RefundRules");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "BookingDetails");

            migrationBuilder.DropTable(
                name: "Fares");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "PassengerTypes");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "CoachClasses");

            migrationBuilder.DropTable(
                name: "Trains");

            migrationBuilder.DropTable(
                name: "TrainTypes");
        }
    }
}
