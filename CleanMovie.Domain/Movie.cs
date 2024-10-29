namespace CleanMovie.Domain;

public class Movie
{
    public int MovieId { get; set; }
    public string MovieName { get; set; }
    public decimal RentalCost { get; set; }
    public int RentalDuration { get; set; }
    public IList<MovieRental> MovieRentals { get; set; }
}