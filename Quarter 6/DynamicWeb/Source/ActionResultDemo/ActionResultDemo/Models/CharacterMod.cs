using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActionResultDemo.Models
{
    public class CharacterMod
    {
        public String Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }

        public Dictionary<string, int> Attributes { get; set; }


        public CharacterMod()
        {
            Attributes = new Dictionary<string, int>
            {
                { "STR", 2 },
                { "PER", 5 },
                { "END", 1 },
                { "CHA", 10 },
                { "INT", 2 },
                { "AGI", 3 },
                { "LCK", 6 }
            };

        }

        override
        public string ToString()
        {
            String res = $"name = {Name}, Level = {Level}, Health Points = {HealthPoints}, Attributes = ";
            res += PrintDic();
            return res;
        }

        public String PrintDic()
        {
            String res = "";
            foreach(KeyValuePair<String, int> i in Attributes)
            {
                res += string.Format("  [{0} = {1}]  "+"", i.Key, i.Value);
            }
            return res;
        }
    }

  
}