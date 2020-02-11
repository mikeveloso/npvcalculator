using System.Threading.Tasks;

using NpvCalculator.Models;

namespace NpvCalculator.Repositories
{
    public interface INpvRepository
    {
        Npv CalculateNetPresentValue(Npv npv);
    }
}
