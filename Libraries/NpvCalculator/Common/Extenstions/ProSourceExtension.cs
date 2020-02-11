using System;

namespace NpvCalculator.Common
{
    public static class NpvCalculatorExtension
    {
        public static double ToDouble(this double? doubleValue, double defaultValue = -1)
        {
            return (doubleValue.HasValue ? doubleValue.Value : defaultValue);
        }

        public static double ToDouble(this int? intValue, double defaultValue = -1)
        {
            return (intValue.HasValue ? Convert.ToDouble(intValue.Value) : defaultValue);
        }

        public static double ToDouble(this int intValue)
        {
            return Convert.ToDouble(intValue);
        }

        public static double ConvertNegativeToPositive(this double? doubleValue)
        {
            return (doubleValue.HasValue ? (doubleValue.ToDouble(0) >= 0 ? doubleValue.ToDouble(0) * -1 : doubleValue.ToDouble(0)) : 0);
        }

        public static double ConvertNegativeToPositive(this double doubleValue)
        {
            return (doubleValue > 0 ? doubleValue * -1 : 0);
        }

        public static int ConvertNegativeToPositive(this int? intValue)
        {
            return (intValue.HasValue ? (intValue.ToInteger(0) >= 0 ? intValue.ToInteger(0) * -1 : intValue.ToInteger(0)) : 0);
        }

        public static int ConvertNegativeToPositive(this int intValue)
        {
            return (intValue >= 0 ? intValue * -1 : intValue);
        }

        public static double ConvertPositiveToNegative(this double? doubleValue)
        {
            return (doubleValue.HasValue ? (doubleValue.ToDouble(0) < 0 ? doubleValue.ToDouble(0) * -1 : doubleValue.ToDouble(0)) : 0);
        }

        public static double ConvertPositiveToNegative(this double doubleValue)
        {
            return (doubleValue <= 0 ? doubleValue * -1 : doubleValue);
        }

        public static int ConvertPositiveToNegative(this int? intValue)
        {
            return (intValue.HasValue ? (intValue.ToInteger(0) <= 0 ? intValue.ToInteger(0) * -1 : intValue.ToInteger(0)) : 0);
        }

        public static int ConvertPositiveToNegative(this int intValue)
        {
            return (intValue <= 0 ? intValue * -1 : intValue);
        }
                
        public static double ConvertDoubleToPercentage(this double? doubleValue, int decimalPlaces, MidpointRounding midPointRounding = MidpointRounding.AwayFromZero)
        {
            return Math.Round((doubleValue.ToDouble(0) / 100), decimalPlaces, midPointRounding);
        }
                
        public static double ConvertDoubleToPercentage(this double doubleValue, int decimalPlaces, MidpointRounding midPointRounding = MidpointRounding.AwayFromZero)
        {
            return Math.Round((doubleValue / 100), decimalPlaces, midPointRounding);
        }

        public static double ConvertIntegerToPercentage(this int? intValue, int decimalPlaces, MidpointRounding midPointRounding = MidpointRounding.AwayFromZero)
        {
            return Math.Round((intValue.ToDouble(0) / 100), decimalPlaces, midPointRounding);
        }

        public static double ConvertIntegerToPercentage(this int intValue, int decimalPlaces, MidpointRounding midPointRounding = MidpointRounding.AwayFromZero)
        {
            return Math.Round((intValue.ToDouble() / 100), decimalPlaces, midPointRounding);
        }
        
        public static string ToStringPercentage(this double? doubleValue, string format)
        {
            return (string.Format(format, (doubleValue.ToDouble(0) / 100)));
        }

        public static string ToStringPercentage(this double doubleValue, string format)
        {
            return (string.Format(format, doubleValue));
        }

        public static string ToStringPercentage(this int? intValue, string format)
        {
            return (string.Format(format, (intValue.ToInteger(0) / 100)));
        }

        public static string ToStringPercentage(this int intValue, string format)
        {
            return (string.Format(format, (intValue / 100)));
        }

        public static string ToStringCurrency(this double? doubleValue, string format)
        {
            return string.Format(format, doubleValue.ToDouble(0));
        }

        public static string ToStringCurrency(this double doubleValue, string format)
        {
            return string.Format(format, doubleValue);
        }

        public static string ToStringCurrency(this int? intValue, string format)
        {
            return string.Format(format, intValue.ToDouble(0));
        }

        public static string ToStringCurrency(this int intValue, string format)
        {
            return string.Format(format, intValue);
        }

        public static int ToInteger(this int? intValue, int defaultValue = -1)
        {
            return (intValue.HasValue ? intValue.Value : defaultValue);
        }

        public static bool IsInRange(this double? doubleValue, double? lowerBound, double? upperBound)
        {
            if (lowerBound > upperBound)
                return false;

            return doubleValue.ToDouble() >= lowerBound.ToDouble() && doubleValue.ToDouble() <= upperBound.ToDouble();            
        }

        public static bool IsInRange(this double doubleValue, double lowerBound, double upperBound)
        {
            if (lowerBound > upperBound)
                return false;

            return doubleValue >= lowerBound && doubleValue <= upperBound;
        }

        public static bool IsGreaterThan(this double? doubleValue, double? minValue)
        {
            return (doubleValue > minValue);
        }

        public static bool IsGreaterThan(this double doubleValue, double minValue)
        {
            return (doubleValue > minValue);
        }
    }
}
