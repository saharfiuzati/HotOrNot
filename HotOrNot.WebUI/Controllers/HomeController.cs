using System;
using System.Web.Mvc;
using HotOrNot.WebUI.Models;


namespace HotOrNot.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IHotOrNotContext db { get; set; }

        public HomeController()
        {
            db = new HotOrNotContext();
        }

        public HomeController(IHotOrNotContext hotOrNotContext)
        {
            db = hotOrNotContext;
        }

        public ActionResult Index()
        {
            return View(db.FindRandomPicture());
        }

        public ActionResult IncLike(int PictureId)
        {
            db.AddLikeOrDislike(PictureId, true);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult IncDisLike(int PictureId)
        {
            db.AddLikeOrDislike(PictureId, false);
            return RedirectToAction("Index", "Home");
        }

        [AcceptVerbs("GET")]
        public ActionResult Create()
        {
            Picture picture = new Picture();
            return View(picture);
        }

        [AcceptVerbs("POST")]
        public ActionResult Create(string MyFileName, string Mytitle, string Mydescription)
        {
            Picture picture = new Picture();
            try
            {
                db.Create(MyFileName, Mytitle, Mydescription);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception err)
            {
                return View(picture);
            }

        }

    }
}