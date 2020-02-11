using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using NpvCalculator.Models;
using NpvCalculator.Services;

namespace NpvCalculatorCalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public readonly INpvCalculatorService npvCalculatorService;

        public HomeController(INpvCalculatorService calculatorService) => npvCalculatorService = calculatorService;

        public IActionResult Index()
        {
            var model = new Npv();
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CalculateNPV([FromBody]Npv model)
        {
            try
            {
                model = npvCalculatorService.CalculateNpv(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message, ex.InnerException);
            }

            return PartialView("/Views/Home/Partials/_NpvResults.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> GenerateCashFlows([FromBody]Npv npvValues)
        {
            List<CashFlow> model = new List<CashFlow>();
            
            for (var i = 1; i <= npvValues.Years; i++)
            {
                if (i <= npvValues.CashFlows.Count)
                {
                    model.Add(npvValues.CashFlows[i - 1]);
                }
                else
                {
                    model.Add(new CashFlow() { Year = i });
                }
            }
            
            return PartialView("/Views/Home/Partials/_CashFlows.cshtml", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }        
    }
}
