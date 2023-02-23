using Backend.Enums;
using Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class IncomeTax : ITax
    {
        public TaxType Type { get => TaxType.IncomeTax; }

        public double Percentage { get => 0.1; }

        public double CalculateTax(double income)
        {
            if (income > 1000)
            {
                return (income - 1000)* Percentage;
            }

            return 0;
        }
    }
}
