using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.model
{
    public partial class Group
    {
        public int Artist_ID { get; set; }
        public string Group_Name { get; set; }
        public virtual Album IdArtistNavigation { get; set; }

    }
}
