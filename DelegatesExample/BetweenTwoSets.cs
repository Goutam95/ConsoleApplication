using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class BetweenTwoSets
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            return 0;
        }
        public static void Main(string[]args) 
        {
            Console.WriteLine(GetTotalX(new() { 2, 4 }, new() { 16,32,96 }));

        }
    }
}
/*
 * Objective:

Find the count of integers x such that:

    Every element in array a is a factor of x (i.e., x % a[i] == 0 for all i).

    x is a factor of every element in array b (i.e., b[j] % x == 0 for all j).
 *input 
2 3
2 4
16 32 96

 *Explanation:

We are looking for numbers x that:

    Are multiples of 2 and 4 (from array a)

    Are factors of 16, 32, 96 (from array b)
 *Logic:

    Find LCM of array a: The number must be a multiple of all elements in a.

        LCM(2, 4) = 4

    Find GCD of array b: The number must divide all elements in b.

        GCD(16, 32, 96) = 16

    Count the number of multiples of LCM that evenly divide the GCD:

        Loop through all multiples of LCM (4, 8, 12, ...) up to GCD (16).

        For each, check if it divides the GCD.

        Valid values in this case: 4, 8, 16 → Count = 3

 */               
   