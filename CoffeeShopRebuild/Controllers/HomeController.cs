using CoffeeShopRebuild.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopRebuild.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {

            return View();
        }
        public ActionResult CoffeeRegistration(User data)
        {
            CoffeeEntities ORM = new CoffeeEntities();

            if (ModelState.IsValid)
            {

                ORM.Users.Add(data);
                ORM.SaveChanges();
                ViewBag.message = $"{data.FirstName}, you have been added!";
            }
            else
            {
                ViewBag.message = "Item is not valid, cannot add to DB.";
            }
            return View();
        }
    }
}