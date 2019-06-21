using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreScratchConsole
{
    class Program
    {
        // This whole project is a place to play and review!
        static void Main(string[] args)
        {
            // LINQ Refresher
            var bulldogs = GetRandomListOfBulldogs();
            //PrintBulldogs(bulldogs);

            //var blueBulldogs = GetBlueBulldogs(bulldogs);

            // Declarative Syntax
            //var query = from b in bulldogs where b.Color == "Blue" select b;

            //var query = bulldogs.Where(b => b.Color == "Blue").Select(b => b);
            //var blueBulldogs = query.ToList();

            var query = bulldogs.OrderByDescending(b => b.Id).Select(b => b.Id);

            query.ToList().ForEach(PrintInt);


            //PrintBulldogs();

        }

        static void PrintInt(int i)
        {
            Console.WriteLine(i);
        }

        static void PrintBulldogs(List<Bulldog> dogs)
        {
            dogs.ForEach(b =>
            {
                Console.WriteLine($"{b.Id}: {b.Name}, {b.Color}");
                // Add them to some other DB Table
            });
        }

        static List<Bulldog> GetRandomListOfBulldogs(int count = 100)
        {
            List<Bulldog> result = new List<Bulldog>();
            for (int i = 0; i < count; i++)
            {
                result.Add(new Bulldog()
                {
                    Id = i + 1,
                    Name = "Stout " + i,
                    Color = i % 2 == 0 ? "Blue" : "Pink"
                });
            }
            return result;
        }

        static void TestExtensionMethods()
        {
            // String - Append YEET to any string!
            //var result = AppendYeetToString("Hello World");
            //Console.WriteLine(result);

            //var aString = "";

            //aString.YEETinate();

            Console.WriteLine("This Rocks!".YEETinate());

            Console.WriteLine(100.Add(900));
        }

        static string AppendYeetToString(string theString)
        {
            return theString + " YEEEEET!";
        }
    }
}
