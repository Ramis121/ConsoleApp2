using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.model
{
    public class albums_songs
    {
        public int album_id { get; set; }
        public virtual Songs song_id { get; set; }
        public int track_number {get; set; }
    }
}
