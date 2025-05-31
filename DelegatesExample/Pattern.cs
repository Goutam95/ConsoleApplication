namespace DelegatesExample
{
    public static class Pattern
    {
        public static void RightAngleTrianglePattern()
        {
            Console.WriteLine("Enter the how many line star print");
            var number = Console.ReadLine();
            for (int i = 1; i <= int.Parse(number); ++i)
            {
                for(int j=1;j<=i;++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
        public static void InvertedAngleTrianglePattern() 
        {
            Console.WriteLine("Enter the how many line star print");
            var number = Console.ReadLine();
            for (int i = int.Parse(number); i >= 1; --i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}