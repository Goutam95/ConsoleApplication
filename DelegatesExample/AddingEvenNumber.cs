using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public static class AddingEvenNumber
    {
        public static void Additions()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            //int sumv    = 0;
            //foreach (int i in a) 
            //{
            //     if(i%2==0)
            //        { 
            //            sumv += i; 
            //        }
            //}
            
            Console.WriteLine(a.Where(i => i % 2 == 0).Sum(i => (long)i));// sum of even number
            Console.WriteLine(a.Where(i => i % 2 != 0).Sum(i => (long)i));// sum of non even number

        }
    }
}
