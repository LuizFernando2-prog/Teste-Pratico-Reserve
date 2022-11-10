using System;

namespace TestePraticoReserve.Models
{
    public class ViewModel
    {
        public int Id { get; set; }
        public GlobalViewModel? global { get; set; }
        public List<CountriesInfectedModels>? CountriesInfectedModels { get; set; }
        public DateTime? date { get; set; }
    }
}
