namespace DelegatesExample
{
    public class plusMinus
    {
        public static void PlusMinusCal(List<int> arr)
        {
            int countOfPositiveNum = 0;
            int countOfNegativeNum = 0;
            int CountOfZeronum     = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    countOfPositiveNum += 1;
                }
                else if (arr[i] < 0)
                {
                    countOfNegativeNum += 1;
                }                
                else
                {
                    CountOfZeronum+= 1;
                }
            }

            Console.WriteLine($"{(double)countOfPositiveNum / arr.Count:f6}");
            Console.WriteLine($"{(double)countOfNegativeNum / arr.Count:f6}");
            Console.WriteLine($"{(double)CountOfZeronum / arr.Count:f6}");
        }
        static void Mainss(string[] args)
        {
            List<int> input = new() { -1, 0, 4, 7 };
            PlusMinusCal(input);
        }
    }
}
