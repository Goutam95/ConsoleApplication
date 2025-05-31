namespace DelegatesExample
{
    public static class FindTheMissingNumber
    {
        public static void FindTheMissingNumbers()
        {
            int[] a = { 1, 2, 0, 4, 5,8 };
            int i = 0;
            for (int t=0; a.Max() != i;t++)
            {
                if (a.Contains(i))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
             
        }
    }
}
