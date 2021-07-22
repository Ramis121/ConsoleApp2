using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.model
{
    public class Persons
    {
        public virtual Artist artist_id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public DateTime birchday { get; set; }
        public int MyProperty { get; set; }
    }
}
