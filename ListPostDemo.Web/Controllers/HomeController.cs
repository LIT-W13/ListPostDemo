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

//create an application that displays a list of people. On top of the list
//have a link that takes you to a page that allows the user to enter multiple
//people. When that page loads, there should be one row of textboxes (first name,
//lastname and age) with a button on top that says "Add". When Add is clicked,
//another row of textboxes should appear. Beneath those textboxes, there should
//be a submit button, that when clicked, adds all those people to the database
//and then redirects the user back to the home page (with a success message showing on top).
//On the home page, in the first
//column of every row, have a checkbox. On top of that column (in the header) have a
//"Delete all" button. When this button is clicked, all the people that were checked
//off, should get deleted. The user should get redirected back to the home page, and
//a message should be displayed on top.
