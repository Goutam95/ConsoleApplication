namespace DelegatesExample
{
    public static class ReversedTheList
    {
        public static void ReversedTheData() 
        {
            string[] list  = new string[] { "abcd", "dce" };
            string[] lists = Array.Empty<string>();
            string revarsstring=string.Empty;
            foreach (var item in list)
            {
                for(int i = item.Length-1; i >= 0; i--)
                {
                    revarsstring += item[i];
                }
                Array.Resize(ref lists, lists.Length + 1);
                lists[lists.Length -1] = revarsstring;
                revarsstring           = string.Empty;
            }

            Console.WriteLine(string.Join(',',lists));
            //int[] a= { 1, 2, 3 };
            //Array.Reverse(a);
            // Console.WriteLine(string.Join(',',a));
        }
    }
}
