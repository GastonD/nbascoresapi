using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NBA_Scores_API.Models{
    public class BoxScore
    {
        public int id {get; set;}
        public string HomeTeam {get; set;}
        public long HomeScore { get; set; }
        public string AwayTeam { get; set; }
        public long AwayScore { get; set; }
    }
}


