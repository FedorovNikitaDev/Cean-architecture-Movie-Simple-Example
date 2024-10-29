namespace CleanMovie.Domain;

public class Member
{
    public int MemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int RentalId { get; set; }
    public Rental Rental { get; set; }
}