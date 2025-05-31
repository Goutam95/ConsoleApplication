namespace DelegatesExample
{
    public class StairCase
    {
        public static void StairCasePrint(int input)
        { 
            if (input == 0 || input < 0) 
            {
                Console.WriteLine("Value cannot null or negative");
            }
            else
            {
                for (int i = 1; i <= input; i++) 
                {
                    for (int j = input- i; j > 0; j--)  
                    {
                        Console.Write(" ");   
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }                                
        }      
        static void Mainss(string[] args)                                           
        {
             StairCasePrint(5);
        }
    }
}      