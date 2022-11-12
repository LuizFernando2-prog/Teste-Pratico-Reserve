using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestePraticoReserve.Models;
namespace TestePraticoReserve.Controllers
{
    public class CountriesInfectedController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewModel countries = new ViewModel();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://api.covid19api.com/summary"))
                {
                    string apiResnponse = await response.Content.ReadAsStringAsync();
                    countries = JsonConvert.DeserializeObject<ViewModel>(apiResnponse);
                }
            }
            List<CountriesInfectedModels> countriesInfectedModels = countries.Countries.OrderByDescending(i => i.ActiveCases).Take(10).ToList();

            var count = 1; 
            foreach(var item in countriesInfectedModels)
            {
                item.Position = "º" + count;

                count++;
            }


          return View(countriesInfectedModels);
        } 
    }
}