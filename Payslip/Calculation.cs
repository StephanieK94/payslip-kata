using System;

namespace Payslip
{
    public class Calculation
    {
        public int GetRoundedCalculation(double calculation)
        {
            var inputtedDouble = calculation;

            var outputtedDouble = Math.Round(inputtedDouble, MidpointRounding.AwayFromZero);

            var result = Convert.ToInt32(outputtedDouble);

            return result;
        }

        public double GetGrossIncome(double salary)
        {
            var employeeSalary = salary;

            var grossMonthlyIncome = employeeSalary / 12;

            var roundedGrossMonthlyIncome = GetRoundedCalculation(grossMonthlyIncome);

            return roundedGrossMonthlyIncome;
        }

        public double GetIncomeTax(double salary)
        {
            var employeeSalary = salary;

            double monthlyIncomeTax = 0;

            if (employeeSalary <= 18200)
            {
                return 0;
            }

            if (employeeSalary >=18201 && employeeSalary <= 37000)
            {
                monthlyIncomeTax = ((employeeSalary - 18200) * 0.19 )/ 12;
            }

            if (employeeSalary >=37001 && employeeSalary <= 80000)
            {
                monthlyIncomeTax = (((employeeSalary - 37000) * 0.325)+3572) / 12;
            }

            if (employeeSalary >= 80001 && employeeSalary <= 180000)
            {
                monthlyIncomeTax = (((employeeSalary - 80000) * 0.37)+ 17547) / 12;
            }

            if (employeeSalary >=180001 && employeeSalary >= 180001)
            {
                monthlyIncomeTax = (((employeeSalary - 180000) * 0.45)+ 54547) / 12;
            }

            var roundedIncomeTax = GetRoundedCalculation(monthlyIncomeTax);

            return roundedIncomeTax;
        }

        public int GetNetIncome(int income, int tax)
        {
            var grossIncome = income;
            var incomeTax = tax;

            var netIncome = grossIncome - incomeTax;
            var result = GetRoundedCalculation(netIncome);

            return result;
        }

        public int GetSuperAmount(double gross, double payRate)
        {
            var grossIncome = gross;
            var superRate = payRate;

            var superAmount = grossIncome * superRate;

            var result = GetRoundedCalculation(superAmount);

            return result;
        }
    }
}