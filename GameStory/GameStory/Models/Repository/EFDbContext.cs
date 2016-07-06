﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameStory.Models.Repository
{
    public   class EFDbContext:DbContext
    {   
       
      public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}