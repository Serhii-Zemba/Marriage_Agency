﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Marriage_Agency_Women_.Models.Woman
{
    public class WomanContext : DbContext
    {
        public DbSet<Woman> Women { get; set; }
    }
}