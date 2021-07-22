using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.model
{
    public class Albums
    {
        public int artist_id { get; set; }
        public string album_title { get; set; }
        public int album_year { get; set; }
        public string albums_tracks { get; set; }

        public virtual albums_songs albums_id { get; set; }
    }
}
