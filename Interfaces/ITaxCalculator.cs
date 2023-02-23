using Backend.Interfaces;
using System.Collections.Generic;

namespace Backend.Models
{
    public interface ITaxCalculator
    {
        List<ITax> Taxes { get; }

        double CalculateIncome(double income);
    }
}