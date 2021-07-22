using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.model
{
    public partial class Song
    {
        public Song()
        {
            Albums_Songs = new HashSet<Album_song>();
        }
        public int Song_ID { get; set; }
        public string Song_Title { get; set; }
        public virtual ICollection<Album_song> Albums_Songs { get; set; }
        public int Duration { get; set; }
    }
}
