using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeAnNhom.Models;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;



namespace DeAnNhom.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product(int id)
        {
            return View();
        }



        


        
    }
}