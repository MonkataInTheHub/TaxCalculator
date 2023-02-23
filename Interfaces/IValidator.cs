namespace Backend.Models
{
    public interface IValidator
    {
        void IsValidIncome(double input);
        void IsValidNumber(string input);
        void IsValidMenuNumber(int input);
    }
}