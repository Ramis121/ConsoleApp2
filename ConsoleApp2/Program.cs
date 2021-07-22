using ConsoleApp2.model;
using ExamWork.DataAccess;
using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var f = context.Countries;
                f.Add(new Country { Country_ID = 12 });

                context.SaveChanges();

                foreach (var item in f)
                {
                    Console.WriteLine("{0}", item.Country_ID); 
                }
            }
        }
    }
}
