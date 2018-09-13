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
        new Picture() { PictureId = 1, FileName = "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&ved=2ahUKEwifisnH5bjdAhWKliwKHaXFDwYQjRx6BAgBEAU&url=https%3A%2F%2Fwww.pexels.com%2Fsearch%2Fbeauty%2F&psig=AOvVaw3ZytY6Z9sL1rCIE7abC7_b&ust=1536956038178285", CreateDate=System.DateTime.Now},
        new Picture() { PictureId = 2, FileName = "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&ved=2ahUKEwj_v_bR5bjdAhXFZCwKHdfoDE8QjRx6BAgBEAU&url=https%3A%2F%2Fwww.gettyimages.ie%2F&psig=AOvVaw3ZytY6Z9sL1rCIE7abC7_b&ust=1536956038178285", CreateDate= System.DateTime.Now },
        new Picture() { PictureId = 3, FileName = "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&ved=2ahUKEwirjefX5bjdAhUGhiwKHSufAEcQjRx6BAgBEAU&url=https%3A%2F%2Fwww.w3schools.com%2Fw3css%2Fw3css_images.asp&psig=AOvVaw3ZytY6Z9sL1rCIE7abC7_b&ust=1536956038178285", CreateDate= System.DateTime.Now });
        }
    }
}
