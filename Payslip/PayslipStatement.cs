namespace Payslip
{
    public class PayslipStatement
    {
        public string FullName { get; set; }
        public string PayPeriod { get; set; }
        public decimal GrossIncome { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal NetIncome { get; set; }
        public decimal SuperAmount { get; set; }
    }
}