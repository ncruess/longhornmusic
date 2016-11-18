using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class AlbumReview
    {
        public Int32 AlbumReviewID { get; set; }

        [Required(ErrorMessage = "Please select a score.")]
        [Display("Score")]
        public Int32 AlbumScore { get; set; }

        [Display("Review Text (optional)")]
        public string AlbumReviewText { get; set; }

        [Display("Album")]
        public virtual Artist ReviewedAlbum { get; set; }
    }
}