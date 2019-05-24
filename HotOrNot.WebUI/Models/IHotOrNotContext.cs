using System.Data.Entity;

namespace HotOrNot.WebUI.Models
{
    public interface IHotOrNotContext
    {
        DbSet<Picture> Pictures { get; set; }

        Picture FindRandomPicture();

        void AddLikeOrDislike(int pictureId, bool flag);

        void Create(string MyFileName, string Mytitle, string Mydescription);
    }
}