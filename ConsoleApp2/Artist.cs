using ConsoleApp2.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public partial class Artist
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
            Groups = new HashSet<Group>();
            Persons = new HashSet<Person>();
        }
        public int Artit_ID { get; set; }
        public int Genre_ID { get; set; }
        public int Country_ID { get; set; }
        public string Artist_Site_URL { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Person> Persons { get; set; }

        public virtual Album IdGenreNavigation { get; set; }
        public virtual Album IdCountryNavigation { get; set; }

    }
}
