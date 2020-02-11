using System.Collections.Generic;
using System.Linq;
using System.Numeric;

using NpvCalculator.Common;
using NpvCalculator.Models;

namespace NpvCalculator.Tests
{
    public class FakeNpv
    {
        public static Npv GetBaseNpvWithResults(double minRate = 1.00, double maxRate = 15.00, double rateInterval = 0.25, 
                                      double initialValue = 10000, double initialCashFlow = 1000, 
                                      double cashFlowInterval = 500, int years = 10)
        {
            Npv npv = new Npv()
            {
                LowerBoundRate = minRate,
                UpperBoundRate = maxRate,
                RateIncrement = rateInterval,
                InitialValue = initialValue,
                Years = years,
                Messages = new List<ValidationMessage>() ///Ensure that there is no validation or error messages
            };
                        
            for (var i = 0; i <= years; i++)
            {
                npv.CashFlows.Add(new CashFlow()
                {
                    Year = i,
                    Amount = initialCashFlow
                });

                initialCashFlow += cashFlowInterval;
            }

            List<double> cashFlowValues = npv.CashFlows.Select(m => m.Amount.ToDouble(0)).ToList<double>();

            for (double rate = minRate; rate <= maxRate; rate += rateInterval)
            {
                npv.NpvResultItems.Add(new NpvResultItem { Rate = rate, NetPresentValue = Financial.Npv(rate, cashFlowValues) });
            }

            return npv;
        }
    }
}
