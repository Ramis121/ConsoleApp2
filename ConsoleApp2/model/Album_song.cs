﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.model
{
    public partial class Album_song
    {
        public int Album_ID { get; set; }
        public int Song_ID { get; set; }
        public int Track_Number { get; set; }
        public virtual Album IdAlbumNavigation { get; set; }
        public virtual Album IdSongNavigation { get; set; }

    }
}