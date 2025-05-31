namespace DelegatesExample
{
    public class TheHurdleRace
    {
        public static int TheRace(int k, List<int> height)
        {
            if(height.Max() >= k) 
            {
                return height.Max() - k;
            }
            return 0;
        }
        public static void Mainss (string[] args)
        { 
            Console.WriteLine(TheRace(4, new() { 1, 6 ,3 ,5 ,2 })); 
        }
    }
}