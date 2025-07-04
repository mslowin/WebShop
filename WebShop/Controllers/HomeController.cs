using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using WebShop.Application.Interfaces;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemService _itemService;

        public HomeController(ILogger<HomeController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var entities = new List<Entity>();
            for (int i = 0; i < 10; i++)
            {
                entities.Add(new Entity { Id = i, Name = $"Item {i}", Type = "Grocery" });
            }
            TempData["Entities"] = System.Text.Json.JsonSerializer.Serialize(entities);
            return View();
        }

        public IActionResult ViewListOfItems()
        {
            _logger.LogInformation("Listed all items");
            var entitiesJson = TempData["Entities"] as string;
            if (entitiesJson == null)
            {
                return NotFound();
            }

            var entities = System.Text.Json.JsonSerializer.Deserialize<List<Entity>>(entitiesJson);
            TempData["Entities"] = System.Text.Json.JsonSerializer.Serialize(entities);
            return View(entities);
        }

        public IActionResult InspectItem(int id)
        {
            var entitiesJson = TempData["Entities"] as string;
            if (entitiesJson == null)
            {
                return NotFound();
            }

            var entities = System.Text.Json.JsonSerializer.Deserialize<List<Entity>>(entitiesJson);
            TempData["Entities"] = System.Text.Json.JsonSerializer.Serialize(entities);
            var item = entities?.Find(e => e.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // DeleteItem
        public IActionResult DeleteItem(int id)
        {
            var entitiesJson = TempData["Entities"] as string;
            if (entitiesJson == null)
            {
                return NotFound();
            }

            var entities = System.Text.Json.JsonSerializer.Deserialize<List<Entity>>(entitiesJson);
            entities?.RemoveAt(id);
            TempData["Entities"] = System.Text.Json.JsonSerializer.Serialize(entities);
            return RedirectToAction("ViewListOfItems");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
