using System.Linq;
using System.Data.Entity;

namespace HotOrNot.WebUI.Models
{
    public class HotOrNotContext : DbContext, IHotOrNotContext
    {
        public HotOrNotContext() : base("name=HotOrNot")
        {

        }

        public DbSet<Picture> Pictures { get; set; }

        public Picture FindRandomPicture()
        {
            using (HotOrNotContext hotOrNotContext = new HotOrNotContext())
            {
                return hotOrNotContext.Pictures.OrderBy(o => System.Guid.NewGuid()).First();
            }
        }

        public void AddLikeOrDislike(int pictureId, bool flag)
        {
            using (HotOrNotContext hotOrNotContext = new HotOrNotContext())
            {
                if (flag == true)
                {
                    var MyPicture = hotOrNotContext.Pictures.Find(pictureId);
                    MyPicture.LikeCnt++;
                    hotOrNotContext.SaveChanges();
                }
                else
                {
                    var MyPicture = hotOrNotContext.Pictures.Find(pictureId);
                    MyPicture.DisLikeCnt++;
                    hotOrNotContext.SaveChanges();
                }
            }
        }

        public void Create(string MyFileName, string Mytitle, string Mydescription)
        {
            Picture picture = new Picture();
            using (HotOrNotContext hotOrNotContext = new HotOrNotContext())
            {
                var MaxPictureID = hotOrNotContext.Pictures.OrderByDescending(u => u.PictureId).FirstOrDefault();
                int NextID = MaxPictureID.PictureId;
                hotOrNotContext.Pictures.Add(new Picture { PictureId = NextID + 1, FilePath = MyFileName, Title = Mytitle, Description = Mydescription, LikeCnt = 0, DisLikeCnt = 0, CreateDate = System.DateTime.Now });
                hotOrNotContext.SaveChanges();
            }
        }
    }
}