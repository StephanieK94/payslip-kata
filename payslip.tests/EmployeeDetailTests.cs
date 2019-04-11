using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
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

            var commaSeparator = new EmployeeDetails();

            var employeeInformation = commaSeparator.GetEmployeeInformation(employeeFile);

            Assert.Equal("David Rudd", employeeInformation.FullName);
            Assert.Equal(expectedEmployee[2], employeeInformation.Salary);
            Assert.Equal(expectedEmployee[3], employeeInformation.PayRate);
            Assert.Equal(expectedEmployee[4], employeeInformation.PayPeriod);
        }


        [Fact]
        public void GivenStringArrayOutputsStringStatement()
        {
            string[] employee = { "David Rudd", "01 March - 31 March", "5004", "922", "4082", "450" };

            var statement = new StatementCompiler();

            var employeeStatement = statement.CompileStrings(employee);

            Assert.Equal("David Rudd,01 March - 31 March,5004,922,4082,450", employeeStatement);
        }

        [Fact]
        public void GivenNumberReturnString()
        {
            int grossIncome = 5004;

            var incomeInteger = new Calculation();

            var incomeString = incomeInteger.ToStringConverter(grossIncome);

            Assert.Equal("5004", incomeString);
        }

        [Fact]
        public void GivenStringReturnFullName()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            var commaSeparator = new EmployeeDetails();

            var employeeInformation = commaSeparator.GetEmployeeInformation(employeeFile);

            Assert.Equal("David Rudd", employeeInformation.FullName);
        }

        [Fact]
        public void GivenStringReturnNumber()
        {
            var salary = "60050";

            var converter = new Calculation();

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

            var calculator = new Calculation();

            var rate = calculator.GetTrimmedNumber(payRate);

            Assert.Equal("9", rate);
        }

        //[Fact]
        //public void GivenEmployeeDetailsStringGetFullEmployeeInformation()
        //{
        //    string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

        //    var employee = new EmployeeInformation();

            

            
        //}
    }
}
