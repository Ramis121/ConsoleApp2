using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.model
{
    public class Songs
    {
        public virtual albums_songs song_id { get; set; }
        public string song_title { get; set; }
        public string song_duration { get; set; }
    }
}
