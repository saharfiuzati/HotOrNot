﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;


namespace HotOrNot.WebUI.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string FileName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}