using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanMovie.Infrastructure;

public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>()
            .HasOne(m => m.Rental)
            .WithMany(r => r.Members)
            .HasForeignKey(m => m.RentalId);

        modelBuilder.Entity<MovieRental>()
            .HasKey(mr => new { mr.MovieId, mr.RentalId });

        modelBuilder.Entity<Rental>()
            .Property(r => r.TotalCost)
            .HasColumnType("decimal(18, 2)");
        
        modelBuilder.Entity<Movie>()
            .Property(r => r.RentalCost)
            .HasColumnType("decimal(18, 2)");
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<MovieRental> MovieRentals { get; set; }
}