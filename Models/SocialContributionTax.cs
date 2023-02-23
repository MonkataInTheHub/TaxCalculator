using Backend.Enums;
using Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class SocialContributionTax : ITax
    {
        public TaxType Type { get => TaxType.SocialContributionTax; }

        public double Percentage { get => 0.15; }

        public double CalculateTax(double income)
        {
            if (income > 1000)
            {
                if (income < 3000)
                {
                    return (income-1000) * Percentage;
                }
                else
                {
                    return 2000 * Percentage;
                }
            }

            return 0;
        }
    }
}
