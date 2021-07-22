using ConsoleApp2.model;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Aplication())
            {
                context.Add(new Songs { song_title = "Лезгинка" });

                context.SaveChanges();
            }
        }
    }
}
