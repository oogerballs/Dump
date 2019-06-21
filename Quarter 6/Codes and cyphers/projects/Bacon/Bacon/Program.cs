using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacon
{
    class Program
    {
        static void Main(string[] args)
        {
            Input();
        }

        private static void Input()
        {
            Console.WriteLine("Write the word");
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    numbers.Add(1);
                }
                else
                {
                    numbers.Add(0);
                }
            }

            int inc = 1;
            foreach(int i in numbers)
            {
                Console.Write(i);
                if(inc % 5 == 0)
                {
                    Console.Write("|");
                }
                inc += 1;
            }
        }

        private static string WallOfIf(List<int> nums)
        {
            int inc = 0;
            for (int i = 1; i < nums.Count+1; i++)
            {
                inc += nums[i];
                if (i % 5 == 0)
                {
                    if (inc == 0)
                    {

                    }else if( inc == 1)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 3)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }
                    else if (inc == 2)
                    {

                    }

                    inc = 0;
                }
            }

            return "";
        }

    }
}
