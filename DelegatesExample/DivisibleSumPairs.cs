using LanguageExt.Common;

namespace DelegatesExample
{
    public class DivisibleSumPairs
    {
        public static int SumPairs(int n, int k, List<int> ar)
        {
            int sum = 0, countPairs = 0;
            if(n != 0 && k != 0 && ar != null)
            { 
                for(int i = 0; i < ar.Count; i++)
                {
                    for (int j = i+1; j < ar.Count; j++)
                    {
                        sum = ar[i] + ar[j];
                        if (sum % k == 0)
                        {
                            countPairs++;
                        }
                    }
                }
                return countPairs;
            }
            else
            {      
                Console.WriteLine("Given input variable cannot null or empty");
            }
            return 0; 
        }
        public static void Mainee(string[] args) 
        {
            int result = SumPairs(6, 3, new() { 1, 3, 2, 6, 1, 2 });
            Console.WriteLine(result);
        }
    }
}
//Here are the 5 valid pairs when k=3 : 
//(0,2) -> ar[1] + ar[2] = 3
//(0,5) -> ar[1] + ar[2] = 3
//(1,3) -> ar[3] + ar[6] = 9
//(2,4) -> ar[2] + ar[1] = 3
//(4,5) -> ar[1] + ar[2] = 3
//return 5