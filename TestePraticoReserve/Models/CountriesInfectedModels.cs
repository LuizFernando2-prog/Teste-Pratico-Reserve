using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestePraticoReserve.Models
{
    public class CountriesInfectedModels
    {
        public string ID { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
        public DateTime Date { get; set; }
        public PremiumModel Premium { get; set; }
        public string Position { get; set; }
        public int ActiveCases => TotalDeaths - TotalRecovered;
    }
}
