using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMAF.Models
{
    public class AircraftBunoViewModel       //https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-3.1#add-search-by-genre
    {
        public List<Aircraft> Movies { get; set; }
        public SelectList BUNO { get; set; }
        public int AircraftBuno { get; set; }
        public int SearchString { get; set; }
    }
}