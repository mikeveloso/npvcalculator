using System.Threading.Tasks;

using NpvCalculator.Models;

namespace NpvCalculator.Services
{
    public interface INpvCalculatorService
    {
        Npv CalculateNpv(Npv npv);
    }
}
