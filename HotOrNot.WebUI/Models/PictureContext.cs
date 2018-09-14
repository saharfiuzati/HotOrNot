using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HotOrNot.WebUI.Models
{
    public class HotOrNotContext: DbContext
    {
        public HotOrNotContext() : base("name=HotOrNot")
        {

        }

        public DbSet<Picture> Pictures { get; set; }
        
    }
}