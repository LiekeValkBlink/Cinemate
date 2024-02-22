using Cinemate.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Cinemate.API.Data;

public class CinemateDbContext: DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<Authorization> Authorizations { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieCategory> MovieCategories { get; set; }
    public DbSet<PromoCode> PromoCodes { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Screening> Screenings { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<SeatReserved> SeatReserveds { get; set; }
    public DbSet<Theater> Theathers { get; set; }
    public DbSet<TheaterRoom> TheatherRooms { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketPromoCodes> TicketPromoCodes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserReview> UserReviews { get; set; }
    
    

    public CinemateDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("cinemate"));
        optionsBuilder.LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Add unique constraints to unique columns in multiple tables
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
        
        modelBuilder.Entity<Employee>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<Theater>()
            .HasIndex(u => u.Name)
            .IsUnique();
        
        modelBuilder.Entity<Authorization>()
            .HasIndex(u => u.Description)
            .IsUnique();
        
        modelBuilder.Entity<PromoCode>()
            .HasIndex(u => u.Name)
            .IsUnique();
        
        //Provide default value
        modelBuilder.Entity<User>()
            .Property(p => p.SubscribedToNewsletter)
            .HasDefaultValue(false);
    }
}