namespace DelegatesExample
{
    public class SumOfArray
    {
        public static int SimpleArraySum(int[] ar)
        {
            int sum = 0;
            if (ar == null)
            {
                return sum;
            }
            else
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    sum += ar[i];
                }
            }     
            return sum;
        }  
        static void Mainss(string[] args)
        {
            Console.WriteLine(SimpleArraySum(new[] { 1, 2, 4, 7 }));
        }
    }
}            
