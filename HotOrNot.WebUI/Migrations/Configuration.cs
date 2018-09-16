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
        new Picture() { PictureId = 25, FilePath = "http://www.gstatic.com/webp/gallery/1.jpg",Title= "A beautiful Mountain",Description="A greate Place To Start Your Adventure!", CreateDate=System.DateTime.Now},
        new Picture() { PictureId = 26, FilePath = "http://www.gstatic.com/webp/gallery/2.jpg", Title = "A beautiful River", Description = "A greate Place To Test Your Boat!", CreateDate = System.DateTime.Now },
        new Picture() { PictureId = 27, FilePath = "http://www.gstatic.com/webp/gallery/3.jpg", Title = "A Snowy Day", Description = "Winter Is Coming!", CreateDate = System.DateTime.Now },
        new Picture() { PictureId = 28, FilePath = "http://www.gstatic.com/webp/gallery/4.jpg", Title = "A beautiful Tree", Description = "Feeling Young Again!", CreateDate = System.DateTime.Now });
        }
    }
}
