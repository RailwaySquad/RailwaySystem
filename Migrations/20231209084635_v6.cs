using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railway_Group01.Migrations
{
    public partial class v6 : Migration
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
                name: "PassengerTypes",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerTypes", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "RefundRules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidFrom = table.Column<int>(type: "int", nullable: false),
                    ValidTo = table.Column<int>(type: "int", nullable: false),
                    RefundAmount = table.Column<int>(type: "int", nullable: false),
                    RefundFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    NameOfDivision = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Passengers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeCode = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Passengers_PassengerTypes_TypeCode",
                        column: x => x.TypeCode,
                        principalTable: "PassengerTypes",
                        principalColumn: "Code");
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    ClassCode = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    TypeCode = table.Column<string>(type: "nvarchar(10)", nullable: true)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fares_TrainTypes_TypeCode",
                        column: x => x.TypeCode,
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
                name: "Seats",
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
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Coaches_CoachId",
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
                    ScheduleId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_BookingDetails_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingDetails_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleSeat",
                columns: table => new
                {
                    ListOfBookedSeatIdId = table.Column<int>(type: "int", nullable: false),
                    SchedulesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleSeat", x => new { x.ListOfBookedSeatIdId, x.SchedulesId });
                    table.ForeignKey(
                        name: "FK_ScheduleSeat_Schedules_SchedulesId",
                        column: x => x.SchedulesId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleSeat_Seats_ListOfBookedSeatIdId",
                        column: x => x.ListOfBookedSeatIdId,
                        principalTable: "Seats",
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                table: "PassengerTypes",
                columns: new[] { "Code", "Discount", "Name" },
                values: new object[,]
                {
                    { "AD", 0, "Adult" },
                    { "CH", 50, "Child" },
                    { "ED", 10, "Elderly " },
                    { "ST", 10, "Student" }
                });

            migrationBuilder.InsertData(
                table: "RefundRules",
                columns: new[] { "Id", "RefundAmount", "RefundFee", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, 100, 1m, 0, 24 },
                    { 2, 90, 0m, 24, 4 },
                    { 3, 0, 0m, 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Code", "Name", "NameOfDivision", "ZipCode", "Zone" },
                values: new object[,]
                {
                    { 1, "SGO", "Sai Gon", "Ho Chi Minh City", 0, 4 },
                    { 2, "BHO", "Bien Hoa", "Dong Nai Province", 0, 4 },
                    { 3, "LKA", "Long Khanh", "Dong Nai Province", 0, 4 },
                    { 4, "SKI", "Suoi Kiet", "Nam Binh Thuan Province", 0, 3 },
                    { 5, "SKI", "Binh Thuan", "Binh Thuan Province", 0, 3 },
                    { 6, "MLA", "Ma Lam", "Bac Binh Thuan Province", 0, 3 },
                    { 7, "SMA", "Song Mao", "Bac Binh Thuan Province", 0, 3 },
                    { 8, "TCH", "Thap Cham", "Cam Ranh Province", 0, 3 },
                    { 9, "NBA", "Nga Ba", "Binh Thuan Province", 0, 3 },
                    { 10, "NTR", "Nha Trang", "Khanh Hoa Province", 0, 3 },
                    { 11, "NHO", "Ninh Hoa", "Khanh Hoa Province", 0, 3 },
                    { 12, "VGI", "Van Gia", "Khanh Hoa Province", 0, 3 },
                    { 13, "TYH", "Tuy Hoa", "Phu Yen Province", 0, 3 },
                    { 14, "DTR", "Dieu Tri", "Binh Dinh Province", 0, 3 },
                    { 15, "BSO", "Bong Son", "Binh Dinh Province", 0, 3 },
                    { 16, "DPH", "Duc Pho", "Quang Ngai Province", 0, 3 },
                    { 17, "QNG", "Quang Ngai", "Quang Ngai Province", 0, 3 },
                    { 18, "NTH", "Nui Thanh", "Quang Nam Province", 0, 3 },
                    { 19, "TKY", "Tam Ky", "Quang Nam Province", 0, 3 },
                    { 20, "PCA", "Phu Cang", "Quang Nam Province", 0, 3 },
                    { 21, "TKI", "Tra Kieu", "Quang Nam Province", 0, 3 },
                    { 22, "DNA", "Da Nang", "Quang Nam Province", 0, 3 },
                    { 23, "LCO", "Lang Co", "Thua Thien Hue Province", 0, 2 },
                    { 24, "HUE", "Hue", "Thua Thien Hue Province", 0, 2 },
                    { 25, "DHA", "Dong Ha", "Quang Tri Province", 0, 2 },
                    { 26, "DHO", "Dong Hoi", "Quang Binh Province", 0, 2 },
                    { 27, "DLE", "Dong Le", "Quang Binh Province", 0, 2 },
                    { 28, "HPH", "Huong Pho", "Ha Tinh Province", 0, 2 },
                    { 29, "YTR", "Yen Trung", "Ha Tinh Province", 0, 2 },
                    { 30, "VIN", "Vinh", "Nghe An Province", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Code", "Name", "NameOfDivision", "ZipCode", "Zone" },
                values: new object[,]
                {
                    { 31, "CSY", "Cho Sy", "Nghe An Province", 0, 1 },
                    { 32, "MKO", "Minh Khoi", "Nghe An Province", 0, 1 },
                    { 33, "THO", "Thanh Hoa", "Thanh Hoa Province", 0, 1 },
                    { 34, "BIS", "Bim Son", "Thanh Hoa Province", 0, 1 },
                    { 35, "NBI", "Ninh Binh", "Ninh Binh Province", 0, 1 },
                    { 36, "NDI", "Nam Dinh", "Nam Dinh Province", 0, 1 },
                    { 37, "PLY", "Phu Ly", "Ha Nam Province", 0, 1 },
                    { 38, "HNO", "Ha Noi", "Hanoi Capital", 0, 1 }
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
                table: "Routes",
                columns: new[] { "Id", "Distance", "EndStationId", "StartStationId" },
                values: new object[,]
                {
                    { 1, 1726, 38, 1 },
                    { 2, 1726, 1, 38 },
                    { 3, 1726, 38, 1 },
                    { 4, 1726, 1, 38 },
                    { 5, 1726, 38, 1 },
                    { 6, 1726, 1, 38 }
                });

            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "Code", "IsRunning", "TypeCode" },
                values: new object[,]
                {
                    { "SE1", false, "F" },
                    { "SE2", false, "F" },
                    { "SE3", false, "SF" },
                    { "SE4", false, "SF" },
                    { "SE5", false, "S" },
                    { "SE6", false, "S" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "ClassCode", "CoachNo", "NoOfCompartments", "NoOfSeats", "TrainCode" },
                values: new object[,]
                {
                    { 1, "AC1", 1, 7, 28, "SE1" },
                    { 2, "AC1", 2, 7, 28, "SE1" },
                    { 3, "AC2", 3, 7, 28, "SE1" },
                    { 4, "AC2", 4, 7, 28, "SE1" },
                    { 5, "AC3", 5, 7, 42, "SE1" },
                    { 6, "AC3", 6, 7, 42, "SE1" },
                    { 7, "SL", 7, 0, 32, "SE1" },
                    { 8, "SL", 8, 0, 32, "SE1" },
                    { 9, "GE", 9, 0, 62, "SE1" },
                    { 10, "GE", 10, 0, 62, "SE1" },
                    { 11, "AC1", 1, 7, 28, "SE2" },
                    { 12, "AC1", 2, 7, 28, "SE2" },
                    { 13, "AC2", 3, 7, 28, "SE2" },
                    { 14, "AC2", 4, 7, 28, "SE2" },
                    { 15, "AC3", 5, 7, 42, "SE2" },
                    { 16, "AC3", 6, 7, 42, "SE2" },
                    { 17, "SL", 7, 0, 32, "SE2" },
                    { 18, "SL", 8, 0, 32, "SE2" },
                    { 19, "GE", 9, 0, 62, "SE2" },
                    { 20, "GE", 10, 0, 62, "SE2" },
                    { 21, "AC1", 1, 7, 28, "SE3" },
                    { 22, "AC1", 2, 7, 28, "SE3" },
                    { 23, "AC2", 3, 7, 28, "SE3" },
                    { 24, "AC2", 4, 7, 28, "SE3" },
                    { 25, "AC3", 5, 7, 42, "SE3" },
                    { 26, "AC3", 6, 7, 42, "SE3" },
                    { 27, "SL", 7, 0, 32, "SE3" },
                    { 28, "SL", 8, 0, 32, "SE3" },
                    { 29, "GE", 9, 0, 62, "SE3" },
                    { 30, "GE", 10, 0, 62, "SE3" },
                    { 31, "AC1", 1, 7, 28, "SE4" },
                    { 32, "AC1", 2, 7, 28, "SE4" },
                    { 33, "AC2", 3, 7, 28, "SE4" },
                    { 34, "AC2", 4, 7, 28, "SE4" },
                    { 35, "AC3", 5, 7, 42, "SE4" },
                    { 36, "AC3", 6, 7, 42, "SE4" },
                    { 37, "SL", 7, 0, 32, "SE4" },
                    { 38, "SL", 8, 0, 32, "SE4" },
                    { 39, "GE", 9, 0, 62, "SE4" },
                    { 40, "GE", 10, 0, 62, "SE4" },
                    { 41, "AC1", 1, 7, 28, "SE5" },
                    { 42, "AC1", 2, 7, 28, "SE5" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "ClassCode", "CoachNo", "NoOfCompartments", "NoOfSeats", "TrainCode" },
                values: new object[,]
                {
                    { 43, "AC2", 3, 7, 28, "SE5" },
                    { 44, "AC2", 4, 7, 28, "SE5" },
                    { 45, "AC3", 5, 7, 42, "SE5" },
                    { 46, "AC3", 6, 7, 42, "SE5" },
                    { 47, "SL", 7, 0, 32, "SE5" },
                    { 48, "SL", 8, 0, 32, "SE5" },
                    { 49, "GE", 9, 0, 62, "SE5" },
                    { 50, "GE", 10, 0, 62, "SE5" },
                    { 51, "AC1", 1, 7, 28, "SE6" },
                    { 52, "AC1", 2, 7, 28, "SE6" },
                    { 53, "AC2", 3, 7, 28, "SE6" },
                    { 54, "AC2", 4, 7, 28, "SE6" },
                    { 55, "AC3", 5, 7, 42, "SE6" },
                    { 56, "AC3", 6, 7, 42, "SE6" },
                    { 57, "SL", 7, 0, 32, "SE6" },
                    { 58, "SL", 8, 0, 32, "SE6" },
                    { 59, "GE", 9, 0, 62, "SE6" },
                    { 60, "GE", 10, 0, 62, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Fares",
                columns: new[] { "Id", "ClassCode", "Price", "RouteId", "TypeCode" },
                values: new object[,]
                {
                    { 1, "AC1", 100m, 1, "S" },
                    { 2, "AC1", 110m, 1, "F" },
                    { 3, "AC1", 120m, 1, "SF" },
                    { 4, "AC2", 90m, 1, "S" },
                    { 5, "AC2", 100m, 1, "F" },
                    { 6, "AC2", 110m, 1, "SF" },
                    { 7, "AC3", 80m, 1, "S" },
                    { 8, "AC3", 90m, 1, "F" },
                    { 9, "AC3", 120m, 1, "SF" },
                    { 10, "SL", 70m, 1, "S" },
                    { 11, "SL", 80m, 1, "F" },
                    { 12, "SL", 90m, 1, "SF" },
                    { 13, "GE", 60m, 1, "S" },
                    { 14, "GE", 70m, 1, "F" },
                    { 15, "GE", 80m, 1, "SF" },
                    { 16, "AC1", 100m, 2, "S" },
                    { 17, "AC1", 110m, 2, "F" },
                    { 18, "AC1", 120m, 2, "SF" },
                    { 19, "AC2", 90m, 2, "S" },
                    { 20, "AC2", 100m, 2, "F" },
                    { 21, "AC2", 110m, 2, "SF" },
                    { 22, "AC3", 80m, 2, "S" },
                    { 23, "AC3", 90m, 2, "F" },
                    { 24, "AC3", 120m, 2, "SF" }
                });

            migrationBuilder.InsertData(
                table: "Fares",
                columns: new[] { "Id", "ClassCode", "Price", "RouteId", "TypeCode" },
                values: new object[,]
                {
                    { 25, "SL", 70m, 2, "S" },
                    { 26, "SL", 80m, 2, "F" },
                    { 27, "SL", 90m, 2, "SF" },
                    { 28, "GE", 60m, 2, "S" },
                    { 29, "GE", 70m, 2, "F" },
                    { 30, "GE", 80m, 2, "SF" },
                    { 31, "AC1", 100m, 3, "S" },
                    { 32, "AC1", 110m, 3, "F" },
                    { 33, "AC1", 120m, 3, "SF" },
                    { 34, "AC2", 90m, 3, "S" },
                    { 35, "AC2", 100m, 3, "F" },
                    { 36, "AC2", 110m, 3, "SF" },
                    { 37, "AC3", 80m, 3, "S" },
                    { 38, "AC3", 90m, 3, "F" },
                    { 39, "AC3", 120m, 3, "SF" },
                    { 40, "SL", 70m, 3, "S" },
                    { 41, "SL", 80m, 3, "F" },
                    { 42, "SL", 90m, 3, "SF" },
                    { 43, "GE", 60m, 3, "S" },
                    { 44, "GE", 70m, 3, "F" },
                    { 45, "GE", 80m, 3, "SF" },
                    { 46, "AC1", 100m, 4, "S" },
                    { 47, "AC1", 110m, 4, "F" },
                    { 48, "AC1", 120m, 4, "SF" },
                    { 49, "AC2", 90m, 4, "S" },
                    { 50, "AC2", 100m, 4, "F" },
                    { 51, "AC2", 110m, 4, "SF" },
                    { 52, "AC3", 80m, 4, "S" },
                    { 53, "AC3", 90m, 4, "F" },
                    { 54, "AC3", 120m, 4, "SF" },
                    { 55, "SL", 70m, 4, "S" },
                    { 56, "SL", 80m, 4, "F" },
                    { 57, "SL", 90m, 4, "SF" },
                    { 58, "GE", 60m, 4, "S" },
                    { 59, "GE", 70m, 4, "F" },
                    { 60, "GE", 80m, 4, "SF" },
                    { 61, "AC1", 100m, 5, "S" },
                    { 62, "AC1", 110m, 5, "F" },
                    { 63, "AC1", 120m, 5, "SF" },
                    { 64, "AC2", 90m, 5, "S" },
                    { 65, "AC2", 100m, 5, "F" },
                    { 66, "AC2", 110m, 5, "SF" }
                });

            migrationBuilder.InsertData(
                table: "Fares",
                columns: new[] { "Id", "ClassCode", "Price", "RouteId", "TypeCode" },
                values: new object[,]
                {
                    { 67, "AC3", 80m, 5, "S" },
                    { 68, "AC3", 90m, 5, "F" },
                    { 69, "AC3", 120m, 5, "SF" },
                    { 70, "SL", 70m, 5, "S" },
                    { 71, "SL", 80m, 5, "F" },
                    { 72, "SL", 90m, 5, "SF" },
                    { 73, "GE", 60m, 5, "S" },
                    { 74, "GE", 70m, 5, "F" },
                    { 75, "GE", 80m, 5, "SF" },
                    { 76, "AC1", 100m, 6, "S" },
                    { 77, "AC1", 110m, 6, "F" },
                    { 78, "AC1", 120m, 6, "SF" },
                    { 79, "AC2", 90m, 6, "S" },
                    { 80, "AC2", 100m, 6, "F" },
                    { 81, "AC2", 110m, 6, "SF" },
                    { 82, "AC3", 80m, 6, "S" },
                    { 83, "AC3", 90m, 6, "F" },
                    { 84, "AC3", 120m, 6, "SF" },
                    { 85, "SL", 70m, 6, "S" },
                    { 86, "SL", 80m, 6, "F" },
                    { 87, "SL", 90m, 6, "SF" },
                    { 88, "GE", 60m, 6, "S" },
                    { 89, "GE", 70m, 6, "F" },
                    { 90, "GE", 80m, 6, "SF" }
                });

            migrationBuilder.InsertData(
                table: "RouteDetails",
                columns: new[] { "Id", "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[,]
                {
                    { 1, 1, 0, 1, 0, 1, 0 },
                    { 2, 2, 5, 1, 29, 1, 40 },
                    { 3, 3, 5, 2, 77, 1, 76 },
                    { 4, 4, 5, 3, 123, 1, 46 },
                    { 5, 5, 5, 4, 175, 1, 67 },
                    { 6, 6, 5, 5, 193, 1, 23 },
                    { 7, 7, 5, 6, 242, 1, 46 },
                    { 8, 8, 5, 7, 318, 1, 78 },
                    { 9, 9, 5, 8, 362, 1, 56 },
                    { 10, 10, 5, 9, 411, 1, 45 },
                    { 11, 11, 5, 10, 445, 1, 59 },
                    { 12, 12, 5, 11, 472, 1, 29 },
                    { 13, 13, 5, 12, 528, 1, 62 },
                    { 14, 14, 5, 13, 630, 1, 98 },
                    { 15, 15, 5, 14, 709, 1, 96 },
                    { 16, 16, 5, 15, 758, 1, 48 },
                    { 17, 17, 5, 16, 798, 1, 56 },
                    { 18, 18, 5, 17, 836, 1, 41 }
                });

            migrationBuilder.InsertData(
                table: "RouteDetails",
                columns: new[] { "Id", "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[,]
                {
                    { 19, 19, 5, 18, 861, 1, 27 },
                    { 20, 20, 5, 19, 884, 1, 23 },
                    { 21, 21, 5, 20, 901, 1, 15 },
                    { 22, 22, 5, 21, 935, 1, 54 },
                    { 23, 23, 5, 22, 971, 1, 89 },
                    { 24, 24, 5, 23, 1038, 1, 110 },
                    { 25, 25, 5, 24, 1104, 1, 103 },
                    { 26, 26, 5, 25, 1204, 1, 114 },
                    { 27, 27, 5, 26, 1290, 1, 73 },
                    { 28, 28, 5, 27, 1339, 1, 55 },
                    { 29, 29, 5, 28, 1386, 1, 31 },
                    { 30, 30, 5, 29, 1407, 1, 42 },
                    { 31, 31, 5, 30, 1447, 1, 79 },
                    { 32, 32, 5, 31, 1529, 1, 50 },
                    { 33, 33, 5, 32, 1551, 1, 37 },
                    { 34, 34, 5, 33, 1585, 1, 45 },
                    { 35, 35, 5, 34, 1611, 1, 32 },
                    { 36, 36, 5, 35, 1639, 1, 45 },
                    { 37, 37, 5, 36, 1670, 1, 45 },
                    { 38, 38, 5, 37, 1726, 1, 67 },
                    { 39, 38, 0, 38, 0, 2, 0 },
                    { 40, 37, 5, 38, 56, 2, 67 },
                    { 41, 36, 5, 37, 87, 2, 45 },
                    { 42, 35, 5, 36, 115, 2, 42 },
                    { 43, 34, 5, 35, 141, 2, 32 },
                    { 44, 33, 5, 34, 175, 2, 45 },
                    { 45, 32, 5, 33, 197, 2, 37 },
                    { 46, 31, 5, 32, 279, 2, 50 },
                    { 47, 30, 5, 31, 319, 2, 79 },
                    { 48, 29, 5, 30, 340, 2, 42 },
                    { 49, 28, 5, 29, 387, 2, 31 },
                    { 50, 27, 5, 28, 436, 2, 55 },
                    { 51, 26, 5, 27, 522, 2, 73 },
                    { 52, 25, 5, 26, 622, 2, 114 },
                    { 53, 24, 5, 25, 688, 2, 103 },
                    { 54, 23, 5, 24, 755, 2, 110 },
                    { 55, 22, 5, 23, 791, 2, 89 },
                    { 56, 21, 5, 22, 825, 2, 54 },
                    { 57, 20, 5, 21, 842, 2, 15 },
                    { 58, 19, 5, 20, 865, 2, 23 },
                    { 59, 18, 5, 19, 890, 2, 27 },
                    { 60, 17, 5, 18, 928, 2, 41 }
                });

            migrationBuilder.InsertData(
                table: "RouteDetails",
                columns: new[] { "Id", "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[,]
                {
                    { 61, 16, 5, 17, 968, 2, 56 },
                    { 62, 15, 5, 16, 1017, 2, 48 },
                    { 63, 14, 5, 15, 1096, 2, 96 },
                    { 64, 13, 5, 14, 1198, 2, 98 },
                    { 65, 12, 5, 13, 1254, 2, 62 },
                    { 66, 11, 5, 12, 1281, 2, 29 },
                    { 67, 10, 5, 11, 1315, 2, 59 },
                    { 68, 9, 5, 10, 1364, 2, 45 },
                    { 69, 8, 5, 9, 1408, 2, 56 },
                    { 70, 7, 5, 8, 1484, 2, 78 },
                    { 71, 6, 5, 7, 1533, 2, 46 },
                    { 72, 5, 5, 6, 1551, 2, 23 },
                    { 73, 4, 5, 5, 1603, 2, 67 },
                    { 74, 3, 5, 4, 1649, 2, 46 },
                    { 75, 2, 5, 3, 1697, 2, 76 },
                    { 76, 1, 5, 2, 1726, 2, 40 },
                    { 77, 1, 0, 1, 0, 3, 0 },
                    { 78, 2, 5, 1, 29, 3, 38 },
                    { 79, 5, 5, 2, 175, 3, 147 },
                    { 80, 8, 5, 5, 318, 3, 126 },
                    { 81, 10, 5, 8, 411, 3, 88 },
                    { 82, 13, 5, 10, 528, 3, 110 },
                    { 83, 14, 5, 13, 630, 3, 95 },
                    { 84, 17, 5, 14, 798, 3, 95 },
                    { 85, 19, 5, 17, 861, 3, 60 },
                    { 86, 22, 5, 19, 935, 3, 68 },
                    { 87, 24, 5, 22, 1038, 3, 145 },
                    { 88, 25, 5, 24, 1104, 3, 70 },
                    { 89, 26, 5, 25, 1204, 3, 95 },
                    { 90, 27, 5, 26, 1290, 3, 153 },
                    { 91, 28, 5, 27, 1339, 3, 54 },
                    { 92, 30, 5, 28, 1407, 3, 25 },
                    { 93, 33, 5, 30, 1551, 3, 132 },
                    { 94, 35, 5, 33, 1611, 3, 60 },
                    { 95, 36, 5, 35, 1639, 3, 29 },
                    { 96, 37, 5, 36, 1670, 3, 31 },
                    { 97, 38, 5, 37, 1726, 3, 62 },
                    { 98, 38, 0, 38, 0, 4, 0 },
                    { 99, 37, 5, 38, 56, 4, 62 },
                    { 100, 36, 5, 37, 87, 4, 76 },
                    { 101, 33, 5, 36, 175, 4, 76 },
                    { 102, 30, 5, 33, 319, 4, 132 }
                });

            migrationBuilder.InsertData(
                table: "RouteDetails",
                columns: new[] { "Id", "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[,]
                {
                    { 103, 29, 5, 30, 340, 4, 25 },
                    { 104, 28, 5, 29, 387, 4, 54 },
                    { 105, 26, 5, 28, 522, 4, 153 },
                    { 106, 25, 5, 26, 622, 4, 95 },
                    { 107, 24, 5, 25, 688, 4, 70 },
                    { 108, 22, 5, 24, 791, 4, 145 },
                    { 109, 19, 5, 22, 865, 4, 68 },
                    { 110, 17, 5, 19, 928, 4, 60 },
                    { 111, 14, 5, 17, 1096, 4, 95 },
                    { 112, 13, 5, 14, 1198, 4, 95 },
                    { 113, 10, 5, 13, 1315, 4, 110 },
                    { 114, 5, 5, 10, 1551, 4, 246 },
                    { 115, 2, 5, 5, 1697, 4, 147 },
                    { 116, 1, 5, 2, 1726, 4, 38 },
                    { 117, 1, 0, 1, 0, 5, 0 },
                    { 118, 2, 5, 1, 29, 5, 38 },
                    { 119, 3, 5, 2, 77, 5, 60 },
                    { 120, 5, 5, 3, 175, 5, 101 },
                    { 121, 10, 5, 5, 411, 5, 246 },
                    { 122, 13, 5, 10, 528, 5, 110 },
                    { 123, 14, 5, 13, 630, 5, 95 },
                    { 124, 15, 5, 14, 709, 5, 96 },
                    { 125, 17, 5, 15, 798, 5, 88 },
                    { 126, 19, 5, 17, 861, 5, 60 },
                    { 127, 22, 5, 19, 935, 5, 68 },
                    { 128, 24, 5, 22, 1038, 5, 145 },
                    { 129, 25, 5, 24, 1104, 5, 70 },
                    { 130, 26, 5, 25, 1204, 5, 95 },
                    { 131, 27, 5, 26, 1290, 5, 153 },
                    { 132, 28, 5, 27, 1339, 5, 54 },
                    { 133, 29, 5, 28, 1386, 5, 31 },
                    { 134, 30, 5, 29, 1407, 5, 42 },
                    { 135, 33, 5, 30, 1551, 5, 132 },
                    { 136, 36, 5, 33, 1639, 5, 96 },
                    { 137, 37, 5, 36, 1670, 5, 76 },
                    { 138, 38, 5, 37, 1726, 5, 62 },
                    { 139, 38, 0, 38, 0, 6, 0 },
                    { 140, 37, 5, 38, 56, 6, 62 },
                    { 141, 36, 5, 37, 87, 6, 76 },
                    { 142, 33, 5, 36, 175, 6, 96 },
                    { 143, 30, 5, 33, 319, 6, 132 },
                    { 144, 29, 5, 30, 340, 6, 42 }
                });

            migrationBuilder.InsertData(
                table: "RouteDetails",
                columns: new[] { "Id", "ArrivalStationId", "DelayTime", "DepartureStationId", "Distance", "RouteId", "TravelTime" },
                values: new object[,]
                {
                    { 145, 28, 5, 29, 387, 6, 31 },
                    { 146, 26, 5, 28, 522, 6, 153 },
                    { 147, 25, 5, 26, 622, 6, 95 },
                    { 148, 24, 5, 25, 688, 6, 70 },
                    { 149, 22, 5, 24, 791, 6, 145 },
                    { 150, 19, 5, 22, 865, 6, 68 },
                    { 151, 17, 5, 19, 928, 6, 60 },
                    { 152, 14, 5, 17, 1096, 6, 95 },
                    { 153, 13, 5, 14, 1198, 6, 95 },
                    { 154, 10, 5, 13, 1315, 6, 110 },
                    { 155, 5, 5, 10, 1551, 6, 246 },
                    { 156, 2, 5, 5, 1697, 6, 147 },
                    { 157, 1, 5, 2, 1726, 6, 38 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 8, 31, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 2, new DateTime(2023, 9, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 3, new DateTime(2023, 9, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 8, 31, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 4, new DateTime(2023, 9, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 5, new DateTime(2023, 9, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 8, 31, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 6, new DateTime(2023, 9, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 7, new DateTime(2023, 9, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 8, 31, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 8, new DateTime(2023, 9, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 9, new DateTime(2023, 9, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 10, new DateTime(2023, 9, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 11, new DateTime(2023, 9, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 12, new DateTime(2023, 9, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 13, new DateTime(2023, 9, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 14, new DateTime(2023, 9, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 15, new DateTime(2023, 9, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 16, new DateTime(2023, 9, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 17, new DateTime(2023, 9, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 18, new DateTime(2023, 9, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 19, new DateTime(2023, 9, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 20, new DateTime(2023, 9, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 21, new DateTime(2023, 9, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 22, new DateTime(2023, 9, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 23, new DateTime(2023, 9, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 24, new DateTime(2023, 9, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 25, new DateTime(2023, 9, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 26, new DateTime(2023, 9, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 27, new DateTime(2023, 9, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 28, new DateTime(2023, 9, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 29, new DateTime(2023, 9, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 30, new DateTime(2023, 9, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 31, new DateTime(2023, 9, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 32, new DateTime(2023, 9, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 33, new DateTime(2023, 9, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 34, new DateTime(2023, 9, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 35, new DateTime(2023, 9, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 36, new DateTime(2023, 9, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 37, new DateTime(2023, 9, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 38, new DateTime(2023, 9, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 39, new DateTime(2023, 9, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 40, new DateTime(2023, 9, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 41, new DateTime(2023, 9, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 42, new DateTime(2023, 9, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 43, new DateTime(2023, 9, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 44, new DateTime(2023, 9, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 45, new DateTime(2023, 9, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 46, new DateTime(2023, 9, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 47, new DateTime(2023, 9, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 48, new DateTime(2023, 9, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 49, new DateTime(2023, 9, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 50, new DateTime(2023, 9, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 51, new DateTime(2023, 9, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 52, new DateTime(2023, 9, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 53, new DateTime(2023, 9, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 54, new DateTime(2023, 9, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 55, new DateTime(2023, 9, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 56, new DateTime(2023, 9, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 57, new DateTime(2023, 9, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 58, new DateTime(2023, 9, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 59, new DateTime(2023, 9, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 60, new DateTime(2023, 9, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 61, new DateTime(2023, 9, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 62, new DateTime(2023, 9, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 63, new DateTime(2023, 9, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 64, new DateTime(2023, 9, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 65, new DateTime(2023, 9, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 66, new DateTime(2023, 9, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 67, new DateTime(2023, 9, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 68, new DateTime(2023, 9, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 69, new DateTime(2023, 9, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 70, new DateTime(2023, 9, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 71, new DateTime(2023, 9, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 72, new DateTime(2023, 9, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 73, new DateTime(2023, 9, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 74, new DateTime(2023, 9, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 75, new DateTime(2023, 9, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 76, new DateTime(2023, 9, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 77, new DateTime(2023, 9, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 78, new DateTime(2023, 9, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 79, new DateTime(2023, 9, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 80, new DateTime(2023, 9, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 81, new DateTime(2023, 9, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 82, new DateTime(2023, 9, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 83, new DateTime(2023, 9, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 84, new DateTime(2023, 9, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 85, new DateTime(2023, 9, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 86, new DateTime(2023, 9, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 87, new DateTime(2023, 9, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 88, new DateTime(2023, 9, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 89, new DateTime(2023, 9, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 90, new DateTime(2023, 9, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 91, new DateTime(2023, 9, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 92, new DateTime(2023, 9, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 93, new DateTime(2023, 9, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 94, new DateTime(2023, 9, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 95, new DateTime(2023, 9, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 96, new DateTime(2023, 9, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 97, new DateTime(2023, 9, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 98, new DateTime(2023, 9, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 99, new DateTime(2023, 9, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 100, new DateTime(2023, 9, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 101, new DateTime(2023, 9, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 102, new DateTime(2023, 9, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 103, new DateTime(2023, 9, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 104, new DateTime(2023, 9, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 105, new DateTime(2023, 9, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 106, new DateTime(2023, 9, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 107, new DateTime(2023, 9, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 108, new DateTime(2023, 9, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 109, new DateTime(2023, 9, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 110, new DateTime(2023, 9, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 111, new DateTime(2023, 9, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 112, new DateTime(2023, 9, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 113, new DateTime(2023, 9, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 114, new DateTime(2023, 9, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 115, new DateTime(2023, 9, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 116, new DateTime(2023, 9, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 117, new DateTime(2023, 9, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 118, new DateTime(2023, 9, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 119, new DateTime(2023, 9, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 120, new DateTime(2023, 9, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 121, new DateTime(2023, 9, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 122, new DateTime(2023, 9, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 123, new DateTime(2023, 9, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 124, new DateTime(2023, 9, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 125, new DateTime(2023, 9, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 126, new DateTime(2023, 9, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 127, new DateTime(2023, 9, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 128, new DateTime(2023, 9, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 129, new DateTime(2023, 9, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 130, new DateTime(2023, 9, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 131, new DateTime(2023, 9, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 132, new DateTime(2023, 9, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 133, new DateTime(2023, 9, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 134, new DateTime(2023, 9, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 135, new DateTime(2023, 9, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 136, new DateTime(2023, 9, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 137, new DateTime(2023, 9, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 138, new DateTime(2023, 9, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 139, new DateTime(2023, 9, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 140, new DateTime(2023, 9, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 141, new DateTime(2023, 9, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 142, new DateTime(2023, 9, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 143, new DateTime(2023, 9, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 144, new DateTime(2023, 9, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 145, new DateTime(2023, 9, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 146, new DateTime(2023, 9, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 147, new DateTime(2023, 9, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 148, new DateTime(2023, 9, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 149, new DateTime(2023, 9, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 150, new DateTime(2023, 9, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 151, new DateTime(2023, 9, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 152, new DateTime(2023, 9, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 153, new DateTime(2023, 9, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 154, new DateTime(2023, 9, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 155, new DateTime(2023, 9, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 156, new DateTime(2023, 9, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 157, new DateTime(2023, 9, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 158, new DateTime(2023, 9, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 159, new DateTime(2023, 9, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 160, new DateTime(2023, 9, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 161, new DateTime(2023, 9, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 162, new DateTime(2023, 9, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 163, new DateTime(2023, 9, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 164, new DateTime(2023, 9, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 165, new DateTime(2023, 9, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 166, new DateTime(2023, 9, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 167, new DateTime(2023, 9, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 168, new DateTime(2023, 9, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 169, new DateTime(2023, 9, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 170, new DateTime(2023, 9, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 171, new DateTime(2023, 9, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 172, new DateTime(2023, 9, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 173, new DateTime(2023, 9, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 174, new DateTime(2023, 10, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 175, new DateTime(2023, 9, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 176, new DateTime(2023, 10, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 177, new DateTime(2023, 9, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 178, new DateTime(2023, 10, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 179, new DateTime(2023, 9, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 180, new DateTime(2023, 10, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 181, new DateTime(2023, 10, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 182, new DateTime(2023, 10, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 183, new DateTime(2023, 10, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 184, new DateTime(2023, 10, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 185, new DateTime(2023, 10, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 186, new DateTime(2023, 10, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 187, new DateTime(2023, 10, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 9, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 188, new DateTime(2023, 10, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 189, new DateTime(2023, 10, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 190, new DateTime(2023, 10, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 191, new DateTime(2023, 10, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 192, new DateTime(2023, 10, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 193, new DateTime(2023, 10, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 194, new DateTime(2023, 10, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 195, new DateTime(2023, 10, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 196, new DateTime(2023, 10, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 197, new DateTime(2023, 10, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 198, new DateTime(2023, 10, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 199, new DateTime(2023, 10, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 200, new DateTime(2023, 10, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 201, new DateTime(2023, 10, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 202, new DateTime(2023, 10, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 203, new DateTime(2023, 10, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 204, new DateTime(2023, 10, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 205, new DateTime(2023, 10, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 206, new DateTime(2023, 10, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 207, new DateTime(2023, 10, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 208, new DateTime(2023, 10, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 209, new DateTime(2023, 10, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 210, new DateTime(2023, 10, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 211, new DateTime(2023, 10, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 212, new DateTime(2023, 10, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 213, new DateTime(2023, 10, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 214, new DateTime(2023, 10, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 215, new DateTime(2023, 10, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 216, new DateTime(2023, 10, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 217, new DateTime(2023, 10, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 218, new DateTime(2023, 10, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 219, new DateTime(2023, 10, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 220, new DateTime(2023, 10, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 221, new DateTime(2023, 10, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 222, new DateTime(2023, 10, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 223, new DateTime(2023, 10, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 224, new DateTime(2023, 10, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 225, new DateTime(2023, 10, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 226, new DateTime(2023, 10, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 227, new DateTime(2023, 10, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 228, new DateTime(2023, 10, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 229, new DateTime(2023, 10, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 230, new DateTime(2023, 10, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 231, new DateTime(2023, 10, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 232, new DateTime(2023, 10, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 233, new DateTime(2023, 10, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 234, new DateTime(2023, 10, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 235, new DateTime(2023, 10, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 236, new DateTime(2023, 10, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 237, new DateTime(2023, 10, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 238, new DateTime(2023, 10, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 239, new DateTime(2023, 10, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 240, new DateTime(2023, 10, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 241, new DateTime(2023, 10, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 242, new DateTime(2023, 10, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 243, new DateTime(2023, 10, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 244, new DateTime(2023, 10, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 245, new DateTime(2023, 10, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 246, new DateTime(2023, 10, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 247, new DateTime(2023, 10, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 248, new DateTime(2023, 10, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 249, new DateTime(2023, 10, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 250, new DateTime(2023, 10, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 251, new DateTime(2023, 10, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 252, new DateTime(2023, 10, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 253, new DateTime(2023, 10, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 254, new DateTime(2023, 10, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 255, new DateTime(2023, 10, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 256, new DateTime(2023, 10, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 257, new DateTime(2023, 10, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 258, new DateTime(2023, 10, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 259, new DateTime(2023, 10, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 260, new DateTime(2023, 10, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 261, new DateTime(2023, 10, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 262, new DateTime(2023, 10, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 263, new DateTime(2023, 10, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 264, new DateTime(2023, 10, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 265, new DateTime(2023, 10, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 266, new DateTime(2023, 10, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 267, new DateTime(2023, 10, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 268, new DateTime(2023, 10, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 269, new DateTime(2023, 10, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 270, new DateTime(2023, 10, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 271, new DateTime(2023, 10, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 272, new DateTime(2023, 10, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 273, new DateTime(2023, 10, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 274, new DateTime(2023, 10, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 275, new DateTime(2023, 10, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 276, new DateTime(2023, 10, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 277, new DateTime(2023, 10, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 278, new DateTime(2023, 10, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 279, new DateTime(2023, 10, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 280, new DateTime(2023, 10, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 281, new DateTime(2023, 10, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 282, new DateTime(2023, 10, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 283, new DateTime(2023, 10, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 284, new DateTime(2023, 10, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 285, new DateTime(2023, 10, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 286, new DateTime(2023, 10, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 287, new DateTime(2023, 10, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 288, new DateTime(2023, 10, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 289, new DateTime(2023, 10, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 290, new DateTime(2023, 10, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 291, new DateTime(2023, 10, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 292, new DateTime(2023, 10, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 293, new DateTime(2023, 10, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 294, new DateTime(2023, 10, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 295, new DateTime(2023, 10, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 296, new DateTime(2023, 10, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 297, new DateTime(2023, 10, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 298, new DateTime(2023, 10, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 299, new DateTime(2023, 10, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 300, new DateTime(2023, 10, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 301, new DateTime(2023, 10, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 302, new DateTime(2023, 10, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 303, new DateTime(2023, 10, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 304, new DateTime(2023, 10, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 305, new DateTime(2023, 10, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 306, new DateTime(2023, 10, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 307, new DateTime(2023, 10, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 308, new DateTime(2023, 10, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 309, new DateTime(2023, 10, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 310, new DateTime(2023, 10, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 311, new DateTime(2023, 10, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 312, new DateTime(2023, 10, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 313, new DateTime(2023, 10, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 314, new DateTime(2023, 10, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 315, new DateTime(2023, 10, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 316, new DateTime(2023, 10, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 317, new DateTime(2023, 10, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 318, new DateTime(2023, 10, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 319, new DateTime(2023, 10, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 320, new DateTime(2023, 10, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 321, new DateTime(2023, 10, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 322, new DateTime(2023, 10, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 323, new DateTime(2023, 10, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 324, new DateTime(2023, 10, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 325, new DateTime(2023, 10, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 326, new DateTime(2023, 10, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 327, new DateTime(2023, 10, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 328, new DateTime(2023, 10, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 329, new DateTime(2023, 10, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 330, new DateTime(2023, 10, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 331, new DateTime(2023, 10, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 332, new DateTime(2023, 10, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 333, new DateTime(2023, 10, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 334, new DateTime(2023, 10, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 335, new DateTime(2023, 10, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 336, new DateTime(2023, 10, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 337, new DateTime(2023, 10, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 338, new DateTime(2023, 10, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 339, new DateTime(2023, 10, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 340, new DateTime(2023, 10, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 341, new DateTime(2023, 10, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 342, new DateTime(2023, 10, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 343, new DateTime(2023, 10, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 344, new DateTime(2023, 10, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 345, new DateTime(2023, 10, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 346, new DateTime(2023, 10, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 347, new DateTime(2023, 10, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 348, new DateTime(2023, 10, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 349, new DateTime(2023, 10, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 350, new DateTime(2023, 10, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 351, new DateTime(2023, 10, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 352, new DateTime(2023, 10, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 353, new DateTime(2023, 10, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 354, new DateTime(2023, 10, 31, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 355, new DateTime(2023, 10, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 356, new DateTime(2023, 10, 31, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 357, new DateTime(2023, 10, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 358, new DateTime(2023, 10, 31, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 359, new DateTime(2023, 10, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 360, new DateTime(2023, 10, 31, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 361, new DateTime(2023, 10, 31, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 362, new DateTime(2023, 11, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 31, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 363, new DateTime(2023, 10, 31, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 364, new DateTime(2023, 11, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 31, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 365, new DateTime(2023, 11, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 366, new DateTime(2023, 11, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 31, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 367, new DateTime(2023, 11, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 368, new DateTime(2023, 11, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 31, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 369, new DateTime(2023, 11, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 31, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 370, new DateTime(2023, 11, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 371, new DateTime(2023, 11, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 31, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 372, new DateTime(2023, 11, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 373, new DateTime(2023, 11, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 374, new DateTime(2023, 11, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 375, new DateTime(2023, 11, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 376, new DateTime(2023, 11, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 377, new DateTime(2023, 11, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 378, new DateTime(2023, 11, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 379, new DateTime(2023, 11, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 380, new DateTime(2023, 11, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 381, new DateTime(2023, 11, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 382, new DateTime(2023, 11, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 383, new DateTime(2023, 11, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 384, new DateTime(2023, 11, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 385, new DateTime(2023, 11, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 386, new DateTime(2023, 11, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 387, new DateTime(2023, 11, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 388, new DateTime(2023, 11, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 389, new DateTime(2023, 11, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 390, new DateTime(2023, 11, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 391, new DateTime(2023, 11, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 392, new DateTime(2023, 11, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 393, new DateTime(2023, 11, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 394, new DateTime(2023, 11, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 395, new DateTime(2023, 11, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 396, new DateTime(2023, 11, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 397, new DateTime(2023, 11, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 398, new DateTime(2023, 11, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 399, new DateTime(2023, 11, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 400, new DateTime(2023, 11, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 401, new DateTime(2023, 11, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 402, new DateTime(2023, 11, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 403, new DateTime(2023, 11, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 404, new DateTime(2023, 11, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 405, new DateTime(2023, 11, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 406, new DateTime(2023, 11, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 407, new DateTime(2023, 11, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 408, new DateTime(2023, 11, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 409, new DateTime(2023, 11, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 410, new DateTime(2023, 11, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 411, new DateTime(2023, 11, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 412, new DateTime(2023, 11, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 413, new DateTime(2023, 11, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 414, new DateTime(2023, 11, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 415, new DateTime(2023, 11, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 416, new DateTime(2023, 11, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 417, new DateTime(2023, 11, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 418, new DateTime(2023, 11, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 419, new DateTime(2023, 11, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 420, new DateTime(2023, 11, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 421, new DateTime(2023, 11, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 422, new DateTime(2023, 11, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 423, new DateTime(2023, 11, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 424, new DateTime(2023, 11, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 425, new DateTime(2023, 11, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 426, new DateTime(2023, 11, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 427, new DateTime(2023, 11, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 428, new DateTime(2023, 11, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 429, new DateTime(2023, 11, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 430, new DateTime(2023, 11, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 431, new DateTime(2023, 11, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 432, new DateTime(2023, 11, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 433, new DateTime(2023, 11, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 434, new DateTime(2023, 11, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 435, new DateTime(2023, 11, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 436, new DateTime(2023, 11, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 437, new DateTime(2023, 11, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 438, new DateTime(2023, 11, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 439, new DateTime(2023, 11, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 440, new DateTime(2023, 11, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 441, new DateTime(2023, 11, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 442, new DateTime(2023, 11, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 443, new DateTime(2023, 11, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 444, new DateTime(2023, 11, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 445, new DateTime(2023, 11, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 446, new DateTime(2023, 11, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 447, new DateTime(2023, 11, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 448, new DateTime(2023, 11, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 449, new DateTime(2023, 11, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 450, new DateTime(2023, 11, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 451, new DateTime(2023, 11, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 452, new DateTime(2023, 11, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 453, new DateTime(2023, 11, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 454, new DateTime(2023, 11, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 455, new DateTime(2023, 11, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 456, new DateTime(2023, 11, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 457, new DateTime(2023, 11, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 458, new DateTime(2023, 11, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 459, new DateTime(2023, 11, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 460, new DateTime(2023, 11, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 461, new DateTime(2023, 11, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 462, new DateTime(2023, 11, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 463, new DateTime(2023, 11, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 464, new DateTime(2023, 11, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 465, new DateTime(2023, 11, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 466, new DateTime(2023, 11, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 467, new DateTime(2023, 11, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 468, new DateTime(2023, 11, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 469, new DateTime(2023, 11, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 470, new DateTime(2023, 11, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 471, new DateTime(2023, 11, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 472, new DateTime(2023, 11, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 473, new DateTime(2023, 11, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 474, new DateTime(2023, 11, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 475, new DateTime(2023, 11, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 476, new DateTime(2023, 11, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 477, new DateTime(2023, 11, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 478, new DateTime(2023, 11, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 479, new DateTime(2023, 11, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 480, new DateTime(2023, 11, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 481, new DateTime(2023, 11, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 482, new DateTime(2023, 11, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 483, new DateTime(2023, 11, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 484, new DateTime(2023, 11, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 485, new DateTime(2023, 11, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 486, new DateTime(2023, 11, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 487, new DateTime(2023, 11, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 488, new DateTime(2023, 11, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 489, new DateTime(2023, 11, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 490, new DateTime(2023, 11, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 491, new DateTime(2023, 11, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 492, new DateTime(2023, 11, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 493, new DateTime(2023, 11, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 494, new DateTime(2023, 11, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 495, new DateTime(2023, 11, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 496, new DateTime(2023, 11, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 497, new DateTime(2023, 11, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 498, new DateTime(2023, 11, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 499, new DateTime(2023, 11, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 500, new DateTime(2023, 11, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 501, new DateTime(2023, 11, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 502, new DateTime(2023, 11, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 503, new DateTime(2023, 11, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 504, new DateTime(2023, 11, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 505, new DateTime(2023, 11, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 506, new DateTime(2023, 11, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 507, new DateTime(2023, 11, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 508, new DateTime(2023, 11, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 509, new DateTime(2023, 11, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 510, new DateTime(2023, 11, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 511, new DateTime(2023, 11, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 512, new DateTime(2023, 11, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 513, new DateTime(2023, 11, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 514, new DateTime(2023, 11, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 515, new DateTime(2023, 11, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 516, new DateTime(2023, 11, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 517, new DateTime(2023, 11, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 518, new DateTime(2023, 11, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 519, new DateTime(2023, 11, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 520, new DateTime(2023, 11, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 521, new DateTime(2023, 11, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 522, new DateTime(2023, 11, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 523, new DateTime(2023, 11, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 524, new DateTime(2023, 11, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 525, new DateTime(2023, 11, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 526, new DateTime(2023, 11, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 527, new DateTime(2023, 11, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 528, new DateTime(2023, 11, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 529, new DateTime(2023, 11, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 530, new DateTime(2023, 11, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 531, new DateTime(2023, 11, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 532, new DateTime(2023, 11, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 533, new DateTime(2023, 11, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 534, new DateTime(2023, 11, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 535, new DateTime(2023, 11, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 536, new DateTime(2023, 11, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 537, new DateTime(2023, 11, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 538, new DateTime(2023, 11, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 539, new DateTime(2023, 11, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 540, new DateTime(2023, 11, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 541, new DateTime(2023, 11, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 542, new DateTime(2023, 12, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 543, new DateTime(2023, 11, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 544, new DateTime(2023, 12, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 545, new DateTime(2023, 12, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 546, new DateTime(2023, 12, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 547, new DateTime(2023, 12, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 548, new DateTime(2023, 12, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 549, new DateTime(2023, 12, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 550, new DateTime(2023, 12, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 551, new DateTime(2023, 12, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 11, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 552, new DateTime(2023, 12, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 553, new DateTime(2023, 12, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 554, new DateTime(2023, 12, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 555, new DateTime(2023, 12, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 556, new DateTime(2023, 12, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 557, new DateTime(2023, 12, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 558, new DateTime(2023, 12, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 559, new DateTime(2023, 12, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 560, new DateTime(2023, 12, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 561, new DateTime(2023, 12, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 562, new DateTime(2023, 12, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 563, new DateTime(2023, 12, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 564, new DateTime(2023, 12, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 565, new DateTime(2023, 12, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 566, new DateTime(2023, 12, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 567, new DateTime(2023, 12, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 568, new DateTime(2023, 12, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 569, new DateTime(2023, 12, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 570, new DateTime(2023, 12, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 571, new DateTime(2023, 12, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 572, new DateTime(2023, 12, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 573, new DateTime(2023, 12, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 574, new DateTime(2023, 12, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 575, new DateTime(2023, 12, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 576, new DateTime(2023, 12, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 577, new DateTime(2023, 12, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 578, new DateTime(2023, 12, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 579, new DateTime(2023, 12, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 580, new DateTime(2023, 12, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 581, new DateTime(2023, 12, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 582, new DateTime(2023, 12, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 583, new DateTime(2023, 12, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 584, new DateTime(2023, 12, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 585, new DateTime(2023, 12, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 586, new DateTime(2023, 12, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 587, new DateTime(2023, 12, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 588, new DateTime(2023, 12, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 589, new DateTime(2023, 12, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 590, new DateTime(2023, 12, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 591, new DateTime(2023, 12, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 592, new DateTime(2023, 12, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 593, new DateTime(2023, 12, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 594, new DateTime(2023, 12, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 595, new DateTime(2023, 12, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 596, new DateTime(2023, 12, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 597, new DateTime(2023, 12, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 598, new DateTime(2023, 12, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 599, new DateTime(2023, 12, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 600, new DateTime(2023, 12, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 601, new DateTime(2023, 12, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 602, new DateTime(2023, 12, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 603, new DateTime(2023, 12, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 604, new DateTime(2023, 12, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 605, new DateTime(2023, 12, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 606, new DateTime(2023, 12, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 607, new DateTime(2023, 12, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 608, new DateTime(2023, 12, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 609, new DateTime(2023, 12, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 610, new DateTime(2023, 12, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 611, new DateTime(2023, 12, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 612, new DateTime(2023, 12, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 613, new DateTime(2023, 12, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 614, new DateTime(2023, 12, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 615, new DateTime(2023, 12, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 616, new DateTime(2023, 12, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 617, new DateTime(2023, 12, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 618, new DateTime(2023, 12, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 619, new DateTime(2023, 12, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 620, new DateTime(2023, 12, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 621, new DateTime(2023, 12, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 622, new DateTime(2023, 12, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 623, new DateTime(2023, 12, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 624, new DateTime(2023, 12, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 625, new DateTime(2023, 12, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 626, new DateTime(2023, 12, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 627, new DateTime(2023, 12, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 628, new DateTime(2023, 12, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 629, new DateTime(2023, 12, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 630, new DateTime(2023, 12, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 631, new DateTime(2023, 12, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 632, new DateTime(2023, 12, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 633, new DateTime(2023, 12, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 634, new DateTime(2023, 12, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 635, new DateTime(2023, 12, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 636, new DateTime(2023, 12, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 637, new DateTime(2023, 12, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 638, new DateTime(2023, 12, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 639, new DateTime(2023, 12, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 640, new DateTime(2023, 12, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 641, new DateTime(2023, 12, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 642, new DateTime(2023, 12, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 643, new DateTime(2023, 12, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 644, new DateTime(2023, 12, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 645, new DateTime(2023, 12, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 646, new DateTime(2023, 12, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 647, new DateTime(2023, 12, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 648, new DateTime(2023, 12, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 649, new DateTime(2023, 12, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 650, new DateTime(2023, 12, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 651, new DateTime(2023, 12, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 652, new DateTime(2023, 12, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 653, new DateTime(2023, 12, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 654, new DateTime(2023, 12, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 655, new DateTime(2023, 12, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 656, new DateTime(2023, 12, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 657, new DateTime(2023, 12, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 658, new DateTime(2023, 12, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 659, new DateTime(2023, 12, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 660, new DateTime(2023, 12, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 661, new DateTime(2023, 12, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 662, new DateTime(2023, 12, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 663, new DateTime(2023, 12, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 664, new DateTime(2023, 12, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 665, new DateTime(2023, 12, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 666, new DateTime(2023, 12, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 667, new DateTime(2023, 12, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 668, new DateTime(2023, 12, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 669, new DateTime(2023, 12, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 670, new DateTime(2023, 12, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 671, new DateTime(2023, 12, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 672, new DateTime(2023, 12, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 673, new DateTime(2023, 12, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 674, new DateTime(2023, 12, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 675, new DateTime(2023, 12, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 676, new DateTime(2023, 12, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 677, new DateTime(2023, 12, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 678, new DateTime(2023, 12, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 679, new DateTime(2023, 12, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 680, new DateTime(2023, 12, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 681, new DateTime(2023, 12, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 682, new DateTime(2023, 12, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 683, new DateTime(2023, 12, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 684, new DateTime(2023, 12, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 685, new DateTime(2023, 12, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 686, new DateTime(2023, 12, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 687, new DateTime(2023, 12, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 688, new DateTime(2023, 12, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 689, new DateTime(2023, 12, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 690, new DateTime(2023, 12, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 691, new DateTime(2023, 12, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 692, new DateTime(2023, 12, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 693, new DateTime(2023, 12, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 694, new DateTime(2023, 12, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 695, new DateTime(2023, 12, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 696, new DateTime(2023, 12, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 697, new DateTime(2023, 12, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 698, new DateTime(2023, 12, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 699, new DateTime(2023, 12, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 700, new DateTime(2023, 12, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 701, new DateTime(2023, 12, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 702, new DateTime(2023, 12, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 703, new DateTime(2023, 12, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 704, new DateTime(2023, 12, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 705, new DateTime(2023, 12, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 706, new DateTime(2023, 12, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 707, new DateTime(2023, 12, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 708, new DateTime(2023, 12, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 709, new DateTime(2023, 12, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 710, new DateTime(2023, 12, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 711, new DateTime(2023, 12, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 712, new DateTime(2023, 12, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 713, new DateTime(2023, 12, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 714, new DateTime(2023, 12, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 715, new DateTime(2023, 12, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 716, new DateTime(2023, 12, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 717, new DateTime(2023, 12, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 718, new DateTime(2023, 12, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 719, new DateTime(2023, 12, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 720, new DateTime(2023, 12, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 721, new DateTime(2023, 12, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 722, new DateTime(2023, 12, 31, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 723, new DateTime(2023, 12, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 724, new DateTime(2023, 12, 31, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 725, new DateTime(2023, 12, 31, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 726, new DateTime(2024, 1, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 727, new DateTime(2023, 12, 31, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 728, new DateTime(2024, 1, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 729, new DateTime(2023, 12, 31, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 730, new DateTime(2024, 1, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 31, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 731, new DateTime(2023, 12, 31, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 732, new DateTime(2024, 1, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 31, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 733, new DateTime(2024, 1, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 31, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 734, new DateTime(2024, 1, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 735, new DateTime(2024, 1, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 31, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 736, new DateTime(2024, 1, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 737, new DateTime(2024, 1, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 31, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 738, new DateTime(2024, 1, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 739, new DateTime(2024, 1, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 31, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 740, new DateTime(2024, 1, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 741, new DateTime(2024, 1, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 742, new DateTime(2024, 1, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 743, new DateTime(2024, 1, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 744, new DateTime(2024, 1, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 745, new DateTime(2024, 1, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 746, new DateTime(2024, 1, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 747, new DateTime(2024, 1, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 748, new DateTime(2024, 1, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 749, new DateTime(2024, 1, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 750, new DateTime(2024, 1, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 751, new DateTime(2024, 1, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 752, new DateTime(2024, 1, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 753, new DateTime(2024, 1, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 754, new DateTime(2024, 1, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 755, new DateTime(2024, 1, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 756, new DateTime(2024, 1, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 757, new DateTime(2024, 1, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 758, new DateTime(2024, 1, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 759, new DateTime(2024, 1, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 760, new DateTime(2024, 1, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 761, new DateTime(2024, 1, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 762, new DateTime(2024, 1, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 763, new DateTime(2024, 1, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 764, new DateTime(2024, 1, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 765, new DateTime(2024, 1, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 766, new DateTime(2024, 1, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 767, new DateTime(2024, 1, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 768, new DateTime(2024, 1, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 769, new DateTime(2024, 1, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 770, new DateTime(2024, 1, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 771, new DateTime(2024, 1, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 772, new DateTime(2024, 1, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 773, new DateTime(2024, 1, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 774, new DateTime(2024, 1, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 775, new DateTime(2024, 1, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 776, new DateTime(2024, 1, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 777, new DateTime(2024, 1, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 778, new DateTime(2024, 1, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 779, new DateTime(2024, 1, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 780, new DateTime(2024, 1, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 781, new DateTime(2024, 1, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 782, new DateTime(2024, 1, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 783, new DateTime(2024, 1, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 784, new DateTime(2024, 1, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 785, new DateTime(2024, 1, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 786, new DateTime(2024, 1, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 787, new DateTime(2024, 1, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 788, new DateTime(2024, 1, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 789, new DateTime(2024, 1, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 790, new DateTime(2024, 1, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 791, new DateTime(2024, 1, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 792, new DateTime(2024, 1, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 793, new DateTime(2024, 1, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 794, new DateTime(2024, 1, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 795, new DateTime(2024, 1, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 796, new DateTime(2024, 1, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 797, new DateTime(2024, 1, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 798, new DateTime(2024, 1, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 799, new DateTime(2024, 1, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 800, new DateTime(2024, 1, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 801, new DateTime(2024, 1, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 802, new DateTime(2024, 1, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 803, new DateTime(2024, 1, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 804, new DateTime(2024, 1, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 805, new DateTime(2024, 1, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 806, new DateTime(2024, 1, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 807, new DateTime(2024, 1, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 808, new DateTime(2024, 1, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 809, new DateTime(2024, 1, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 810, new DateTime(2024, 1, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 811, new DateTime(2024, 1, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 812, new DateTime(2024, 1, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 813, new DateTime(2024, 1, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 814, new DateTime(2024, 1, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 815, new DateTime(2024, 1, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 816, new DateTime(2024, 1, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 817, new DateTime(2024, 1, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 818, new DateTime(2024, 1, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 819, new DateTime(2024, 1, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 820, new DateTime(2024, 1, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 821, new DateTime(2024, 1, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 822, new DateTime(2024, 1, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 823, new DateTime(2024, 1, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 824, new DateTime(2024, 1, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 825, new DateTime(2024, 1, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 826, new DateTime(2024, 1, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 827, new DateTime(2024, 1, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 828, new DateTime(2024, 1, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 829, new DateTime(2024, 1, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 830, new DateTime(2024, 1, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 831, new DateTime(2024, 1, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 832, new DateTime(2024, 1, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 833, new DateTime(2024, 1, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 834, new DateTime(2024, 1, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 835, new DateTime(2024, 1, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 836, new DateTime(2024, 1, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 837, new DateTime(2024, 1, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 838, new DateTime(2024, 1, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 839, new DateTime(2024, 1, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 840, new DateTime(2024, 1, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 841, new DateTime(2024, 1, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 842, new DateTime(2024, 1, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 843, new DateTime(2024, 1, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 844, new DateTime(2024, 1, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 845, new DateTime(2024, 1, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 846, new DateTime(2024, 1, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 847, new DateTime(2024, 1, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 848, new DateTime(2024, 1, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 849, new DateTime(2024, 1, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 850, new DateTime(2024, 1, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 851, new DateTime(2024, 1, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 852, new DateTime(2024, 1, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 853, new DateTime(2024, 1, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 854, new DateTime(2024, 1, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 855, new DateTime(2024, 1, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 856, new DateTime(2024, 1, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 857, new DateTime(2024, 1, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 858, new DateTime(2024, 1, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 859, new DateTime(2024, 1, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 860, new DateTime(2024, 1, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 861, new DateTime(2024, 1, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 862, new DateTime(2024, 1, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 863, new DateTime(2024, 1, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 864, new DateTime(2024, 1, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 865, new DateTime(2024, 1, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 866, new DateTime(2024, 1, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 867, new DateTime(2024, 1, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 868, new DateTime(2024, 1, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 869, new DateTime(2024, 1, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 870, new DateTime(2024, 1, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 871, new DateTime(2024, 1, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 872, new DateTime(2024, 1, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 873, new DateTime(2024, 1, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 874, new DateTime(2024, 1, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 875, new DateTime(2024, 1, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 876, new DateTime(2024, 1, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 877, new DateTime(2024, 1, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 878, new DateTime(2024, 1, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 879, new DateTime(2024, 1, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 880, new DateTime(2024, 1, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 881, new DateTime(2024, 1, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 882, new DateTime(2024, 1, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 883, new DateTime(2024, 1, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 884, new DateTime(2024, 1, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 885, new DateTime(2024, 1, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 886, new DateTime(2024, 1, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 887, new DateTime(2024, 1, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 888, new DateTime(2024, 1, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 889, new DateTime(2024, 1, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 890, new DateTime(2024, 1, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 891, new DateTime(2024, 1, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 892, new DateTime(2024, 1, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 893, new DateTime(2024, 1, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 894, new DateTime(2024, 1, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 895, new DateTime(2024, 1, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 896, new DateTime(2024, 1, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 897, new DateTime(2024, 1, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 898, new DateTime(2024, 1, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 899, new DateTime(2024, 1, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 900, new DateTime(2024, 1, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 901, new DateTime(2024, 1, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 902, new DateTime(2024, 1, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 903, new DateTime(2024, 1, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 904, new DateTime(2024, 1, 30, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 905, new DateTime(2024, 1, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 906, new DateTime(2024, 1, 31, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 907, new DateTime(2024, 1, 30, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 908, new DateTime(2024, 1, 31, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 909, new DateTime(2024, 1, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 910, new DateTime(2024, 1, 31, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 911, new DateTime(2024, 1, 30, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 912, new DateTime(2024, 1, 31, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 30, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 913, new DateTime(2024, 1, 31, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 914, new DateTime(2024, 2, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 31, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 915, new DateTime(2024, 1, 31, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 30, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 916, new DateTime(2024, 2, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 31, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 917, new DateTime(2024, 2, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 918, new DateTime(2024, 2, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 31, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 919, new DateTime(2024, 2, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 30, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 920, new DateTime(2024, 2, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 31, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 921, new DateTime(2024, 2, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 31, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 922, new DateTime(2024, 2, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 923, new DateTime(2024, 2, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 31, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 924, new DateTime(2024, 2, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 925, new DateTime(2024, 2, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 926, new DateTime(2024, 2, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 927, new DateTime(2024, 2, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 928, new DateTime(2024, 2, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 929, new DateTime(2024, 2, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 930, new DateTime(2024, 2, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 931, new DateTime(2024, 2, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 932, new DateTime(2024, 2, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 933, new DateTime(2024, 2, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 934, new DateTime(2024, 2, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 935, new DateTime(2024, 2, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 936, new DateTime(2024, 2, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 937, new DateTime(2024, 2, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 938, new DateTime(2024, 2, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 939, new DateTime(2024, 2, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 940, new DateTime(2024, 2, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 941, new DateTime(2024, 2, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 942, new DateTime(2024, 2, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 943, new DateTime(2024, 2, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 944, new DateTime(2024, 2, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 945, new DateTime(2024, 2, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 946, new DateTime(2024, 2, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 947, new DateTime(2024, 2, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 948, new DateTime(2024, 2, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 949, new DateTime(2024, 2, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 950, new DateTime(2024, 2, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 951, new DateTime(2024, 2, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 952, new DateTime(2024, 2, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 953, new DateTime(2024, 2, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 954, new DateTime(2024, 2, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 955, new DateTime(2024, 2, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 956, new DateTime(2024, 2, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 957, new DateTime(2024, 2, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 958, new DateTime(2024, 2, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 959, new DateTime(2024, 2, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 960, new DateTime(2024, 2, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 961, new DateTime(2024, 2, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 962, new DateTime(2024, 2, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 963, new DateTime(2024, 2, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 964, new DateTime(2024, 2, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 965, new DateTime(2024, 2, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 966, new DateTime(2024, 2, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 967, new DateTime(2024, 2, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 968, new DateTime(2024, 2, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 969, new DateTime(2024, 2, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 970, new DateTime(2024, 2, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 971, new DateTime(2024, 2, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 972, new DateTime(2024, 2, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 973, new DateTime(2024, 2, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 974, new DateTime(2024, 2, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 975, new DateTime(2024, 2, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 976, new DateTime(2024, 2, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 977, new DateTime(2024, 2, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 978, new DateTime(2024, 2, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 979, new DateTime(2024, 2, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 980, new DateTime(2024, 2, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 981, new DateTime(2024, 2, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 982, new DateTime(2024, 2, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 983, new DateTime(2024, 2, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 984, new DateTime(2024, 2, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 985, new DateTime(2024, 2, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 986, new DateTime(2024, 2, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 987, new DateTime(2024, 2, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 988, new DateTime(2024, 2, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 989, new DateTime(2024, 2, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 990, new DateTime(2024, 2, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 991, new DateTime(2024, 2, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 992, new DateTime(2024, 2, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 993, new DateTime(2024, 2, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 994, new DateTime(2024, 2, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 995, new DateTime(2024, 2, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 996, new DateTime(2024, 2, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 997, new DateTime(2024, 2, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 998, new DateTime(2024, 2, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 999, new DateTime(2024, 2, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1000, new DateTime(2024, 2, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1001, new DateTime(2024, 2, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1002, new DateTime(2024, 2, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1003, new DateTime(2024, 2, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1004, new DateTime(2024, 2, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1005, new DateTime(2024, 2, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1006, new DateTime(2024, 2, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1007, new DateTime(2024, 2, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1008, new DateTime(2024, 2, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1009, new DateTime(2024, 2, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1010, new DateTime(2024, 2, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1011, new DateTime(2024, 2, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1012, new DateTime(2024, 2, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1013, new DateTime(2024, 2, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1014, new DateTime(2024, 2, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1015, new DateTime(2024, 2, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1016, new DateTime(2024, 2, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1017, new DateTime(2024, 2, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1018, new DateTime(2024, 2, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1019, new DateTime(2024, 2, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1020, new DateTime(2024, 2, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1021, new DateTime(2024, 2, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1022, new DateTime(2024, 2, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1023, new DateTime(2024, 2, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1024, new DateTime(2024, 2, 19, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 18, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1025, new DateTime(2024, 2, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1026, new DateTime(2024, 2, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1027, new DateTime(2024, 2, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1028, new DateTime(2024, 2, 20, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 18, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1029, new DateTime(2024, 2, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1030, new DateTime(2024, 2, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1031, new DateTime(2024, 2, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1032, new DateTime(2024, 2, 20, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 19, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1033, new DateTime(2024, 2, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1034, new DateTime(2024, 2, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1035, new DateTime(2024, 2, 20, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 19, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1036, new DateTime(2024, 2, 21, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 20, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1037, new DateTime(2024, 2, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 1038, new DateTime(2024, 2, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1039, new DateTime(2024, 2, 21, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 19, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1040, new DateTime(2024, 2, 22, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 20, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1041, new DateTime(2024, 2, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1042, new DateTime(2024, 2, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1043, new DateTime(2024, 2, 21, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 20, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1044, new DateTime(2024, 2, 22, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 21, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1045, new DateTime(2024, 2, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1046, new DateTime(2024, 2, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1047, new DateTime(2024, 2, 22, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 21, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1048, new DateTime(2024, 2, 23, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 22, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1049, new DateTime(2024, 2, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1050, new DateTime(2024, 2, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1051, new DateTime(2024, 2, 23, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 21, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1052, new DateTime(2024, 2, 24, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 22, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1053, new DateTime(2024, 2, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1054, new DateTime(2024, 2, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1055, new DateTime(2024, 2, 23, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 22, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1056, new DateTime(2024, 2, 24, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 23, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1057, new DateTime(2024, 2, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1058, new DateTime(2024, 2, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1059, new DateTime(2024, 2, 24, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 23, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1060, new DateTime(2024, 2, 25, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 24, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1061, new DateTime(2024, 2, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1062, new DateTime(2024, 2, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1063, new DateTime(2024, 2, 25, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 23, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1064, new DateTime(2024, 2, 26, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 24, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1065, new DateTime(2024, 2, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1066, new DateTime(2024, 2, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1067, new DateTime(2024, 2, 25, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 24, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1068, new DateTime(2024, 2, 26, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 25, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1069, new DateTime(2024, 2, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1070, new DateTime(2024, 2, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1071, new DateTime(2024, 2, 26, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 25, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1072, new DateTime(2024, 2, 27, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 26, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1073, new DateTime(2024, 2, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1074, new DateTime(2024, 2, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1075, new DateTime(2024, 2, 27, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 25, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1076, new DateTime(2024, 2, 28, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 26, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1077, new DateTime(2024, 2, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1078, new DateTime(2024, 2, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1079, new DateTime(2024, 2, 27, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 26, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 1080, new DateTime(2024, 2, 28, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 27, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1081, new DateTime(2024, 2, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1082, new DateTime(2024, 2, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1083, new DateTime(2024, 2, 28, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 27, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1084, new DateTime(2024, 2, 29, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 28, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1085, new DateTime(2024, 2, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1086, new DateTime(2024, 3, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1087, new DateTime(2024, 2, 29, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 27, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1088, new DateTime(2024, 3, 1, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 28, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1089, new DateTime(2024, 2, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1090, new DateTime(2024, 3, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1091, new DateTime(2024, 2, 29, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 28, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1092, new DateTime(2024, 3, 1, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 29, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1093, new DateTime(2024, 3, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1094, new DateTime(2024, 3, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1095, new DateTime(2024, 3, 1, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 29, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1096, new DateTime(2024, 3, 2, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 1, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1097, new DateTime(2024, 3, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1098, new DateTime(2024, 3, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1099, new DateTime(2024, 3, 2, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 29, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1100, new DateTime(2024, 3, 3, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 1, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1101, new DateTime(2024, 3, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1102, new DateTime(2024, 3, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1103, new DateTime(2024, 3, 2, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 1, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1104, new DateTime(2024, 3, 3, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 2, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1105, new DateTime(2024, 3, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1106, new DateTime(2024, 3, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1107, new DateTime(2024, 3, 3, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 2, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1108, new DateTime(2024, 3, 4, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 3, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1109, new DateTime(2024, 3, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1110, new DateTime(2024, 3, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1111, new DateTime(2024, 3, 4, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 2, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1112, new DateTime(2024, 3, 5, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 3, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1113, new DateTime(2024, 3, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1114, new DateTime(2024, 3, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1115, new DateTime(2024, 3, 4, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 3, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1116, new DateTime(2024, 3, 5, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 4, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1117, new DateTime(2024, 3, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1118, new DateTime(2024, 3, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1119, new DateTime(2024, 3, 5, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 4, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1120, new DateTime(2024, 3, 6, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 5, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1121, new DateTime(2024, 3, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 1122, new DateTime(2024, 3, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1123, new DateTime(2024, 3, 6, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 4, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1124, new DateTime(2024, 3, 7, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 5, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1125, new DateTime(2024, 3, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1126, new DateTime(2024, 3, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1127, new DateTime(2024, 3, 6, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 5, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1128, new DateTime(2024, 3, 7, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 6, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1129, new DateTime(2024, 3, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1130, new DateTime(2024, 3, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1131, new DateTime(2024, 3, 7, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 6, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1132, new DateTime(2024, 3, 8, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 7, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1133, new DateTime(2024, 3, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1134, new DateTime(2024, 3, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1135, new DateTime(2024, 3, 8, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 6, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1136, new DateTime(2024, 3, 9, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 7, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1137, new DateTime(2024, 3, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1138, new DateTime(2024, 3, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1139, new DateTime(2024, 3, 8, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 7, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1140, new DateTime(2024, 3, 9, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 8, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1141, new DateTime(2024, 3, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1142, new DateTime(2024, 3, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1143, new DateTime(2024, 3, 9, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 8, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1144, new DateTime(2024, 3, 10, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 9, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1145, new DateTime(2024, 3, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1146, new DateTime(2024, 3, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1147, new DateTime(2024, 3, 10, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 8, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1148, new DateTime(2024, 3, 11, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 9, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1149, new DateTime(2024, 3, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1150, new DateTime(2024, 3, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1151, new DateTime(2024, 3, 10, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 9, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1152, new DateTime(2024, 3, 11, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 10, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1153, new DateTime(2024, 3, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1154, new DateTime(2024, 3, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1155, new DateTime(2024, 3, 11, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 10, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1156, new DateTime(2024, 3, 12, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 11, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1157, new DateTime(2024, 3, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1158, new DateTime(2024, 3, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1159, new DateTime(2024, 3, 12, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 10, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1160, new DateTime(2024, 3, 13, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 11, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1161, new DateTime(2024, 3, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1162, new DateTime(2024, 3, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1163, new DateTime(2024, 3, 12, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 11, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 1164, new DateTime(2024, 3, 13, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 12, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1165, new DateTime(2024, 3, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1166, new DateTime(2024, 3, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1167, new DateTime(2024, 3, 13, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 12, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1168, new DateTime(2024, 3, 14, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 13, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1169, new DateTime(2024, 3, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1170, new DateTime(2024, 3, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1171, new DateTime(2024, 3, 14, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 12, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1172, new DateTime(2024, 3, 15, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 13, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1173, new DateTime(2024, 3, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1174, new DateTime(2024, 3, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1175, new DateTime(2024, 3, 14, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 13, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1176, new DateTime(2024, 3, 15, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 14, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1177, new DateTime(2024, 3, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1178, new DateTime(2024, 3, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1179, new DateTime(2024, 3, 15, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 14, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1180, new DateTime(2024, 3, 16, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 15, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1181, new DateTime(2024, 3, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1182, new DateTime(2024, 3, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1183, new DateTime(2024, 3, 16, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 14, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1184, new DateTime(2024, 3, 17, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 15, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1185, new DateTime(2024, 3, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1186, new DateTime(2024, 3, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1187, new DateTime(2024, 3, 16, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 15, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1188, new DateTime(2024, 3, 17, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 16, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1189, new DateTime(2024, 3, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1190, new DateTime(2024, 3, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1191, new DateTime(2024, 3, 17, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 16, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1192, new DateTime(2024, 3, 18, 23, 11, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 17, 15, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1193, new DateTime(2024, 3, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1194, new DateTime(2024, 3, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1195, new DateTime(2024, 3, 18, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 16, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1196, new DateTime(2024, 3, 19, 9, 1, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 17, 23, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1197, new DateTime(2024, 3, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1198, new DateTime(2024, 3, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1199, new DateTime(2024, 3, 18, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 17, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1200, new DateTime(2024, 3, 19, 17, 24, 34, 333, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 3, 18, 7, 46, 34, 333, DateTimeKind.Local).AddTicks(5721), false, "SE6 HN-SG Slow Train", 2, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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
                table: "Seats",
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

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_BookingId",
                table: "BookingDetails",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_ScheduleId",
                table: "BookingDetails",
                column: "ScheduleId");

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
                name: "IX_Fares_TypeCode",
                table: "Fares",
                column: "TypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_TypeCode",
                table: "Passengers",
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
                name: "IX_ScheduleSeat_SchedulesId",
                table: "ScheduleSeat",
                column: "SchedulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_CoachId",
                table: "Seats",
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
                name: "ScheduleSeat");

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
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "PassengerTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Routes");

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
