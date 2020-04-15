using System;
using SamuriApp.Data;
using SamuriApp.Domain;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        //public static SamuriDbContext context = new SamuriDbContext();

        static void Main(string[] args)
        {
            /*context.Database.EnsureCreated();
            AddSamuri("Edward young");
            GetSamuri();*/
            Console.WriteLine("Hello World!");
        }

        /*public static void  AddSamuri(string name)
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
    }
}