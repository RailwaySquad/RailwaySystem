using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace Railway_Group01.Data;

public class RailwayDbContext : IdentityDbContext<User>
{
    public RailwayDbContext(DbContextOptions<RailwayDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            var tableName = entityType.GetTableName();
            if (tableName!.StartsWith("AspNet"))
                entityType.SetTableName(tableName.Substring(6));
        }

        // Passenger 1:1 Ticket
        builder.Entity<Passenger>()
        .HasOne(e => e.Ticket)
        .WithOne(e => e.Passenger)
        .HasForeignKey<Ticket>(e => e.CIDNo)
        .IsRequired();

        // Ticket 1:1 Feedback
        builder.Entity<Ticket>()
        .HasOne(e => e.Feedback)
        .WithOne(e => e.Ticket)
        .HasForeignKey<Feedback>(e => e.PNRNo)
        .IsRequired();

        // Ticket 1:1 BookingDetails
        builder.Entity<Ticket>()
        .HasOne(e => e.BookingDetails)
        .WithOne(e => e.Ticket)
        .HasForeignKey<BookingDetails>(e => e.PNRNo)
        .IsRequired();
        builder.Entity<Station>().HasMany(p => p.DepartureRouteDetails).WithOne(p => p.DepartureStation);
        builder.Entity<Station>().HasMany(p => p.ArrivalRouteDetails).WithOne(p => p.ArrivalStation);
        builder.Entity<Station>().HasData(
                new Station { Id = 1, StationCode = "SGO", StationName = "Sai Gon", ZipCode = 700000, NameOfDivision = "Ho Chi Minh City", Zone = "Southern" },
                new Station { Id = 2, StationCode = "NTR", StationName = "Nha Trang", ZipCode = 650000, NameOfDivision = "Khanh Hoa Province", Zone = "Central" },
                new Station { Id = 3, StationCode = "HUE", StationName = "Hue", ZipCode = 530000, NameOfDivision = "Thua Thien Hue Province", Zone = "Central" },
                new Station { Id = 4, StationCode = "HNO", StationName = "Ha Noi", ZipCode = 700000, NameOfDivision = "Hanoi Capital", Zone = "North" }
                );
        builder.Entity<Train>().HasData(
            new Train { TrainCode = "SE101", Name = "SE1", TypeCode = "F", IsRunning = true, Description = "Train SE1 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE102", Name = "SE1", TypeCode = "F", IsRunning = true, Description = "Train SE1 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE201", Name = "SE2", TypeCode = "F", IsRunning = true, Description = "Train SE2 is a fast train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE202", Name = "SE2", TypeCode = "F", IsRunning = true, Description = "Train SE2 is a fast train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE301", Name = "SE3", TypeCode = "SF", IsRunning = true, Description = "The SE3 train is the fastest and most beautiful train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE302", Name = "SE3", TypeCode = "SF", IsRunning = true, Description = "The SE3 train is the fastest and most beautiful train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE401", Name = "SE4", TypeCode = "SF", IsRunning = true, Description = "Train SE4 is the fastest and most beautiful train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE402", Name = "SE4", TypeCode = "SF", IsRunning = true, Description = "Train SE4 is the fastest and most beautiful train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE501", Name = "SE5", TypeCode = "S", IsRunning = true, Description = "Train SE5 is a slow train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE502", Name = "SE5", TypeCode = "S", IsRunning = true, Description = "Train SE5 is a slow train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE601", Name = "SE6", TypeCode = "S", IsRunning = true, Description = "Train SE6 is a slow train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE602", Name = "SE6", TypeCode = "S", IsRunning = true, Description = "Train SE6 is a slow train running on the unified North-South train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE701", Name = "SE7", TypeCode = "F", IsRunning = true, Description = "Train SE7 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE702", Name = "SE7", TypeCode = "F", IsRunning = true, Description = "Train SE7 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE801", Name = "SE8", TypeCode = "F", IsRunning = true, Description = "Train SE8 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." },
            new Train { TrainCode = "SE802", Name = "SE8", TypeCode = "F", IsRunning = true, Description = "Train SE8 is a fast train running on the North-South unified train route. The Railway industry is trying to improve service quality and train speed to increasingly meet the travel needs of customers." }
            );
        builder.Entity<Coach>().HasData(
            //SE101
            new Coach { Id = 1, TypeCode = "AC1", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE101", SeatAvailable = 8, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 2, TypeCode = "AC1", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE101", SeatAvailable = 2, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 3, TypeCode = "AC2", Name = "Class A", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE101", SeatAvailable = 4, Description = "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious" },
            new Coach { Id = 4, TypeCode = "AC3", Name = "Class B", NoOfCompartment = 6, NoOfSeat = 2, TrainCode = "SE101", SeatAvailable = 12, Description = "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs" },
            new Coach { Id = 5, TypeCode = "SL", Name = "Class C", NoOfCompartment = 6, NoOfSeat = 6, TrainCode = "SE101", SeatAvailable = 20, Description = "more comfor and amenities\nhigher fare" },
            new Coach { Id = 6, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE101", SeatAvailable = 64, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            //SE201
            new Coach { Id = 7, TypeCode = "AC1", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE201", SeatAvailable = 8, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 8, TypeCode = "AC2", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE201", SeatAvailable = 10, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 9, TypeCode = "SL", Name = "Class C", NoOfCompartment = 6, NoOfSeat = 6, TrainCode = "SE201", SeatAvailable = 12, Description = "more comfor and amenities\\nhigher fare" },
            new Coach { Id = 10, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE201", SeatAvailable = 3, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            new Coach { Id = 11, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE201", SeatAvailable = 2, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            //SE301
            new Coach { Id = 12, TypeCode = "AC1", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE301", SeatAvailable = 8, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 13, TypeCode = "AC2", Name = "Class A", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE301", SeatAvailable = 8, Description = "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious" },
            new Coach { Id = 14, TypeCode = "AC3", Name = "Class B", NoOfCompartment = 6, NoOfSeat = 2, TrainCode = "SE301", SeatAvailable = 12, Description = "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs" },
            new Coach { Id = 15, TypeCode = "SL", Name = "Class C", NoOfCompartment = 6, NoOfSeat = 6, TrainCode = "SE301", SeatAvailable = 22, Description = "more comfor and amenities\\nhigher fare" },
            new Coach { Id = 16, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE301", SeatAvailable = 22, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            //SE401
            new Coach { Id = 17, TypeCode = "AC1", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE401", SeatAvailable = 8, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 18, TypeCode = "AC2", Name = "Class A", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE401", SeatAvailable = 8, Description = "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious" },
            new Coach { Id = 19, TypeCode = "AC3", Name = "Class B", NoOfCompartment = 6, NoOfSeat = 2, TrainCode = "SE401", SeatAvailable = 12, Description = "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs" },
            new Coach { Id = 20, TypeCode = "SL", Name = "Class C", NoOfCompartment = 6, NoOfSeat = 6, TrainCode = "SE401", SeatAvailable = 20, Description = "more comfor and amenities\\nhigher fare" },
            new Coach { Id = 21, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE401", SeatAvailable = 24, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            //SE501
            new Coach { Id = 22, TypeCode = "AC1", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE501", SeatAvailable = 2, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 23, TypeCode = "AC2", Name = "Class A", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE501", SeatAvailable = 3, Description = "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious" },
            new Coach { Id = 24, TypeCode = "AC3", Name = "Class B", NoOfCompartment = 6, NoOfSeat = 2, TrainCode = "SE501", SeatAvailable = 10, Description = "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs" },
            new Coach { Id = 25, TypeCode = "SL", Name = "Class C", NoOfCompartment = 6, NoOfSeat = 6, TrainCode = "SE501", SeatAvailable = 17, Description = "more comfor and amenities\\nhigher fare" },
            new Coach { Id = 26, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE501", SeatAvailable = 13, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            //SE601
            new Coach { Id = 27, TypeCode = "AC1", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE601", SeatAvailable = 7, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 28, TypeCode = "AC2", Name = "Class A", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE601", SeatAvailable = 6, Description = "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious" },
            new Coach { Id = 29, TypeCode = "AC3", Name = "Class B", NoOfCompartment = 6, NoOfSeat = 2, TrainCode = "SE601", SeatAvailable = 10, Description = "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs" },
            new Coach { Id = 30, TypeCode = "SL", Name = "Class C", NoOfCompartment = 6, NoOfSeat = 6, TrainCode = "SE601", SeatAvailable = 20, Description = "more comfor and amenities\\nhigher fare" },
            new Coach { Id = 31, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE601", SeatAvailable = 12, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            new Coach { Id = 32, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE601", SeatAvailable = 13, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            //SE701
            new Coach { Id = 33, TypeCode = "AC1", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE701", SeatAvailable = 8, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 34, TypeCode = "AC2", Name = "Class A", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE701", SeatAvailable = 8, Description = "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious" },
            new Coach { Id = 35, TypeCode = "AC3", Name = "Class B", NoOfCompartment = 6, NoOfSeat = 2, TrainCode = "SE701", SeatAvailable = 11, Description = "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs" },
            new Coach { Id = 36, TypeCode = "SL", Name = "Class C", NoOfCompartment = 6, NoOfSeat = 6, TrainCode = "SE701", SeatAvailable = 22, Description = "more comfor and amenities\\nhigher fare" },
            new Coach { Id = 37, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE701", SeatAvailable = 16, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            new Coach { Id = 38, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE701", SeatAvailable = 28, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            //SE801
            new Coach { Id = 39, TypeCode = "AC1", Name = "Class S", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE801", SeatAvailable = 8, Description = "Personal cabin(4)or coupe(2seat)\nPrivacy\nHigh fare\nComfortable Seat\nU can carry your Dog" },
            new Coach { Id = 40, TypeCode = "AC2", Name = "Class A", NoOfCompartment = 4, NoOfSeat = 2, TrainCode = "SE801", SeatAvailable = 8, Description = "No privacy\nComparatively Comfortable\nAverage fare\nNo dogs allowed\nluggage spaceious" },
            new Coach { Id = 41, TypeCode = "AC3", Name = "Class B", NoOfCompartment = 6, NoOfSeat = 2, TrainCode = "SE801", SeatAvailable = 11, Description = "Average Rush\nCooling worth comfort\nLess Lagague space\nAgain No Dogs" },
            new Coach { Id = 42, TypeCode = "SL", Name = "Class C", NoOfCompartment = 6, NoOfSeat = 6, TrainCode = "SE801", SeatAvailable = 10, Description = "more comfor and amenities\\nhigher fare" },
            new Coach { Id = 43, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE801", SeatAvailable = 16, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" },
            new Coach { Id = 44, TypeCode = "GE", Name = "Class D", NoOfCompartment = 4, NoOfSeat = 16, TrainCode = "SE801", SeatAvailable = 22, Description = "basic amenities\nbudget-friendly\nbench-type seats\nmore people" }
            );
        builder.Entity<Route>().HasData(
            new Route { Id = 1, StartStationId = 1, EndStationId = 4, Distance = 1726 },//SG-HaNoi 1 SG-NT-Hue-HN
            new Route { Id = 2, StartStationId = 1, EndStationId = 2, Distance = 411 },//SG-NhaTrang
            new Route { Id = 3, StartStationId = 2, EndStationId = 3, Distance = 627 },//NhaTrang-Hue
            new Route { Id = 4, StartStationId = 1, EndStationId = 3, Distance = 1038 },//SG-Hue 1 SG-NT-Hue
            new Route { Id = 5, StartStationId = 1, EndStationId = 3, Distance = 1038 },//SG-Hue 2 SG-Hue
            new Route { Id = 6, StartStationId = 2, EndStationId = 4, Distance = 1315 },//NT-HN 1 NT-Hue-HN
            new Route { Id = 7, StartStationId = 2, EndStationId = 4, Distance = 1315 },//NT-HN 2 NT-HN
            new Route { Id = 8, StartStationId = 3, EndStationId = 4, Distance = 688 },//Hue-HaNoi

            new Route { Id = 9, StartStationId = 1, EndStationId = 4, Distance = 1726 },//SG-HN 2 SG-NT-HN
            new Route { Id = 10, StartStationId = 1, EndStationId = 4, Distance = 1726 },//SG-HN 3 SG-Hue-HN

            new Route { Id = 11, StartStationId = 4, EndStationId = 1, Distance = 1726 },//HN-SG 1 HN-Hue-NT-SG
            new Route { Id = 12, StartStationId = 4, EndStationId = 3, Distance = 688 },//HN-Hue
            new Route { Id = 13, StartStationId = 4, EndStationId = 2, Distance = 1315 },//HN-NT 1 HN-Hue-NT
            new Route { Id = 14, StartStationId = 4, EndStationId = 2, Distance = 1315 },//HN-NT 2 HN-NT
            new Route { Id = 15, StartStationId = 3, EndStationId = 2, Distance = 627},//Hue-NT
            new Route { Id = 16, StartStationId = 3, EndStationId = 1, Distance = 1038 },//Hue-SG 1 Hue-NT-SG
            new Route { Id = 17, StartStationId = 3, EndStationId = 1, Distance = 1038 },//Hue-SG 2 Hue-SG
            new Route { Id = 18, StartStationId = 2, EndStationId = 1, Distance = 411 },//NT-SG

            new Route { Id = 19, StartStationId = 4, EndStationId = 1, Distance = 1726 },//HN-SG 2 HaNoi-Hue-SaiGon
            new Route { Id = 20, StartStationId = 4, EndStationId = 1, Distance = 1726 }//HN-SG-3 HaNoi-NhaTrang-SaiGon
            );
        
        builder.Entity<RouteDetails>().HasData(
            //RouteId=1 SaiGon-HaNoi 1 SG-NT-Hue-HN
            new RouteDetails { Id = 1, DepartureStationId = 1, ArrivalStationId = 2, DelayTime = 15, Distance = 411, TravelTime = 8, RouteId = 1 }, 
            new RouteDetails { Id = 2, DepartureStationId = 2, ArrivalStationId = 3, DelayTime = 13, Distance = 627, TravelTime = 12.4, RouteId = 1 },
            new RouteDetails { Id = 3, DepartureStationId = 3, ArrivalStationId = 4, DelayTime = 12, Distance = 688, TravelTime = 15.6, RouteId = 1 },
            new RouteDetails { Id = 4, DepartureStationId = 1, ArrivalStationId = 4, DelayTime = 13, Distance = 1726, TravelTime = 36, RouteId = 1},
            //RouteId=2 SG-NhaTrang
            new RouteDetails { Id = 5, DepartureStationId = 1, ArrivalStationId = 2, DelayTime = 15, Distance = 411, TravelTime = 8, RouteId = 2},
            //RouteId=3 NhaTrang-Hue
            new RouteDetails { Id = 6, DepartureStationId = 2, ArrivalStationId = 3, DelayTime = 13, Distance = 627, TravelTime = 12.4, RouteId = 3 },
            //RouteId=4 SG-Hue 1 SG-NT-Hue
            new RouteDetails { Id = 7, DepartureStationId = 1, ArrivalStationId = 2, DelayTime = 15, Distance = 411, TravelTime = 8, RouteId = 4 },
            new RouteDetails { Id = 8, DepartureStationId = 2, ArrivalStationId = 3, DelayTime = 13, Distance = 627, TravelTime = 12.4, RouteId = 4 },
            new RouteDetails { Id = 9, DepartureStationId = 1, ArrivalStationId = 3, DelayTime = 14, Distance = 1038, TravelTime = 20.4, RouteId = 4 },
            //RouteId=5 SG-Hue 2 SG-Hue
            new RouteDetails { Id = 10, DepartureStationId = 1, ArrivalStationId = 3, DelayTime = 15, Distance = 1038, TravelTime = 19.5, RouteId = 5 },
            //RouteId=6 NhaTrang-HaNoi   1  NhaTrang-Hue-HaNoi
            new RouteDetails { Id = 11, DepartureStationId = 2, ArrivalStationId = 3, DelayTime = 13, Distance = 627, TravelTime = 12.4, RouteId = 6 },
            new RouteDetails { Id = 12, DepartureStationId = 3, ArrivalStationId = 4, DelayTime = 12, Distance = 688, TravelTime = 15.6, RouteId = 6 }, 
            new RouteDetails { Id = 13, DepartureStationId = 2, ArrivalStationId = 4, DelayTime = 13, Distance = 1315, TravelTime = 28, RouteId = 6 },
            //RouteId=7 NT-HN 2 NhaTrang-HaNoi
            new RouteDetails { Id = 14, DepartureStationId = 2, ArrivalStationId = 4, DelayTime = 13, Distance = 1315, TravelTime = 27, RouteId = 7 },
            //RouteId=8 Hue-HaNoi
            new RouteDetails { Id = 15, DepartureStationId = 3, ArrivalStationId = 4, DelayTime = 12, Distance = 688, TravelTime = 15.6, RouteId = 8 },
            
            //RouteId=9 SaiGon-HaNoi 2 SaiGon-NhaTrang-HaNoi
            new RouteDetails { Id = 16, DepartureStationId = 1, ArrivalStationId = 2, DelayTime = 15, Distance = 411, TravelTime = 8, RouteId = 9 },
            new RouteDetails { Id = 17, DepartureStationId = 2, ArrivalStationId = 4, DelayTime = 13, Distance = 1315, TravelTime = 27, RouteId = 9 },
            new RouteDetails { Id = 18, DepartureStationId = 1, ArrivalStationId = 4, DelayTime = 14, Distance = 1726, TravelTime = 35, RouteId = 9 },
            //RouteId=10  SaiGon-HaNoi 3 SaiGon-Hue-HaNoi
            new RouteDetails { Id = 19, DepartureStationId = 1, ArrivalStationId = 3, DelayTime = 15, Distance = 1038, TravelTime = 18, RouteId = 10 },
            new RouteDetails { Id = 20, DepartureStationId = 3, ArrivalStationId = 4, DelayTime = 12, Distance = 688, TravelTime = 14, RouteId =10 },
            new RouteDetails { Id = 21, DepartureStationId = 1, ArrivalStationId = 4, DelayTime = 14, Distance = 1726, TravelTime = 32, RouteId = 10 },

            //RouteId=11  HaNoi-SaiGon 1 HaNoi-Hue-NhaTrang-SaiGon
            new RouteDetails { Id = 22, DepartureStationId = 4, ArrivalStationId = 3, DelayTime = 15, Distance = 688, TravelTime = 15.6, RouteId = 11 },
            new RouteDetails { Id = 23, DepartureStationId = 3, ArrivalStationId = 2, DelayTime = 13, Distance = 627, TravelTime = 12.4, RouteId = 11 },
            new RouteDetails { Id = 24, DepartureStationId = 2, ArrivalStationId = 1, DelayTime = 15, Distance = 411, TravelTime = 8, RouteId = 11 },
            new RouteDetails { Id = 25, DepartureStationId = 4, ArrivalStationId = 1, DelayTime = 15, Distance = 1726, TravelTime = 36, RouteId = 11 },
            //RouteId=12 HaNoi-Hue
            new RouteDetails { Id = 26, DepartureStationId = 4, ArrivalStationId = 3, DelayTime = 15, Distance = 688, TravelTime = 15.6, RouteId = 12 },
            //RouteId=13 HaNoi-NhaTrang 1 HaNoi-Hue-NhaTrang
            new RouteDetails { Id = 27, DepartureStationId = 4, ArrivalStationId = 3, DelayTime = 15, Distance = 688, TravelTime = 15.6, RouteId = 13 },
            new RouteDetails { Id = 28, DepartureStationId = 3, ArrivalStationId = 2, DelayTime = 13, Distance = 627, TravelTime = 12.4, RouteId = 13 },
            new RouteDetails { Id = 29, DepartureStationId = 4, ArrivalStationId = 2, DelayTime = 14, Distance = 1315, TravelTime = 28, RouteId = 13 },
            //RouteId=14 HaNoi-NhaTrang 2  HaNoi-NhaTrang
            new RouteDetails { Id = 30, DepartureStationId = 4, ArrivalStationId = 2, DelayTime = 14, Distance = 1315, TravelTime = 27, RouteId = 14 },
            //RouteId=15 Hue-NhaTrang
            new RouteDetails { Id = 31, DepartureStationId = 3, ArrivalStationId = 2, DelayTime = 13, Distance = 627, TravelTime = 12.4, RouteId = 15 },
            //RouteId=16 Hue-SaiGon 1 Hue-NhaTrang-SaiGon
            new RouteDetails { Id = 32, DepartureStationId = 3, ArrivalStationId = 2, DelayTime = 13, Distance = 627, TravelTime = 12.4, RouteId = 16 },
            new RouteDetails { Id = 33, DepartureStationId = 2, ArrivalStationId = 1, DelayTime = 15, Distance = 411, TravelTime = 8, RouteId = 16 },
            new RouteDetails { Id = 34, DepartureStationId = 3, ArrivalStationId = 1, DelayTime = 14, Distance = 1038, TravelTime = 20.4, RouteId = 16 },
            //RouteId=17 Hue-SaiGon 2 Hue-SaiGon
            new RouteDetails { Id = 35, DepartureStationId = 3, ArrivalStationId = 1, DelayTime = 14, Distance = 1038, TravelTime = 19.5, RouteId = 17 },
            //RouteId=18 NhaTrang-SaiGon
            new RouteDetails { Id = 36, DepartureStationId = 2, ArrivalStationId = 1, DelayTime = 15, Distance = 411, TravelTime = 8, RouteId = 18 },

            //RouteId=19 HaNoi-SaiGon 2 HaNoi-Hue-SaiGon
            new RouteDetails { Id = 37, DepartureStationId = 4, ArrivalStationId = 3, DelayTime = 15, Distance = 688, TravelTime = 14, RouteId = 19 },
            new RouteDetails { Id = 38, DepartureStationId = 3, ArrivalStationId = 1, DelayTime = 14, Distance = 1038, TravelTime = 18, RouteId = 19 },
            new RouteDetails { Id = 39, DepartureStationId = 4, ArrivalStationId = 1, DelayTime = 15, Distance = 1726, TravelTime = 32, RouteId = 19 },
            //RouteId=20 HaNoi-SaiGon 3  HaNoi-NhaTrang-SaiGon
            new RouteDetails { Id = 40, DepartureStationId = 4, ArrivalStationId = 2, DelayTime = 15, Distance = 1315, TravelTime = 27, RouteId = 20 },
            new RouteDetails { Id = 41, DepartureStationId = 2, ArrivalStationId = 1, DelayTime = 13, Distance = 411, TravelTime = 8, RouteId = 20 },
            new RouteDetails { Id = 42, DepartureStationId = 4, ArrivalStationId = 1, DelayTime = 15, Distance = 1726, TravelTime = 35, RouteId = 20 }
            );
        builder.Entity<Schedule>().HasData(
            //SG-NT-H-HN 1 ngayXP 2-12 SE801
                //SG-HN
            new Schedule { Id = 1, RouteId = 1, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 6, 0, 0), EndAt = new DateTime(2023, 12, 3, 18, 12, 0), TrainCode = "SE801" },
                //SG-NT
            new Schedule { Id = 2, RouteId = 2, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 6, 0, 0), EndAt = new DateTime(2023, 12, 2, 8, 15, 0), TrainCode = "SE801" },
                //NT-H
            new Schedule { Id = 3, RouteId = 3, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 8, 28, 0), EndAt = new DateTime(2023, 12, 2, 21, 0, 0), TrainCode = "SE801" },
                //H-HN
            new Schedule { Id = 4, RouteId = 8, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 21, 12, 0), EndAt = new DateTime(2023, 12, 3, 18, 0, 0), TrainCode = "SE801" },
                //SG-H
            new Schedule { Id = 5, RouteId = 4, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 6, 0, 0), EndAt = new DateTime(2023, 12, 2, 21, 0, 0), TrainCode = "SE801" },
                //NT-HN
            new Schedule { Id = 6, RouteId = 6, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 8, 28, 0), EndAt = new DateTime(2023, 12, 3, 18, 0, 0), TrainCode = "SE801" },
            //SG-NT-HN  ngayXP 2-12 SE202
                //SG-HN 
            new Schedule { Id = 7, RouteId = 9, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 14, 00, 0), EndAt = new DateTime(2023, 12, 4, 1, 30, 0), TrainCode = "SE201" },
                //SG-NT
            new Schedule { Id = 8, RouteId = 2, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 14, 00, 0), EndAt = new DateTime(2023, 12, 2, 22, 15, 0), TrainCode = "SE201" },
                //NT-HN
            new Schedule { Id = 9, RouteId = 7, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 22, 27, 0), EndAt = new DateTime(2023, 12, 4, 1, 30, 0), TrainCode = "SE201" },
            //SG-H-HN ngayXP 3-12 SE401 
                //SG-HN
            new Schedule { Id = 10, RouteId = 10, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 7, 30, 0), EndAt = new DateTime(2023, 12, 4, 16, 0, 0), TrainCode = "SE401" },
                //SG-H
            new Schedule { Id = 11, RouteId = 5, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 7, 30, 0), EndAt = new DateTime(2023, 12, 4, 3, 10, 0), TrainCode = "SE401" },
                //H-HN
            new Schedule { Id = 12, RouteId = 8, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 4, 3, 25, 0), EndAt = new DateTime(2023, 12, 4, 16, 0, 0), TrainCode = "SE401" },

            //HN-H-NT-SG ngayXP 2-12
                //HN-SG 
            new Schedule { Id = 13, RouteId = 11, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 7, 20, 0), EndAt = new DateTime(2023, 12, 3, 19, 20, 0), TrainCode = "SE701" },
                //HN-H 
            new Schedule { Id = 14, RouteId = 12, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 7, 20, 0), EndAt = new DateTime(2023, 12, 2, 23, 0, 0), TrainCode = "SE701" },
                //H-NT
            new Schedule { Id = 15, RouteId = 15, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 23, 13, 0), EndAt = new DateTime(2023, 12, 3, 12, 0, 0), TrainCode = "SE701" },
                //NT-SG
            new Schedule { Id = 16, RouteId = 18, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 12, 15, 0), EndAt = new DateTime(2023, 12, 3, 19, 20, 0), TrainCode = "SE701" },
                //HN-NT
            new Schedule { Id = 17, RouteId = 13, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 7, 20, 0), EndAt = new DateTime(2023, 12, 3, 12, 0, 0), TrainCode = "SE701" },
                //H-SG
            new Schedule { Id = 18, RouteId = 16, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 23, 13, 0), EndAt = new DateTime(2023, 12, 3, 19, 20, 0), TrainCode = "SE701" },
            
            //HN-H-SG ngayXP 2-12 
                //HN-SG
            new Schedule { Id = 19, RouteId = 19, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 17, 20, 0), EndAt = new DateTime(2023, 12, 4, 1, 20, 0), TrainCode = "SE301" },
                //HN-H
            new Schedule { Id = 20, RouteId = 12, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 17, 20, 0), EndAt = new DateTime(2023, 12, 3, 7, 20, 0), TrainCode = "SE301" },
                //H-SG
            new Schedule { Id = 21, RouteId = 17, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 7, 34, 0), EndAt = new DateTime(2023, 12, 4, 1, 20, 0), TrainCode = "SE301" },

            //HN-NT-SG ngay XP 3-12
                //HN-SG
            new Schedule { Id = 22, RouteId = 20, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 9, 0, 0), EndAt = new DateTime(2023, 12, 4, 20, 13, 0), TrainCode = "SE101" },
                //HN-NT
            new Schedule { Id = 23, RouteId = 14, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 9, 0, 0), EndAt = new DateTime(2023, 12, 4, 12, 0, 0), TrainCode = "SE101" },
                //NT-SG
            new Schedule { Id = 24, RouteId = 20, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 4, 12, 13, 0), EndAt = new DateTime(2023, 12, 4, 20, 0, 0), TrainCode = "SE101" }
            );
        builder.Entity<Fare>().HasData(
            new Fare { Id = 1, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "SF", Price = 30 },
            new Fare { Id = 2, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "SF", Price = 25 },
            new Fare { Id = 3, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "SF", Price = 20 },
            new Fare { Id = 4, RouteId = 1, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "SF", Price = 10 },
            new Fare { Id = 5, RouteId = 1, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "SF", Price = 5 },

            new Fare { Id = 6, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "F", Price = 27 },
            new Fare { Id = 7, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "F", Price = 20 },
            new Fare { Id = 8, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "F", Price = 15 },
            new Fare { Id = 9, RouteId = 1, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "F", Price = 8 },
            new Fare { Id = 10, RouteId = 1, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "F", Price = 4 },

            new Fare { Id = 11, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "S", Price = 25 },
            new Fare { Id = 12, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "S", Price = 18 },
            new Fare { Id = 13, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "S", Price = 12 },
            new Fare { Id = 14, RouteId = 1, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "S", Price = 6 },
            new Fare { Id = 15, RouteId = 1, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "S", Price = 3 },

            new Fare { Id = 16, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "SF", Price = 30 },
            new Fare { Id = 17, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "SF", Price = 35 },
            new Fare { Id = 18, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "SF", Price = 25 },
            new Fare { Id = 19, RouteId = 2, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "SF", Price = 15 },
            new Fare { Id = 20, RouteId = 2, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "SF", Price = 5.5 },

            new Fare { Id = 21, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "F", Price = 45 },
            new Fare { Id = 22, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "F", Price = 25 },
            new Fare { Id = 23, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "F", Price = 20 },
            new Fare { Id = 24, RouteId = 2, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "F", Price = 8.5 },
            new Fare { Id = 25, RouteId = 2, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "F", Price = 4.5 },

            new Fare { Id = 26, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "S", Price = 39 },
            new Fare { Id = 27, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "S", Price = 20 },
            new Fare { Id = 28, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "S", Price = 16 },
            new Fare { Id = 29, RouteId = 2, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "S", Price = 6.5 },
            new Fare { Id = 30, RouteId = 2, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "S", Price = 3.5 },

            new Fare { Id = 31, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "SF", Price = 50 },
            new Fare { Id = 32, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "SF", Price = 30 },
            new Fare { Id = 33, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "SF", Price = 20 },
            new Fare { Id = 34, RouteId = 3, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "SF", Price = 10 },
            new Fare { Id = 35, RouteId = 3, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "SF", Price = 5 },

            new Fare { Id = 36, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "F", Price = 40 },
            new Fare { Id = 37, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "F", Price = 20 },
            new Fare { Id = 38, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "F", Price = 15 },
            new Fare { Id = 39, RouteId = 3, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "F", Price = 8 },
            new Fare { Id = 40, RouteId = 3, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "F", Price = 4 },

            new Fare { Id = 41, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "S", Price = 36 },
            new Fare { Id = 42, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "S", Price = 18 },
            new Fare { Id = 43, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "S", Price = 12 },
            new Fare { Id = 44, RouteId = 3, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "S", Price = 6 },
            new Fare { Id = 45, RouteId = 3, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "S", Price = 3 },

            new Fare { Id = 46, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "SF", Price = 55 },
            new Fare { Id = 47, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "SF", Price = 35 },
            new Fare { Id = 48, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "SF", Price = 25 },
            new Fare { Id = 49, RouteId = 4, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "SF", Price = 12 },
            new Fare { Id = 50, RouteId = 4, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "SF", Price = 5.5 },

            new Fare { Id = 51, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "F", Price = 45 },
            new Fare { Id = 52, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "F", Price = 25 },
            new Fare { Id = 53, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "F", Price = 20 },
            new Fare { Id = 54, RouteId = 4, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "F", Price = 8.5 },
            new Fare { Id = 55, RouteId = 4, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "F", Price = 4.5 },

            new Fare { Id = 56, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "S", Price = 39 },
            new Fare { Id = 57, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "S", Price = 20 },
            new Fare { Id = 58, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "S", Price = 16 },
            new Fare { Id = 59, RouteId = 4, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "S", Price = 6.5 },
            new Fare { Id = 60, RouteId = 4, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "S", Price = 3.5 }
            );
    }

    public DbSet<Passenger>? Passengers { get; set; }
    public DbSet<Ticket>? Tickets { get; set; }
    public DbSet<Feedback>? Feedbacks { get; set; }
    public DbSet<Booking>? Bookings { get; set; }
    public DbSet<BookingDetails>? BookingDetailss { get; set; }
    public DbSet<Transaction>? Transactions { get; set; }
    public DbSet<Refund>? Refunds { get; set; }
    public DbSet<RefundRule>? RefundRules { get; set; }
    public DbSet<Schedule>? Schedules { get; set; }
    public DbSet<Train>? Trains { get; set; }
    public DbSet<Route>? Routes { get; set; }
    public DbSet<RouteDetails>? RouteDetailss { get; set; }
    public DbSet<Coach>? Coachs { get; set; }
    public DbSet<Station>? Stations { get; set; }
    public DbSet<Fare>? Fares { get; set; }
}
