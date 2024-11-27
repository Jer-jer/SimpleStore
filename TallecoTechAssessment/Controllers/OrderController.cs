using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TallecoTechAssessment.Models;

namespace TallecoTechAssessment.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "orders.json");
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);

            var orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);
            return View(orders);
        }
    }
}
