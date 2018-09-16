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

            return View(db.Pictures.OrderBy(o=> Guid.NewGuid()).First());
        }
        

        public  ActionResult IncLike(int? PictureId)
        {
            var MyPicture = db.Pictures.Find(PictureId);
            MyPicture.LikeCnt++;
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        public ActionResult IncDisLike(int? PictureId)
        {
            var MyPicture = db.Pictures.Find(PictureId);
            MyPicture.DisLikeCnt++;
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        [AcceptVerbs("GET")]
        public ActionResult Create()
        {
           // HotOrNotContext Pic = new HotOrNotContext();
            Picture picture = new Picture();
            return View(picture);
        }
        [AcceptVerbs("POST")]
        public ActionResult Create(string MyFileName,string Mytitle,string Mydescription)
        {
            Picture picture = new Picture();
            try
            {
                var MaxPictureID = db.Pictures.OrderByDescending(u => u.PictureId).FirstOrDefault();
                int NextID = MaxPictureID.PictureId;
                db.Pictures.Add(new Picture { PictureId = NextID + 1, FilePath = MyFileName,Title=Mytitle,Description=Mydescription, LikeCnt = 0, DisLikeCnt = 0, CreateDate = System.DateTime.Now });
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception err)
            {
                return View(picture);
            }
            
        }

    }
}