using System;
using System.Collections.Generic;

namespace SamuriApp.Domain
{
    public class Samuri
    {
        public Samuri()
        {
            //ensure list of Quotes is instantiated before we try to use it in code
            Quotes = new List<Quote>();

        }

        public List<Quote> Quotes { get; set; } 
        public int Id { get; set; }
        public String Name { get; set; }
        public Clan Clan { get; set; }

    }
}
