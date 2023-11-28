using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railway_Group01.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Fares",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "CoachModel",
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
                    table.PrimaryKey("PK_CoachModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoachModel_Trains_TrainsTrainCode",
                        column: x => x.TrainsTrainCode,
                        principalTable: "Trains",
                        principalColumn: "TrainCode");
                });

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
                keyValue: 3,
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 10.0);

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
                keyValue: 7,
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 36.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 18.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 55.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 35.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 25.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 45.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 25.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 8.5);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 4.5);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 39.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 6.5);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 3.5);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 31,
                column: "Price",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: 30.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 33,
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 35,
                column: "Price",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 36,
                column: "Price",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 37,
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 39,
                column: "Price",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 40,
                column: "Price",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 41,
                column: "Price",
                value: 36.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 42,
                column: "Price",
                value: 18.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 43,
                column: "Price",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 44,
                column: "Price",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 45,
                column: "Price",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 46,
                column: "Price",
                value: 55.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 47,
                column: "Price",
                value: 35.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 48,
                column: "Price",
                value: 25.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 49,
                column: "Price",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 50,
                column: "Price",
                value: 5.5);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 51,
                column: "Price",
                value: 45.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 52,
                column: "Price",
                value: 25.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 54,
                column: "Price",
                value: 8.5);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 55,
                column: "Price",
                value: 4.5);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 56,
                column: "Price",
                value: 39.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 57,
                column: "Price",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 59,
                column: "Price",
                value: 6.5);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 60,
                column: "Price",
                value: 3.5);

            migrationBuilder.CreateIndex(
                name: "IX_CoachModel_TrainsTrainCode",
                table: "CoachModel",
                column: "TrainsTrainCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoachModel");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Fares",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 300000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 200000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 50000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 200000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 150000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 80000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 40000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 360000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 180000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 120000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 30000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 250000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 150000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 55000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 250000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 200000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 85000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 45000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 390000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 200000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 160000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 65000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 35000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 31,
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: 300000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 33,
                column: "Price",
                value: 200000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 35,
                column: "Price",
                value: 50000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 36,
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 37,
                column: "Price",
                value: 200000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: 150000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 39,
                column: "Price",
                value: 80000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 40,
                column: "Price",
                value: 40000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 41,
                column: "Price",
                value: 360000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 42,
                column: "Price",
                value: 180000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 43,
                column: "Price",
                value: 120000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 44,
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 45,
                column: "Price",
                value: 30000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 46,
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 47,
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 48,
                column: "Price",
                value: 250000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 49,
                column: "Price",
                value: 150000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 50,
                column: "Price",
                value: 55000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 51,
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 52,
                column: "Price",
                value: 250000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 200000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 54,
                column: "Price",
                value: 85000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 55,
                column: "Price",
                value: 45000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 56,
                column: "Price",
                value: 390000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 57,
                column: "Price",
                value: 200000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 160000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 59,
                column: "Price",
                value: 65000);

            migrationBuilder.UpdateData(
                table: "Fares",
                keyColumn: "Id",
                keyValue: 60,
                column: "Price",
                value: 35000);
        }
    }
}
