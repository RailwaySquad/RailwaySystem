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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Trip = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Passengers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeCode = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    BookingDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Passengers_BookingDetails_BookingDetailId",
                        column: x => x.BookingDetailId,
                        principalTable: "BookingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Passengers_PassengerTypes_TypeCode",
                        column: x => x.TypeCode,
                        principalTable: "PassengerTypes",
                        principalColumn: "Code");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Fares_FareId",
                        column: x => x.FareId,
                        principalTable: "Fares",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_PassengerID",
                        column: x => x.PassengerID,
                        principalTable: "Passengers",
                        principalColumn: "ID");
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
                        principalColumn: "PNRNo");
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
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
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
                    { 1, new DateTime(2023, 9, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 2, new DateTime(2023, 9, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 3, new DateTime(2023, 9, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 4, new DateTime(2023, 9, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 5, new DateTime(2023, 9, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 6, new DateTime(2023, 9, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 7, new DateTime(2023, 9, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 8, new DateTime(2023, 9, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 9, new DateTime(2023, 9, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 10, new DateTime(2023, 9, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 11, new DateTime(2023, 9, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 12, new DateTime(2023, 9, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 13, new DateTime(2023, 9, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 14, new DateTime(2023, 9, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 15, new DateTime(2023, 9, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 16, new DateTime(2023, 9, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 17, new DateTime(2023, 9, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 18, new DateTime(2023, 9, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 19, new DateTime(2023, 9, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 20, new DateTime(2023, 9, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 21, new DateTime(2023, 9, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 22, new DateTime(2023, 9, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 23, new DateTime(2023, 9, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 24, new DateTime(2023, 9, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 25, new DateTime(2023, 9, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 26, new DateTime(2023, 9, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 27, new DateTime(2023, 9, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 28, new DateTime(2023, 9, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 29, new DateTime(2023, 9, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 30, new DateTime(2023, 9, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 31, new DateTime(2023, 9, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 32, new DateTime(2023, 9, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 33, new DateTime(2023, 9, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 34, new DateTime(2023, 9, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 35, new DateTime(2023, 9, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 36, new DateTime(2023, 9, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 37, new DateTime(2023, 9, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 38, new DateTime(2023, 9, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 39, new DateTime(2023, 9, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 40, new DateTime(2023, 9, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 41, new DateTime(2023, 9, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 42, new DateTime(2023, 9, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 43, new DateTime(2023, 9, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 44, new DateTime(2023, 9, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 45, new DateTime(2023, 9, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 46, new DateTime(2023, 9, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 47, new DateTime(2023, 9, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 48, new DateTime(2023, 9, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 49, new DateTime(2023, 9, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 50, new DateTime(2023, 9, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 51, new DateTime(2023, 9, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 52, new DateTime(2023, 9, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 53, new DateTime(2023, 9, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 54, new DateTime(2023, 9, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 55, new DateTime(2023, 9, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 56, new DateTime(2023, 9, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 57, new DateTime(2023, 9, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 58, new DateTime(2023, 9, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 59, new DateTime(2023, 9, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 60, new DateTime(2023, 9, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 61, new DateTime(2023, 9, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 62, new DateTime(2023, 9, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 63, new DateTime(2023, 9, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 64, new DateTime(2023, 9, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 65, new DateTime(2023, 9, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 66, new DateTime(2023, 9, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 67, new DateTime(2023, 9, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 68, new DateTime(2023, 9, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 69, new DateTime(2023, 9, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 70, new DateTime(2023, 9, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 71, new DateTime(2023, 9, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 72, new DateTime(2023, 9, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 73, new DateTime(2023, 9, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 74, new DateTime(2023, 9, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 75, new DateTime(2023, 9, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 76, new DateTime(2023, 9, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 77, new DateTime(2023, 9, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 78, new DateTime(2023, 9, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 79, new DateTime(2023, 9, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 80, new DateTime(2023, 9, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 81, new DateTime(2023, 9, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 82, new DateTime(2023, 9, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 83, new DateTime(2023, 9, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 84, new DateTime(2023, 9, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 85, new DateTime(2023, 9, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 86, new DateTime(2023, 9, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 87, new DateTime(2023, 9, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 88, new DateTime(2023, 9, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 89, new DateTime(2023, 9, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 90, new DateTime(2023, 9, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 91, new DateTime(2023, 9, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 92, new DateTime(2023, 9, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 93, new DateTime(2023, 9, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 94, new DateTime(2023, 9, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 95, new DateTime(2023, 9, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 96, new DateTime(2023, 9, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 97, new DateTime(2023, 9, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 98, new DateTime(2023, 9, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 99, new DateTime(2023, 9, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 100, new DateTime(2023, 9, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 101, new DateTime(2023, 9, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 102, new DateTime(2023, 9, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 103, new DateTime(2023, 9, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 104, new DateTime(2023, 9, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 105, new DateTime(2023, 9, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 106, new DateTime(2023, 9, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 107, new DateTime(2023, 9, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 108, new DateTime(2023, 9, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 109, new DateTime(2023, 9, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 110, new DateTime(2023, 9, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 111, new DateTime(2023, 9, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 112, new DateTime(2023, 9, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 113, new DateTime(2023, 9, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 114, new DateTime(2023, 9, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 115, new DateTime(2023, 9, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 116, new DateTime(2023, 9, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 117, new DateTime(2023, 9, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 118, new DateTime(2023, 9, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 119, new DateTime(2023, 9, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 120, new DateTime(2023, 9, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 121, new DateTime(2023, 9, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 122, new DateTime(2023, 9, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 123, new DateTime(2023, 9, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 124, new DateTime(2023, 9, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 125, new DateTime(2023, 9, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 126, new DateTime(2023, 9, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 127, new DateTime(2023, 9, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 128, new DateTime(2023, 9, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 129, new DateTime(2023, 9, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 130, new DateTime(2023, 9, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 131, new DateTime(2023, 9, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 132, new DateTime(2023, 9, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 133, new DateTime(2023, 9, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 134, new DateTime(2023, 9, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 135, new DateTime(2023, 9, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 136, new DateTime(2023, 9, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 137, new DateTime(2023, 9, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 138, new DateTime(2023, 9, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 139, new DateTime(2023, 9, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 140, new DateTime(2023, 9, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 141, new DateTime(2023, 9, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 142, new DateTime(2023, 9, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 143, new DateTime(2023, 9, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 144, new DateTime(2023, 9, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 145, new DateTime(2023, 9, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 146, new DateTime(2023, 9, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 147, new DateTime(2023, 9, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 148, new DateTime(2023, 9, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 149, new DateTime(2023, 9, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 150, new DateTime(2023, 9, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 151, new DateTime(2023, 9, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 152, new DateTime(2023, 9, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 153, new DateTime(2023, 9, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 154, new DateTime(2023, 9, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 155, new DateTime(2023, 9, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 156, new DateTime(2023, 9, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 157, new DateTime(2023, 9, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 158, new DateTime(2023, 9, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 159, new DateTime(2023, 9, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 160, new DateTime(2023, 9, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 161, new DateTime(2023, 9, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 162, new DateTime(2023, 9, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 163, new DateTime(2023, 9, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 164, new DateTime(2023, 9, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 165, new DateTime(2023, 9, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 166, new DateTime(2023, 10, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 167, new DateTime(2023, 9, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 168, new DateTime(2023, 10, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 169, new DateTime(2023, 10, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 170, new DateTime(2023, 10, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 171, new DateTime(2023, 10, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 172, new DateTime(2023, 10, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 173, new DateTime(2023, 10, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 174, new DateTime(2023, 10, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 175, new DateTime(2023, 10, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 176, new DateTime(2023, 10, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 177, new DateTime(2023, 10, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 178, new DateTime(2023, 10, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 179, new DateTime(2023, 10, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 9, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 180, new DateTime(2023, 10, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 181, new DateTime(2023, 10, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 182, new DateTime(2023, 10, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 183, new DateTime(2023, 10, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 184, new DateTime(2023, 10, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 185, new DateTime(2023, 10, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 186, new DateTime(2023, 10, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 187, new DateTime(2023, 10, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 188, new DateTime(2023, 10, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 189, new DateTime(2023, 10, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 190, new DateTime(2023, 10, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 191, new DateTime(2023, 10, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 192, new DateTime(2023, 10, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 193, new DateTime(2023, 10, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 194, new DateTime(2023, 10, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 195, new DateTime(2023, 10, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 196, new DateTime(2023, 10, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 197, new DateTime(2023, 10, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 198, new DateTime(2023, 10, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 199, new DateTime(2023, 10, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 200, new DateTime(2023, 10, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 201, new DateTime(2023, 10, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 202, new DateTime(2023, 10, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 203, new DateTime(2023, 10, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 204, new DateTime(2023, 10, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 205, new DateTime(2023, 10, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 206, new DateTime(2023, 10, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 207, new DateTime(2023, 10, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 208, new DateTime(2023, 10, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 209, new DateTime(2023, 10, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 210, new DateTime(2023, 10, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 211, new DateTime(2023, 10, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 212, new DateTime(2023, 10, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 213, new DateTime(2023, 10, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 214, new DateTime(2023, 10, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 215, new DateTime(2023, 10, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 216, new DateTime(2023, 10, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 217, new DateTime(2023, 10, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 218, new DateTime(2023, 10, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 219, new DateTime(2023, 10, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 220, new DateTime(2023, 10, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 221, new DateTime(2023, 10, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 222, new DateTime(2023, 10, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 223, new DateTime(2023, 10, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 224, new DateTime(2023, 10, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 225, new DateTime(2023, 10, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 226, new DateTime(2023, 10, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 227, new DateTime(2023, 10, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 228, new DateTime(2023, 10, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 229, new DateTime(2023, 10, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 230, new DateTime(2023, 10, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 231, new DateTime(2023, 10, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 232, new DateTime(2023, 10, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 233, new DateTime(2023, 10, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 234, new DateTime(2023, 10, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 235, new DateTime(2023, 10, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 236, new DateTime(2023, 10, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 237, new DateTime(2023, 10, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 238, new DateTime(2023, 10, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 239, new DateTime(2023, 10, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 240, new DateTime(2023, 10, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 241, new DateTime(2023, 10, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 242, new DateTime(2023, 10, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 243, new DateTime(2023, 10, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 244, new DateTime(2023, 10, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 245, new DateTime(2023, 10, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 246, new DateTime(2023, 10, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 247, new DateTime(2023, 10, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 248, new DateTime(2023, 10, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 249, new DateTime(2023, 10, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 250, new DateTime(2023, 10, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 251, new DateTime(2023, 10, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 252, new DateTime(2023, 10, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 253, new DateTime(2023, 10, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 254, new DateTime(2023, 10, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 255, new DateTime(2023, 10, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 256, new DateTime(2023, 10, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 257, new DateTime(2023, 10, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 258, new DateTime(2023, 10, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 259, new DateTime(2023, 10, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 260, new DateTime(2023, 10, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 261, new DateTime(2023, 10, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 262, new DateTime(2023, 10, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 263, new DateTime(2023, 10, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 264, new DateTime(2023, 10, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 265, new DateTime(2023, 10, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 266, new DateTime(2023, 10, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 267, new DateTime(2023, 10, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 268, new DateTime(2023, 10, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 269, new DateTime(2023, 10, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 270, new DateTime(2023, 10, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 271, new DateTime(2023, 10, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 272, new DateTime(2023, 10, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 273, new DateTime(2023, 10, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 274, new DateTime(2023, 10, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 275, new DateTime(2023, 10, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 276, new DateTime(2023, 10, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 277, new DateTime(2023, 10, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 278, new DateTime(2023, 10, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 279, new DateTime(2023, 10, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 280, new DateTime(2023, 10, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 281, new DateTime(2023, 10, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 282, new DateTime(2023, 10, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 283, new DateTime(2023, 10, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 284, new DateTime(2023, 10, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 285, new DateTime(2023, 10, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 286, new DateTime(2023, 10, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 287, new DateTime(2023, 10, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 288, new DateTime(2023, 10, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 289, new DateTime(2023, 10, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 290, new DateTime(2023, 10, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 291, new DateTime(2023, 10, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 292, new DateTime(2023, 10, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 293, new DateTime(2023, 10, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 294, new DateTime(2023, 10, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 295, new DateTime(2023, 10, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 296, new DateTime(2023, 10, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 297, new DateTime(2023, 10, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 298, new DateTime(2023, 10, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 299, new DateTime(2023, 10, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 300, new DateTime(2023, 10, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 301, new DateTime(2023, 10, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 302, new DateTime(2023, 10, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 303, new DateTime(2023, 10, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 304, new DateTime(2023, 10, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 305, new DateTime(2023, 10, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 306, new DateTime(2023, 10, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 307, new DateTime(2023, 10, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 308, new DateTime(2023, 10, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 309, new DateTime(2023, 10, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 310, new DateTime(2023, 10, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 311, new DateTime(2023, 10, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 312, new DateTime(2023, 10, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 313, new DateTime(2023, 10, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 314, new DateTime(2023, 10, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 315, new DateTime(2023, 10, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 316, new DateTime(2023, 10, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 317, new DateTime(2023, 10, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 318, new DateTime(2023, 10, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 319, new DateTime(2023, 10, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 320, new DateTime(2023, 10, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 321, new DateTime(2023, 10, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 322, new DateTime(2023, 10, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 323, new DateTime(2023, 10, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 324, new DateTime(2023, 10, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 325, new DateTime(2023, 10, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 326, new DateTime(2023, 10, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 327, new DateTime(2023, 10, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 328, new DateTime(2023, 10, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 329, new DateTime(2023, 10, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 330, new DateTime(2023, 10, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 331, new DateTime(2023, 10, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 332, new DateTime(2023, 10, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 333, new DateTime(2023, 10, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 334, new DateTime(2023, 10, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 335, new DateTime(2023, 10, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 336, new DateTime(2023, 10, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 337, new DateTime(2023, 10, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 338, new DateTime(2023, 10, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 339, new DateTime(2023, 10, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 340, new DateTime(2023, 10, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 341, new DateTime(2023, 10, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 342, new DateTime(2023, 10, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 343, new DateTime(2023, 10, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 344, new DateTime(2023, 10, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 345, new DateTime(2023, 10, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 346, new DateTime(2023, 10, 31, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 347, new DateTime(2023, 10, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 348, new DateTime(2023, 10, 31, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 349, new DateTime(2023, 10, 31, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 350, new DateTime(2023, 11, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 31, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 351, new DateTime(2023, 10, 31, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 352, new DateTime(2023, 11, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 31, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 353, new DateTime(2023, 10, 31, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 354, new DateTime(2023, 11, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 31, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 355, new DateTime(2023, 10, 31, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 356, new DateTime(2023, 11, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 31, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 357, new DateTime(2023, 11, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 358, new DateTime(2023, 11, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 31, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 359, new DateTime(2023, 11, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 360, new DateTime(2023, 11, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 10, 31, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 361, new DateTime(2023, 11, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 362, new DateTime(2023, 11, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 363, new DateTime(2023, 11, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 364, new DateTime(2023, 11, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 365, new DateTime(2023, 11, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 366, new DateTime(2023, 11, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 367, new DateTime(2023, 11, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 368, new DateTime(2023, 11, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 369, new DateTime(2023, 11, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 370, new DateTime(2023, 11, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 371, new DateTime(2023, 11, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 372, new DateTime(2023, 11, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 373, new DateTime(2023, 11, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 374, new DateTime(2023, 11, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 375, new DateTime(2023, 11, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 376, new DateTime(2023, 11, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 377, new DateTime(2023, 11, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 378, new DateTime(2023, 11, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 379, new DateTime(2023, 11, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 380, new DateTime(2023, 11, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 381, new DateTime(2023, 11, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 382, new DateTime(2023, 11, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 383, new DateTime(2023, 11, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 384, new DateTime(2023, 11, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 385, new DateTime(2023, 11, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 386, new DateTime(2023, 11, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 387, new DateTime(2023, 11, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 388, new DateTime(2023, 11, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 389, new DateTime(2023, 11, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 390, new DateTime(2023, 11, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 391, new DateTime(2023, 11, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 392, new DateTime(2023, 11, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 393, new DateTime(2023, 11, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 394, new DateTime(2023, 11, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 395, new DateTime(2023, 11, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 396, new DateTime(2023, 11, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 397, new DateTime(2023, 11, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 398, new DateTime(2023, 11, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 399, new DateTime(2023, 11, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 400, new DateTime(2023, 11, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 401, new DateTime(2023, 11, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 402, new DateTime(2023, 11, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 403, new DateTime(2023, 11, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 404, new DateTime(2023, 11, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 405, new DateTime(2023, 11, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 406, new DateTime(2023, 11, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 407, new DateTime(2023, 11, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 408, new DateTime(2023, 11, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 409, new DateTime(2023, 11, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 410, new DateTime(2023, 11, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 411, new DateTime(2023, 11, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 412, new DateTime(2023, 11, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 413, new DateTime(2023, 11, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 414, new DateTime(2023, 11, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 415, new DateTime(2023, 11, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 416, new DateTime(2023, 11, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 417, new DateTime(2023, 11, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 418, new DateTime(2023, 11, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 419, new DateTime(2023, 11, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 420, new DateTime(2023, 11, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 421, new DateTime(2023, 11, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 422, new DateTime(2023, 11, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 423, new DateTime(2023, 11, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 424, new DateTime(2023, 11, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 425, new DateTime(2023, 11, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 426, new DateTime(2023, 11, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 427, new DateTime(2023, 11, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 428, new DateTime(2023, 11, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 429, new DateTime(2023, 11, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 430, new DateTime(2023, 11, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 431, new DateTime(2023, 11, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 432, new DateTime(2023, 11, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 433, new DateTime(2023, 11, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 434, new DateTime(2023, 11, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 435, new DateTime(2023, 11, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 436, new DateTime(2023, 11, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 437, new DateTime(2023, 11, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 438, new DateTime(2023, 11, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 439, new DateTime(2023, 11, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 440, new DateTime(2023, 11, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 441, new DateTime(2023, 11, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 442, new DateTime(2023, 11, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 443, new DateTime(2023, 11, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 444, new DateTime(2023, 11, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 445, new DateTime(2023, 11, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 446, new DateTime(2023, 11, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 447, new DateTime(2023, 11, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 448, new DateTime(2023, 11, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 449, new DateTime(2023, 11, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 450, new DateTime(2023, 11, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 451, new DateTime(2023, 11, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 452, new DateTime(2023, 11, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 453, new DateTime(2023, 11, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 454, new DateTime(2023, 11, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 455, new DateTime(2023, 11, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 456, new DateTime(2023, 11, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 457, new DateTime(2023, 11, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 458, new DateTime(2023, 11, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 459, new DateTime(2023, 11, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 460, new DateTime(2023, 11, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 461, new DateTime(2023, 11, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 462, new DateTime(2023, 11, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 463, new DateTime(2023, 11, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 464, new DateTime(2023, 11, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 465, new DateTime(2023, 11, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 466, new DateTime(2023, 11, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 467, new DateTime(2023, 11, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 468, new DateTime(2023, 11, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 469, new DateTime(2023, 11, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 470, new DateTime(2023, 11, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 471, new DateTime(2023, 11, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 472, new DateTime(2023, 11, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 473, new DateTime(2023, 11, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 474, new DateTime(2023, 11, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 475, new DateTime(2023, 11, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 476, new DateTime(2023, 11, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 477, new DateTime(2023, 11, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 478, new DateTime(2023, 11, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 479, new DateTime(2023, 11, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 480, new DateTime(2023, 11, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 481, new DateTime(2023, 11, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 482, new DateTime(2023, 11, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 483, new DateTime(2023, 11, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 484, new DateTime(2023, 11, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 485, new DateTime(2023, 11, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 486, new DateTime(2023, 11, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 487, new DateTime(2023, 11, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 488, new DateTime(2023, 11, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 489, new DateTime(2023, 11, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 490, new DateTime(2023, 11, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 491, new DateTime(2023, 11, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 492, new DateTime(2023, 11, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 493, new DateTime(2023, 11, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 494, new DateTime(2023, 11, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 495, new DateTime(2023, 11, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 496, new DateTime(2023, 11, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 497, new DateTime(2023, 11, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 498, new DateTime(2023, 11, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 499, new DateTime(2023, 11, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 500, new DateTime(2023, 11, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 501, new DateTime(2023, 11, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 502, new DateTime(2023, 11, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 503, new DateTime(2023, 11, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 504, new DateTime(2023, 11, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 505, new DateTime(2023, 11, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 506, new DateTime(2023, 11, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 507, new DateTime(2023, 11, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 508, new DateTime(2023, 11, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 509, new DateTime(2023, 11, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 510, new DateTime(2023, 11, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 511, new DateTime(2023, 11, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 512, new DateTime(2023, 11, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 513, new DateTime(2023, 11, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 514, new DateTime(2023, 11, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 515, new DateTime(2023, 11, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 516, new DateTime(2023, 11, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 517, new DateTime(2023, 11, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 518, new DateTime(2023, 11, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 519, new DateTime(2023, 11, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 520, new DateTime(2023, 11, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 521, new DateTime(2023, 11, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 522, new DateTime(2023, 11, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 523, new DateTime(2023, 11, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 524, new DateTime(2023, 11, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 525, new DateTime(2023, 11, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 526, new DateTime(2023, 11, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 527, new DateTime(2023, 11, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 528, new DateTime(2023, 11, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 529, new DateTime(2023, 11, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 530, new DateTime(2023, 12, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 531, new DateTime(2023, 11, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 532, new DateTime(2023, 12, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 533, new DateTime(2023, 11, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 534, new DateTime(2023, 12, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 535, new DateTime(2023, 11, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 536, new DateTime(2023, 12, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 537, new DateTime(2023, 12, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 538, new DateTime(2023, 12, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 539, new DateTime(2023, 12, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 540, new DateTime(2023, 12, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 541, new DateTime(2023, 12, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 542, new DateTime(2023, 12, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 543, new DateTime(2023, 12, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 544, new DateTime(2023, 12, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 545, new DateTime(2023, 12, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 546, new DateTime(2023, 12, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 547, new DateTime(2023, 12, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 548, new DateTime(2023, 12, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 549, new DateTime(2023, 12, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 550, new DateTime(2023, 12, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 551, new DateTime(2023, 12, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 552, new DateTime(2023, 12, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 553, new DateTime(2023, 12, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 554, new DateTime(2023, 12, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 555, new DateTime(2023, 12, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 556, new DateTime(2023, 12, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 557, new DateTime(2023, 12, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 558, new DateTime(2023, 12, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 559, new DateTime(2023, 12, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 560, new DateTime(2023, 12, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 561, new DateTime(2023, 12, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 562, new DateTime(2023, 12, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 563, new DateTime(2023, 12, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 564, new DateTime(2023, 12, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 565, new DateTime(2023, 12, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 566, new DateTime(2023, 12, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 567, new DateTime(2023, 12, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 568, new DateTime(2023, 12, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 569, new DateTime(2023, 12, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 570, new DateTime(2023, 12, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 571, new DateTime(2023, 12, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 572, new DateTime(2023, 12, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 573, new DateTime(2023, 12, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 574, new DateTime(2023, 12, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 575, new DateTime(2023, 12, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 576, new DateTime(2023, 12, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 577, new DateTime(2023, 12, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 578, new DateTime(2023, 12, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 579, new DateTime(2023, 12, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 580, new DateTime(2023, 12, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 581, new DateTime(2023, 12, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 582, new DateTime(2023, 12, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 583, new DateTime(2023, 12, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 584, new DateTime(2023, 12, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 585, new DateTime(2023, 12, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 586, new DateTime(2023, 12, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 587, new DateTime(2023, 12, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 588, new DateTime(2023, 12, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 589, new DateTime(2023, 12, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 590, new DateTime(2023, 12, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 591, new DateTime(2023, 12, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 592, new DateTime(2023, 12, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 593, new DateTime(2023, 12, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 594, new DateTime(2023, 12, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 595, new DateTime(2023, 12, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 596, new DateTime(2023, 12, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 597, new DateTime(2023, 12, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 598, new DateTime(2023, 12, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 599, new DateTime(2023, 12, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 600, new DateTime(2023, 12, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 601, new DateTime(2023, 12, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 602, new DateTime(2023, 12, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 603, new DateTime(2023, 12, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 604, new DateTime(2023, 12, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 605, new DateTime(2023, 12, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 606, new DateTime(2023, 12, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 607, new DateTime(2023, 12, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 608, new DateTime(2023, 12, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 609, new DateTime(2023, 12, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 610, new DateTime(2023, 12, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 611, new DateTime(2023, 12, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 612, new DateTime(2023, 12, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 613, new DateTime(2023, 12, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 614, new DateTime(2023, 12, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 615, new DateTime(2023, 12, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 616, new DateTime(2023, 12, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 617, new DateTime(2023, 12, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 618, new DateTime(2023, 12, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 619, new DateTime(2023, 12, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 620, new DateTime(2023, 12, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 621, new DateTime(2023, 12, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 622, new DateTime(2023, 12, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 623, new DateTime(2023, 12, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 624, new DateTime(2023, 12, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 625, new DateTime(2023, 12, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 626, new DateTime(2023, 12, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 627, new DateTime(2023, 12, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 628, new DateTime(2023, 12, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 629, new DateTime(2023, 12, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 630, new DateTime(2023, 12, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 631, new DateTime(2023, 12, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 632, new DateTime(2023, 12, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 633, new DateTime(2023, 12, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 634, new DateTime(2023, 12, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 635, new DateTime(2023, 12, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 636, new DateTime(2023, 12, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 637, new DateTime(2023, 12, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 638, new DateTime(2023, 12, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 639, new DateTime(2023, 12, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 640, new DateTime(2023, 12, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 641, new DateTime(2023, 12, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 642, new DateTime(2023, 12, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 643, new DateTime(2023, 12, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 644, new DateTime(2023, 12, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 645, new DateTime(2023, 12, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 646, new DateTime(2023, 12, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 647, new DateTime(2023, 12, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 648, new DateTime(2023, 12, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 649, new DateTime(2023, 12, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 650, new DateTime(2023, 12, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 651, new DateTime(2023, 12, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 652, new DateTime(2023, 12, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 653, new DateTime(2023, 12, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 654, new DateTime(2023, 12, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 655, new DateTime(2023, 12, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 656, new DateTime(2023, 12, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 657, new DateTime(2023, 12, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 658, new DateTime(2023, 12, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 659, new DateTime(2023, 12, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 660, new DateTime(2023, 12, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 661, new DateTime(2023, 12, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 662, new DateTime(2023, 12, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 663, new DateTime(2023, 12, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 664, new DateTime(2023, 12, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 665, new DateTime(2023, 12, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 666, new DateTime(2023, 12, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 667, new DateTime(2023, 12, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 668, new DateTime(2023, 12, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 669, new DateTime(2023, 12, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 670, new DateTime(2023, 12, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 671, new DateTime(2023, 12, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 672, new DateTime(2023, 12, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 673, new DateTime(2023, 12, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 674, new DateTime(2023, 12, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 675, new DateTime(2023, 12, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 676, new DateTime(2023, 12, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 677, new DateTime(2023, 12, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 678, new DateTime(2023, 12, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 679, new DateTime(2023, 12, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 680, new DateTime(2023, 12, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 681, new DateTime(2023, 12, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 682, new DateTime(2023, 12, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 683, new DateTime(2023, 12, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 684, new DateTime(2023, 12, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 685, new DateTime(2023, 12, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 686, new DateTime(2023, 12, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 687, new DateTime(2023, 12, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 688, new DateTime(2023, 12, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 689, new DateTime(2023, 12, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 690, new DateTime(2023, 12, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 691, new DateTime(2023, 12, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 692, new DateTime(2023, 12, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 693, new DateTime(2023, 12, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 694, new DateTime(2023, 12, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 695, new DateTime(2023, 12, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 696, new DateTime(2023, 12, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 697, new DateTime(2023, 12, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 698, new DateTime(2023, 12, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 699, new DateTime(2023, 12, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 700, new DateTime(2023, 12, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 701, new DateTime(2023, 12, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 702, new DateTime(2023, 12, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 703, new DateTime(2023, 12, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 704, new DateTime(2023, 12, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 705, new DateTime(2023, 12, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 706, new DateTime(2023, 12, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 707, new DateTime(2023, 12, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 708, new DateTime(2023, 12, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 709, new DateTime(2023, 12, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 710, new DateTime(2023, 12, 31, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 711, new DateTime(2023, 12, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 712, new DateTime(2023, 12, 31, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 713, new DateTime(2023, 12, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 714, new DateTime(2023, 12, 31, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 715, new DateTime(2023, 12, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 716, new DateTime(2023, 12, 31, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 717, new DateTime(2023, 12, 31, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 718, new DateTime(2024, 1, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 719, new DateTime(2023, 12, 31, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 720, new DateTime(2024, 1, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 721, new DateTime(2024, 1, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 31, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 722, new DateTime(2024, 1, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 723, new DateTime(2024, 1, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 31, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 724, new DateTime(2024, 1, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 725, new DateTime(2024, 1, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 31, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 726, new DateTime(2024, 1, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 727, new DateTime(2024, 1, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 31, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 728, new DateTime(2024, 1, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 729, new DateTime(2024, 1, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 31, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 730, new DateTime(2024, 1, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 731, new DateTime(2024, 1, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 31, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 732, new DateTime(2024, 1, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 733, new DateTime(2024, 1, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 734, new DateTime(2024, 1, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 735, new DateTime(2024, 1, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 736, new DateTime(2024, 1, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 737, new DateTime(2024, 1, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 738, new DateTime(2024, 1, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 739, new DateTime(2024, 1, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 740, new DateTime(2024, 1, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 741, new DateTime(2024, 1, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 742, new DateTime(2024, 1, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 743, new DateTime(2024, 1, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 744, new DateTime(2024, 1, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 745, new DateTime(2024, 1, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 746, new DateTime(2024, 1, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 747, new DateTime(2024, 1, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 748, new DateTime(2024, 1, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 749, new DateTime(2024, 1, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 750, new DateTime(2024, 1, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 751, new DateTime(2024, 1, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 752, new DateTime(2024, 1, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 753, new DateTime(2024, 1, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 754, new DateTime(2024, 1, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 755, new DateTime(2024, 1, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 756, new DateTime(2024, 1, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 757, new DateTime(2024, 1, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 758, new DateTime(2024, 1, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 759, new DateTime(2024, 1, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 760, new DateTime(2024, 1, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 761, new DateTime(2024, 1, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 762, new DateTime(2024, 1, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 763, new DateTime(2024, 1, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 764, new DateTime(2024, 1, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 765, new DateTime(2024, 1, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 766, new DateTime(2024, 1, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 767, new DateTime(2024, 1, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 768, new DateTime(2024, 1, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 769, new DateTime(2024, 1, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 770, new DateTime(2024, 1, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 771, new DateTime(2024, 1, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 772, new DateTime(2024, 1, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 773, new DateTime(2024, 1, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 774, new DateTime(2024, 1, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 775, new DateTime(2024, 1, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 776, new DateTime(2024, 1, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 777, new DateTime(2024, 1, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 778, new DateTime(2024, 1, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 779, new DateTime(2024, 1, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 780, new DateTime(2024, 1, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 781, new DateTime(2024, 1, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 782, new DateTime(2024, 1, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 783, new DateTime(2024, 1, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 784, new DateTime(2024, 1, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 785, new DateTime(2024, 1, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 786, new DateTime(2024, 1, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 787, new DateTime(2024, 1, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 788, new DateTime(2024, 1, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 789, new DateTime(2024, 1, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 790, new DateTime(2024, 1, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 791, new DateTime(2024, 1, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 792, new DateTime(2024, 1, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 793, new DateTime(2024, 1, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 794, new DateTime(2024, 1, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 795, new DateTime(2024, 1, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 796, new DateTime(2024, 1, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 797, new DateTime(2024, 1, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 798, new DateTime(2024, 1, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 799, new DateTime(2024, 1, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 800, new DateTime(2024, 1, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 801, new DateTime(2024, 1, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 802, new DateTime(2024, 1, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 803, new DateTime(2024, 1, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 804, new DateTime(2024, 1, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 805, new DateTime(2024, 1, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 806, new DateTime(2024, 1, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 807, new DateTime(2024, 1, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 808, new DateTime(2024, 1, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 809, new DateTime(2024, 1, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 810, new DateTime(2024, 1, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 811, new DateTime(2024, 1, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 812, new DateTime(2024, 1, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 813, new DateTime(2024, 1, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 814, new DateTime(2024, 1, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 815, new DateTime(2024, 1, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 816, new DateTime(2024, 1, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 817, new DateTime(2024, 1, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 818, new DateTime(2024, 1, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 819, new DateTime(2024, 1, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 820, new DateTime(2024, 1, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 821, new DateTime(2024, 1, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 822, new DateTime(2024, 1, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 823, new DateTime(2024, 1, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 824, new DateTime(2024, 1, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 825, new DateTime(2024, 1, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 826, new DateTime(2024, 1, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 827, new DateTime(2024, 1, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 828, new DateTime(2024, 1, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 829, new DateTime(2024, 1, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 830, new DateTime(2024, 1, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 831, new DateTime(2024, 1, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 832, new DateTime(2024, 1, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 833, new DateTime(2024, 1, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 834, new DateTime(2024, 1, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 835, new DateTime(2024, 1, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 836, new DateTime(2024, 1, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 837, new DateTime(2024, 1, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 838, new DateTime(2024, 1, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 839, new DateTime(2024, 1, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 840, new DateTime(2024, 1, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 841, new DateTime(2024, 1, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 842, new DateTime(2024, 1, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 843, new DateTime(2024, 1, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 844, new DateTime(2024, 1, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 845, new DateTime(2024, 1, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 846, new DateTime(2024, 1, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 847, new DateTime(2024, 1, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 848, new DateTime(2024, 1, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 849, new DateTime(2024, 1, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 850, new DateTime(2024, 1, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 851, new DateTime(2024, 1, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 852, new DateTime(2024, 1, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 853, new DateTime(2024, 1, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 854, new DateTime(2024, 1, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 855, new DateTime(2024, 1, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 856, new DateTime(2024, 1, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 857, new DateTime(2024, 1, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 858, new DateTime(2024, 1, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 859, new DateTime(2024, 1, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 860, new DateTime(2024, 1, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 861, new DateTime(2024, 1, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 862, new DateTime(2024, 1, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 863, new DateTime(2024, 1, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 864, new DateTime(2024, 1, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 865, new DateTime(2024, 1, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 866, new DateTime(2024, 1, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 867, new DateTime(2024, 1, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 868, new DateTime(2024, 1, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 869, new DateTime(2024, 1, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 870, new DateTime(2024, 1, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 871, new DateTime(2024, 1, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 872, new DateTime(2024, 1, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 873, new DateTime(2024, 1, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 874, new DateTime(2024, 1, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 875, new DateTime(2024, 1, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 876, new DateTime(2024, 1, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 877, new DateTime(2024, 1, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 878, new DateTime(2024, 1, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 879, new DateTime(2024, 1, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 880, new DateTime(2024, 1, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 881, new DateTime(2024, 1, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 882, new DateTime(2024, 1, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 883, new DateTime(2024, 1, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 884, new DateTime(2024, 1, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 885, new DateTime(2024, 1, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 886, new DateTime(2024, 1, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 887, new DateTime(2024, 1, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 888, new DateTime(2024, 1, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 889, new DateTime(2024, 1, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 890, new DateTime(2024, 1, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 891, new DateTime(2024, 1, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 892, new DateTime(2024, 1, 30, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 893, new DateTime(2024, 1, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 894, new DateTime(2024, 1, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 895, new DateTime(2024, 1, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 896, new DateTime(2024, 1, 30, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 897, new DateTime(2024, 1, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 898, new DateTime(2024, 1, 31, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 899, new DateTime(2024, 1, 30, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 900, new DateTime(2024, 1, 31, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 901, new DateTime(2024, 1, 31, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 902, new DateTime(2024, 2, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 31, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 903, new DateTime(2024, 1, 31, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 30, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 904, new DateTime(2024, 2, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 31, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 905, new DateTime(2024, 1, 31, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 906, new DateTime(2024, 2, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 31, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 907, new DateTime(2024, 1, 31, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 30, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 908, new DateTime(2024, 2, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 31, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 909, new DateTime(2024, 2, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 910, new DateTime(2024, 2, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 31, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 911, new DateTime(2024, 2, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 30, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 912, new DateTime(2024, 2, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 31, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 913, new DateTime(2024, 2, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 914, new DateTime(2024, 2, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 915, new DateTime(2024, 2, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 916, new DateTime(2024, 2, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 917, new DateTime(2024, 2, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 918, new DateTime(2024, 2, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 919, new DateTime(2024, 2, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 920, new DateTime(2024, 2, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 921, new DateTime(2024, 2, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 922, new DateTime(2024, 2, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 923, new DateTime(2024, 2, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 924, new DateTime(2024, 2, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 925, new DateTime(2024, 2, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 926, new DateTime(2024, 2, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 927, new DateTime(2024, 2, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 928, new DateTime(2024, 2, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 929, new DateTime(2024, 2, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 930, new DateTime(2024, 2, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 931, new DateTime(2024, 2, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 932, new DateTime(2024, 2, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 933, new DateTime(2024, 2, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 934, new DateTime(2024, 2, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 935, new DateTime(2024, 2, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 936, new DateTime(2024, 2, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 937, new DateTime(2024, 2, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 938, new DateTime(2024, 2, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 939, new DateTime(2024, 2, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 940, new DateTime(2024, 2, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 941, new DateTime(2024, 2, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 942, new DateTime(2024, 2, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 943, new DateTime(2024, 2, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 944, new DateTime(2024, 2, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 945, new DateTime(2024, 2, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 946, new DateTime(2024, 2, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 947, new DateTime(2024, 2, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 948, new DateTime(2024, 2, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 949, new DateTime(2024, 2, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 950, new DateTime(2024, 2, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 951, new DateTime(2024, 2, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 952, new DateTime(2024, 2, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 953, new DateTime(2024, 2, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 954, new DateTime(2024, 2, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 955, new DateTime(2024, 2, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 956, new DateTime(2024, 2, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 957, new DateTime(2024, 2, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 958, new DateTime(2024, 2, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 959, new DateTime(2024, 2, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 960, new DateTime(2024, 2, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 961, new DateTime(2024, 2, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 962, new DateTime(2024, 2, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 963, new DateTime(2024, 2, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 964, new DateTime(2024, 2, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 965, new DateTime(2024, 2, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 966, new DateTime(2024, 2, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 967, new DateTime(2024, 2, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 968, new DateTime(2024, 2, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 969, new DateTime(2024, 2, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 970, new DateTime(2024, 2, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 971, new DateTime(2024, 2, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 972, new DateTime(2024, 2, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 973, new DateTime(2024, 2, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 974, new DateTime(2024, 2, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 975, new DateTime(2024, 2, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 976, new DateTime(2024, 2, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 977, new DateTime(2024, 2, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 978, new DateTime(2024, 2, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 979, new DateTime(2024, 2, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 980, new DateTime(2024, 2, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 981, new DateTime(2024, 2, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 982, new DateTime(2024, 2, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 983, new DateTime(2024, 2, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 984, new DateTime(2024, 2, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 985, new DateTime(2024, 2, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 986, new DateTime(2024, 2, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 987, new DateTime(2024, 2, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 988, new DateTime(2024, 2, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 989, new DateTime(2024, 2, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 990, new DateTime(2024, 2, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 991, new DateTime(2024, 2, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 992, new DateTime(2024, 2, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 993, new DateTime(2024, 2, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 994, new DateTime(2024, 2, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 995, new DateTime(2024, 2, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 996, new DateTime(2024, 2, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 997, new DateTime(2024, 2, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 998, new DateTime(2024, 2, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 999, new DateTime(2024, 2, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1000, new DateTime(2024, 2, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1001, new DateTime(2024, 2, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1002, new DateTime(2024, 2, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1003, new DateTime(2024, 2, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1004, new DateTime(2024, 2, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1005, new DateTime(2024, 2, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1006, new DateTime(2024, 2, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1007, new DateTime(2024, 2, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1008, new DateTime(2024, 2, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1009, new DateTime(2024, 2, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1010, new DateTime(2024, 2, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1011, new DateTime(2024, 2, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1012, new DateTime(2024, 2, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1013, new DateTime(2024, 2, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1014, new DateTime(2024, 2, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1015, new DateTime(2024, 2, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1016, new DateTime(2024, 2, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1017, new DateTime(2024, 2, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1018, new DateTime(2024, 2, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1019, new DateTime(2024, 2, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1020, new DateTime(2024, 2, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1021, new DateTime(2024, 2, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1022, new DateTime(2024, 2, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1023, new DateTime(2024, 2, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1024, new DateTime(2024, 2, 21, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 20, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1025, new DateTime(2024, 2, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1026, new DateTime(2024, 2, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1027, new DateTime(2024, 2, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1028, new DateTime(2024, 2, 21, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 20, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1029, new DateTime(2024, 2, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1030, new DateTime(2024, 2, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1031, new DateTime(2024, 2, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1032, new DateTime(2024, 2, 22, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 20, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1033, new DateTime(2024, 2, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1034, new DateTime(2024, 2, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1035, new DateTime(2024, 2, 22, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 21, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1036, new DateTime(2024, 2, 23, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 22, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1037, new DateTime(2024, 2, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 1038, new DateTime(2024, 2, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1039, new DateTime(2024, 2, 22, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 21, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1040, new DateTime(2024, 2, 23, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 22, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1041, new DateTime(2024, 2, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1042, new DateTime(2024, 2, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1043, new DateTime(2024, 2, 23, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 21, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1044, new DateTime(2024, 2, 24, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 22, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1045, new DateTime(2024, 2, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1046, new DateTime(2024, 2, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1047, new DateTime(2024, 2, 24, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 23, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1048, new DateTime(2024, 2, 25, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 24, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1049, new DateTime(2024, 2, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1050, new DateTime(2024, 2, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1051, new DateTime(2024, 2, 24, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 23, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1052, new DateTime(2024, 2, 25, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 24, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1053, new DateTime(2024, 2, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1054, new DateTime(2024, 2, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1055, new DateTime(2024, 2, 25, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 23, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1056, new DateTime(2024, 2, 26, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 24, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1057, new DateTime(2024, 2, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1058, new DateTime(2024, 2, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1059, new DateTime(2024, 2, 26, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 25, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1060, new DateTime(2024, 2, 27, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 26, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1061, new DateTime(2024, 2, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1062, new DateTime(2024, 2, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1063, new DateTime(2024, 2, 26, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 25, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1064, new DateTime(2024, 2, 27, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 26, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1065, new DateTime(2024, 2, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1066, new DateTime(2024, 2, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1067, new DateTime(2024, 2, 27, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 25, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1068, new DateTime(2024, 2, 28, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 26, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1069, new DateTime(2024, 2, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1070, new DateTime(2024, 2, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1071, new DateTime(2024, 2, 28, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 27, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1072, new DateTime(2024, 2, 29, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 28, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1073, new DateTime(2024, 2, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1074, new DateTime(2024, 2, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1075, new DateTime(2024, 2, 28, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 27, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1076, new DateTime(2024, 2, 29, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 28, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1077, new DateTime(2024, 2, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1078, new DateTime(2024, 3, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1079, new DateTime(2024, 2, 29, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 27, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 1080, new DateTime(2024, 3, 1, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 28, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1081, new DateTime(2024, 3, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1082, new DateTime(2024, 3, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1083, new DateTime(2024, 3, 1, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 29, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1084, new DateTime(2024, 3, 2, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 1, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1085, new DateTime(2024, 3, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1086, new DateTime(2024, 3, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1087, new DateTime(2024, 3, 1, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 29, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1088, new DateTime(2024, 3, 2, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 1, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1089, new DateTime(2024, 3, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1090, new DateTime(2024, 3, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1091, new DateTime(2024, 3, 2, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 2, 29, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1092, new DateTime(2024, 3, 3, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 1, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1093, new DateTime(2024, 3, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1094, new DateTime(2024, 3, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1095, new DateTime(2024, 3, 3, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 2, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1096, new DateTime(2024, 3, 4, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 3, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1097, new DateTime(2024, 3, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1098, new DateTime(2024, 3, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1099, new DateTime(2024, 3, 3, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 2, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1100, new DateTime(2024, 3, 4, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 3, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1101, new DateTime(2024, 3, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1102, new DateTime(2024, 3, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1103, new DateTime(2024, 3, 4, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 2, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1104, new DateTime(2024, 3, 5, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 3, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1105, new DateTime(2024, 3, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1106, new DateTime(2024, 3, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1107, new DateTime(2024, 3, 5, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 4, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1108, new DateTime(2024, 3, 6, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 5, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1109, new DateTime(2024, 3, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1110, new DateTime(2024, 3, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1111, new DateTime(2024, 3, 5, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 4, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1112, new DateTime(2024, 3, 6, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 5, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1113, new DateTime(2024, 3, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1114, new DateTime(2024, 3, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1115, new DateTime(2024, 3, 6, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 4, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1116, new DateTime(2024, 3, 7, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 5, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1117, new DateTime(2024, 3, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1118, new DateTime(2024, 3, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1119, new DateTime(2024, 3, 7, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 6, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1120, new DateTime(2024, 3, 8, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 7, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1121, new DateTime(2024, 3, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 1122, new DateTime(2024, 3, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1123, new DateTime(2024, 3, 7, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 6, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1124, new DateTime(2024, 3, 8, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 7, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1125, new DateTime(2024, 3, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1126, new DateTime(2024, 3, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1127, new DateTime(2024, 3, 8, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 6, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1128, new DateTime(2024, 3, 9, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 7, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1129, new DateTime(2024, 3, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1130, new DateTime(2024, 3, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1131, new DateTime(2024, 3, 9, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 8, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1132, new DateTime(2024, 3, 10, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 9, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1133, new DateTime(2024, 3, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1134, new DateTime(2024, 3, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1135, new DateTime(2024, 3, 9, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 8, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1136, new DateTime(2024, 3, 10, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 9, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1137, new DateTime(2024, 3, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1138, new DateTime(2024, 3, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1139, new DateTime(2024, 3, 10, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 8, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1140, new DateTime(2024, 3, 11, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 9, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1141, new DateTime(2024, 3, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1142, new DateTime(2024, 3, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1143, new DateTime(2024, 3, 11, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 10, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1144, new DateTime(2024, 3, 12, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 11, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1145, new DateTime(2024, 3, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1146, new DateTime(2024, 3, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1147, new DateTime(2024, 3, 11, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 10, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1148, new DateTime(2024, 3, 12, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 11, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1149, new DateTime(2024, 3, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1150, new DateTime(2024, 3, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1151, new DateTime(2024, 3, 12, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 10, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1152, new DateTime(2024, 3, 13, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 11, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1153, new DateTime(2024, 3, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1154, new DateTime(2024, 3, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1155, new DateTime(2024, 3, 13, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 12, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1156, new DateTime(2024, 3, 14, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 13, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1157, new DateTime(2024, 3, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1158, new DateTime(2024, 3, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1159, new DateTime(2024, 3, 13, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 12, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1160, new DateTime(2024, 3, 14, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 13, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1161, new DateTime(2024, 3, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1162, new DateTime(2024, 3, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1163, new DateTime(2024, 3, 14, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 12, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Arrival", "Departure", "IsFinished", "Name", "RouteId", "TrainCode" },
                values: new object[,]
                {
                    { 1164, new DateTime(2024, 3, 15, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 13, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1165, new DateTime(2024, 3, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1166, new DateTime(2024, 3, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1167, new DateTime(2024, 3, 15, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 14, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1168, new DateTime(2024, 3, 16, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 15, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1169, new DateTime(2024, 3, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1170, new DateTime(2024, 3, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1171, new DateTime(2024, 3, 15, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 14, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1172, new DateTime(2024, 3, 16, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 15, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1173, new DateTime(2024, 3, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1174, new DateTime(2024, 3, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1175, new DateTime(2024, 3, 16, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 14, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1176, new DateTime(2024, 3, 17, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 15, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1177, new DateTime(2024, 3, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1178, new DateTime(2024, 3, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1179, new DateTime(2024, 3, 17, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 16, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1180, new DateTime(2024, 3, 18, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 17, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1181, new DateTime(2024, 3, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1182, new DateTime(2024, 3, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1183, new DateTime(2024, 3, 17, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 16, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1184, new DateTime(2024, 3, 18, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 17, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1185, new DateTime(2024, 3, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1186, new DateTime(2024, 3, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1187, new DateTime(2024, 3, 18, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 16, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1188, new DateTime(2024, 3, 19, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 17, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" },
                    { 1189, new DateTime(2024, 3, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 HN-SG Fast Train", 4, "SE1" },
                    { 1190, new DateTime(2024, 3, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE1 SG-HN Fast Train", 3, "SE1" },
                    { 1191, new DateTime(2024, 3, 19, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 18, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 SG-HN Fast Train", 3, "SE2" },
                    { 1192, new DateTime(2024, 3, 20, 12, 52, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 19, 5, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE2 HN-SG Fast Train", 4, "SE2" },
                    { 1193, new DateTime(2024, 3, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 HN-SG Super Fast Train", 6, "SE3" },
                    { 1194, new DateTime(2024, 3, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE3 SG-HN Super Fast Train", 5, "SE3" },
                    { 1195, new DateTime(2024, 3, 19, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 18, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 SG-HN Super Fast Train", 5, "SE4" },
                    { 1196, new DateTime(2024, 3, 20, 22, 42, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 19, 13, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE4 HN-SG Super Fast Train", 6, "SE4" },
                    { 1197, new DateTime(2024, 3, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 HN-SG Slow Train", 2, "SE5" },
                    { 1198, new DateTime(2024, 3, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE5 SG-HN Slow Train", 1, "SE5" },
                    { 1199, new DateTime(2024, 3, 20, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 18, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 SG-HN Slow Train", 1, "SE6" },
                    { 1200, new DateTime(2024, 3, 21, 7, 5, 54, 734, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 3, 19, 21, 27, 54, 734, DateTimeKind.Local).AddTicks(5850), false, "SE6 HN-SG Slow Train", 2, "SE6" }
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
                    { 197, false, 7, 0, 1 },
                    { 198, false, 7, 0, 2 },
                    { 199, false, 7, 0, 3 },
                    { 200, false, 7, 0, 4 },
                    { 201, false, 7, 0, 5 },
                    { 202, false, 7, 0, 6 },
                    { 203, false, 7, 0, 7 },
                    { 204, false, 7, 0, 8 },
                    { 205, false, 7, 0, 9 },
                    { 206, false, 7, 0, 10 },
                    { 207, false, 7, 0, 11 },
                    { 208, false, 7, 0, 12 },
                    { 209, false, 7, 0, 13 },
                    { 210, false, 7, 0, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 211, false, 7, 0, 15 },
                    { 212, false, 7, 0, 16 },
                    { 213, false, 7, 0, 17 },
                    { 214, false, 7, 0, 18 },
                    { 215, false, 7, 0, 19 },
                    { 216, false, 7, 0, 20 },
                    { 217, false, 7, 0, 21 },
                    { 218, false, 7, 0, 22 },
                    { 219, false, 7, 0, 23 },
                    { 220, false, 7, 0, 24 },
                    { 221, false, 7, 0, 25 },
                    { 222, false, 7, 0, 26 },
                    { 223, false, 7, 0, 27 },
                    { 224, false, 7, 0, 28 },
                    { 225, false, 7, 0, 29 },
                    { 226, false, 7, 0, 30 },
                    { 227, false, 7, 0, 31 },
                    { 228, false, 7, 0, 32 },
                    { 229, false, 8, 0, 1 },
                    { 230, false, 8, 0, 2 },
                    { 231, false, 8, 0, 3 },
                    { 232, false, 8, 0, 4 },
                    { 233, false, 8, 0, 5 },
                    { 234, false, 8, 0, 6 },
                    { 235, false, 8, 0, 7 },
                    { 236, false, 8, 0, 8 },
                    { 237, false, 8, 0, 9 },
                    { 238, false, 8, 0, 10 },
                    { 239, false, 8, 0, 11 },
                    { 240, false, 8, 0, 12 },
                    { 241, false, 8, 0, 13 },
                    { 242, false, 8, 0, 14 },
                    { 243, false, 8, 0, 15 },
                    { 244, false, 8, 0, 16 },
                    { 245, false, 8, 0, 17 },
                    { 246, false, 8, 0, 18 },
                    { 247, false, 8, 0, 19 },
                    { 248, false, 8, 0, 20 },
                    { 249, false, 8, 0, 21 },
                    { 250, false, 8, 0, 22 },
                    { 251, false, 8, 0, 23 },
                    { 252, false, 8, 0, 24 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 253, false, 8, 0, 25 },
                    { 254, false, 8, 0, 26 },
                    { 255, false, 8, 0, 27 },
                    { 256, false, 8, 0, 28 },
                    { 257, false, 8, 0, 29 },
                    { 258, false, 8, 0, 30 },
                    { 259, false, 8, 0, 31 },
                    { 260, false, 8, 0, 32 },
                    { 261, false, 9, 0, 1 },
                    { 262, false, 9, 0, 2 },
                    { 263, false, 9, 0, 3 },
                    { 264, false, 9, 0, 4 },
                    { 265, false, 9, 0, 5 },
                    { 266, false, 9, 0, 6 },
                    { 267, false, 9, 0, 7 },
                    { 268, false, 9, 0, 8 },
                    { 269, false, 9, 0, 9 },
                    { 270, false, 9, 0, 10 },
                    { 271, false, 9, 0, 11 },
                    { 272, false, 9, 0, 12 },
                    { 273, false, 9, 0, 13 },
                    { 274, false, 9, 0, 14 },
                    { 275, false, 9, 0, 15 },
                    { 276, false, 9, 0, 16 },
                    { 277, false, 9, 0, 17 },
                    { 278, false, 9, 0, 18 },
                    { 279, false, 9, 0, 19 },
                    { 280, false, 9, 0, 20 },
                    { 281, false, 9, 0, 21 },
                    { 282, false, 9, 0, 22 },
                    { 283, false, 9, 0, 23 },
                    { 284, false, 9, 0, 24 },
                    { 285, false, 9, 0, 25 },
                    { 286, false, 9, 0, 26 },
                    { 287, false, 9, 0, 27 },
                    { 288, false, 9, 0, 28 },
                    { 289, false, 9, 0, 29 },
                    { 290, false, 9, 0, 30 },
                    { 291, false, 9, 0, 31 },
                    { 292, false, 9, 0, 32 },
                    { 293, false, 9, 0, 33 },
                    { 294, false, 9, 0, 34 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 295, false, 9, 0, 35 },
                    { 296, false, 9, 0, 36 },
                    { 297, false, 9, 0, 37 },
                    { 298, false, 9, 0, 38 },
                    { 299, false, 9, 0, 39 },
                    { 300, false, 9, 0, 40 },
                    { 301, false, 9, 0, 41 },
                    { 302, false, 9, 0, 42 },
                    { 303, false, 9, 0, 43 },
                    { 304, false, 9, 0, 44 },
                    { 305, false, 9, 0, 45 },
                    { 306, false, 9, 0, 46 },
                    { 307, false, 9, 0, 47 },
                    { 308, false, 9, 0, 48 },
                    { 309, false, 9, 0, 49 },
                    { 310, false, 9, 0, 50 },
                    { 311, false, 9, 0, 51 },
                    { 312, false, 9, 0, 52 },
                    { 313, false, 9, 0, 53 },
                    { 314, false, 9, 0, 54 },
                    { 315, false, 9, 0, 55 },
                    { 316, false, 9, 0, 56 },
                    { 317, false, 9, 0, 57 },
                    { 318, false, 9, 0, 58 },
                    { 319, false, 9, 0, 59 },
                    { 320, false, 9, 0, 60 },
                    { 321, false, 9, 0, 61 },
                    { 322, false, 9, 0, 62 },
                    { 323, false, 10, 0, 1 },
                    { 324, false, 10, 0, 2 },
                    { 325, false, 10, 0, 3 },
                    { 326, false, 10, 0, 4 },
                    { 327, false, 10, 0, 5 },
                    { 328, false, 10, 0, 6 },
                    { 329, false, 10, 0, 7 },
                    { 330, false, 10, 0, 8 },
                    { 331, false, 10, 0, 9 },
                    { 332, false, 10, 0, 10 },
                    { 333, false, 10, 0, 11 },
                    { 334, false, 10, 0, 12 },
                    { 335, false, 10, 0, 13 },
                    { 336, false, 10, 0, 14 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 337, false, 10, 0, 15 },
                    { 338, false, 10, 0, 16 },
                    { 339, false, 10, 0, 17 },
                    { 340, false, 10, 0, 18 },
                    { 341, false, 10, 0, 19 },
                    { 342, false, 10, 0, 20 },
                    { 343, false, 10, 0, 21 },
                    { 344, false, 10, 0, 22 },
                    { 345, false, 10, 0, 23 },
                    { 346, false, 10, 0, 24 },
                    { 347, false, 10, 0, 25 },
                    { 348, false, 10, 0, 26 },
                    { 349, false, 10, 0, 27 },
                    { 350, false, 10, 0, 28 },
                    { 351, false, 10, 0, 29 },
                    { 352, false, 10, 0, 30 },
                    { 353, false, 10, 0, 31 },
                    { 354, false, 10, 0, 32 },
                    { 355, false, 10, 0, 33 },
                    { 356, false, 10, 0, 34 },
                    { 357, false, 10, 0, 35 },
                    { 358, false, 10, 0, 36 },
                    { 359, false, 10, 0, 37 },
                    { 360, false, 10, 0, 38 },
                    { 361, false, 10, 0, 39 },
                    { 362, false, 10, 0, 40 },
                    { 363, false, 10, 0, 41 },
                    { 364, false, 10, 0, 42 },
                    { 365, false, 10, 0, 43 },
                    { 366, false, 10, 0, 44 },
                    { 367, false, 10, 0, 45 },
                    { 368, false, 10, 0, 46 },
                    { 369, false, 10, 0, 47 },
                    { 370, false, 10, 0, 48 },
                    { 371, false, 10, 0, 49 },
                    { 372, false, 10, 0, 50 },
                    { 373, false, 10, 0, 51 },
                    { 374, false, 10, 0, 52 },
                    { 375, false, 10, 0, 53 },
                    { 376, false, 10, 0, 54 },
                    { 377, false, 10, 0, 55 },
                    { 378, false, 10, 0, 56 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 379, false, 10, 0, 57 },
                    { 380, false, 10, 0, 58 },
                    { 381, false, 10, 0, 59 },
                    { 382, false, 10, 0, 60 },
                    { 383, false, 10, 0, 61 },
                    { 384, false, 10, 0, 62 },
                    { 385, false, 11, 1, 1 },
                    { 386, false, 11, 1, 2 },
                    { 387, false, 11, 1, 3 },
                    { 388, false, 11, 1, 4 },
                    { 389, false, 11, 2, 5 },
                    { 390, false, 11, 2, 6 },
                    { 391, false, 11, 2, 7 },
                    { 392, false, 11, 2, 8 },
                    { 393, false, 11, 3, 9 },
                    { 394, false, 11, 3, 10 },
                    { 395, false, 11, 3, 11 },
                    { 396, false, 11, 3, 12 },
                    { 397, false, 11, 4, 13 },
                    { 398, false, 11, 4, 14 },
                    { 399, false, 11, 4, 15 },
                    { 400, false, 11, 4, 16 },
                    { 401, false, 11, 5, 17 },
                    { 402, false, 11, 5, 18 },
                    { 403, false, 11, 5, 19 },
                    { 404, false, 11, 5, 20 },
                    { 405, false, 11, 6, 21 },
                    { 406, false, 11, 6, 22 },
                    { 407, false, 11, 6, 23 },
                    { 408, false, 11, 6, 24 },
                    { 409, false, 11, 7, 25 },
                    { 410, false, 11, 7, 26 },
                    { 411, false, 11, 7, 27 },
                    { 412, false, 11, 7, 28 },
                    { 413, false, 12, 1, 1 },
                    { 414, false, 12, 1, 2 },
                    { 415, false, 12, 1, 3 },
                    { 416, false, 12, 1, 4 },
                    { 417, false, 12, 2, 5 },
                    { 418, false, 12, 2, 6 },
                    { 419, false, 12, 2, 7 },
                    { 420, false, 12, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 421, false, 12, 3, 9 },
                    { 422, false, 12, 3, 10 },
                    { 423, false, 12, 3, 11 },
                    { 424, false, 12, 3, 12 },
                    { 425, false, 12, 4, 13 },
                    { 426, false, 12, 4, 14 },
                    { 427, false, 12, 4, 15 },
                    { 428, false, 12, 4, 16 },
                    { 429, false, 12, 5, 17 },
                    { 430, false, 12, 5, 18 },
                    { 431, false, 12, 5, 19 },
                    { 432, false, 12, 5, 20 },
                    { 433, false, 12, 6, 21 },
                    { 434, false, 12, 6, 22 },
                    { 435, false, 12, 6, 23 },
                    { 436, false, 12, 6, 24 },
                    { 437, false, 12, 7, 25 },
                    { 438, false, 12, 7, 26 },
                    { 439, false, 12, 7, 27 },
                    { 440, false, 12, 7, 28 },
                    { 441, false, 13, 1, 1 },
                    { 442, false, 13, 1, 2 },
                    { 443, false, 13, 1, 3 },
                    { 444, false, 13, 1, 4 },
                    { 445, false, 13, 2, 5 },
                    { 446, false, 13, 2, 6 },
                    { 447, false, 13, 2, 7 },
                    { 448, false, 13, 2, 8 },
                    { 449, false, 13, 3, 9 },
                    { 450, false, 13, 3, 10 },
                    { 451, false, 13, 3, 11 },
                    { 452, false, 13, 3, 12 },
                    { 453, false, 13, 4, 13 },
                    { 454, false, 13, 4, 14 },
                    { 455, false, 13, 4, 15 },
                    { 456, false, 13, 4, 16 },
                    { 457, false, 13, 5, 17 },
                    { 458, false, 13, 5, 18 },
                    { 459, false, 13, 5, 19 },
                    { 460, false, 13, 5, 20 },
                    { 461, false, 13, 6, 21 },
                    { 462, false, 13, 6, 22 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 463, false, 13, 6, 23 },
                    { 464, false, 13, 6, 24 },
                    { 465, false, 13, 7, 25 },
                    { 466, false, 13, 7, 26 },
                    { 467, false, 13, 7, 27 },
                    { 468, false, 13, 7, 28 },
                    { 469, false, 14, 1, 1 },
                    { 470, false, 14, 1, 2 },
                    { 471, false, 14, 1, 3 },
                    { 472, false, 14, 1, 4 },
                    { 473, false, 14, 2, 5 },
                    { 474, false, 14, 2, 6 },
                    { 475, false, 14, 2, 7 },
                    { 476, false, 14, 2, 8 },
                    { 477, false, 14, 3, 9 },
                    { 478, false, 14, 3, 10 },
                    { 479, false, 14, 3, 11 },
                    { 480, false, 14, 3, 12 },
                    { 481, false, 14, 4, 13 },
                    { 482, false, 14, 4, 14 },
                    { 483, false, 14, 4, 15 },
                    { 484, false, 14, 4, 16 },
                    { 485, false, 14, 5, 17 },
                    { 486, false, 14, 5, 18 },
                    { 487, false, 14, 5, 19 },
                    { 488, false, 14, 5, 20 },
                    { 489, false, 14, 6, 21 },
                    { 490, false, 14, 6, 22 },
                    { 491, false, 14, 6, 23 },
                    { 492, false, 14, 6, 24 },
                    { 493, false, 14, 7, 25 },
                    { 494, false, 14, 7, 26 },
                    { 495, false, 14, 7, 27 },
                    { 496, false, 14, 7, 28 },
                    { 497, false, 15, 1, 1 },
                    { 498, false, 15, 1, 2 },
                    { 499, false, 15, 1, 3 },
                    { 500, false, 15, 1, 4 },
                    { 501, false, 15, 1, 5 },
                    { 502, false, 15, 1, 6 },
                    { 503, false, 15, 2, 7 },
                    { 504, false, 15, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 505, false, 15, 2, 9 },
                    { 506, false, 15, 2, 10 },
                    { 507, false, 15, 2, 11 },
                    { 508, false, 15, 2, 12 },
                    { 509, false, 15, 3, 13 },
                    { 510, false, 15, 3, 14 },
                    { 511, false, 15, 3, 15 },
                    { 512, false, 15, 3, 16 },
                    { 513, false, 15, 3, 17 },
                    { 514, false, 15, 3, 18 },
                    { 515, false, 15, 4, 19 },
                    { 516, false, 15, 4, 20 },
                    { 517, false, 15, 4, 21 },
                    { 518, false, 15, 4, 22 },
                    { 519, false, 15, 4, 23 },
                    { 520, false, 15, 4, 24 },
                    { 521, false, 15, 5, 25 },
                    { 522, false, 15, 5, 26 },
                    { 523, false, 15, 5, 27 },
                    { 524, false, 15, 5, 28 },
                    { 525, false, 15, 5, 29 },
                    { 526, false, 15, 5, 30 },
                    { 527, false, 15, 6, 31 },
                    { 528, false, 15, 6, 32 },
                    { 529, false, 15, 6, 33 },
                    { 530, false, 15, 6, 34 },
                    { 531, false, 15, 6, 35 },
                    { 532, false, 15, 6, 36 },
                    { 533, false, 15, 7, 37 },
                    { 534, false, 15, 7, 38 },
                    { 535, false, 15, 7, 39 },
                    { 536, false, 15, 7, 40 },
                    { 537, false, 15, 7, 41 },
                    { 538, false, 15, 7, 42 },
                    { 539, false, 16, 1, 1 },
                    { 540, false, 16, 1, 2 },
                    { 541, false, 16, 1, 3 },
                    { 542, false, 16, 1, 4 },
                    { 543, false, 16, 1, 5 },
                    { 544, false, 16, 1, 6 },
                    { 545, false, 16, 2, 7 },
                    { 546, false, 16, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 547, false, 16, 2, 9 },
                    { 548, false, 16, 2, 10 },
                    { 549, false, 16, 2, 11 },
                    { 550, false, 16, 2, 12 },
                    { 551, false, 16, 3, 13 },
                    { 552, false, 16, 3, 14 },
                    { 553, false, 16, 3, 15 },
                    { 554, false, 16, 3, 16 },
                    { 555, false, 16, 3, 17 },
                    { 556, false, 16, 3, 18 },
                    { 557, false, 16, 4, 19 },
                    { 558, false, 16, 4, 20 },
                    { 559, false, 16, 4, 21 },
                    { 560, false, 16, 4, 22 },
                    { 561, false, 16, 4, 23 },
                    { 562, false, 16, 4, 24 },
                    { 563, false, 16, 5, 25 },
                    { 564, false, 16, 5, 26 },
                    { 565, false, 16, 5, 27 },
                    { 566, false, 16, 5, 28 },
                    { 567, false, 16, 5, 29 },
                    { 568, false, 16, 5, 30 },
                    { 569, false, 16, 6, 31 },
                    { 570, false, 16, 6, 32 },
                    { 571, false, 16, 6, 33 },
                    { 572, false, 16, 6, 34 },
                    { 573, false, 16, 6, 35 },
                    { 574, false, 16, 6, 36 },
                    { 575, false, 16, 7, 37 },
                    { 576, false, 16, 7, 38 },
                    { 577, false, 16, 7, 39 },
                    { 578, false, 16, 7, 40 },
                    { 579, false, 16, 7, 41 },
                    { 580, false, 16, 7, 42 },
                    { 581, false, 17, 0, 1 },
                    { 582, false, 17, 0, 2 },
                    { 583, false, 17, 0, 3 },
                    { 584, false, 17, 0, 4 },
                    { 585, false, 17, 0, 5 },
                    { 586, false, 17, 0, 6 },
                    { 587, false, 17, 0, 7 },
                    { 588, false, 17, 0, 8 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 589, false, 17, 0, 9 },
                    { 590, false, 17, 0, 10 },
                    { 591, false, 17, 0, 11 },
                    { 592, false, 17, 0, 12 },
                    { 593, false, 17, 0, 13 },
                    { 594, false, 17, 0, 14 },
                    { 595, false, 17, 0, 15 },
                    { 596, false, 17, 0, 16 },
                    { 597, false, 17, 0, 17 },
                    { 598, false, 17, 0, 18 },
                    { 599, false, 17, 0, 19 },
                    { 600, false, 17, 0, 20 },
                    { 601, false, 17, 0, 21 },
                    { 602, false, 17, 0, 22 },
                    { 603, false, 17, 0, 23 },
                    { 604, false, 17, 0, 24 },
                    { 605, false, 17, 0, 25 },
                    { 606, false, 17, 0, 26 },
                    { 607, false, 17, 0, 27 },
                    { 608, false, 17, 0, 28 },
                    { 609, false, 17, 0, 29 },
                    { 610, false, 17, 0, 30 },
                    { 611, false, 17, 0, 31 },
                    { 612, false, 17, 0, 32 },
                    { 613, false, 18, 0, 1 },
                    { 614, false, 18, 0, 2 },
                    { 615, false, 18, 0, 3 },
                    { 616, false, 18, 0, 4 },
                    { 617, false, 18, 0, 5 },
                    { 618, false, 18, 0, 6 },
                    { 619, false, 18, 0, 7 },
                    { 620, false, 18, 0, 8 },
                    { 621, false, 18, 0, 9 },
                    { 622, false, 18, 0, 10 },
                    { 623, false, 18, 0, 11 },
                    { 624, false, 18, 0, 12 },
                    { 625, false, 18, 0, 13 },
                    { 626, false, 18, 0, 14 },
                    { 627, false, 18, 0, 15 },
                    { 628, false, 18, 0, 16 },
                    { 629, false, 18, 0, 17 },
                    { 630, false, 18, 0, 18 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 631, false, 18, 0, 19 },
                    { 632, false, 18, 0, 20 },
                    { 633, false, 18, 0, 21 },
                    { 634, false, 18, 0, 22 },
                    { 635, false, 18, 0, 23 },
                    { 636, false, 18, 0, 24 },
                    { 637, false, 18, 0, 25 },
                    { 638, false, 18, 0, 26 },
                    { 639, false, 18, 0, 27 },
                    { 640, false, 18, 0, 28 },
                    { 641, false, 18, 0, 29 },
                    { 642, false, 18, 0, 30 },
                    { 643, false, 18, 0, 31 },
                    { 644, false, 18, 0, 32 },
                    { 645, false, 19, 0, 1 },
                    { 646, false, 19, 0, 2 },
                    { 647, false, 19, 0, 3 },
                    { 648, false, 19, 0, 4 },
                    { 649, false, 19, 0, 5 },
                    { 650, false, 19, 0, 6 },
                    { 651, false, 19, 0, 7 },
                    { 652, false, 19, 0, 8 },
                    { 653, false, 19, 0, 9 },
                    { 654, false, 19, 0, 10 },
                    { 655, false, 19, 0, 11 },
                    { 656, false, 19, 0, 12 },
                    { 657, false, 19, 0, 13 },
                    { 658, false, 19, 0, 14 },
                    { 659, false, 19, 0, 15 },
                    { 660, false, 19, 0, 16 },
                    { 661, false, 19, 0, 17 },
                    { 662, false, 19, 0, 18 },
                    { 663, false, 19, 0, 19 },
                    { 664, false, 19, 0, 20 },
                    { 665, false, 19, 0, 21 },
                    { 666, false, 19, 0, 22 },
                    { 667, false, 19, 0, 23 },
                    { 668, false, 19, 0, 24 },
                    { 669, false, 19, 0, 25 },
                    { 670, false, 19, 0, 26 },
                    { 671, false, 19, 0, 27 },
                    { 672, false, 19, 0, 28 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 673, false, 19, 0, 29 },
                    { 674, false, 19, 0, 30 },
                    { 675, false, 19, 0, 31 },
                    { 676, false, 19, 0, 32 },
                    { 677, false, 19, 0, 33 },
                    { 678, false, 19, 0, 34 },
                    { 679, false, 19, 0, 35 },
                    { 680, false, 19, 0, 36 },
                    { 681, false, 19, 0, 37 },
                    { 682, false, 19, 0, 38 },
                    { 683, false, 19, 0, 39 },
                    { 684, false, 19, 0, 40 },
                    { 685, false, 19, 0, 41 },
                    { 686, false, 19, 0, 42 },
                    { 687, false, 19, 0, 43 },
                    { 688, false, 19, 0, 44 },
                    { 689, false, 19, 0, 45 },
                    { 690, false, 19, 0, 46 },
                    { 691, false, 19, 0, 47 },
                    { 692, false, 19, 0, 48 },
                    { 693, false, 19, 0, 49 },
                    { 694, false, 19, 0, 50 },
                    { 695, false, 19, 0, 51 },
                    { 696, false, 19, 0, 52 },
                    { 697, false, 19, 0, 53 },
                    { 698, false, 19, 0, 54 },
                    { 699, false, 19, 0, 55 },
                    { 700, false, 19, 0, 56 },
                    { 701, false, 19, 0, 57 },
                    { 702, false, 19, 0, 58 },
                    { 703, false, 19, 0, 59 },
                    { 704, false, 19, 0, 60 },
                    { 705, false, 19, 0, 61 },
                    { 706, false, 19, 0, 62 },
                    { 707, false, 20, 0, 1 },
                    { 708, false, 20, 0, 2 },
                    { 709, false, 20, 0, 3 },
                    { 710, false, 20, 0, 4 },
                    { 711, false, 20, 0, 5 },
                    { 712, false, 20, 0, 6 },
                    { 713, false, 20, 0, 7 },
                    { 714, false, 20, 0, 8 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 715, false, 20, 0, 9 },
                    { 716, false, 20, 0, 10 },
                    { 717, false, 20, 0, 11 },
                    { 718, false, 20, 0, 12 },
                    { 719, false, 20, 0, 13 },
                    { 720, false, 20, 0, 14 },
                    { 721, false, 20, 0, 15 },
                    { 722, false, 20, 0, 16 },
                    { 723, false, 20, 0, 17 },
                    { 724, false, 20, 0, 18 },
                    { 725, false, 20, 0, 19 },
                    { 726, false, 20, 0, 20 },
                    { 727, false, 20, 0, 21 },
                    { 728, false, 20, 0, 22 },
                    { 729, false, 20, 0, 23 },
                    { 730, false, 20, 0, 24 },
                    { 731, false, 20, 0, 25 },
                    { 732, false, 20, 0, 26 },
                    { 733, false, 20, 0, 27 },
                    { 734, false, 20, 0, 28 },
                    { 735, false, 20, 0, 29 },
                    { 736, false, 20, 0, 30 },
                    { 737, false, 20, 0, 31 },
                    { 738, false, 20, 0, 32 },
                    { 739, false, 20, 0, 33 },
                    { 740, false, 20, 0, 34 },
                    { 741, false, 20, 0, 35 },
                    { 742, false, 20, 0, 36 },
                    { 743, false, 20, 0, 37 },
                    { 744, false, 20, 0, 38 },
                    { 745, false, 20, 0, 39 },
                    { 746, false, 20, 0, 40 },
                    { 747, false, 20, 0, 41 },
                    { 748, false, 20, 0, 42 },
                    { 749, false, 20, 0, 43 },
                    { 750, false, 20, 0, 44 },
                    { 751, false, 20, 0, 45 },
                    { 752, false, 20, 0, 46 },
                    { 753, false, 20, 0, 47 },
                    { 754, false, 20, 0, 48 },
                    { 755, false, 20, 0, 49 },
                    { 756, false, 20, 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 757, false, 20, 0, 51 },
                    { 758, false, 20, 0, 52 },
                    { 759, false, 20, 0, 53 },
                    { 760, false, 20, 0, 54 },
                    { 761, false, 20, 0, 55 },
                    { 762, false, 20, 0, 56 },
                    { 763, false, 20, 0, 57 },
                    { 764, false, 20, 0, 58 },
                    { 765, false, 20, 0, 59 },
                    { 766, false, 20, 0, 60 },
                    { 767, false, 20, 0, 61 },
                    { 768, false, 20, 0, 62 },
                    { 769, false, 21, 1, 1 },
                    { 770, false, 21, 1, 2 },
                    { 771, false, 21, 1, 3 },
                    { 772, false, 21, 1, 4 },
                    { 773, false, 21, 2, 5 },
                    { 774, false, 21, 2, 6 },
                    { 775, false, 21, 2, 7 },
                    { 776, false, 21, 2, 8 },
                    { 777, false, 21, 3, 9 },
                    { 778, false, 21, 3, 10 },
                    { 779, false, 21, 3, 11 },
                    { 780, false, 21, 3, 12 },
                    { 781, false, 21, 4, 13 },
                    { 782, false, 21, 4, 14 },
                    { 783, false, 21, 4, 15 },
                    { 784, false, 21, 4, 16 },
                    { 785, false, 21, 5, 17 },
                    { 786, false, 21, 5, 18 },
                    { 787, false, 21, 5, 19 },
                    { 788, false, 21, 5, 20 },
                    { 789, false, 21, 6, 21 },
                    { 790, false, 21, 6, 22 },
                    { 791, false, 21, 6, 23 },
                    { 792, false, 21, 6, 24 },
                    { 793, false, 21, 7, 25 },
                    { 794, false, 21, 7, 26 },
                    { 795, false, 21, 7, 27 },
                    { 796, false, 21, 7, 28 },
                    { 797, false, 22, 1, 1 },
                    { 798, false, 22, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 799, false, 22, 1, 3 },
                    { 800, false, 22, 1, 4 },
                    { 801, false, 22, 2, 5 },
                    { 802, false, 22, 2, 6 },
                    { 803, false, 22, 2, 7 },
                    { 804, false, 22, 2, 8 },
                    { 805, false, 22, 3, 9 },
                    { 806, false, 22, 3, 10 },
                    { 807, false, 22, 3, 11 },
                    { 808, false, 22, 3, 12 },
                    { 809, false, 22, 4, 13 },
                    { 810, false, 22, 4, 14 },
                    { 811, false, 22, 4, 15 },
                    { 812, false, 22, 4, 16 },
                    { 813, false, 22, 5, 17 },
                    { 814, false, 22, 5, 18 },
                    { 815, false, 22, 5, 19 },
                    { 816, false, 22, 5, 20 },
                    { 817, false, 22, 6, 21 },
                    { 818, false, 22, 6, 22 },
                    { 819, false, 22, 6, 23 },
                    { 820, false, 22, 6, 24 },
                    { 821, false, 22, 7, 25 },
                    { 822, false, 22, 7, 26 },
                    { 823, false, 22, 7, 27 },
                    { 824, false, 22, 7, 28 },
                    { 825, false, 23, 1, 1 },
                    { 826, false, 23, 1, 2 },
                    { 827, false, 23, 1, 3 },
                    { 828, false, 23, 1, 4 },
                    { 829, false, 23, 2, 5 },
                    { 830, false, 23, 2, 6 },
                    { 831, false, 23, 2, 7 },
                    { 832, false, 23, 2, 8 },
                    { 833, false, 23, 3, 9 },
                    { 834, false, 23, 3, 10 },
                    { 835, false, 23, 3, 11 },
                    { 836, false, 23, 3, 12 },
                    { 837, false, 23, 4, 13 },
                    { 838, false, 23, 4, 14 },
                    { 839, false, 23, 4, 15 },
                    { 840, false, 23, 4, 16 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 841, false, 23, 5, 17 },
                    { 842, false, 23, 5, 18 },
                    { 843, false, 23, 5, 19 },
                    { 844, false, 23, 5, 20 },
                    { 845, false, 23, 6, 21 },
                    { 846, false, 23, 6, 22 },
                    { 847, false, 23, 6, 23 },
                    { 848, false, 23, 6, 24 },
                    { 849, false, 23, 7, 25 },
                    { 850, false, 23, 7, 26 },
                    { 851, false, 23, 7, 27 },
                    { 852, false, 23, 7, 28 },
                    { 853, false, 24, 1, 1 },
                    { 854, false, 24, 1, 2 },
                    { 855, false, 24, 1, 3 },
                    { 856, false, 24, 1, 4 },
                    { 857, false, 24, 2, 5 },
                    { 858, false, 24, 2, 6 },
                    { 859, false, 24, 2, 7 },
                    { 860, false, 24, 2, 8 },
                    { 861, false, 24, 3, 9 },
                    { 862, false, 24, 3, 10 },
                    { 863, false, 24, 3, 11 },
                    { 864, false, 24, 3, 12 },
                    { 865, false, 24, 4, 13 },
                    { 866, false, 24, 4, 14 },
                    { 867, false, 24, 4, 15 },
                    { 868, false, 24, 4, 16 },
                    { 869, false, 24, 5, 17 },
                    { 870, false, 24, 5, 18 },
                    { 871, false, 24, 5, 19 },
                    { 872, false, 24, 5, 20 },
                    { 873, false, 24, 6, 21 },
                    { 874, false, 24, 6, 22 },
                    { 875, false, 24, 6, 23 },
                    { 876, false, 24, 6, 24 },
                    { 877, false, 24, 7, 25 },
                    { 878, false, 24, 7, 26 },
                    { 879, false, 24, 7, 27 },
                    { 880, false, 24, 7, 28 },
                    { 881, false, 25, 1, 1 },
                    { 882, false, 25, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 883, false, 25, 1, 3 },
                    { 884, false, 25, 1, 4 },
                    { 885, false, 25, 1, 5 },
                    { 886, false, 25, 1, 6 },
                    { 887, false, 25, 2, 7 },
                    { 888, false, 25, 2, 8 },
                    { 889, false, 25, 2, 9 },
                    { 890, false, 25, 2, 10 },
                    { 891, false, 25, 2, 11 },
                    { 892, false, 25, 2, 12 },
                    { 893, false, 25, 3, 13 },
                    { 894, false, 25, 3, 14 },
                    { 895, false, 25, 3, 15 },
                    { 896, false, 25, 3, 16 },
                    { 897, false, 25, 3, 17 },
                    { 898, false, 25, 3, 18 },
                    { 899, false, 25, 4, 19 },
                    { 900, false, 25, 4, 20 },
                    { 901, false, 25, 4, 21 },
                    { 902, false, 25, 4, 22 },
                    { 903, false, 25, 4, 23 },
                    { 904, false, 25, 4, 24 },
                    { 905, false, 25, 5, 25 },
                    { 906, false, 25, 5, 26 },
                    { 907, false, 25, 5, 27 },
                    { 908, false, 25, 5, 28 },
                    { 909, false, 25, 5, 29 },
                    { 910, false, 25, 5, 30 },
                    { 911, false, 25, 6, 31 },
                    { 912, false, 25, 6, 32 },
                    { 913, false, 25, 6, 33 },
                    { 914, false, 25, 6, 34 },
                    { 915, false, 25, 6, 35 },
                    { 916, false, 25, 6, 36 },
                    { 917, false, 25, 7, 37 },
                    { 918, false, 25, 7, 38 },
                    { 919, false, 25, 7, 39 },
                    { 920, false, 25, 7, 40 },
                    { 921, false, 25, 7, 41 },
                    { 922, false, 25, 7, 42 },
                    { 923, false, 26, 1, 1 },
                    { 924, false, 26, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 925, false, 26, 1, 3 },
                    { 926, false, 26, 1, 4 },
                    { 927, false, 26, 1, 5 },
                    { 928, false, 26, 1, 6 },
                    { 929, false, 26, 2, 7 },
                    { 930, false, 26, 2, 8 },
                    { 931, false, 26, 2, 9 },
                    { 932, false, 26, 2, 10 },
                    { 933, false, 26, 2, 11 },
                    { 934, false, 26, 2, 12 },
                    { 935, false, 26, 3, 13 },
                    { 936, false, 26, 3, 14 },
                    { 937, false, 26, 3, 15 },
                    { 938, false, 26, 3, 16 },
                    { 939, false, 26, 3, 17 },
                    { 940, false, 26, 3, 18 },
                    { 941, false, 26, 4, 19 },
                    { 942, false, 26, 4, 20 },
                    { 943, false, 26, 4, 21 },
                    { 944, false, 26, 4, 22 },
                    { 945, false, 26, 4, 23 },
                    { 946, false, 26, 4, 24 },
                    { 947, false, 26, 5, 25 },
                    { 948, false, 26, 5, 26 },
                    { 949, false, 26, 5, 27 },
                    { 950, false, 26, 5, 28 },
                    { 951, false, 26, 5, 29 },
                    { 952, false, 26, 5, 30 },
                    { 953, false, 26, 6, 31 },
                    { 954, false, 26, 6, 32 },
                    { 955, false, 26, 6, 33 },
                    { 956, false, 26, 6, 34 },
                    { 957, false, 26, 6, 35 },
                    { 958, false, 26, 6, 36 },
                    { 959, false, 26, 7, 37 },
                    { 960, false, 26, 7, 38 },
                    { 961, false, 26, 7, 39 },
                    { 962, false, 26, 7, 40 },
                    { 963, false, 26, 7, 41 },
                    { 964, false, 26, 7, 42 },
                    { 965, false, 27, 0, 1 },
                    { 966, false, 27, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 967, false, 27, 0, 3 },
                    { 968, false, 27, 0, 4 },
                    { 969, false, 27, 0, 5 },
                    { 970, false, 27, 0, 6 },
                    { 971, false, 27, 0, 7 },
                    { 972, false, 27, 0, 8 },
                    { 973, false, 27, 0, 9 },
                    { 974, false, 27, 0, 10 },
                    { 975, false, 27, 0, 11 },
                    { 976, false, 27, 0, 12 },
                    { 977, false, 27, 0, 13 },
                    { 978, false, 27, 0, 14 },
                    { 979, false, 27, 0, 15 },
                    { 980, false, 27, 0, 16 },
                    { 981, false, 27, 0, 17 },
                    { 982, false, 27, 0, 18 },
                    { 983, false, 27, 0, 19 },
                    { 984, false, 27, 0, 20 },
                    { 985, false, 27, 0, 21 },
                    { 986, false, 27, 0, 22 },
                    { 987, false, 27, 0, 23 },
                    { 988, false, 27, 0, 24 },
                    { 989, false, 27, 0, 25 },
                    { 990, false, 27, 0, 26 },
                    { 991, false, 27, 0, 27 },
                    { 992, false, 27, 0, 28 },
                    { 993, false, 27, 0, 29 },
                    { 994, false, 27, 0, 30 },
                    { 995, false, 27, 0, 31 },
                    { 996, false, 27, 0, 32 },
                    { 997, false, 28, 0, 1 },
                    { 998, false, 28, 0, 2 },
                    { 999, false, 28, 0, 3 },
                    { 1000, false, 28, 0, 4 },
                    { 1001, false, 28, 0, 5 },
                    { 1002, false, 28, 0, 6 },
                    { 1003, false, 28, 0, 7 },
                    { 1004, false, 28, 0, 8 },
                    { 1005, false, 28, 0, 9 },
                    { 1006, false, 28, 0, 10 },
                    { 1007, false, 28, 0, 11 },
                    { 1008, false, 28, 0, 12 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1009, false, 28, 0, 13 },
                    { 1010, false, 28, 0, 14 },
                    { 1011, false, 28, 0, 15 },
                    { 1012, false, 28, 0, 16 },
                    { 1013, false, 28, 0, 17 },
                    { 1014, false, 28, 0, 18 },
                    { 1015, false, 28, 0, 19 },
                    { 1016, false, 28, 0, 20 },
                    { 1017, false, 28, 0, 21 },
                    { 1018, false, 28, 0, 22 },
                    { 1019, false, 28, 0, 23 },
                    { 1020, false, 28, 0, 24 },
                    { 1021, false, 28, 0, 25 },
                    { 1022, false, 28, 0, 26 },
                    { 1023, false, 28, 0, 27 },
                    { 1024, false, 28, 0, 28 },
                    { 1025, false, 28, 0, 29 },
                    { 1026, false, 28, 0, 30 },
                    { 1027, false, 28, 0, 31 },
                    { 1028, false, 28, 0, 32 },
                    { 1029, false, 29, 0, 1 },
                    { 1030, false, 29, 0, 2 },
                    { 1031, false, 29, 0, 3 },
                    { 1032, false, 29, 0, 4 },
                    { 1033, false, 29, 0, 5 },
                    { 1034, false, 29, 0, 6 },
                    { 1035, false, 29, 0, 7 },
                    { 1036, false, 29, 0, 8 },
                    { 1037, false, 29, 0, 9 },
                    { 1038, false, 29, 0, 10 },
                    { 1039, false, 29, 0, 11 },
                    { 1040, false, 29, 0, 12 },
                    { 1041, false, 29, 0, 13 },
                    { 1042, false, 29, 0, 14 },
                    { 1043, false, 29, 0, 15 },
                    { 1044, false, 29, 0, 16 },
                    { 1045, false, 29, 0, 17 },
                    { 1046, false, 29, 0, 18 },
                    { 1047, false, 29, 0, 19 },
                    { 1048, false, 29, 0, 20 },
                    { 1049, false, 29, 0, 21 },
                    { 1050, false, 29, 0, 22 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1051, false, 29, 0, 23 },
                    { 1052, false, 29, 0, 24 },
                    { 1053, false, 29, 0, 25 },
                    { 1054, false, 29, 0, 26 },
                    { 1055, false, 29, 0, 27 },
                    { 1056, false, 29, 0, 28 },
                    { 1057, false, 29, 0, 29 },
                    { 1058, false, 29, 0, 30 },
                    { 1059, false, 29, 0, 31 },
                    { 1060, false, 29, 0, 32 },
                    { 1061, false, 29, 0, 33 },
                    { 1062, false, 29, 0, 34 },
                    { 1063, false, 29, 0, 35 },
                    { 1064, false, 29, 0, 36 },
                    { 1065, false, 29, 0, 37 },
                    { 1066, false, 29, 0, 38 },
                    { 1067, false, 29, 0, 39 },
                    { 1068, false, 29, 0, 40 },
                    { 1069, false, 29, 0, 41 },
                    { 1070, false, 29, 0, 42 },
                    { 1071, false, 29, 0, 43 },
                    { 1072, false, 29, 0, 44 },
                    { 1073, false, 29, 0, 45 },
                    { 1074, false, 29, 0, 46 },
                    { 1075, false, 29, 0, 47 },
                    { 1076, false, 29, 0, 48 },
                    { 1077, false, 29, 0, 49 },
                    { 1078, false, 29, 0, 50 },
                    { 1079, false, 29, 0, 51 },
                    { 1080, false, 29, 0, 52 },
                    { 1081, false, 29, 0, 53 },
                    { 1082, false, 29, 0, 54 },
                    { 1083, false, 29, 0, 55 },
                    { 1084, false, 29, 0, 56 },
                    { 1085, false, 29, 0, 57 },
                    { 1086, false, 29, 0, 58 },
                    { 1087, false, 29, 0, 59 },
                    { 1088, false, 29, 0, 60 },
                    { 1089, false, 29, 0, 61 },
                    { 1090, false, 29, 0, 62 },
                    { 1091, false, 30, 0, 1 },
                    { 1092, false, 30, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1093, false, 30, 0, 3 },
                    { 1094, false, 30, 0, 4 },
                    { 1095, false, 30, 0, 5 },
                    { 1096, false, 30, 0, 6 },
                    { 1097, false, 30, 0, 7 },
                    { 1098, false, 30, 0, 8 },
                    { 1099, false, 30, 0, 9 },
                    { 1100, false, 30, 0, 10 },
                    { 1101, false, 30, 0, 11 },
                    { 1102, false, 30, 0, 12 },
                    { 1103, false, 30, 0, 13 },
                    { 1104, false, 30, 0, 14 },
                    { 1105, false, 30, 0, 15 },
                    { 1106, false, 30, 0, 16 },
                    { 1107, false, 30, 0, 17 },
                    { 1108, false, 30, 0, 18 },
                    { 1109, false, 30, 0, 19 },
                    { 1110, false, 30, 0, 20 },
                    { 1111, false, 30, 0, 21 },
                    { 1112, false, 30, 0, 22 },
                    { 1113, false, 30, 0, 23 },
                    { 1114, false, 30, 0, 24 },
                    { 1115, false, 30, 0, 25 },
                    { 1116, false, 30, 0, 26 },
                    { 1117, false, 30, 0, 27 },
                    { 1118, false, 30, 0, 28 },
                    { 1119, false, 30, 0, 29 },
                    { 1120, false, 30, 0, 30 },
                    { 1121, false, 30, 0, 31 },
                    { 1122, false, 30, 0, 32 },
                    { 1123, false, 30, 0, 33 },
                    { 1124, false, 30, 0, 34 },
                    { 1125, false, 30, 0, 35 },
                    { 1126, false, 30, 0, 36 },
                    { 1127, false, 30, 0, 37 },
                    { 1128, false, 30, 0, 38 },
                    { 1129, false, 30, 0, 39 },
                    { 1130, false, 30, 0, 40 },
                    { 1131, false, 30, 0, 41 },
                    { 1132, false, 30, 0, 42 },
                    { 1133, false, 30, 0, 43 },
                    { 1134, false, 30, 0, 44 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1135, false, 30, 0, 45 },
                    { 1136, false, 30, 0, 46 },
                    { 1137, false, 30, 0, 47 },
                    { 1138, false, 30, 0, 48 },
                    { 1139, false, 30, 0, 49 },
                    { 1140, false, 30, 0, 50 },
                    { 1141, false, 30, 0, 51 },
                    { 1142, false, 30, 0, 52 },
                    { 1143, false, 30, 0, 53 },
                    { 1144, false, 30, 0, 54 },
                    { 1145, false, 30, 0, 55 },
                    { 1146, false, 30, 0, 56 },
                    { 1147, false, 30, 0, 57 },
                    { 1148, false, 30, 0, 58 },
                    { 1149, false, 30, 0, 59 },
                    { 1150, false, 30, 0, 60 },
                    { 1151, false, 30, 0, 61 },
                    { 1152, false, 30, 0, 62 },
                    { 1153, false, 31, 1, 1 },
                    { 1154, false, 31, 1, 2 },
                    { 1155, false, 31, 1, 3 },
                    { 1156, false, 31, 1, 4 },
                    { 1157, false, 31, 2, 5 },
                    { 1158, false, 31, 2, 6 },
                    { 1159, false, 31, 2, 7 },
                    { 1160, false, 31, 2, 8 },
                    { 1161, false, 31, 3, 9 },
                    { 1162, false, 31, 3, 10 },
                    { 1163, false, 31, 3, 11 },
                    { 1164, false, 31, 3, 12 },
                    { 1165, false, 31, 4, 13 },
                    { 1166, false, 31, 4, 14 },
                    { 1167, false, 31, 4, 15 },
                    { 1168, false, 31, 4, 16 },
                    { 1169, false, 31, 5, 17 },
                    { 1170, false, 31, 5, 18 },
                    { 1171, false, 31, 5, 19 },
                    { 1172, false, 31, 5, 20 },
                    { 1173, false, 31, 6, 21 },
                    { 1174, false, 31, 6, 22 },
                    { 1175, false, 31, 6, 23 },
                    { 1176, false, 31, 6, 24 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1177, false, 31, 7, 25 },
                    { 1178, false, 31, 7, 26 },
                    { 1179, false, 31, 7, 27 },
                    { 1180, false, 31, 7, 28 },
                    { 1181, false, 32, 1, 1 },
                    { 1182, false, 32, 1, 2 },
                    { 1183, false, 32, 1, 3 },
                    { 1184, false, 32, 1, 4 },
                    { 1185, false, 32, 2, 5 },
                    { 1186, false, 32, 2, 6 },
                    { 1187, false, 32, 2, 7 },
                    { 1188, false, 32, 2, 8 },
                    { 1189, false, 32, 3, 9 },
                    { 1190, false, 32, 3, 10 },
                    { 1191, false, 32, 3, 11 },
                    { 1192, false, 32, 3, 12 },
                    { 1193, false, 32, 4, 13 },
                    { 1194, false, 32, 4, 14 },
                    { 1195, false, 32, 4, 15 },
                    { 1196, false, 32, 4, 16 },
                    { 1197, false, 32, 5, 17 },
                    { 1198, false, 32, 5, 18 },
                    { 1199, false, 32, 5, 19 },
                    { 1200, false, 32, 5, 20 },
                    { 1201, false, 32, 6, 21 },
                    { 1202, false, 32, 6, 22 },
                    { 1203, false, 32, 6, 23 },
                    { 1204, false, 32, 6, 24 },
                    { 1205, false, 32, 7, 25 },
                    { 1206, false, 32, 7, 26 },
                    { 1207, false, 32, 7, 27 },
                    { 1208, false, 32, 7, 28 },
                    { 1209, false, 33, 1, 1 },
                    { 1210, false, 33, 1, 2 },
                    { 1211, false, 33, 1, 3 },
                    { 1212, false, 33, 1, 4 },
                    { 1213, false, 33, 2, 5 },
                    { 1214, false, 33, 2, 6 },
                    { 1215, false, 33, 2, 7 },
                    { 1216, false, 33, 2, 8 },
                    { 1217, false, 33, 3, 9 },
                    { 1218, false, 33, 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1219, false, 33, 3, 11 },
                    { 1220, false, 33, 3, 12 },
                    { 1221, false, 33, 4, 13 },
                    { 1222, false, 33, 4, 14 },
                    { 1223, false, 33, 4, 15 },
                    { 1224, false, 33, 4, 16 },
                    { 1225, false, 33, 5, 17 },
                    { 1226, false, 33, 5, 18 },
                    { 1227, false, 33, 5, 19 },
                    { 1228, false, 33, 5, 20 },
                    { 1229, false, 33, 6, 21 },
                    { 1230, false, 33, 6, 22 },
                    { 1231, false, 33, 6, 23 },
                    { 1232, false, 33, 6, 24 },
                    { 1233, false, 33, 7, 25 },
                    { 1234, false, 33, 7, 26 },
                    { 1235, false, 33, 7, 27 },
                    { 1236, false, 33, 7, 28 },
                    { 1237, false, 34, 1, 1 },
                    { 1238, false, 34, 1, 2 },
                    { 1239, false, 34, 1, 3 },
                    { 1240, false, 34, 1, 4 },
                    { 1241, false, 34, 2, 5 },
                    { 1242, false, 34, 2, 6 },
                    { 1243, false, 34, 2, 7 },
                    { 1244, false, 34, 2, 8 },
                    { 1245, false, 34, 3, 9 },
                    { 1246, false, 34, 3, 10 },
                    { 1247, false, 34, 3, 11 },
                    { 1248, false, 34, 3, 12 },
                    { 1249, false, 34, 4, 13 },
                    { 1250, false, 34, 4, 14 },
                    { 1251, false, 34, 4, 15 },
                    { 1252, false, 34, 4, 16 },
                    { 1253, false, 34, 5, 17 },
                    { 1254, false, 34, 5, 18 },
                    { 1255, false, 34, 5, 19 },
                    { 1256, false, 34, 5, 20 },
                    { 1257, false, 34, 6, 21 },
                    { 1258, false, 34, 6, 22 },
                    { 1259, false, 34, 6, 23 },
                    { 1260, false, 34, 6, 24 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1261, false, 34, 7, 25 },
                    { 1262, false, 34, 7, 26 },
                    { 1263, false, 34, 7, 27 },
                    { 1264, false, 34, 7, 28 },
                    { 1265, false, 35, 1, 1 },
                    { 1266, false, 35, 1, 2 },
                    { 1267, false, 35, 1, 3 },
                    { 1268, false, 35, 1, 4 },
                    { 1269, false, 35, 1, 5 },
                    { 1270, false, 35, 1, 6 },
                    { 1271, false, 35, 2, 7 },
                    { 1272, false, 35, 2, 8 },
                    { 1273, false, 35, 2, 9 },
                    { 1274, false, 35, 2, 10 },
                    { 1275, false, 35, 2, 11 },
                    { 1276, false, 35, 2, 12 },
                    { 1277, false, 35, 3, 13 },
                    { 1278, false, 35, 3, 14 },
                    { 1279, false, 35, 3, 15 },
                    { 1280, false, 35, 3, 16 },
                    { 1281, false, 35, 3, 17 },
                    { 1282, false, 35, 3, 18 },
                    { 1283, false, 35, 4, 19 },
                    { 1284, false, 35, 4, 20 },
                    { 1285, false, 35, 4, 21 },
                    { 1286, false, 35, 4, 22 },
                    { 1287, false, 35, 4, 23 },
                    { 1288, false, 35, 4, 24 },
                    { 1289, false, 35, 5, 25 },
                    { 1290, false, 35, 5, 26 },
                    { 1291, false, 35, 5, 27 },
                    { 1292, false, 35, 5, 28 },
                    { 1293, false, 35, 5, 29 },
                    { 1294, false, 35, 5, 30 },
                    { 1295, false, 35, 6, 31 },
                    { 1296, false, 35, 6, 32 },
                    { 1297, false, 35, 6, 33 },
                    { 1298, false, 35, 6, 34 },
                    { 1299, false, 35, 6, 35 },
                    { 1300, false, 35, 6, 36 },
                    { 1301, false, 35, 7, 37 },
                    { 1302, false, 35, 7, 38 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1303, false, 35, 7, 39 },
                    { 1304, false, 35, 7, 40 },
                    { 1305, false, 35, 7, 41 },
                    { 1306, false, 35, 7, 42 },
                    { 1307, false, 36, 1, 1 },
                    { 1308, false, 36, 1, 2 },
                    { 1309, false, 36, 1, 3 },
                    { 1310, false, 36, 1, 4 },
                    { 1311, false, 36, 1, 5 },
                    { 1312, false, 36, 1, 6 },
                    { 1313, false, 36, 2, 7 },
                    { 1314, false, 36, 2, 8 },
                    { 1315, false, 36, 2, 9 },
                    { 1316, false, 36, 2, 10 },
                    { 1317, false, 36, 2, 11 },
                    { 1318, false, 36, 2, 12 },
                    { 1319, false, 36, 3, 13 },
                    { 1320, false, 36, 3, 14 },
                    { 1321, false, 36, 3, 15 },
                    { 1322, false, 36, 3, 16 },
                    { 1323, false, 36, 3, 17 },
                    { 1324, false, 36, 3, 18 },
                    { 1325, false, 36, 4, 19 },
                    { 1326, false, 36, 4, 20 },
                    { 1327, false, 36, 4, 21 },
                    { 1328, false, 36, 4, 22 },
                    { 1329, false, 36, 4, 23 },
                    { 1330, false, 36, 4, 24 },
                    { 1331, false, 36, 5, 25 },
                    { 1332, false, 36, 5, 26 },
                    { 1333, false, 36, 5, 27 },
                    { 1334, false, 36, 5, 28 },
                    { 1335, false, 36, 5, 29 },
                    { 1336, false, 36, 5, 30 },
                    { 1337, false, 36, 6, 31 },
                    { 1338, false, 36, 6, 32 },
                    { 1339, false, 36, 6, 33 },
                    { 1340, false, 36, 6, 34 },
                    { 1341, false, 36, 6, 35 },
                    { 1342, false, 36, 6, 36 },
                    { 1343, false, 36, 7, 37 },
                    { 1344, false, 36, 7, 38 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1345, false, 36, 7, 39 },
                    { 1346, false, 36, 7, 40 },
                    { 1347, false, 36, 7, 41 },
                    { 1348, false, 36, 7, 42 },
                    { 1349, false, 37, 0, 1 },
                    { 1350, false, 37, 0, 2 },
                    { 1351, false, 37, 0, 3 },
                    { 1352, false, 37, 0, 4 },
                    { 1353, false, 37, 0, 5 },
                    { 1354, false, 37, 0, 6 },
                    { 1355, false, 37, 0, 7 },
                    { 1356, false, 37, 0, 8 },
                    { 1357, false, 37, 0, 9 },
                    { 1358, false, 37, 0, 10 },
                    { 1359, false, 37, 0, 11 },
                    { 1360, false, 37, 0, 12 },
                    { 1361, false, 37, 0, 13 },
                    { 1362, false, 37, 0, 14 },
                    { 1363, false, 37, 0, 15 },
                    { 1364, false, 37, 0, 16 },
                    { 1365, false, 37, 0, 17 },
                    { 1366, false, 37, 0, 18 },
                    { 1367, false, 37, 0, 19 },
                    { 1368, false, 37, 0, 20 },
                    { 1369, false, 37, 0, 21 },
                    { 1370, false, 37, 0, 22 },
                    { 1371, false, 37, 0, 23 },
                    { 1372, false, 37, 0, 24 },
                    { 1373, false, 37, 0, 25 },
                    { 1374, false, 37, 0, 26 },
                    { 1375, false, 37, 0, 27 },
                    { 1376, false, 37, 0, 28 },
                    { 1377, false, 37, 0, 29 },
                    { 1378, false, 37, 0, 30 },
                    { 1379, false, 37, 0, 31 },
                    { 1380, false, 37, 0, 32 },
                    { 1381, false, 38, 0, 1 },
                    { 1382, false, 38, 0, 2 },
                    { 1383, false, 38, 0, 3 },
                    { 1384, false, 38, 0, 4 },
                    { 1385, false, 38, 0, 5 },
                    { 1386, false, 38, 0, 6 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1387, false, 38, 0, 7 },
                    { 1388, false, 38, 0, 8 },
                    { 1389, false, 38, 0, 9 },
                    { 1390, false, 38, 0, 10 },
                    { 1391, false, 38, 0, 11 },
                    { 1392, false, 38, 0, 12 },
                    { 1393, false, 38, 0, 13 },
                    { 1394, false, 38, 0, 14 },
                    { 1395, false, 38, 0, 15 },
                    { 1396, false, 38, 0, 16 },
                    { 1397, false, 38, 0, 17 },
                    { 1398, false, 38, 0, 18 },
                    { 1399, false, 38, 0, 19 },
                    { 1400, false, 38, 0, 20 },
                    { 1401, false, 38, 0, 21 },
                    { 1402, false, 38, 0, 22 },
                    { 1403, false, 38, 0, 23 },
                    { 1404, false, 38, 0, 24 },
                    { 1405, false, 38, 0, 25 },
                    { 1406, false, 38, 0, 26 },
                    { 1407, false, 38, 0, 27 },
                    { 1408, false, 38, 0, 28 },
                    { 1409, false, 38, 0, 29 },
                    { 1410, false, 38, 0, 30 },
                    { 1411, false, 38, 0, 31 },
                    { 1412, false, 38, 0, 32 },
                    { 1413, false, 39, 0, 1 },
                    { 1414, false, 39, 0, 2 },
                    { 1415, false, 39, 0, 3 },
                    { 1416, false, 39, 0, 4 },
                    { 1417, false, 39, 0, 5 },
                    { 1418, false, 39, 0, 6 },
                    { 1419, false, 39, 0, 7 },
                    { 1420, false, 39, 0, 8 },
                    { 1421, false, 39, 0, 9 },
                    { 1422, false, 39, 0, 10 },
                    { 1423, false, 39, 0, 11 },
                    { 1424, false, 39, 0, 12 },
                    { 1425, false, 39, 0, 13 },
                    { 1426, false, 39, 0, 14 },
                    { 1427, false, 39, 0, 15 },
                    { 1428, false, 39, 0, 16 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1429, false, 39, 0, 17 },
                    { 1430, false, 39, 0, 18 },
                    { 1431, false, 39, 0, 19 },
                    { 1432, false, 39, 0, 20 },
                    { 1433, false, 39, 0, 21 },
                    { 1434, false, 39, 0, 22 },
                    { 1435, false, 39, 0, 23 },
                    { 1436, false, 39, 0, 24 },
                    { 1437, false, 39, 0, 25 },
                    { 1438, false, 39, 0, 26 },
                    { 1439, false, 39, 0, 27 },
                    { 1440, false, 39, 0, 28 },
                    { 1441, false, 39, 0, 29 },
                    { 1442, false, 39, 0, 30 },
                    { 1443, false, 39, 0, 31 },
                    { 1444, false, 39, 0, 32 },
                    { 1445, false, 39, 0, 33 },
                    { 1446, false, 39, 0, 34 },
                    { 1447, false, 39, 0, 35 },
                    { 1448, false, 39, 0, 36 },
                    { 1449, false, 39, 0, 37 },
                    { 1450, false, 39, 0, 38 },
                    { 1451, false, 39, 0, 39 },
                    { 1452, false, 39, 0, 40 },
                    { 1453, false, 39, 0, 41 },
                    { 1454, false, 39, 0, 42 },
                    { 1455, false, 39, 0, 43 },
                    { 1456, false, 39, 0, 44 },
                    { 1457, false, 39, 0, 45 },
                    { 1458, false, 39, 0, 46 },
                    { 1459, false, 39, 0, 47 },
                    { 1460, false, 39, 0, 48 },
                    { 1461, false, 39, 0, 49 },
                    { 1462, false, 39, 0, 50 },
                    { 1463, false, 39, 0, 51 },
                    { 1464, false, 39, 0, 52 },
                    { 1465, false, 39, 0, 53 },
                    { 1466, false, 39, 0, 54 },
                    { 1467, false, 39, 0, 55 },
                    { 1468, false, 39, 0, 56 },
                    { 1469, false, 39, 0, 57 },
                    { 1470, false, 39, 0, 58 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1471, false, 39, 0, 59 },
                    { 1472, false, 39, 0, 60 },
                    { 1473, false, 39, 0, 61 },
                    { 1474, false, 39, 0, 62 },
                    { 1475, false, 40, 0, 1 },
                    { 1476, false, 40, 0, 2 },
                    { 1477, false, 40, 0, 3 },
                    { 1478, false, 40, 0, 4 },
                    { 1479, false, 40, 0, 5 },
                    { 1480, false, 40, 0, 6 },
                    { 1481, false, 40, 0, 7 },
                    { 1482, false, 40, 0, 8 },
                    { 1483, false, 40, 0, 9 },
                    { 1484, false, 40, 0, 10 },
                    { 1485, false, 40, 0, 11 },
                    { 1486, false, 40, 0, 12 },
                    { 1487, false, 40, 0, 13 },
                    { 1488, false, 40, 0, 14 },
                    { 1489, false, 40, 0, 15 },
                    { 1490, false, 40, 0, 16 },
                    { 1491, false, 40, 0, 17 },
                    { 1492, false, 40, 0, 18 },
                    { 1493, false, 40, 0, 19 },
                    { 1494, false, 40, 0, 20 },
                    { 1495, false, 40, 0, 21 },
                    { 1496, false, 40, 0, 22 },
                    { 1497, false, 40, 0, 23 },
                    { 1498, false, 40, 0, 24 },
                    { 1499, false, 40, 0, 25 },
                    { 1500, false, 40, 0, 26 },
                    { 1501, false, 40, 0, 27 },
                    { 1502, false, 40, 0, 28 },
                    { 1503, false, 40, 0, 29 },
                    { 1504, false, 40, 0, 30 },
                    { 1505, false, 40, 0, 31 },
                    { 1506, false, 40, 0, 32 },
                    { 1507, false, 40, 0, 33 },
                    { 1508, false, 40, 0, 34 },
                    { 1509, false, 40, 0, 35 },
                    { 1510, false, 40, 0, 36 },
                    { 1511, false, 40, 0, 37 },
                    { 1512, false, 40, 0, 38 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1513, false, 40, 0, 39 },
                    { 1514, false, 40, 0, 40 },
                    { 1515, false, 40, 0, 41 },
                    { 1516, false, 40, 0, 42 },
                    { 1517, false, 40, 0, 43 },
                    { 1518, false, 40, 0, 44 },
                    { 1519, false, 40, 0, 45 },
                    { 1520, false, 40, 0, 46 },
                    { 1521, false, 40, 0, 47 },
                    { 1522, false, 40, 0, 48 },
                    { 1523, false, 40, 0, 49 },
                    { 1524, false, 40, 0, 50 },
                    { 1525, false, 40, 0, 51 },
                    { 1526, false, 40, 0, 52 },
                    { 1527, false, 40, 0, 53 },
                    { 1528, false, 40, 0, 54 },
                    { 1529, false, 40, 0, 55 },
                    { 1530, false, 40, 0, 56 },
                    { 1531, false, 40, 0, 57 },
                    { 1532, false, 40, 0, 58 },
                    { 1533, false, 40, 0, 59 },
                    { 1534, false, 40, 0, 60 },
                    { 1535, false, 40, 0, 61 },
                    { 1536, false, 40, 0, 62 },
                    { 1537, false, 41, 1, 1 },
                    { 1538, false, 41, 1, 2 },
                    { 1539, false, 41, 1, 3 },
                    { 1540, false, 41, 1, 4 },
                    { 1541, false, 41, 2, 5 },
                    { 1542, false, 41, 2, 6 },
                    { 1543, false, 41, 2, 7 },
                    { 1544, false, 41, 2, 8 },
                    { 1545, false, 41, 3, 9 },
                    { 1546, false, 41, 3, 10 },
                    { 1547, false, 41, 3, 11 },
                    { 1548, false, 41, 3, 12 },
                    { 1549, false, 41, 4, 13 },
                    { 1550, false, 41, 4, 14 },
                    { 1551, false, 41, 4, 15 },
                    { 1552, false, 41, 4, 16 },
                    { 1553, false, 41, 5, 17 },
                    { 1554, false, 41, 5, 18 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1555, false, 41, 5, 19 },
                    { 1556, false, 41, 5, 20 },
                    { 1557, false, 41, 6, 21 },
                    { 1558, false, 41, 6, 22 },
                    { 1559, false, 41, 6, 23 },
                    { 1560, false, 41, 6, 24 },
                    { 1561, false, 41, 7, 25 },
                    { 1562, false, 41, 7, 26 },
                    { 1563, false, 41, 7, 27 },
                    { 1564, false, 41, 7, 28 },
                    { 1565, false, 42, 1, 1 },
                    { 1566, false, 42, 1, 2 },
                    { 1567, false, 42, 1, 3 },
                    { 1568, false, 42, 1, 4 },
                    { 1569, false, 42, 2, 5 },
                    { 1570, false, 42, 2, 6 },
                    { 1571, false, 42, 2, 7 },
                    { 1572, false, 42, 2, 8 },
                    { 1573, false, 42, 3, 9 },
                    { 1574, false, 42, 3, 10 },
                    { 1575, false, 42, 3, 11 },
                    { 1576, false, 42, 3, 12 },
                    { 1577, false, 42, 4, 13 },
                    { 1578, false, 42, 4, 14 },
                    { 1579, false, 42, 4, 15 },
                    { 1580, false, 42, 4, 16 },
                    { 1581, false, 42, 5, 17 },
                    { 1582, false, 42, 5, 18 },
                    { 1583, false, 42, 5, 19 },
                    { 1584, false, 42, 5, 20 },
                    { 1585, false, 42, 6, 21 },
                    { 1586, false, 42, 6, 22 },
                    { 1587, false, 42, 6, 23 },
                    { 1588, false, 42, 6, 24 },
                    { 1589, false, 42, 7, 25 },
                    { 1590, false, 42, 7, 26 },
                    { 1591, false, 42, 7, 27 },
                    { 1592, false, 42, 7, 28 },
                    { 1593, false, 43, 1, 1 },
                    { 1594, false, 43, 1, 2 },
                    { 1595, false, 43, 1, 3 },
                    { 1596, false, 43, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1597, false, 43, 2, 5 },
                    { 1598, false, 43, 2, 6 },
                    { 1599, false, 43, 2, 7 },
                    { 1600, false, 43, 2, 8 },
                    { 1601, false, 43, 3, 9 },
                    { 1602, false, 43, 3, 10 },
                    { 1603, false, 43, 3, 11 },
                    { 1604, false, 43, 3, 12 },
                    { 1605, false, 43, 4, 13 },
                    { 1606, false, 43, 4, 14 },
                    { 1607, false, 43, 4, 15 },
                    { 1608, false, 43, 4, 16 },
                    { 1609, false, 43, 5, 17 },
                    { 1610, false, 43, 5, 18 },
                    { 1611, false, 43, 5, 19 },
                    { 1612, false, 43, 5, 20 },
                    { 1613, false, 43, 6, 21 },
                    { 1614, false, 43, 6, 22 },
                    { 1615, false, 43, 6, 23 },
                    { 1616, false, 43, 6, 24 },
                    { 1617, false, 43, 7, 25 },
                    { 1618, false, 43, 7, 26 },
                    { 1619, false, 43, 7, 27 },
                    { 1620, false, 43, 7, 28 },
                    { 1621, false, 44, 1, 1 },
                    { 1622, false, 44, 1, 2 },
                    { 1623, false, 44, 1, 3 },
                    { 1624, false, 44, 1, 4 },
                    { 1625, false, 44, 2, 5 },
                    { 1626, false, 44, 2, 6 },
                    { 1627, false, 44, 2, 7 },
                    { 1628, false, 44, 2, 8 },
                    { 1629, false, 44, 3, 9 },
                    { 1630, false, 44, 3, 10 },
                    { 1631, false, 44, 3, 11 },
                    { 1632, false, 44, 3, 12 },
                    { 1633, false, 44, 4, 13 },
                    { 1634, false, 44, 4, 14 },
                    { 1635, false, 44, 4, 15 },
                    { 1636, false, 44, 4, 16 },
                    { 1637, false, 44, 5, 17 },
                    { 1638, false, 44, 5, 18 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1639, false, 44, 5, 19 },
                    { 1640, false, 44, 5, 20 },
                    { 1641, false, 44, 6, 21 },
                    { 1642, false, 44, 6, 22 },
                    { 1643, false, 44, 6, 23 },
                    { 1644, false, 44, 6, 24 },
                    { 1645, false, 44, 7, 25 },
                    { 1646, false, 44, 7, 26 },
                    { 1647, false, 44, 7, 27 },
                    { 1648, false, 44, 7, 28 },
                    { 1649, false, 45, 1, 1 },
                    { 1650, false, 45, 1, 2 },
                    { 1651, false, 45, 1, 3 },
                    { 1652, false, 45, 1, 4 },
                    { 1653, false, 45, 1, 5 },
                    { 1654, false, 45, 1, 6 },
                    { 1655, false, 45, 2, 7 },
                    { 1656, false, 45, 2, 8 },
                    { 1657, false, 45, 2, 9 },
                    { 1658, false, 45, 2, 10 },
                    { 1659, false, 45, 2, 11 },
                    { 1660, false, 45, 2, 12 },
                    { 1661, false, 45, 3, 13 },
                    { 1662, false, 45, 3, 14 },
                    { 1663, false, 45, 3, 15 },
                    { 1664, false, 45, 3, 16 },
                    { 1665, false, 45, 3, 17 },
                    { 1666, false, 45, 3, 18 },
                    { 1667, false, 45, 4, 19 },
                    { 1668, false, 45, 4, 20 },
                    { 1669, false, 45, 4, 21 },
                    { 1670, false, 45, 4, 22 },
                    { 1671, false, 45, 4, 23 },
                    { 1672, false, 45, 4, 24 },
                    { 1673, false, 45, 5, 25 },
                    { 1674, false, 45, 5, 26 },
                    { 1675, false, 45, 5, 27 },
                    { 1676, false, 45, 5, 28 },
                    { 1677, false, 45, 5, 29 },
                    { 1678, false, 45, 5, 30 },
                    { 1679, false, 45, 6, 31 },
                    { 1680, false, 45, 6, 32 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1681, false, 45, 6, 33 },
                    { 1682, false, 45, 6, 34 },
                    { 1683, false, 45, 6, 35 },
                    { 1684, false, 45, 6, 36 },
                    { 1685, false, 45, 7, 37 },
                    { 1686, false, 45, 7, 38 },
                    { 1687, false, 45, 7, 39 },
                    { 1688, false, 45, 7, 40 },
                    { 1689, false, 45, 7, 41 },
                    { 1690, false, 45, 7, 42 },
                    { 1691, false, 46, 1, 1 },
                    { 1692, false, 46, 1, 2 },
                    { 1693, false, 46, 1, 3 },
                    { 1694, false, 46, 1, 4 },
                    { 1695, false, 46, 1, 5 },
                    { 1696, false, 46, 1, 6 },
                    { 1697, false, 46, 2, 7 },
                    { 1698, false, 46, 2, 8 },
                    { 1699, false, 46, 2, 9 },
                    { 1700, false, 46, 2, 10 },
                    { 1701, false, 46, 2, 11 },
                    { 1702, false, 46, 2, 12 },
                    { 1703, false, 46, 3, 13 },
                    { 1704, false, 46, 3, 14 },
                    { 1705, false, 46, 3, 15 },
                    { 1706, false, 46, 3, 16 },
                    { 1707, false, 46, 3, 17 },
                    { 1708, false, 46, 3, 18 },
                    { 1709, false, 46, 4, 19 },
                    { 1710, false, 46, 4, 20 },
                    { 1711, false, 46, 4, 21 },
                    { 1712, false, 46, 4, 22 },
                    { 1713, false, 46, 4, 23 },
                    { 1714, false, 46, 4, 24 },
                    { 1715, false, 46, 5, 25 },
                    { 1716, false, 46, 5, 26 },
                    { 1717, false, 46, 5, 27 },
                    { 1718, false, 46, 5, 28 },
                    { 1719, false, 46, 5, 29 },
                    { 1720, false, 46, 5, 30 },
                    { 1721, false, 46, 6, 31 },
                    { 1722, false, 46, 6, 32 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1723, false, 46, 6, 33 },
                    { 1724, false, 46, 6, 34 },
                    { 1725, false, 46, 6, 35 },
                    { 1726, false, 46, 6, 36 },
                    { 1727, false, 46, 7, 37 },
                    { 1728, false, 46, 7, 38 },
                    { 1729, false, 46, 7, 39 },
                    { 1730, false, 46, 7, 40 },
                    { 1731, false, 46, 7, 41 },
                    { 1732, false, 46, 7, 42 },
                    { 1733, false, 47, 0, 1 },
                    { 1734, false, 47, 0, 2 },
                    { 1735, false, 47, 0, 3 },
                    { 1736, false, 47, 0, 4 },
                    { 1737, false, 47, 0, 5 },
                    { 1738, false, 47, 0, 6 },
                    { 1739, false, 47, 0, 7 },
                    { 1740, false, 47, 0, 8 },
                    { 1741, false, 47, 0, 9 },
                    { 1742, false, 47, 0, 10 },
                    { 1743, false, 47, 0, 11 },
                    { 1744, false, 47, 0, 12 },
                    { 1745, false, 47, 0, 13 },
                    { 1746, false, 47, 0, 14 },
                    { 1747, false, 47, 0, 15 },
                    { 1748, false, 47, 0, 16 },
                    { 1749, false, 47, 0, 17 },
                    { 1750, false, 47, 0, 18 },
                    { 1751, false, 47, 0, 19 },
                    { 1752, false, 47, 0, 20 },
                    { 1753, false, 47, 0, 21 },
                    { 1754, false, 47, 0, 22 },
                    { 1755, false, 47, 0, 23 },
                    { 1756, false, 47, 0, 24 },
                    { 1757, false, 47, 0, 25 },
                    { 1758, false, 47, 0, 26 },
                    { 1759, false, 47, 0, 27 },
                    { 1760, false, 47, 0, 28 },
                    { 1761, false, 47, 0, 29 },
                    { 1762, false, 47, 0, 30 },
                    { 1763, false, 47, 0, 31 },
                    { 1764, false, 47, 0, 32 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1765, false, 48, 0, 1 },
                    { 1766, false, 48, 0, 2 },
                    { 1767, false, 48, 0, 3 },
                    { 1768, false, 48, 0, 4 },
                    { 1769, false, 48, 0, 5 },
                    { 1770, false, 48, 0, 6 },
                    { 1771, false, 48, 0, 7 },
                    { 1772, false, 48, 0, 8 },
                    { 1773, false, 48, 0, 9 },
                    { 1774, false, 48, 0, 10 },
                    { 1775, false, 48, 0, 11 },
                    { 1776, false, 48, 0, 12 },
                    { 1777, false, 48, 0, 13 },
                    { 1778, false, 48, 0, 14 },
                    { 1779, false, 48, 0, 15 },
                    { 1780, false, 48, 0, 16 },
                    { 1781, false, 48, 0, 17 },
                    { 1782, false, 48, 0, 18 },
                    { 1783, false, 48, 0, 19 },
                    { 1784, false, 48, 0, 20 },
                    { 1785, false, 48, 0, 21 },
                    { 1786, false, 48, 0, 22 },
                    { 1787, false, 48, 0, 23 },
                    { 1788, false, 48, 0, 24 },
                    { 1789, false, 48, 0, 25 },
                    { 1790, false, 48, 0, 26 },
                    { 1791, false, 48, 0, 27 },
                    { 1792, false, 48, 0, 28 },
                    { 1793, false, 48, 0, 29 },
                    { 1794, false, 48, 0, 30 },
                    { 1795, false, 48, 0, 31 },
                    { 1796, false, 48, 0, 32 },
                    { 1797, false, 49, 0, 1 },
                    { 1798, false, 49, 0, 2 },
                    { 1799, false, 49, 0, 3 },
                    { 1800, false, 49, 0, 4 },
                    { 1801, false, 49, 0, 5 },
                    { 1802, false, 49, 0, 6 },
                    { 1803, false, 49, 0, 7 },
                    { 1804, false, 49, 0, 8 },
                    { 1805, false, 49, 0, 9 },
                    { 1806, false, 49, 0, 10 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1807, false, 49, 0, 11 },
                    { 1808, false, 49, 0, 12 },
                    { 1809, false, 49, 0, 13 },
                    { 1810, false, 49, 0, 14 },
                    { 1811, false, 49, 0, 15 },
                    { 1812, false, 49, 0, 16 },
                    { 1813, false, 49, 0, 17 },
                    { 1814, false, 49, 0, 18 },
                    { 1815, false, 49, 0, 19 },
                    { 1816, false, 49, 0, 20 },
                    { 1817, false, 49, 0, 21 },
                    { 1818, false, 49, 0, 22 },
                    { 1819, false, 49, 0, 23 },
                    { 1820, false, 49, 0, 24 },
                    { 1821, false, 49, 0, 25 },
                    { 1822, false, 49, 0, 26 },
                    { 1823, false, 49, 0, 27 },
                    { 1824, false, 49, 0, 28 },
                    { 1825, false, 49, 0, 29 },
                    { 1826, false, 49, 0, 30 },
                    { 1827, false, 49, 0, 31 },
                    { 1828, false, 49, 0, 32 },
                    { 1829, false, 49, 0, 33 },
                    { 1830, false, 49, 0, 34 },
                    { 1831, false, 49, 0, 35 },
                    { 1832, false, 49, 0, 36 },
                    { 1833, false, 49, 0, 37 },
                    { 1834, false, 49, 0, 38 },
                    { 1835, false, 49, 0, 39 },
                    { 1836, false, 49, 0, 40 },
                    { 1837, false, 49, 0, 41 },
                    { 1838, false, 49, 0, 42 },
                    { 1839, false, 49, 0, 43 },
                    { 1840, false, 49, 0, 44 },
                    { 1841, false, 49, 0, 45 },
                    { 1842, false, 49, 0, 46 },
                    { 1843, false, 49, 0, 47 },
                    { 1844, false, 49, 0, 48 },
                    { 1845, false, 49, 0, 49 },
                    { 1846, false, 49, 0, 50 },
                    { 1847, false, 49, 0, 51 },
                    { 1848, false, 49, 0, 52 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1849, false, 49, 0, 53 },
                    { 1850, false, 49, 0, 54 },
                    { 1851, false, 49, 0, 55 },
                    { 1852, false, 49, 0, 56 },
                    { 1853, false, 49, 0, 57 },
                    { 1854, false, 49, 0, 58 },
                    { 1855, false, 49, 0, 59 },
                    { 1856, false, 49, 0, 60 },
                    { 1857, false, 49, 0, 61 },
                    { 1858, false, 49, 0, 62 },
                    { 1859, false, 50, 0, 1 },
                    { 1860, false, 50, 0, 2 },
                    { 1861, false, 50, 0, 3 },
                    { 1862, false, 50, 0, 4 },
                    { 1863, false, 50, 0, 5 },
                    { 1864, false, 50, 0, 6 },
                    { 1865, false, 50, 0, 7 },
                    { 1866, false, 50, 0, 8 },
                    { 1867, false, 50, 0, 9 },
                    { 1868, false, 50, 0, 10 },
                    { 1869, false, 50, 0, 11 },
                    { 1870, false, 50, 0, 12 },
                    { 1871, false, 50, 0, 13 },
                    { 1872, false, 50, 0, 14 },
                    { 1873, false, 50, 0, 15 },
                    { 1874, false, 50, 0, 16 },
                    { 1875, false, 50, 0, 17 },
                    { 1876, false, 50, 0, 18 },
                    { 1877, false, 50, 0, 19 },
                    { 1878, false, 50, 0, 20 },
                    { 1879, false, 50, 0, 21 },
                    { 1880, false, 50, 0, 22 },
                    { 1881, false, 50, 0, 23 },
                    { 1882, false, 50, 0, 24 },
                    { 1883, false, 50, 0, 25 },
                    { 1884, false, 50, 0, 26 },
                    { 1885, false, 50, 0, 27 },
                    { 1886, false, 50, 0, 28 },
                    { 1887, false, 50, 0, 29 },
                    { 1888, false, 50, 0, 30 },
                    { 1889, false, 50, 0, 31 },
                    { 1890, false, 50, 0, 32 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1891, false, 50, 0, 33 },
                    { 1892, false, 50, 0, 34 },
                    { 1893, false, 50, 0, 35 },
                    { 1894, false, 50, 0, 36 },
                    { 1895, false, 50, 0, 37 },
                    { 1896, false, 50, 0, 38 },
                    { 1897, false, 50, 0, 39 },
                    { 1898, false, 50, 0, 40 },
                    { 1899, false, 50, 0, 41 },
                    { 1900, false, 50, 0, 42 },
                    { 1901, false, 50, 0, 43 },
                    { 1902, false, 50, 0, 44 },
                    { 1903, false, 50, 0, 45 },
                    { 1904, false, 50, 0, 46 },
                    { 1905, false, 50, 0, 47 },
                    { 1906, false, 50, 0, 48 },
                    { 1907, false, 50, 0, 49 },
                    { 1908, false, 50, 0, 50 },
                    { 1909, false, 50, 0, 51 },
                    { 1910, false, 50, 0, 52 },
                    { 1911, false, 50, 0, 53 },
                    { 1912, false, 50, 0, 54 },
                    { 1913, false, 50, 0, 55 },
                    { 1914, false, 50, 0, 56 },
                    { 1915, false, 50, 0, 57 },
                    { 1916, false, 50, 0, 58 },
                    { 1917, false, 50, 0, 59 },
                    { 1918, false, 50, 0, 60 },
                    { 1919, false, 50, 0, 61 },
                    { 1920, false, 50, 0, 62 },
                    { 1921, false, 51, 1, 1 },
                    { 1922, false, 51, 1, 2 },
                    { 1923, false, 51, 1, 3 },
                    { 1924, false, 51, 1, 4 },
                    { 1925, false, 51, 2, 5 },
                    { 1926, false, 51, 2, 6 },
                    { 1927, false, 51, 2, 7 },
                    { 1928, false, 51, 2, 8 },
                    { 1929, false, 51, 3, 9 },
                    { 1930, false, 51, 3, 10 },
                    { 1931, false, 51, 3, 11 },
                    { 1932, false, 51, 3, 12 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1933, false, 51, 4, 13 },
                    { 1934, false, 51, 4, 14 },
                    { 1935, false, 51, 4, 15 },
                    { 1936, false, 51, 4, 16 },
                    { 1937, false, 51, 5, 17 },
                    { 1938, false, 51, 5, 18 },
                    { 1939, false, 51, 5, 19 },
                    { 1940, false, 51, 5, 20 },
                    { 1941, false, 51, 6, 21 },
                    { 1942, false, 51, 6, 22 },
                    { 1943, false, 51, 6, 23 },
                    { 1944, false, 51, 6, 24 },
                    { 1945, false, 51, 7, 25 },
                    { 1946, false, 51, 7, 26 },
                    { 1947, false, 51, 7, 27 },
                    { 1948, false, 51, 7, 28 },
                    { 1949, false, 52, 1, 1 },
                    { 1950, false, 52, 1, 2 },
                    { 1951, false, 52, 1, 3 },
                    { 1952, false, 52, 1, 4 },
                    { 1953, false, 52, 2, 5 },
                    { 1954, false, 52, 2, 6 },
                    { 1955, false, 52, 2, 7 },
                    { 1956, false, 52, 2, 8 },
                    { 1957, false, 52, 3, 9 },
                    { 1958, false, 52, 3, 10 },
                    { 1959, false, 52, 3, 11 },
                    { 1960, false, 52, 3, 12 },
                    { 1961, false, 52, 4, 13 },
                    { 1962, false, 52, 4, 14 },
                    { 1963, false, 52, 4, 15 },
                    { 1964, false, 52, 4, 16 },
                    { 1965, false, 52, 5, 17 },
                    { 1966, false, 52, 5, 18 },
                    { 1967, false, 52, 5, 19 },
                    { 1968, false, 52, 5, 20 },
                    { 1969, false, 52, 6, 21 },
                    { 1970, false, 52, 6, 22 },
                    { 1971, false, 52, 6, 23 },
                    { 1972, false, 52, 6, 24 },
                    { 1973, false, 52, 7, 25 },
                    { 1974, false, 52, 7, 26 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 1975, false, 52, 7, 27 },
                    { 1976, false, 52, 7, 28 },
                    { 1977, false, 53, 1, 1 },
                    { 1978, false, 53, 1, 2 },
                    { 1979, false, 53, 1, 3 },
                    { 1980, false, 53, 1, 4 },
                    { 1981, false, 53, 2, 5 },
                    { 1982, false, 53, 2, 6 },
                    { 1983, false, 53, 2, 7 },
                    { 1984, false, 53, 2, 8 },
                    { 1985, false, 53, 3, 9 },
                    { 1986, false, 53, 3, 10 },
                    { 1987, false, 53, 3, 11 },
                    { 1988, false, 53, 3, 12 },
                    { 1989, false, 53, 4, 13 },
                    { 1990, false, 53, 4, 14 },
                    { 1991, false, 53, 4, 15 },
                    { 1992, false, 53, 4, 16 },
                    { 1993, false, 53, 5, 17 },
                    { 1994, false, 53, 5, 18 },
                    { 1995, false, 53, 5, 19 },
                    { 1996, false, 53, 5, 20 },
                    { 1997, false, 53, 6, 21 },
                    { 1998, false, 53, 6, 22 },
                    { 1999, false, 53, 6, 23 },
                    { 2000, false, 53, 6, 24 },
                    { 2001, false, 53, 7, 25 },
                    { 2002, false, 53, 7, 26 },
                    { 2003, false, 53, 7, 27 },
                    { 2004, false, 53, 7, 28 },
                    { 2005, false, 54, 1, 1 },
                    { 2006, false, 54, 1, 2 },
                    { 2007, false, 54, 1, 3 },
                    { 2008, false, 54, 1, 4 },
                    { 2009, false, 54, 2, 5 },
                    { 2010, false, 54, 2, 6 },
                    { 2011, false, 54, 2, 7 },
                    { 2012, false, 54, 2, 8 },
                    { 2013, false, 54, 3, 9 },
                    { 2014, false, 54, 3, 10 },
                    { 2015, false, 54, 3, 11 },
                    { 2016, false, 54, 3, 12 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2017, false, 54, 4, 13 },
                    { 2018, false, 54, 4, 14 },
                    { 2019, false, 54, 4, 15 },
                    { 2020, false, 54, 4, 16 },
                    { 2021, false, 54, 5, 17 },
                    { 2022, false, 54, 5, 18 },
                    { 2023, false, 54, 5, 19 },
                    { 2024, false, 54, 5, 20 },
                    { 2025, false, 54, 6, 21 },
                    { 2026, false, 54, 6, 22 },
                    { 2027, false, 54, 6, 23 },
                    { 2028, false, 54, 6, 24 },
                    { 2029, false, 54, 7, 25 },
                    { 2030, false, 54, 7, 26 },
                    { 2031, false, 54, 7, 27 },
                    { 2032, false, 54, 7, 28 },
                    { 2033, false, 55, 1, 1 },
                    { 2034, false, 55, 1, 2 },
                    { 2035, false, 55, 1, 3 },
                    { 2036, false, 55, 1, 4 },
                    { 2037, false, 55, 1, 5 },
                    { 2038, false, 55, 1, 6 },
                    { 2039, false, 55, 2, 7 },
                    { 2040, false, 55, 2, 8 },
                    { 2041, false, 55, 2, 9 },
                    { 2042, false, 55, 2, 10 },
                    { 2043, false, 55, 2, 11 },
                    { 2044, false, 55, 2, 12 },
                    { 2045, false, 55, 3, 13 },
                    { 2046, false, 55, 3, 14 },
                    { 2047, false, 55, 3, 15 },
                    { 2048, false, 55, 3, 16 },
                    { 2049, false, 55, 3, 17 },
                    { 2050, false, 55, 3, 18 },
                    { 2051, false, 55, 4, 19 },
                    { 2052, false, 55, 4, 20 },
                    { 2053, false, 55, 4, 21 },
                    { 2054, false, 55, 4, 22 },
                    { 2055, false, 55, 4, 23 },
                    { 2056, false, 55, 4, 24 },
                    { 2057, false, 55, 5, 25 },
                    { 2058, false, 55, 5, 26 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2059, false, 55, 5, 27 },
                    { 2060, false, 55, 5, 28 },
                    { 2061, false, 55, 5, 29 },
                    { 2062, false, 55, 5, 30 },
                    { 2063, false, 55, 6, 31 },
                    { 2064, false, 55, 6, 32 },
                    { 2065, false, 55, 6, 33 },
                    { 2066, false, 55, 6, 34 },
                    { 2067, false, 55, 6, 35 },
                    { 2068, false, 55, 6, 36 },
                    { 2069, false, 55, 7, 37 },
                    { 2070, false, 55, 7, 38 },
                    { 2071, false, 55, 7, 39 },
                    { 2072, false, 55, 7, 40 },
                    { 2073, false, 55, 7, 41 },
                    { 2074, false, 55, 7, 42 },
                    { 2075, false, 56, 1, 1 },
                    { 2076, false, 56, 1, 2 },
                    { 2077, false, 56, 1, 3 },
                    { 2078, false, 56, 1, 4 },
                    { 2079, false, 56, 1, 5 },
                    { 2080, false, 56, 1, 6 },
                    { 2081, false, 56, 2, 7 },
                    { 2082, false, 56, 2, 8 },
                    { 2083, false, 56, 2, 9 },
                    { 2084, false, 56, 2, 10 },
                    { 2085, false, 56, 2, 11 },
                    { 2086, false, 56, 2, 12 },
                    { 2087, false, 56, 3, 13 },
                    { 2088, false, 56, 3, 14 },
                    { 2089, false, 56, 3, 15 },
                    { 2090, false, 56, 3, 16 },
                    { 2091, false, 56, 3, 17 },
                    { 2092, false, 56, 3, 18 },
                    { 2093, false, 56, 4, 19 },
                    { 2094, false, 56, 4, 20 },
                    { 2095, false, 56, 4, 21 },
                    { 2096, false, 56, 4, 22 },
                    { 2097, false, 56, 4, 23 },
                    { 2098, false, 56, 4, 24 },
                    { 2099, false, 56, 5, 25 },
                    { 2100, false, 56, 5, 26 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2101, false, 56, 5, 27 },
                    { 2102, false, 56, 5, 28 },
                    { 2103, false, 56, 5, 29 },
                    { 2104, false, 56, 5, 30 },
                    { 2105, false, 56, 6, 31 },
                    { 2106, false, 56, 6, 32 },
                    { 2107, false, 56, 6, 33 },
                    { 2108, false, 56, 6, 34 },
                    { 2109, false, 56, 6, 35 },
                    { 2110, false, 56, 6, 36 },
                    { 2111, false, 56, 7, 37 },
                    { 2112, false, 56, 7, 38 },
                    { 2113, false, 56, 7, 39 },
                    { 2114, false, 56, 7, 40 },
                    { 2115, false, 56, 7, 41 },
                    { 2116, false, 56, 7, 42 },
                    { 2117, false, 57, 0, 1 },
                    { 2118, false, 57, 0, 2 },
                    { 2119, false, 57, 0, 3 },
                    { 2120, false, 57, 0, 4 },
                    { 2121, false, 57, 0, 5 },
                    { 2122, false, 57, 0, 6 },
                    { 2123, false, 57, 0, 7 },
                    { 2124, false, 57, 0, 8 },
                    { 2125, false, 57, 0, 9 },
                    { 2126, false, 57, 0, 10 },
                    { 2127, false, 57, 0, 11 },
                    { 2128, false, 57, 0, 12 },
                    { 2129, false, 57, 0, 13 },
                    { 2130, false, 57, 0, 14 },
                    { 2131, false, 57, 0, 15 },
                    { 2132, false, 57, 0, 16 },
                    { 2133, false, 57, 0, 17 },
                    { 2134, false, 57, 0, 18 },
                    { 2135, false, 57, 0, 19 },
                    { 2136, false, 57, 0, 20 },
                    { 2137, false, 57, 0, 21 },
                    { 2138, false, 57, 0, 22 },
                    { 2139, false, 57, 0, 23 },
                    { 2140, false, 57, 0, 24 },
                    { 2141, false, 57, 0, 25 },
                    { 2142, false, 57, 0, 26 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2143, false, 57, 0, 27 },
                    { 2144, false, 57, 0, 28 },
                    { 2145, false, 57, 0, 29 },
                    { 2146, false, 57, 0, 30 },
                    { 2147, false, 57, 0, 31 },
                    { 2148, false, 57, 0, 32 },
                    { 2149, false, 58, 0, 1 },
                    { 2150, false, 58, 0, 2 },
                    { 2151, false, 58, 0, 3 },
                    { 2152, false, 58, 0, 4 },
                    { 2153, false, 58, 0, 5 },
                    { 2154, false, 58, 0, 6 },
                    { 2155, false, 58, 0, 7 },
                    { 2156, false, 58, 0, 8 },
                    { 2157, false, 58, 0, 9 },
                    { 2158, false, 58, 0, 10 },
                    { 2159, false, 58, 0, 11 },
                    { 2160, false, 58, 0, 12 },
                    { 2161, false, 58, 0, 13 },
                    { 2162, false, 58, 0, 14 },
                    { 2163, false, 58, 0, 15 },
                    { 2164, false, 58, 0, 16 },
                    { 2165, false, 58, 0, 17 },
                    { 2166, false, 58, 0, 18 },
                    { 2167, false, 58, 0, 19 },
                    { 2168, false, 58, 0, 20 },
                    { 2169, false, 58, 0, 21 },
                    { 2170, false, 58, 0, 22 },
                    { 2171, false, 58, 0, 23 },
                    { 2172, false, 58, 0, 24 },
                    { 2173, false, 58, 0, 25 },
                    { 2174, false, 58, 0, 26 },
                    { 2175, false, 58, 0, 27 },
                    { 2176, false, 58, 0, 28 },
                    { 2177, false, 58, 0, 29 },
                    { 2178, false, 58, 0, 30 },
                    { 2179, false, 58, 0, 31 },
                    { 2180, false, 58, 0, 32 },
                    { 2181, false, 59, 0, 1 },
                    { 2182, false, 59, 0, 2 },
                    { 2183, false, 59, 0, 3 },
                    { 2184, false, 59, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2185, false, 59, 0, 5 },
                    { 2186, false, 59, 0, 6 },
                    { 2187, false, 59, 0, 7 },
                    { 2188, false, 59, 0, 8 },
                    { 2189, false, 59, 0, 9 },
                    { 2190, false, 59, 0, 10 },
                    { 2191, false, 59, 0, 11 },
                    { 2192, false, 59, 0, 12 },
                    { 2193, false, 59, 0, 13 },
                    { 2194, false, 59, 0, 14 },
                    { 2195, false, 59, 0, 15 },
                    { 2196, false, 59, 0, 16 },
                    { 2197, false, 59, 0, 17 },
                    { 2198, false, 59, 0, 18 },
                    { 2199, false, 59, 0, 19 },
                    { 2200, false, 59, 0, 20 },
                    { 2201, false, 59, 0, 21 },
                    { 2202, false, 59, 0, 22 },
                    { 2203, false, 59, 0, 23 },
                    { 2204, false, 59, 0, 24 },
                    { 2205, false, 59, 0, 25 },
                    { 2206, false, 59, 0, 26 },
                    { 2207, false, 59, 0, 27 },
                    { 2208, false, 59, 0, 28 },
                    { 2209, false, 59, 0, 29 },
                    { 2210, false, 59, 0, 30 },
                    { 2211, false, 59, 0, 31 },
                    { 2212, false, 59, 0, 32 },
                    { 2213, false, 59, 0, 33 },
                    { 2214, false, 59, 0, 34 },
                    { 2215, false, 59, 0, 35 },
                    { 2216, false, 59, 0, 36 },
                    { 2217, false, 59, 0, 37 },
                    { 2218, false, 59, 0, 38 },
                    { 2219, false, 59, 0, 39 },
                    { 2220, false, 59, 0, 40 },
                    { 2221, false, 59, 0, 41 },
                    { 2222, false, 59, 0, 42 },
                    { 2223, false, 59, 0, 43 },
                    { 2224, false, 59, 0, 44 },
                    { 2225, false, 59, 0, 45 },
                    { 2226, false, 59, 0, 46 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2227, false, 59, 0, 47 },
                    { 2228, false, 59, 0, 48 },
                    { 2229, false, 59, 0, 49 },
                    { 2230, false, 59, 0, 50 },
                    { 2231, false, 59, 0, 51 },
                    { 2232, false, 59, 0, 52 },
                    { 2233, false, 59, 0, 53 },
                    { 2234, false, 59, 0, 54 },
                    { 2235, false, 59, 0, 55 },
                    { 2236, false, 59, 0, 56 },
                    { 2237, false, 59, 0, 57 },
                    { 2238, false, 59, 0, 58 },
                    { 2239, false, 59, 0, 59 },
                    { 2240, false, 59, 0, 60 },
                    { 2241, false, 59, 0, 61 },
                    { 2242, false, 59, 0, 62 },
                    { 2243, false, 60, 0, 1 },
                    { 2244, false, 60, 0, 2 },
                    { 2245, false, 60, 0, 3 },
                    { 2246, false, 60, 0, 4 },
                    { 2247, false, 60, 0, 5 },
                    { 2248, false, 60, 0, 6 },
                    { 2249, false, 60, 0, 7 },
                    { 2250, false, 60, 0, 8 },
                    { 2251, false, 60, 0, 9 },
                    { 2252, false, 60, 0, 10 },
                    { 2253, false, 60, 0, 11 },
                    { 2254, false, 60, 0, 12 },
                    { 2255, false, 60, 0, 13 },
                    { 2256, false, 60, 0, 14 },
                    { 2257, false, 60, 0, 15 },
                    { 2258, false, 60, 0, 16 },
                    { 2259, false, 60, 0, 17 },
                    { 2260, false, 60, 0, 18 },
                    { 2261, false, 60, 0, 19 },
                    { 2262, false, 60, 0, 20 },
                    { 2263, false, 60, 0, 21 },
                    { 2264, false, 60, 0, 22 },
                    { 2265, false, 60, 0, 23 },
                    { 2266, false, 60, 0, 24 },
                    { 2267, false, 60, 0, 25 },
                    { 2268, false, 60, 0, 26 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "CoachId", "CompartmentNo", "SeatNo" },
                values: new object[,]
                {
                    { 2269, false, 60, 0, 27 },
                    { 2270, false, 60, 0, 28 },
                    { 2271, false, 60, 0, 29 },
                    { 2272, false, 60, 0, 30 },
                    { 2273, false, 60, 0, 31 },
                    { 2274, false, 60, 0, 32 },
                    { 2275, false, 60, 0, 33 },
                    { 2276, false, 60, 0, 34 },
                    { 2277, false, 60, 0, 35 },
                    { 2278, false, 60, 0, 36 },
                    { 2279, false, 60, 0, 37 },
                    { 2280, false, 60, 0, 38 },
                    { 2281, false, 60, 0, 39 },
                    { 2282, false, 60, 0, 40 },
                    { 2283, false, 60, 0, 41 },
                    { 2284, false, 60, 0, 42 },
                    { 2285, false, 60, 0, 43 },
                    { 2286, false, 60, 0, 44 },
                    { 2287, false, 60, 0, 45 },
                    { 2288, false, 60, 0, 46 },
                    { 2289, false, 60, 0, 47 },
                    { 2290, false, 60, 0, 48 },
                    { 2291, false, 60, 0, 49 },
                    { 2292, false, 60, 0, 50 },
                    { 2293, false, 60, 0, 51 },
                    { 2294, false, 60, 0, 52 },
                    { 2295, false, 60, 0, 53 },
                    { 2296, false, 60, 0, 54 },
                    { 2297, false, 60, 0, 55 },
                    { 2298, false, 60, 0, 56 },
                    { 2299, false, 60, 0, 57 },
                    { 2300, false, 60, 0, 58 },
                    { 2301, false, 60, 0, 59 },
                    { 2302, false, 60, 0, 60 },
                    { 2303, false, 60, 0, 61 },
                    { 2304, false, 60, 0, 62 }
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
                column: "SeatId");

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
                name: "IX_Passengers_BookingDetailId",
                table: "Passengers",
                column: "BookingDetailId",
                unique: true);

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
                name: "Fares");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "BookingDetails");

            migrationBuilder.DropTable(
                name: "PassengerTypes");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Seats");

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
