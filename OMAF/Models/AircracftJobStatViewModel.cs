using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OMAF.Models
{
    public class AircracftJobStatViewModel
    {
        public List<Aircraft> Aircraft { get; set; }
        public SelectList JobStat { get; set; }
        public string AircraftJobStat { get; set; }
        public string SearchJobStat { get; set; }
    }
}
