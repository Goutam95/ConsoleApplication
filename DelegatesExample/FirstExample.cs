//using System;

//namespace DelegatesExample
//{
//    public class FirstExample
//    {
//        delegate void paramPass(string p1);
//        static void Main(string[] args)
//        {
//            paramPass paramPass = new(paramExecutive);
//            Console.WriteLine("Enter your name");
//            var name = Console.ReadLine();
//            paramPass(name);
//            Console.ReadKey();
//        }

//        static void paramExecutive(string pa)
//        {
//            Console.WriteLine($"{DateTime.Now}: {pa}");
//        }
//    }
//}
