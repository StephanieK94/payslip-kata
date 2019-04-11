using System;

namespace Payslip
{
    public class Calculation
    {
        public double ConvertStringToNumber(string salary)
        {
            var salaryString = salary;

            var value = double.Parse(salaryString);

            return value;
        }

        public string GetTrimmedNumber(string payRate)
        {
            var employeePayRate = payRate;

            var rate = employeePayRate.Trim('%');

            return rate;
        }

        public int GetRoundedCalculation(double calculation)
        {
            var inputtedDouble = calculation;

            var outputtedDouble = Math.Round(inputtedDouble, MidpointRounding.AwayFromZero);

            var result = Convert.ToInt32(outputtedDouble);

            return result;
        }
    }
}