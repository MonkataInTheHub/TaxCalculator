using Backend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Interfaces
{
    public interface ITax
    {
        TaxType Type { get; }
        double Percentage { get; }
        double CalculateTax(double income);
    }
}
