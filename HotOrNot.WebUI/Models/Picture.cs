using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;


namespace HotOrNot.WebUI.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string FilePath { get; set; }
        public DateTime CreateDate { get; set; }
        public int LikeCnt { get; set; }
        public int DisLikeCnt { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}