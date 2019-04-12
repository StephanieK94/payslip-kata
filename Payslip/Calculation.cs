using System;

namespace Payslip
{
    public class Calculation
    {
        public string GetTrimmedNumber(string payRate)
        {
            return payRate.Trim('%');
        }

        public int GetRoundedCalculationAsInteger(double calculation)
        {
            var outputtedDouble = Math.Round(calculation, MidpointRounding.AwayFromZero);

            return Convert.ToInt32(outputtedDouble);
        }

        public string GetGrossIncome(string salary)
        {
            return GetRoundedCalculationAsInteger(double.Parse(salary) / 12).ToString();
        }

        public string GetIncomeTax(string salary)
        {
            var employeeSalary = double.Parse(salary);

            double monthlyIncomeTax = 0;

            if (employeeSalary <= 18200)
            {
                monthlyIncomeTax = 0;
            }

            if (employeeSalary >= 18201 && employeeSalary <= 37000)
            {
                monthlyIncomeTax = ((employeeSalary - 18200) * 0.19) / 12;
            }

            if (employeeSalary >= 37001 && employeeSalary <= 80000)
            {
                monthlyIncomeTax = (((employeeSalary - 37000) * 0.325) + 3572) / 12;
            }

            if (employeeSalary >= 80001 && employeeSalary <= 180000)
            {
                monthlyIncomeTax = (((employeeSalary - 80000) * 0.37) + 17547) / 12;
            }

            if (employeeSalary >= 180001 && employeeSalary >= 180001)
            {
                monthlyIncomeTax = (((employeeSalary - 180000) * 0.45) + 54547) / 12;
            }

            return GetRoundedCalculationAsInteger(monthlyIncomeTax).ToString();
        }

        public string GetNetIncome(string income, string tax)
        {
            var netIncome = (double.Parse(income) - double.Parse(tax));

            return GetRoundedCalculationAsInteger(netIncome).ToString();
        }

        public string GetSuperAmount(string income, string payRate)
        {
            var superAmount = int.Parse(income) * int.Parse(payRate) / 100;

            return GetRoundedCalculationAsInteger(superAmount).ToString();
        }

        //public string ToStringConverter(int grossIncome)
        //{
        //    var intIncome = grossIncome;

        //    var stringIncome = intIncome.ToString();

        //    return stringIncome;
        //}

    }

}