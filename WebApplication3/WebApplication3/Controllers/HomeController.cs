using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Men()
        {
            return View();
        }
        public IActionResult Women()
        {
            return View();
        }
        public IActionResult Kids()
        {
            return View();
        }
        public IActionResult Sports()
        {
            return View();
        }
        public IActionResult NikeSportswear()
        {
            return View();
        }
        public IActionResult NikeID()
        {
            return View();
        }
    }
}
