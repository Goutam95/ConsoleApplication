namespace DelegatesExample
{
    public class kangaroo
    {
        public static string SameDirectionJump(int x1, int v1, int x2, int v2)
        {

            if (x1 < x2 && v1 <= v2)
            {
                return "NO";
            }

            if (x2 < x1 && v2 <= v1)
            {
                return "NO";
            }

            if ((x2 - x1) % (v1 - v2) == 0)
            {
                return "YES";
            }
            return "NO";

        }
        public static void Mainss(string[] args) 
        {
            Console.WriteLine(SameDirectionJump(0,3,4,2));
        }
    }
}
     