namespace DelegatesExample
{
    public static class Filter
    {
        public static void Filtering()
        {
            var num     = new List<int>() { 1, 2,3,4,5,6};
            var evenNum = num.Where(x => x % 2 == 0).ToList();
            var oddNum  = num.Where(x => x % 2 != 0).ToList();

            Console.WriteLine("below the even numbers");
            foreach (var item in evenNum)
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("below the odd numbers");
            foreach (var item in oddNum)
            {
                Console.WriteLine(item); 
            }

        }
    }
}                  