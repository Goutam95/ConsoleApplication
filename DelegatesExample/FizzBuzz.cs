namespace DelegatesExample
{
    public class FizzBuzz
    {
        public static void FizzBuzzTheNum(int input)
        {
            int first  = 3, 
                second = 5;
            for (int i = 1; i <= input; i++) 
            {
                if(i % first == 0 && i % second ==  0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % first == 0)
                { 
                    Console.WriteLine("Fizz"); 
                }
                else if (i % second == 0) 
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
                       
        public static void Mainss(string[] args) 
        {
            FizzBuzzTheNum(15);
        }
    }
}
