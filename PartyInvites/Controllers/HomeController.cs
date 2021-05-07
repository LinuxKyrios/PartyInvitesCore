using System;
using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Good morning" : "Good evening";
            return View("MyView");
        }
    }
}