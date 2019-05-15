using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace employee.tests
{
    public class ProgramTests
    {
        [Fact]
        public void EnsureFileExists()
        {
            var path = Directory.GetCurrentDirectory();

            var pathName = $"{path}\\Employee.csv";

            var boolean = File.Exists(pathName) ? "File Exists" : "File does not exist";

            Assert.Equal("File Exists", boolean);
        }
    }
}
