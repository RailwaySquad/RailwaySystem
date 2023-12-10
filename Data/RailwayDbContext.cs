using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Emit;

namespace Railway_Group01.Data;

public class RailwayDbContext : IdentityDbContext<User>
{
    public RailwayDbContext(DbContextOptions<RailwayDbContext> options)
        : base(options)
    {
    }
    public DbSet<Passenger>? Passengers { get; set; }
    public DbSet<PassengerType>? PassengerTypes { get; set; }
    public DbSet<Ticket>? Tickets { get; set; }
    public DbSet<Feedback>? Feedbacks { get; set; }
    public DbSet<Booking>? Bookings { get; set; }
    public DbSet<BookingDetail>? BookingDetails { get; set; }
    public DbSet<Transaction>? Transactions { get; set; }
    public DbSet<Cancelling>? Cancellings { get; set; }
    public DbSet<RefundRule>? RefundRules { get; set; }
    public DbSet<Schedule>? Schedules { get; set; }
    public DbSet<Train>? Trains { get; set; }
    public DbSet<TrainType>? TrainTypes { get; set; }
    public DbSet<Route>? Routes { get; set; }
    public DbSet<RouteDetail>? RouteDetails { get; set; }
    public DbSet<Coach>? Coaches { get; set; }
    public DbSet<Seat>? Seats { get; set; }
    public DbSet<CoachClass>? CoachClasses { get; set; }
    public DbSet<Station>? Stations { get; set; }
    public DbSet<Fare>? Fares { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            var tableName = entityType.GetTableName();
            if (tableName!.StartsWith("AspNet"))
                entityType.SetTableName(tableName.Substring(6));
        }

        // BookingDetail 1:1 Ticket
        builder.Entity<BookingDetail>()
        .HasOne(e => e.Ticket)
        .WithOne(e => e.BookingDetail)
        .HasForeignKey<Ticket>(e => e.BookingDetailId)
        .OnDelete(DeleteBehavior.NoAction)
        .IsRequired();

        // Booking Detail 1:1 Passenger
        builder.Entity<BookingDetail>()
        .HasOne(e => e.Passenger)
        .WithOne(e => e.BookingDetail)
        .HasForeignKey<Passenger>(e => e.BookingDetailId)
        .OnDelete(DeleteBehavior.Cascade)
        .IsRequired();

        // Ticket 1:1 Cancelling
        builder.Entity<Ticket>()
        .HasOne(e => e.Cancelling)
        .WithOne(e => e.Ticket)
        .HasForeignKey<Cancelling>(e => e.PNRNo)
        .OnDelete(DeleteBehavior.NoAction)
        .IsRequired();

        // Passenger 1:1 Ticket
        builder.Entity<Passenger>()
        .HasOne(e => e.Ticket)
        .WithOne(e => e.Passenger)
        .HasForeignKey<Ticket>(e => e.PassengerID)
        .OnDelete(DeleteBehavior.NoAction)
        .IsRequired();

        // Station 1:m Route
        builder.Entity<Station>().HasMany(p => p.StartRoutes).WithOne(p => p.StartStation).OnDelete(DeleteBehavior.NoAction);
        builder.Entity<Station>().HasMany(p => p.EndRoutes).WithOne(p => p.EndStation).OnDelete(DeleteBehavior.NoAction);

        // Station 1:m RouteDetails
        builder.Entity<Station>().HasMany(p => p.DepartureRouteDetails).WithOne(p => p.DepartureStation).OnDelete(DeleteBehavior.NoAction);
        builder.Entity<Station>().HasMany(p => p.ArrivalRouteDetails).WithOne(p => p.ArrivalStation).OnDelete(DeleteBehavior.NoAction);

        // m:1
        builder.Entity<Seat>().HasMany(e => e.BookingDetails).WithOne(e => e.Seat);
        builder.Entity<CoachClass>().HasMany(p => p.Coaches).WithOne(p => p.Class);
        builder.Entity<CoachClass>().HasMany(p => p.Fares).WithOne(p => p.Class);
        builder.Entity<Train>().HasMany(p => p.Coaches).WithOne(p => p.Train);
        builder.Entity<Train>().HasMany(p => p.Schedules).WithOne(p => p.Train);
        builder.Entity<TrainType>().HasMany(p => p.Trains).WithOne(p => p.Type);
        builder.Entity<TrainType>().HasMany(p => p.Fares).WithOne(p => p.TrainType);
        builder.Entity<Coach>().HasMany(p => p.Seats).WithOne(p => p.Coach);
        builder.Entity<Route>().HasMany(p => p.RouteDetails).WithOne(p => p.Route);
        builder.Entity<Route>().HasMany(p => p.Schedules).WithOne(p => p.Route);
        builder.Entity<Route>().HasMany(p => p.Fares).WithOne(p => p.Route);
        builder.Entity<PassengerType>().HasMany(p => p.Passengers).WithOne(p => p.PassengerType);
        builder.Entity<Booking>().HasMany(b => b.BookingDetails).WithOne(b => b.Booking).OnDelete(DeleteBehavior.Cascade);

        ModelBuilderExtension.Seed(builder);
    }

    public async Task<List<Schedule>> SearchScheduleByRoute(int from, int to)
    {
        List<Schedule> result;
        string op = from < to ? "<" : ">";
        var query = @"
                    WITH QueryRoute AS (
                      SELECT * 
                      FROM RouteDetails 
                      WHERE DepartureStationId = {0} AND DepartureStationId "+ op + @" ArrivalStationId
                      UNION
                      SELECT * 
                      FROM RouteDetails 
                      WHERE ArrivalStationId = {1} AND DepartureStationId "+ op + @" ArrivalStationId
                    )
                    , RankedDistances AS (
                      SELECT 
                        s.Id,
                        s.TrainCode,
	                    s.Arrival,
	                    s.Departure,
	                    s.IsFinished,
	                    s.Name,
	                    s.RouteId,
                        qr.Distance,
                        ROW_NUMBER() OVER (PARTITION BY s.TrainCode ORDER BY qr.Distance DESC) AS rn
                      FROM 
                        QueryRoute qr 
                        JOIN Schedules s ON qr.RouteId = s.RouteId
                    )
                    SELECT
                      Id,
                      TrainCode,
	                  Arrival,
	                  Departure,
	                  IsFinished,
	                  Name,
	                  RouteId
                    FROM
                      RankedDistances
                    WHERE
                      rn = 1;";
        try
        {
            result = await Schedules!.FromSqlRaw(query, from, to).ToListAsync();
        }
        catch {
            throw new Exception("Query error");
        }
        return result;
    }
}
