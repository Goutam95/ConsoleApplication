namespace DelegatesExample
{
    public class ReverseString
    {
        public static void RevString()
        {

            string inputValue = "Goutam Giri";
         //Initialization: We start by declaring a new string variable called revstring and initializing it with an empty string("").
            string revstring = string.Empty;
            //Using Linq and split fun
            string reverse = string.Join(" ", inputValue.Split(' ').Select(X => new string(X.Reverse().ToArray())));// out: matuoG iriG
            Console.WriteLine($"string reverse using Linq and split fun,the final values is = {reverse}");// 0ut:iriG matuoG

            //Using using Linq fun
            string reverseSpace = new(inputValue.ToCharArray().Reverse().ToArray());
            Console.WriteLine($"string reverse using Linq fun,the final values is = {reverseSpace}");

            //--using For Loop logic
            //The for loop iterates through the characters of the inputValue string.
            //The loop variable i is initialized with the length of inputValue minus 1(inputValue.Length - 1).
            //The loop continues as long as i is greater than or equal to 0.
            //In each iteration, the character at the current index i in inputValue is appended to the revstring.

            for (int i = inputValue.Length - 1; i >= 0; i--)
            {
                //By iterating from the end of the string to the beginning, we effectively reverse the order of characters.
               // For example, if inputValue is "hello", the resulting revstring will be "olleh".

                revstring += inputValue[i];   
            }
            Console.WriteLine($"string reverse using For Loop logic,the final values is = {revstring}");// 0ut:iriG matuoG
        }
    }
}