namespace DelegatesExample
{
    public static class FindAPeakInAGivenArray
    {
        public static void FindAPeakInAGivenArrays()
        {
            int []a = new int[] { 1, 3, 6,8,7 };
            int value=0;
            for (int i=1;i< a.Length;i++)
            {
                if (a[i] >= a[i - 1] && a[i] >= a[i + 1])
                    value = i;
            }
            Console.WriteLine(value);
        }
    }
}
