using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Validator : IValidator
    {
        public void IsValidNumber(string input)
        {
            if (input == null || "".Equals(input))
            {
                throw new ArgumentException("Arguments are null or empty");
            }

            if (!Regex.Match(input, "^[0-9]*[\\.,]*[0-9]*$").Success)
            {
                throw new ArgumentException("This is not a number");
            }
        }
        public void IsValidIncome(double input)
        {
            if (input <= 0.0)
            {
                throw new ArgumentException("Number cannot be less or equal to 0");
            }
        }
        public void IsValidMenuNumber(int input)
        {
            if (input>3 || input<1)
            {
                throw new Exception();
            }
        }
    }
}
