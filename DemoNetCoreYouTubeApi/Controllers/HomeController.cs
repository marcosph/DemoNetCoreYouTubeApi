using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoNetCoreYouTubeApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            @ViewBag.Titulo = "fdsfsfasdfasdfasdf fdsfa";
            return View();
        }

        public IActionResult Contact()
        {           
            return View();
        }
        public IActionResult face()
        {
            return View();
        }

        public IActionResult disqus()
        {
            return View();
        }

        [Route("btn")]
        public IActionResult btn()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
