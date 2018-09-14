using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HotOrNot.WebUI.Models;

namespace HotOrNot.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private HotOrNotContext db = new HotOrNotContext();
        public ActionResult Index()
        {
            
            return View(db.Pictures.ToList());
        }

       
    }
}