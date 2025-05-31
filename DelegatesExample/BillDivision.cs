namespace DelegatesExample
{
    public class BillDivision
    {
        public static void Bill(List<int> bill, int k, int b)
        {
            if (bill != null && k != 0 && b != 0)
            {
                int removeItem = bill[k];
                int SumOfArray = 0;
                for (int i = 0; i < bill.Count; i++)
                {
                    SumOfArray += bill[i];
                }
                SumOfArray = (SumOfArray - removeItem) /2;
                if (SumOfArray == b) 
                {
                    Console.WriteLine("Bon Appetit");
                }
                else
                {
                    Console.WriteLine(b - SumOfArray);
                }
            }
            else        
            {      
                Console.WriteLine("Value Cannot be null or empty");
            }
        }
        public static void Mainss() 
        {
            Bill(new() { 3, 10, 2, 9 }, 1, 7);
        }                        
    }       
}
//4 1
//3 10 2 9
//12
//Scenario: Anna didn't eat one of the items on the bill, which cost $10.
//Shared Items: The total cost of the shared items is $14 (3 + 2 + 9).
//Cost Per Person: The cost per person is $7 (14 / 2).
//Overcharge: Brian charged Anna $12 instead of $7, so she was overcharged by $5 (12 - 7).