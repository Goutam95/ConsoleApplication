namespace DelegatesExample
{
    public class CalculateDiagonalDifference
    {
        public static int CalculateDiagonalArray(List<List<int>> arr)
        {
            int n              = arr.Count;
            int firstDiagonal  = 0;
            int secondDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                firstDiagonal  += arr[i][i];
                secondDiagonal += arr[i][n - 1 - i];
            }
            return Math.Abs(firstDiagonal - secondDiagonal);
        }
        public static void Mainss(string[] args) 
        {

            List<List<int>> arr = new()
            {
                 new List<int> { 1, 2, 3 },
                 new List<int> { 4, 5, 6 },
                 new List<int> { 9, 8, 9 }
            };

            Console.WriteLine(CalculateDiagonalArray(arr));
        }
    }
}

