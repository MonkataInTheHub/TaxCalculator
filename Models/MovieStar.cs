using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class MovieStar : IMovieStar
    {
        public string dateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }

        public int CalculateAge(string dateOfBirth)
        {
            DateTime birthDate = DateTime.Parse(dateOfBirth);
            int age = (int)((DateTime.Now - birthDate).TotalDays / 365.25);
            return age;
        }

    }
}
