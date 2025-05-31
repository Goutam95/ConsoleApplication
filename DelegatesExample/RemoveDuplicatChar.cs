namespace DelegatesExample
{
    public static class RemoveDuplicatChar
    {
        public static void RemoveDuplicatCharacter(string str)
        { 
         string newString= string.Empty;
            for (int i = 0; i < str.Length; i++) 
            {
                if (!newString.Contains(str[i]))
                {
                    newString += str[i];
                }
            }
            Console.WriteLine(newString);
        }
    }
}