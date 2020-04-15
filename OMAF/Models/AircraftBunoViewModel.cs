using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OMAF.Models
{
    public class AircraftBunoViewModel
    {
        public List<Aircraft> Aircraft { get; set; }
        public SelectList Buno { get; set; }
        public string AircraftBuno { get; set; }
        public string SearchString { get; set; }
    }
}
