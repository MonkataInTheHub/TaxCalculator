namespace Backend.Models
{
    public interface IMovieStar
    {
        string dateOfBirth { get; set; }
        string Email { get; set; }
        string Name { get; set; }
        string Nationality { get; set; }
        string Sex { get; set; }
        string Surname { get; set; }

        int CalculateAge(string dateOfBirth);
    }
}