using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NBA_Scores_API.Models;

namespace NBA_Scores_API.Controllers{
    [Route("[controller]")]
    [ApiController]
    public class BoxScoreController : ControllerBase
    {        
        private readonly ILogger<WeatherForecastController> _logger;

        public BoxScoreController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<BoxScore> Get()
        {

            return Enumerable.Range(1, 5).Select(index => new BoxScore
            {
                id = index,
                HomeTeam = "Chicago Bulls",
                AwayTeam = "Atlanta Hawks",
                HomeScore = 101,
                AwayScore = 100
            })
            .ToArray();
        }
    }
}

