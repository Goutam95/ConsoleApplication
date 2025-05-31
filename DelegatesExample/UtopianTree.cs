namespace DelegatesExample
{
    public class UtopianTree
    {
        public static int CountTheTree(int n)
        {
            int result = 1;
            if (n == 0) 
            {  
                return 1;
            }
            else 
            { 
                for (int i = 1; i <= n; i++) 
                { 
                    if(i%2 == 1)  
                    {
                        result*=2;
                    }
                    else
                    {  
                        result+=1; 
                    }
                }
                return result;
            }
        }
        public static void Mainss(string[] args)
        { 
            Console.WriteLine(CountTheTree(0));
        }
    }
}
 