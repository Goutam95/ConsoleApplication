namespace DelegatesExample
{
    public class MiniMaxSum
    {
        public static void MiniMaxAddition(List<int> input) 
        {
            int maxValueSum = 0;
            int minValueSum = 0;
            input.Reverse();
            input.Sort();
            if (input == null) 
            {
                Console.WriteLine("Given List is empty");
            }
            else
            {
                for (int j = 0; j < input.Count - 1; j++)
                {
                    minValueSum += input[j];
                }
                for (int k = 1; k < input.Count; k++)
                {
                    maxValueSum += input[k];
                }                                          
            }
            Console.WriteLine($"{minValueSum} {maxValueSum}");
        }
        static void Mainss(string[] args) 
        {
            List<int> list = new() { 5,5,5,5};
            MiniMaxAddition(list);
        }
    }
}
 