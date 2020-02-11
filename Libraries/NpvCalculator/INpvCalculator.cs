using NpvCalculator;

using NpvCalculator.Models;

namespace NpvCalculator
{
    public interface INpvCalculator
    {
        Npv CalculateNetPresentValue(Npv npvData);

    }
}
