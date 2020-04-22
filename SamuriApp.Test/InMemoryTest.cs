using NUnit.Framework;
using SamuriApp.Data;
using SamuriApp.Domain;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SamuriApp.Test
{
    public class InMemoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("CanInsertSamuri");
            using(var context = new SamuriDbContext(builder.Options)){
                var samuri = new Samuri();
                context.Samuris.Add(samuri);
                context.SaveChanges();
                Assert.AreNotEqual(0, samuri.Id);
            }
            Assert.Pass();
        }
    }
}