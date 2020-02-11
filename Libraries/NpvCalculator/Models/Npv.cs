using System.Collections.Generic;
using System.Linq;

namespace NpvCalculator.Models
{
    public class Npv
    {
        public Npv()
        {
            CashFlows = new List<CashFlow>();
            NpvResultItems = new List<NpvResultItem>();
            Messages = new List<ValidationMessage>();
        }

        public double? LowerBoundRate { get; set; }

        public double? UpperBoundRate { get; set; }

        public double? RateIncrement { get; set; }

        public double? InitialValue { get; set; }

        public int? Years { get; set; } 
        
        public List<CashFlow> CashFlows { get; set; }

        public List<NpvResultItem> NpvResultItems { get; set; }

        public List<ValidationMessage> Messages { get; set; }

        public override bool Equals(object o)
        {
            bool result = false;
            Npv npv = o as Npv;
            
            if (o is Npv)
            {
                //Verify Npv Data
                result = (LowerBoundRate == npv.LowerBoundRate &&
                         UpperBoundRate == npv.UpperBoundRate &&
                         RateIncrement == npv.RateIncrement &&
                         InitialValue == npv.InitialValue &&
                         Years == npv.Years);

                var isCashFlowMatch = (CashFlows.Any() && npv.CashFlows.Any());
                var isNpvResultMatch = (NpvResultItems.Any() && npv.NpvResultItems.Any());
                var isValidationMessageMatch = (Messages.Any() && npv.Messages.Any());
                var maxCount = 0;

                //Verify Cash Flow Items
                if (isCashFlowMatch)
                {
                    maxCount = npv.CashFlows.Count - 1;

                    for (var i = 0; i < maxCount; i++)
                    {
                        isCashFlowMatch = (CashFlows[i].Year == npv.CashFlows[i].Year && CashFlows[i].Amount == npv.CashFlows[i].Amount);

                        if (!isCashFlowMatch)
                        {
                            break;
                        }
                    }
                }

                //Verify NPV Result Items
                if (isNpvResultMatch)
                {
                    maxCount = npv.NpvResultItems.Count - 1;

                    for (var i = 0; i < maxCount; i++)
                    {
                        isNpvResultMatch = (NpvResultItems[i].Rate == npv.NpvResultItems[i].Rate && NpvResultItems[i].NetPresentValue == npv.NpvResultItems[i].NetPresentValue);

                        if (!isNpvResultMatch)
                        {
                            break;
                        }
                    }
                }

                //Verify Validation Messages

                if (isValidationMessageMatch)
                {
                    maxCount = npv.Messages.Count - 1;

                    for (var i = 0; i < maxCount; i++)
                    {
                        isValidationMessageMatch = (Messages[i].Message == npv.Messages[i].Message);

                        if (!isValidationMessageMatch)
                        {
                            break;
                        }
                    }
                }

                result = (isCashFlowMatch && isNpvResultMatch && isValidationMessageMatch);
            }

            return result;
        }
    }
}
