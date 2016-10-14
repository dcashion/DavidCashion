using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DavidCashion.Models;


namespace DavidCashion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Weather()
        {
            ViewBag.Message = "Your weather page.";

            return View();
        }

        public ActionResult Fishing()
        {
            ViewBag.message = "Your Fishing Page.";

            return View();
        }

        public ActionResult Cooking()
        {
            ViewBag.Message = "Your Cooking page.";

            return View();
        }

        public ActionResult Canning()
        {
            ViewBag.Message = "Your Canning page.";

            return View();
        }

        public ActionResult SendTextMessage()
        {

            var MessageInfo = new SendMessageInfo();

            MessageInfo.RecieverAddress = "2084129032@messaging.sprinpcs.com";
            MessageInfo.RecieverName = "David Cashion";

            return View(MessageInfo);  //Returns the MessageInfo to the SendTextMessage view

        }
    }
}