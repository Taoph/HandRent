using System;
using HandRent.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HandRent.Tests
{
    [TestClass]
    public class Prog
    {
        public static void Main(string[] args)
        {
            //using (HandRentDbContext db = new HandRentDbContext())
            //{
            //    db.Database.Delete();
            //    db.Database.Create();

            //}
            Console.WriteLine("OK");
            Console.ReadKey();
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
