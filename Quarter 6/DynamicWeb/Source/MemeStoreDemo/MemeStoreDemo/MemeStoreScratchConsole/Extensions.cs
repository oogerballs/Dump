using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreScratchConsole
{
    public static class Extensions
    {
        public static string YEETinate(this string theString)
        {
            return theString + " YEEEEEEEET!";
        }

        public static int Add(this int theInt, int toAdd)
        {
            return theInt + toAdd;
        }

        public static string FreshAvacADoer(this string theString)
        {
            if (theString != "avacado")
                throw new Exception("Something bad happened!");

            return "Fresh Avac     a     do!";
        }
    }
}
