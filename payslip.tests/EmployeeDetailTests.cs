using System.Collections.Generic;
using Payslip;
using Xunit;


namespace payslip.tests
{
    public class EmployeeDetailTests
    {
        [Fact]
        public void GivenStringGetEmployeeDetails()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            string[] expectedEmployee = { "David" , "Rudd" , "60050" , "9%" , "01 March - 31 March" };

            var commaSeparator = new CommaSeparator();

            var employeeInformation = commaSeparator.GetEmployeeInformation(employeeFile);

            Assert.Equal(expectedEmployee[0], employeeInformation.FirstName);
            Assert.Equal(expectedEmployee[1], employeeInformation.LastName);
            Assert.Equal(expectedEmployee[2], employeeInformation.EmployeeSalary);
            Assert.Equal(expectedEmployee[3], employeeInformation.EmployeePayRate);
            Assert.Equal(expectedEmployee[4], employeeInformation.PayPeriod);
        }

        [Fact]
        public void GivenStringReturnFullName()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            var commaSeparator = new CommaSeparator();

            var employeeInformation = commaSeparator.GetEmployeeInformation(employeeFile);

            Assert.Equal("David Rudd", employeeInformation.FullName);
        }

        [Fact]
        public void GivenStringReturnNumber()
        {
            var salary = "60050";

            var converter = new StringConverter();

            var salaryNumber = converter.ConvertStringToNumber(salary);

            Assert.Equal(60050, salaryNumber);
        }

        [Fact]
        public void GivenLessThanPointFiveNumberRoundsDownToNearestInteger()
        {
            var calculation = 10.4d;

            var rounder = new Calculation();

            var roundDown = rounder.GetRoundedCalculation(calculation);

            Assert.Equal(10.0, roundDown);
        }

        [Fact]
        public void GivenPointFiveOrAboveNumberRoundsUpToNearestInteger()
        {
            var calculation = 10.565d;

            var rounder = new Calculation();

            var point5 = rounder.GetRoundedCalculation(calculation);
            var point75 = rounder.GetRoundedCalculation(calculation);

            Assert.Equal(11, point5);
            Assert.Equal(11, point75);
        }

        [Fact]
        public void GivenPayRateStringGetTrimmedString()
        {
            var payRate = "9%";

            var calculator = new StringConverter();

            var rate = calculator.GetTrimmedNumber(payRate);

            Assert.Equal("9", rate);
        }

        [Fact]
        public void GivenSalaryCalculatesGrossMonthlyIncome()
        {
            var salary = 60050;

            var calculator = new Calculation();

            var grossIncome = calculator.GetGrossIncome(salary);

            Assert.Equal(5004, grossIncome);
        }

        [Fact]
        public void GivenSalaryGetMonthlyIncomeTax()
        {
            var salary = 60050;

            var calculator = new Calculation();

            var incomeTax = calculator.GetIncomeTax(salary);

            Assert.Equal(922, incomeTax);
        }

        [Fact]
        public void GivenGrossAndIncomeAmountsGetNetIncome()
        {
            var grossIncome = 5004;
            var incomeTax = 922;

            var calculator = new Calculation();

            var netIncome = calculator.GetNetIncome(grossIncome, incomeTax);

            Assert.Equal(4082, netIncome);
        }


    }
}
