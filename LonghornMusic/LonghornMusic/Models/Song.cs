﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace longhornmusic.Models
{
    public class Song
    {
        public Int32 SongId { get; set; }

        public string SongName { get; set; }

        //TODO: Have calculated fields like Revenue, NumSold, Rating? 

        public virtual List<SongReview> SongReviews { get; set; }

        public virtual List<Arist> SongArtists { get; set; }

        public virtual Album SongAlbum { get; set; }

        public virtual List<Genre> SongGenres { get; set; }
    }
}