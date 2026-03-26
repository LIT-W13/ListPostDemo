using System.Diagnostics;
using ListPostDemo.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListPostDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostNumbers(List<int> numbers)
        {
            return View(new IndexViewModel
            {
                Numbers = numbers
            });
        }


    }
}
