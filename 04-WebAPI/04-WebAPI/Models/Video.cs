﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04_WebAPI.Models
{
    public class Video
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual int Length { get; set; }
    }
}