namespace DelegatesExample
{
    public class TheFruteProblem
    {
        public static void TheFrute(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            List<int> applesPostion  = new();
            List<int> orangesPostion = new();
            int countOfApples  = 0, 
                countOfOranges = 0;
            if (s != 0 && t != 0 && a != 0 && b != 0 && apples != null && oranges != null) 
            {
                for (int i = 0; i < apples.Count; i++)
                {
                    applesPostion.Add(apples[i] + a);
                }

                for (int i = 0; i < oranges.Count; i++)
                {
                    orangesPostion.Add(oranges[i] + b);
                }

                for(int i = 0; i < applesPostion.Count; i++)
                {
                    if (applesPostion[i] >= s && applesPostion[i] <= t)
                    {
                        countOfApples++;
                    }
                }

                for (int i = 0; i < orangesPostion.Count; i++)
                {
                    if (orangesPostion[i] >= s && orangesPostion[i] <= t)
                    {
                        countOfOranges++;
                    }
                }
                Console.WriteLine(countOfApples);
                Console.WriteLine(countOfOranges);
            }
            else
            {
                Console.WriteLine("Given input variable cannot null or empty");
            }
        }

        public static void Mainss(string[] args)
        {
            TheFrute(7, 11, 5, 15, new() { -2, 2, 1 }, new() {5,-6 });
        }
    }                                                                  
}

//The first apple falls at position  = 5-2=3 .
//The second apple falls at position = 5+2=7 .
//The third apple falls at position  = 5+1=6 .
//The first orange falls at position = 15+5=20 .
//The second orange falls at position= 15-6=9 .
//Only one fruit (the second apple) falls within the region between 7 and 11, so we print 1 as our first line of output.
//Only the second orange falls within the region between 7 and 11, so we print 1 as our second line of output.
//output 1 1
   