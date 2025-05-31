using System.Numerics;

namespace DelegatesExample
{
    public class CompareTriplets
    {
        public static List<int> VectorTheValue(List<int> firstUser, List<int> secondUser) 
        {
            List<int> result = new();
            int a = 0, 
                b = 0;
            if(firstUser.Count == secondUser.Count)
            { 
            for(int i = 0; i < firstUser.Count; i++) 
                {
                    if (firstUser[i] > secondUser[i])
                    {
                        a++;
                    }
                    else if(firstUser[i] < secondUser[i])
                    {
                        b++;
                    }
                }
            }
            result.Add(a);
            result.Add(b);
            return result;
        }
        public static void Mainss(string[] args)
        {
            Console.WriteLine(string.Join(" ", VectorTheValue(new() { 5, 6, 7 }, new() { 3, 6, 10 })));
        }
    }
}
