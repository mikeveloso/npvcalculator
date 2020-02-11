using System.Collections.Generic;
using System.Linq;

using NpvCalculator.Common;
using NpvCalculator.Models;

namespace NpvCalculator.Validations
{
    public class NpvValidator
    {
        public static bool ValidateNpvData(Npv npvData, out List<ValidationMessage> messages)
        {
            List<ValidationMessage> validationMessages = new List<ValidationMessage>();

            if (npvData.LowerBoundRate > npvData.UpperBoundRate)
            {
                validationMessages.Add(new ValidationMessage() { Message = "Upper bound rate must be greater than lower bound rate." });
            }

            if (!npvData.LowerBoundRate.IsInRange(0, 100))
            {
                validationMessages.Add(new ValidationMessage() { Message = "Lower bound rate must be between than 0 and 100." });
            }

            if (!npvData.UpperBoundRate.IsInRange(0, 100))
            {
                validationMessages.Add(new ValidationMessage() { Message = "Upper bound rate must be between than 0 and 100." });
            }

            if (!npvData.RateIncrement.IsInRange(0, 100))
            {
                validationMessages.Add(new ValidationMessage() { Message = "Rate Increment must be between than 0 and 100." });
            }

            if (!npvData.InitialValue.HasValue || npvData.InitialValue.ToDouble(-1) < 0)
            {
                validationMessages.Add(new ValidationMessage() { Message = "Rate Increment must have value." });
            }

            if (!npvData.Years.HasValue || npvData.Years.ToInteger(0) <= 0)
            {
                validationMessages.Add(new ValidationMessage() { Message = "Tenure in years must have value." });
            }

            if (!npvData.CashFlows.Any())
            {
                validationMessages.Add(new ValidationMessage() { Message = "Cash flow must have at least one item." });
            }
            else
            {
                List<CashFlow> cashFlows = npvData.CashFlows;

                cashFlows.ForEach(cashFlow =>
                {
                    if (cashFlow.Amount.ToDouble(0) <= 0)
                    {
                        validationMessages.Add(new ValidationMessage() { Message = string.Format("Cash flow for year {0} must have a value greater than 0.", cashFlow.Year) });
                    }
                });
            }

            messages = validationMessages;

            return (!messages.Any());
        }
    }
}
