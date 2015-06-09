using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestWebApplication1.Models
{
    public class Album  //the following are the items in an Album, also are the columns in the Album table in the database
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }  //calls the Artist class file, Models/Artist.cs

        public virtual List<Review> Review { get; set; }  //calls the Review class file, Models/Review.cs
    }
}