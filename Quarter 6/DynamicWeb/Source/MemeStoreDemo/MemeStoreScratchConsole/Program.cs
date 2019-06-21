using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreScratchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ Refresher
            var monsters = GetRandomListOfMonsters();

            //var query = from m in monsters where m.Color == "Blue" select m;

            //var query = monsters.Where(m => m.Color == "Blue").Select(m => m);
            //var blueMonsters = query.ToList();


            var query = monsters.OrderByDescending(m => m.Id).Select(m => m.Id);

            query.ToList().ForEach(i => Console.WriteLine(i));

            //PrintMonsters(blueMonsters);

        }

        static void printInt(int i)
        {
            Console.WriteLine(i);
        }
        static void PrintMonsters(List<Monster> monsters)
        {
            monsters.ForEach(m =>
            {
                Console.WriteLine($"{m.Id}: {m.Name}, {m.Color}");
            });
        }

        static List<Monster> GetRandomListOfMonsters(int count = 100)
        {
            List<Monster> result = new List<Monster>();
            for (int i = 0; i< count;i++)
            {
                result.Add(new Monster()
                {
                    Id = 1,
                    Name = "Lagiavrus",
                    Color = i % 2 == 0 ? "Blue" : "White"
                });
            }

            return result;
        }

    }
}
