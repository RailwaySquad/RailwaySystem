using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railway_Group01.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoachModel");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    Seat = table.Column<int>(type: "int", nullable: false),
                    CIDNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Coachs_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coachs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Carts_Passengers_CIDNo",
                        column: x => x.CIDNo,
                        principalTable: "Passengers",
                        principalColumn: "CIDNo",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Carts_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CoachDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainsTrainCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfCompartment = table.Column<int>(type: "int", nullable: false),
                    NoOfSeat = table.Column<int>(type: "int", nullable: false),
                    SeatAvailable = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoachFare = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoachDto_Trains_TrainsTrainCode",
                        column: x => x.TrainsTrainCode,
                        principalTable: "Trains",
                        principalColumn: "TrainCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CIDNo",
                table: "Carts",
                column: "CIDNo");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CoachId",
                table: "Carts",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ScheduleId",
                table: "Carts",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_CoachDto_TrainsTrainCode",
                table: "CoachDto",
                column: "TrainsTrainCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CoachDto");

            migrationBuilder.CreateTable(
                name: "CoachModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainsTrainCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CoachFare = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfCompartment = table.Column<int>(type: "int", nullable: false),
                    NoOfSeat = table.Column<int>(type: "int", nullable: false),
                    SeatAvailable = table.Column<int>(type: "int", nullable: false),
                    TrainCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoachModel_Trains_TrainsTrainCode",
                        column: x => x.TrainsTrainCode,
                        principalTable: "Trains",
                        principalColumn: "TrainCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoachModel_TrainsTrainCode",
                table: "CoachModel",
                column: "TrainsTrainCode");
        }
    }
}
