using System;
using Xunit;
using System.IO;

namespace payslip.tests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenStringSeparateByComma()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March – 31 March";

            var commaSeparator = new CommaSeparator();

            var firstName = commaSeparator.GetFirstNameFrom(employeeFile);

            Assert.Equal("David", firstName);
        }

    }

    internal class CommaSeparator
    {
        public CommaSeparator()
        {

        }

        internal string GetFirstNameFrom(string employeeFile)
        {
            var employeeDetails = employeeFile.Split(",");

            var firstName = employeeDetails[0];

            return firstName;
        }
    }
}
