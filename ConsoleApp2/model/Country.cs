using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.model
{
    public partial class Country
    {
        public Country()
        {
            Artists = new HashSet<Artist>();
        }
        public int Country_ID { get; set; }
        public string Country_Name { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
    }
}

