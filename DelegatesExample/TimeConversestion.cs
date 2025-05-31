namespace DelegatesExample
{
    public class TimeConversestion
    {
        public static string TimeFormate(string s)
        {
            if(s != null) 
            {
                DateTime dateTime = DateTime.ParseExact(s, "hh:mm:sstt", null);
                return dateTime.ToString("HH:mm:ss");
            }
            else
            {
                return string.Empty;
            }
        }  
        public static void Mainee(string[] args) 
        {
            Console.WriteLine(TimeFormate("07:05:45PM"));
        }
    }
}         
