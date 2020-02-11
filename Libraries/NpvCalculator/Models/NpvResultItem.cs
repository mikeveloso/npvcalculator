namespace NpvCalculator.Models
{
    public class NpvResultItem
    {
        public double? Rate { get; set; }

        public double? NetPresentValue { get; set; }

        public override bool Equals(object o)
        {
            bool result = false;
            NpvResultItem npvResultItem = o as NpvResultItem;

            if (npvResultItem is NpvResultItem)
            {
                //Verify Npv Result Item Data
                result = (Rate == npvResultItem.Rate && NetPresentValue == npvResultItem.NetPresentValue);
            }

            return result;
        }
    }
}
