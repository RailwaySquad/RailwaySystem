using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

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

        // Seat 1:1 BookingDetail
        builder.Entity<Seat>()
        .HasOne(e => e.BookingDetail)
        .WithOne(e => e.Seat)
        .HasForeignKey<BookingDetail>(e => e.SeatId)
        .IsRequired();

        // BookingDetail 1:1 Ticket
        builder.Entity<BookingDetail>()
        .HasOne(e => e.Ticket)
        .WithOne(e => e.BookingDetail)
        .HasForeignKey<Ticket>(e => e.BookingDetailId)
        .IsRequired();

        // Ticket 1:1 Cancelling
        builder.Entity<Ticket>()
        .HasOne(e => e.Cancelling)
        .WithOne(e => e.Ticket)
        .HasForeignKey<Cancelling>(e => e.PNRNo)
        .IsRequired();

        // Passenger 1:1 Ticket
        builder.Entity<Passenger>()
        .HasOne(e => e.Ticket)
        .WithOne(e => e.Passenger)
        .HasForeignKey<Ticket>(e => e.PassengerID)
        .IsRequired();

        // Station 1:m Route
        builder.Entity<Station>().HasMany(p => p.StartRoutes).WithOne(p => p.StartStation).OnDelete(DeleteBehavior.NoAction);
        builder.Entity<Station>().HasMany(p => p.EndRoutes).WithOne(p => p.EndStation).OnDelete(DeleteBehavior.NoAction);

        // Station 1:m RouteDetails
        builder.Entity<Station>().HasMany(p => p.DepartureRouteDetails).WithOne(p => p.DepartureStation).OnDelete(DeleteBehavior.NoAction);
        builder.Entity<Station>().HasMany(p => p.ArrivalRouteDetails).WithOne(p => p.ArrivalStation).OnDelete(DeleteBehavior.NoAction);
        
        builder.Entity<CoachClass>().HasMany(p => p.Coaches).WithOne(p => p.Class);
        builder.Entity<Train>().HasMany(p => p.Coaches).WithOne(p => p.Train);
        builder.Entity<TrainType>().HasMany(p => p.Trains).WithOne(p => p.Type);
        builder.Entity<Coach>().HasMany(p => p.Seats).WithOne(p => p.Coach);
        builder.Entity<Route>().HasMany(p => p.RouteDetails).WithOne(p => p.Route);

        ModelBuilderExtension.Seed(builder);
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
    public DbSet<CoachClass>? CoachClasses { get; set; }
    public DbSet<Station>? Stations { get; set; }
    public DbSet<Fare>? Fares { get; set; }
}
