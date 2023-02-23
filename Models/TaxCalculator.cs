using Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class TaxCalculator : ITaxCalculator
    {
        private readonly ITax _incomeTax;
        private readonly ITax _socialContributionTax;

        public TaxCalculator(IncomeTax incomeTax, SocialContributionTax socialContributionTax)
        {
            _incomeTax = incomeTax;
            _socialContributionTax = socialContributionTax;
        }

        private readonly List<ITax> _taxes = new List<ITax>();
        public double CalculateIncome(double income)
        {
            _taxes.Add(_incomeTax);
            _taxes.Add(_socialContributionTax);
            double tax = 0;
            foreach (ITax _tax in _taxes)
            {
                tax += _tax.CalculateTax(income);
            }

            return income - tax;
        }
        public List<ITax> Taxes { get => _taxes; }
    }
}
