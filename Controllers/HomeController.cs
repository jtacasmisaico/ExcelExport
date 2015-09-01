using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;
using System.Collections.Generic;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var listOfUsers = new List<User>();
            for (int i = 0; i < 20; i++)
            {
                listOfUsers.Add(new User() { Name = "User" + i, Address = "Address" + i, Age = 1 + i });
            }

            return View(listOfUsers);
        }

        public IActionResult Export()
        {
            var listOfUsers = new List<User>();
            for (int i = 0; i < 20; i++)
            {
                listOfUsers.Add(new User() { Name = "User" + i, Address = "Address" + i, Age = 1 + i });
            }

            return new ExcelFileResult(listOfUsers);
        }

    }
}