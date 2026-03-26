using ListPostDemo.Data;
using ListPostDemo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ListPostDemo.Web.Controllers
{
    public class FurnitureController : Controller
    {
        private string _connectionString = @"Data Source=.\sqlexpress;Initial Catalog=FurnitureStore;Integrated Security=true;TrustServerCertificate=true;";

        public IActionResult Index()
        {

            FurnitureDb db = new FurnitureDb(_connectionString);
            var items = db.GetAll();
            var vm = new FurnitureViewModel
            {
                FurnitureItems = items
            };
            if (TempData["message"] != null)
            {
                vm.Message =(string) TempData["message"];

            }
            return View(vm);
        }

        public IActionResult ShowAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(List<FurnitureItem> items)
        {
            FurnitureDb db = new FurnitureDb(_connectionString);
            db.AddMultiple(items);
            TempData["message"] = "Items added successfully";
            return Redirect("/furniture/index");
        }

        [HttpPost]
        public IActionResult DeleteMany(List<int> ids)
        {
            FurnitureDb db = new FurnitureDb(_connectionString);
            db.DeleteMultiple(ids);
            return Redirect("/furniture");
        }
    }
}
