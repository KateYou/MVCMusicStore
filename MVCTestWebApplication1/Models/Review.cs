using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTestWebApplication1.Models
{
    public class Review  //the following are the elements of a review, also are the columns in the Review table in the database
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }

        public string Contents { get; set; }

        [Display(Name="Reviewer's Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}