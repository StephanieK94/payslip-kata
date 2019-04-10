namespace Payslip
{
    public class StringToNumberConverter
    {
        public double ConvertStringToNumber(string salary)
        {
            var salaryString = salary;

            var value = double.Parse(salaryString);

            return value;
        }
    }
}