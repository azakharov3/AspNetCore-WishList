using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        private readonly string index = "Index";
        private readonly string error = "Error";

        public IActionResult Index()
        {
            return View(index);
        }

        public IActionResult Error()
        {
            return View(error);
        }
    }
}
