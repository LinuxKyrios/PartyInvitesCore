using System;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

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

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        //Created post method for containing response and return view with thanks
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
    }
}