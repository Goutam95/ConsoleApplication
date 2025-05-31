namespace DelegatesExample
{
    public class FindTheTallestNumber
    {
        public static int CountTheTallestNumbers(List <int> input)
        {
           int count    = 0;
           int maxValue = input.Max();
            for (int i = 0; i < input.Count;i++)
            {
                if (input[i] == maxValue)
                {
                    count++;                               
                }
            }  
            return count;  
        } 
        public static void Mainss(string[] args) 
        {
           Console.WriteLine(CountTheTallestNumbers(new() { 3, 1, 2, 3 }));
        }
    }
}
