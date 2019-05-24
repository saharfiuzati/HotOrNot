using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity;
using HotOrNot.WebUI.Models;
using System.Web.Mvc;

namespace HotOrNot.WebUI.Controllers.Tests
{
    public class MockHotOrNotContext : IHotOrNotContext
    {
        public DbSet<Picture> Pictures { get; set; }

        public void AddLikeOrDislike(int pictureId, bool flag)
        {
            Picture p = new Picture();
            p.DisLikeCnt = 1;
        }

        public void Create(string MyFileName, string Mytitle, string Mydescription)
        {
            Picture p = new Picture
            {
                PictureId = 1,
                CreateDate = DateTime.Now,
                FilePath = MyFileName,
                DisLikeCnt = 0,
                LikeCnt = 0,
                Title = Mytitle,
                Description = Mydescription

            };
        }

        public Picture FindRandomPicture()
        {
            return new Picture
            {
                PictureId = 1,
                CreateDate = DateTime.Now,
                FilePath = "https://picsum.photos/id/907/200/300",
                DisLikeCnt = 0,
                LikeCnt = 0,
                Title = "MockObject",
                Description = "MockObject"

            };
        }
    }

    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void Index_Returns_ActionResult()
        {
            //Arrange
            HomeController homeController = new HomeController(new MockHotOrNotContext());

            //Act
            ActionResult result = homeController.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod()]
        public void IncLike_Returns_ActionResult()
        {
            //Arrange
            HomeController homeController = new HomeController(new MockHotOrNotContext());

            //Act
            ActionResult result = homeController.IncLike(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
        }

        [TestMethod()]
        public void IncDisLike_Returns_ActionResult()
        {
            //Arrange
            HomeController homeController = new HomeController(new MockHotOrNotContext());

            //Act
            ActionResult result = homeController.IncDisLike(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
        }

        [TestMethod()]
        public void Create_Returns_ActionResult()
        {
            //Arrange
            HomeController homeController = new HomeController(new MockHotOrNotContext());

            //Act
            ActionResult result = homeController.Create();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        [TestMethod()]
        public void Create_Post_Returns_ActionResult()
        {
            //Arrange
            HomeController homeController = new HomeController(new MockHotOrNotContext());

            //Act
            ActionResult result = homeController.Create("testname", "testtitle", "testdescription");

            //Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
        }

    }
}
