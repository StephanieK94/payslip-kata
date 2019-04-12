using System;

namespace Payslip
{
    public class Calculation
    {
        public double ConvertStringToNumber(string salary)
        {
            return double.Parse(salary);
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

        public string GetGrossIncome(string salary)
        {
            var grossMonthlyIncome = double.Parse(salary) / 12;

            var roundedGrossMonthlyIncome = GetRoundedCalculation(grossMonthlyIncome).ToString();

            return roundedGrossMonthlyIncome;
        }

        public string GetIncomeTax(string salary)
        {
            var employeeSalary = ConvertStringToNumber(salary);

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

            var roundedIncomeTax = GetRoundedCalculation(monthlyIncomeTax).ToString();
            //var resultString = ToStringConverter(roundedIncomeTax);

            return roundedIncomeTax;
        }

        public string GetNetIncome(string income, string tax)
        {
            var grossIncome = ConvertStringToNumber(income);
            var incomeTax = ConvertStringToNumber(tax);

            var netIncome = grossIncome - incomeTax;
            var result = GetRoundedCalculation(netIncome).ToString();

            //var resultString = ToStringConverter(result);

            return result;
        }

        public string GetSuperAmount(string gross, string payRate)
        {
            var grossIncome = ConvertStringToNumber(gross);
            var superRate = ConvertStringToNumber(payRate) / 100;

            var superAmount = grossIncome * superRate;

            var result = GetRoundedCalculation(superAmount).ToString();
            //var resultString = ToStringConverter(result);

            return result;
        }

        //public string ToStringConverter(int grossIncome)
        //{
        //    var intIncome = grossIncome;

        //    var stringIncome = intIncome.ToString();

        //    return stringIncome;
        //}

    }

}