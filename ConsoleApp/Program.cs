using System;
using SamuriApp.Data;
using SamuriApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        public static SamuriDbContext context = new SamuriDbContext();

        static void Main(string[] args)
        {
              AddSamuriWithQuote();
            Console.WriteLine("Hello World!");
        }

     /*   public static void  AddSamuri(string name)
        {
            var clan = new Clan()
            {
                Name = name,

            };
            context.Clans.Add(clan);
            context.SaveChanges();
        }

        public static void GetSamuri()
        {
            var Samuri = context.Clans.ToList();
            foreach (var item in Samuri)
            {
                Console.WriteLine($"this is our samuri {item.Name.ToString()}");
            }
        }*/
        public static void AddSamuriWithQuote () {
            var Samuri = new Samuri () {
                Name = "damilola",
                Quotes = new List<Quote> () {
                    new Quote {
                        Text = "samuri is the greatest shinobi"
                    }
                }
            };
            context.Samuris.Add(Samuri);
            context.SaveChanges();
        }
    }
}