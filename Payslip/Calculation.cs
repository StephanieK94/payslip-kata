using System;

namespace Payslip
{
    public class Calculation
    {
        

        //public string[] EmployeeCalculations(EmployeeInformation employee, CalculationInformation foo)
        //{
        //    GrossIncome = GetGrossIncome(employee.Salary);
        //    IncomeTax = GetIncomeTax(employee.Salary);
        //    NetIncome = GetNetIncome(GrossIncome, IncomeTax);
        //    SuperAmount = GetSuperAmount(GrossIncome, employee.PayRate);
        //}

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

        public string GetNetIncome(string grossIncome, string incomeTax)
        {
            var netIncome = (double.Parse(grossIncome) - double.Parse(incomeTax));

            return GetRoundedCalculationAsInteger(netIncome).ToString();
        }

        public string GetSuperAmount(string income, string payRate)
        {
            var superRate = GetTrimmedNumber(payRate);

            var superAmount = int.Parse(income) * int.Parse(superRate) / 100;

            return GetRoundedCalculationAsInteger(superAmount).ToString();
        }

        public CalculationInformation GetCalculations(EmployeeInformation employeeInformation)
        {
            CalculationInformation calculatedEmployee = new CalculationInformation();

            calculatedEmployee.GrossIncome = GetGrossIncome(employeeInformation.Salary);
            calculatedEmployee.IncomeTax = GetIncomeTax(employeeInformation.Salary);
            calculatedEmployee.NetIncome = GetNetIncome(calculatedEmployee.GrossIncome, calculatedEmployee.IncomeTax);
            calculatedEmployee.SuperAmount =
                GetSuperAmount(calculatedEmployee.GrossIncome, employeeInformation.PayRate);

            return calculatedEmployee;
        }
    }

}