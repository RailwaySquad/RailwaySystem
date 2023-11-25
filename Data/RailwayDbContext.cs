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
