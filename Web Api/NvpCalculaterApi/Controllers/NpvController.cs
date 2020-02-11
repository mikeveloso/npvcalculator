using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using NpvCalculator.Models;
using NpvCalculator.Repositories;

namespace NpvCalculator.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class NpvController : ControllerBase
    {
        public readonly INpvRepository repo;

        public NpvController(INpvRepository npvRepo) => repo = npvRepo;

        [HttpGet]
        public ActionResult GetNpv()
        {
            return BadRequest();
        }

        [HttpPost("Calculate")]
        public async Task<ActionResult<Npv>> PostCalculateNpvAsync([FromBody]Npv npv)
        {
            try
            {
                npv = repo.CalculateNetPresentValue(npv);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

            return npv;
        }
    }
}
