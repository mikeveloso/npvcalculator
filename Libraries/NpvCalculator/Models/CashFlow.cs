namespace NpvCalculator.Models
{
    public class CashFlow
    {
        public int? Year { get; set; }

        public double? Amount { get; set; }

        public override bool Equals(object o)
        {
            bool result = false;
            CashFlow cashFlow = o as CashFlow;

            if (cashFlow is CashFlow)
            {
                //Verify CashFlow Data
                result = (Year == cashFlow.Year && Year == cashFlow.Year);
            }

            return result;
        }
    }
}
