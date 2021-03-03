using covid.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace covid.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidController : ControllerBase
    {
        private readonly ILogger<CovidController> _logger;
        private readonly ICovidInfoProvider _covidInfoProvider;

        public CovidController(ILogger<CovidController> logger,
            ICovidInfoProvider covidInfoProvider)
        {
            _logger = logger;
            _covidInfoProvider = covidInfoProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(";)");
        }

        [HttpGet("overview")]
        public async Task<IActionResult> GetOverview()
        {
            _logger.LogInformation("Getting covid overview");

            var overview = await _covidInfoProvider.GetOverview();
            return new JsonResult(overview);
        }
    }
}
