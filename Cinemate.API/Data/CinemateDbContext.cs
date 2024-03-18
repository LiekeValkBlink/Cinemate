using Cinemate.API.Data.Seed;
using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Data;

public class CinemateDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    // Define DbSet properties for each entity in the database
    public DbSet<Authorization> Authorizations { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieCategory> MovieCategories { get; set; }
    public DbSet<PromoCode> PromoCodes { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Screening> Screenings { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<SeatReserved> SeatReserved { get; set; }
    public DbSet<Theater> Theathers { get; set; }
    public DbSet<TheaterRoom> TheaterRooms { get; set; }
    public DbSet<ReservationPromoCodes> ReservationPromoCodes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserReview> UserReviews { get; set; }

    // Constructor with IConfiguration dependency injection to access application settings
    public CinemateDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    // Configures the database connection and logging options
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection using the connection string retrieved from application settings
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("cinemate"));
        
        // Log database operations to the console
        optionsBuilder.LogTo(Console.WriteLine);
        
        // Enable sensitive data logging
        optionsBuilder.EnableSensitiveDataLogging();
    }

    // Configures the database schema and relationships between entities
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Add unique constraints to unique columns in multiple tables
        modelBuilder.Entity<Employee>().HasIndex(u => u.Email).IsUnique();
        modelBuilder.Entity<Theater>().HasIndex(u => u.Name).IsUnique();
        modelBuilder.Entity<Authorization>().HasIndex(u => u.Description).IsUnique();
        modelBuilder.Entity<PromoCode>().HasIndex(u => u.Name).IsUnique();
        
        // Provide default value for the SubscribedToNewsletter property in the User entity
        modelBuilder.Entity<User>().Property(p => p.SubscribedToNewsletter).HasDefaultValue(false);

        // Apply entity configurations defined in separate configuration classes
        modelBuilder.ApplyConfiguration(new MovieCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorizationConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new MovieConfiguration());
        modelBuilder.ApplyConfiguration(new PromoCodeConfiguration());
        modelBuilder.ApplyConfiguration(new ScreeningConfiguration());
        modelBuilder.ApplyConfiguration(new TheaterConfiguration());
        modelBuilder.ApplyConfiguration(new TheaterRoomConfiguration());
        modelBuilder.ApplyConfiguration(new SeatsConfiguration());
        modelBuilder.ApplyConfiguration(new UsersConfiguration());
        modelBuilder.ApplyConfiguration(new ReservationConfiguration());
        modelBuilder.ApplyConfiguration(new SeatsReservedConfiguration());
        modelBuilder.ApplyConfiguration(new ReservationPromoCodeConfiguration());
    }
}
