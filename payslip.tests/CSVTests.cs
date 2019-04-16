using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using Newtonsoft.Json.Linq;
using Payslip;
using Xunit;
using CsvParser = Payslip.CsvParser;

namespace payslip.tests
{
    public class CSVTests
    {
        [Fact]
        public void ReadCsvFileOutputEmployeeInformation()
        {
            var path = Directory.GetCurrentDirectory();

            var pathName = $"{path}\\Employee.csv";
            var parser = new CsvParser();

            var lineItems = parser.GetCsvContents(pathName);

            Assert.Equal("David", lineItems[0].FirstName);
            Assert.Equal("Rudd", lineItems[0].LastName);
            Assert.Equal(60050M, lineItems[0].Salary);
            Assert.Equal(9, lineItems[0].PayRate);
            Assert.Equal("01 March – 31 March", lineItems[0].PayPeriod);
        }

        [Fact]
        public void WriteCsvFileWithPayslipInformation()
        {
            var payslipList = new List<EmployeePayslip>();

            var payslip = new EmployeePayslip
            {
                FullName = "David Rudd",
                PayPeriod = "01 March - 31 March",
                GrossIncome = 5004M,
                NetIncome = 4082M,
                IncomeTax = 922M,
                SuperAmount = 450M
            };

            payslipList.Add(payslip);

            var csvWriter = new WritePayslip();

            var payslipOutput = csvWriter.WriteCsv(payslipList);
            

            Assert.Equal("David Rudd,01 March - 31 March,5004,4082,922,450", payslipOutput[0]);
        }
    }

    public class WritePayslip
    {
        public List<string> WriteCsv(List<EmployeePayslip> payslipList)
        {
            var csvList = new List<string>();
            // Input the list of payslip information
            // Need to convert the decimals ToString() and then String.Join(',', the list of strings)

            // Something along these lines
            // would need to change to a list of strings then pass that in to be written



            // foreach (var employee in payslipList)
            //{
            //string csv = String.Join(',', payslip.FullName,payslip.PayPeriod,payslip.GrossIncome,payslip.IncomeTax,payslip.NetIncome,payslip.SuperAmount);
            //}
            
            //string filePath = "C:\\Users\\StephanieK\\source\\payslip-kata\\payslip.tests\\bin\\Debug\\netcoreapp2.1\\Payslip.csv";

            //File.WriteAllText(filePath, csv);
            return csvList;
        }
    }
}
