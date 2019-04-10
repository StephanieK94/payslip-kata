namespace Payslip
{
    public class StringConverter
    {
        public double ConvertStringToNumber(string salary)
        {
            var salaryString = salary;

            var value = double.Parse(salaryString);

            return value;
        }

        public string GetTrimmedNumber(string payRate)
        {
            var employeePayRate = payRate;

            var rate = employeePayRate.Trim('%');

            return rate;
        }
    }
}