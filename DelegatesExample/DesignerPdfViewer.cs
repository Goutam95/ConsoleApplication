using LanguageExt.Pipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class DesignerPdfViewer
    {

        public static int MultipleTheWords(List<int> h, string word)
        {
            int sum       = 0;
            int highValue = 0;
            
            if(h.Count != 0 && word !=string.Empty) 
            {
                Dictionary<char, int> charValues = new Dictionary<char, int>
                {
                    { 'a', 1 },{ 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'e', 5 },
                    { 'f', 6 },{ 'g', 7 }, { 'h', 8 }, { 'i', 9 }, { 'j', 10 },
                    { 'k', 11 },{ 'l', 12 }, { 'm', 13 }, { 'n', 14 }, { 'o', 15 },
                    { 'p', 16 }, { 'q', 17 }, { 'r', 18 }, { 's', 19 }, { 't', 20 },
                    { 'u', 21 }, { 'v', 22 }, { 'w', 23 }, { 'x', 24 }, { 'y', 25 },
                    { 'z', 26 }
                };
                foreach (char c in word)
                {
                    int currentValue = h[charValues[c] - 1];
                    if (currentValue >= highValue)
                    {
                        highValue = h[charValues[c] - 1];
                    }
                    sum ++; 
                }
                return sum * highValue;
            }
            else
            {
                return 0;
            }
           
        }
        public static void Mainss()
        {
           var reult= MultipleTheWords(new() { 1 ,3 ,1 ,3 ,1 ,4 ,1 ,3 ,2 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 }, "abc");
            Console.WriteLine(reult);
        }
    }
}
