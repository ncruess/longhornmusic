using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class SongReview
    {
        public Int32 SongReviewID { get; set; }

        [Required(ErrorMessage = "Please select a score.")]
        [Display("Score")]
        public Int32 SongScore { get; set; }

        [Display("Review Text (optional)")]
        public string SongReviewText { get; set; }

        [Display("Song")]
        public virtual Song ReviewedSong { get; set; }
    }
}