using System;
using System.Collections.Generic;
using System.IO;
using Payslip;

public class PayslipWriter
{
    public void WritePayslipCsv(List<PayslipStatement> payslipList, string pathNameToWriteTo)
    {
        using (var csvWriter = new StreamWriter(pathNameToWriteTo))
        {
            foreach (var employee in payslipList)
            {
                var employeeStatement = string.Format(
                    "{0},{1},{2},{3},{4},{5}",
                    employee.FullName, employee.PayPeriod, employee.GrossIncome.ToString(),
                    employee.IncomeTax.ToString(), employee.NetIncome.ToString(), employee.SuperAmount.ToString());

                csvWriter.WriteLine(employeeStatement);
            }
        }
    }
}