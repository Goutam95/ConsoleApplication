namespace DelegatesExample
{
    public static class Distinct
    {
        public static void DistinctNumber()
        {
            var listOfNumber = new List<int>() { 1,2,2,3,3,4};
            var list = listOfNumber.Distinct();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
