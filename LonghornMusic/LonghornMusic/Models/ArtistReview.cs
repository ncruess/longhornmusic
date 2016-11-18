using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class ArtistReview
    {
        public Int32 ArtistReviewID { get; set; }

        [Required(ErrorMessage="Please select a score.")]
        [Display("Score")]
        public Int32 ArtistScore { get; set; }

        [Display("Review Text (optional)")]
        public string ArtistReviewText { get; set; }

        [Display("Artist")]
        public virtual Artist ReviewedArtist { get; set; }
    }
}