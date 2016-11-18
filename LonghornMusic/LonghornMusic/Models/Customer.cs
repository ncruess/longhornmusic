using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Customer : AppUser
    {
        public Int32 CustomerID { get; set; }

        [Display("Credit Cards")]
        public List<string> CreditCards { get; set; }

        [Display("Your Reviews")]
        public virtual List<Review> CustomerReviews { get; set; }

        [Display("Your Music Collection")]
        public virtual List<Song> MusicOwned { get; set; }

        [Display("Order History")]
        public virtual List<Purchase> OrderHistory { get; set; }
    }
}