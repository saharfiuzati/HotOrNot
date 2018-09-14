namespace HotOrNot.WebUI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HotOrNot.WebUI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HotOrNot.WebUI.Models.HotOrNotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HotOrNot.WebUI.Models.HotOrNotContext";
        }

        protected override void Seed(HotOrNot.WebUI.Models.HotOrNotContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Pictures.AddOrUpdate(x => x.PictureId,
        new Picture() { PictureId = 1, FileName = "http://www.gstatic.com/webp/gallery/1.jpg", CreateDate=System.DateTime.Now},
        new Picture() { PictureId = 2, FileName = "http://www.gstatic.com/webp/gallery/2.jpg", CreateDate= System.DateTime.Now },
        new Picture() { PictureId = 3, FileName = "http://www.gstatic.com/webp/gallery/3.jpg", CreateDate= System.DateTime.Now });
        }
    }
}
