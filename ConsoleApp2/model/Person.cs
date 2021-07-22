using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.model
{
    public partial class Person
    {
        public int Artist_ID { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public virtual Album IdArtistNavigation { get; set; }
    }
}
