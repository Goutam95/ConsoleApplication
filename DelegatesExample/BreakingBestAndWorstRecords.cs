namespace DelegatesExample
{
    public class BreakingBestAndWorstRecords
    {
        public static List<int> FindTheBestAndWorstRecords(List<int> input)
        {
            List<int> maxValue = new(input[0]);
            List<int> minValue = new(input[0]);

            if (input == null)
            {
                Console.WriteLine("List cannot be null or empty");
                return new List<int>();
            }
            else
            {
                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i] > maxValue[i - 1])
                    {
                        maxValue.Add(input[i]);
                    }
                    else if (input[i] < maxValue[i - 1] || input[i] == maxValue[i - 1])   
                    { 
                        maxValue.Add(maxValue[i - 1]);
                    }
                    if (input[i] > minValue[i - 1])
                    {
                        minValue.Add(minValue[i - 1]);
                    }
                    else if (input[i] < minValue[i - 1] || input[i] == minValue[i - 1])
                    {
                        minValue.Add(input[i]); 
                    }
                }                                      

                maxValue.Remove(input[0]);
                List<int> maxList = maxValue.Distinct().ToList();
                if (maxList.Contains(input[0]))
                {
                    maxList.Remove(input[0]); 
                }

                minValue.Remove(input[0]);
                List<int> minList = minValue.Distinct().ToList();
                if (minList.Contains(input[0]))
                {
                    minList.Remove(input[0]);
                }
                return new List<int> { maxList.Count, minList.Count }; 
            }

        }

        public static void Mainss(string[] args)
        {
            Console.WriteLine(string.Join(" ", FindTheBestAndWorstRecords(new() { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 })));
        } 
    }
}
