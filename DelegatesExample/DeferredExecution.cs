namespace DelegatesExample
{
    public class DeferredExecution
    {
        public static void DeferredExecutionExample()
        {
            var num= new List<int> { 1, 2, 3, 4, 5 };
            var Deferred = num.Where(n => n > 2);
            num.Add(6);
            foreach (var n in Deferred) 
            { 
                Console.WriteLine(n);
            }

        }
    }
}