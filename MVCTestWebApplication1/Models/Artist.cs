using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestWebApplication1.Models
{
    public class Artist  //the following are the columns in the Artist table in the database
    {
        public int ArtistID { get; set; }

        public String Name { get; set; }

        public List<Album> Albums { get; set; }  //calls the Album class file, Models/Album.cs
    }
}