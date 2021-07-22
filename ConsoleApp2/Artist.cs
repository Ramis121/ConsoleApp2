using ConsoleApp2.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Artist 
    {
        public int artist_id { get; set; }
        public int genge_id { get; set; }
        public int country_id { get; set; }
        public int artist_site_url { get; set; }
    }
}
