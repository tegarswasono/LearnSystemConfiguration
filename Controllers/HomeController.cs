using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnSystemConfiguration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LearnSystemConfiguration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly SystemConfiguration _systemConfiguration;

        public HomeController(SystemConfiguration systemConfiguration)
        {
            _systemConfiguration = systemConfiguration;
        }

        [HttpGet]
        public ActionResult<SystemConfiguration> Get()
        {
            var systemConfiguration = _systemConfiguration;
            var result = _systemConfiguration.PlayStopToken;
            return Ok(result);
        }
    }
}
