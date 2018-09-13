using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotOrNot.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ctx = new HotOrNot.WebUI.Models.HotOrNotContext();
            //ctx.Pictures.Add(new Models.Picture
            //{
            //    FileName = "test1.jpg",
            //    CreateDate = DateTime.Now                
            //});
            //ctx.SaveChanges();

            return View(ctx.Pictures);
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
    }
}