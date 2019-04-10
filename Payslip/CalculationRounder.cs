using System;

namespace Payslip
{
    public class CalculationRounder
    {
        public double GetRoundedCalculation(double calculation)
        {
            var inputtedDouble = calculation;

            var outputtedDouble = Math.Round(inputtedDouble, MidpointRounding.AwayFromZero);

            return outputtedDouble;
        }
    }
}