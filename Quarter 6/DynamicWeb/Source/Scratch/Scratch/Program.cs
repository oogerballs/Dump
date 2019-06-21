using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> favs = new Dictionary<string, string>
            {
                { "Book", "The Silent Girls" },
                { "Game", "Left 4 Dead 2" },
                { "Movie", "Logan" }
            };


            foreach (KeyValuePair<String,String> item in favs)
            {
                Console.WriteLine($"The type is {item.Key}, and the item is {item.Value}.");
            }

        }
    }
}
