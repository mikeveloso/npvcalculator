using System;
using System.Collections.Generic;

using NpvCalculator.Common;
using NpvCalculator.Models;
using NpvCalculator.Validations;

namespace NpvCalculator
{
    public class NpvCalculator : INpvCalculator
    {
        public Npv CalculateNetPresentValue(Npv npvData)
        {
            List<NpvResultItem> npvResultItems = new List<NpvResultItem>();
            List<ValidationMessage> messages = new List<ValidationMessage>();

            if (NpvValidator.ValidateNpvData(npvData, out messages))
            {
                double pv = 0;

                for (var rate = npvData.LowerBoundRate.ToDouble(1); rate <= npvData.UpperBoundRate.ToDouble(15); rate += npvData.RateIncrement.ToDouble(0.25))
                {
                    npvData.CashFlows.ForEach(cashFlow => 
                    {
                        pv += CalculatePresentValue(cashFlow.Amount.ToDouble(0), (rate / 100), cashFlow.Year.ToDouble(-1));                                                
                    });

                    double npv = Math.Round((pv - npvData.InitialValue.ToDouble(0)), 2, MidpointRounding.AwayFromZero);

                    npvResultItems.Add(new NpvResultItem() { Rate = rate, NetPresentValue = npv });
                }
            }

            npvData.NpvResultItems = npvResultItems;

            npvData.Messages = messages;

            return npvData;
        }

        protected double CalculatePresentValue(double cashFlow, double rate, double exponent)
        {
            double pv = 0;

            if (rate.IsInRange(0, 100) && exponent.IsGreaterThan(-1))
            {
                pv = cashFlow / Math.Pow(1 + rate, exponent);
            }

            return pv;
        }
    }
}
