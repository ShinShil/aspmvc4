using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _04_WebAPI.Models
{
    public class VideoDb : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}