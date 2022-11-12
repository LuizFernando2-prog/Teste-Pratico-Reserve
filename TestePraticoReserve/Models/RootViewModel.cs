namespace TestePraticoReserve.Models
{
    public class RootViewModel
    {
        public string ID { get; set; }
        public string Message { get; set; }
        public GlobalViewModel Global { get; set; }
        public List<CountriesInfectedModels> Countries { get; set; }
        public DateTime Date { get; set; }
    }
}
