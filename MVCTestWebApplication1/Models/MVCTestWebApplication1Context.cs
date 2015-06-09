﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTestWebApplication1.Models
{
    public class MVCTestWebApplication1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVCTestWebApplication1Context() : base("name=MVCTestWebApplication1Context")
        {
        }

        public System.Data.Entity.DbSet<MVCTestWebApplication1.Models.Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<MVCTestWebApplication1.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MVCTestWebApplication1.Models.Artist> Artists { get; set; }
    
    }
}