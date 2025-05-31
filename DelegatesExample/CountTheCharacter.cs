using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public static class CountTheCharacter
    {
        public static void CountTheChar(string str)
        {
            var CountOfChar = new Dictionary<char, int>();
            foreach(var c in str) 
            {
                if (c != ' ')
                {
                    if (!CountOfChar.ContainsKey(c))
                    {
                        CountOfChar.Add(c, 1);
                    }
                    else 
                    { 
                        CountOfChar[c]++; 
                    }
                }
            }
            foreach (var item in CountOfChar)
            { 
                 Console.WriteLine("{0} - {1}", item.Key,item.Value);
            }

        }
    }
}
