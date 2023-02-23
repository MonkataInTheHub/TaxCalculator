namespace Backend.Models
{
    public interface IReader
    {
        string ReadText();
        int ReadNumbers();
    }
}