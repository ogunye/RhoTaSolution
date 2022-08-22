using Microsoft.AspNetCore.Mvc;
using RhoTaSolution.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTa.ApiServices.DataManager.Controllers
{
    [Route("api/hospitals")]
    [ApiController]
    public class HospitalsController : ControllerBase
    {
        private readonly IServiceManager _services;

        public HospitalsController(IServiceManager services) => _services = services;

        [HttpGet]
        public IActionResult GetHospitals()
        {
            try
            {
                var hospitals = _services.HospitalService.GetHospitals(trackChanges: false);
                return Ok(hospitals);
            }
            catch 
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
