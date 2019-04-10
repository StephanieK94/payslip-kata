namespace Payslip
{
    public class IntegerConverter
    {
        public string ToStringConverter(int grossIncome)
        {
            var intIncome = grossIncome;

            var stringIncome = intIncome.ToString();

            return stringIncome;
        }
    }
}