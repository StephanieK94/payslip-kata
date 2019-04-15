using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace payslip.tests
{
    public class ProgramTests
    {
        [Fact]
        public void EnsureFileExists()
        {
            var path = Directory.GetCurrentDirectory();

            var pathName = $"{path}\\Employee.csv";

            var expectedFile = File.Exists(pathName);

            Assert.True(expectedFile);
        }
    }
}
