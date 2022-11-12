using System;
using System.Collections.Generic;

namespace TestePraticoReserve.Models
{
    public class ViewModel
    {
        public string? ID { get; set; }
        public string? Message { get; set; }
        public GlobalViewModel Global { get; set; }
        public List<CountriesInfectedModels> Countries { get; set; }
        public DateTime Date { get; set; }
    }
}
