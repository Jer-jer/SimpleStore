using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TallecoTechAssessment.Models;

namespace TallecoTechAssessment.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "products.json");
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);

            var products = JsonConvert.DeserializeObject<List<Product>>(jsonData);

            return View(products);
        }
    }
}
