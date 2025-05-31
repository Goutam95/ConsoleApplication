using Model;
using System.Collections.Generic;
using System.Reflection;

namespace DelegatesExample
{
    public class Coding
    {
        static readonly string input = "goutam giri";
        static string output = string.Empty;
        static readonly List<int> listInput = new() { 1, 5, 4, 3 };
        static readonly List<string> logEntries = new() { "s2 error", "s3 error", "s2 error","s2 error","s3 error","s3 error" };

        public static void Code()
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Print(output);
        }
        public static void Duplicate()
        {
            foreach (var t in input)
            {
                if (!output.Contains(t))
                {
                    output += t;
                }
            }
            Print(output);
        }
        public static void TwoMaxValueMultiply()
        {
            List<int> input = new() { 1, 5, 4, 3 };
            int firstMaxValue = 0;
            int secondMaxValue = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] >= firstMaxValue)
                {
                    firstMaxValue = input[i];
                }
                else
                {
                    if (input[i] >= secondMaxValue)
                    {
                        secondMaxValue = input[i];
                    }
                }
            }
            Console.WriteLine(firstMaxValue * secondMaxValue);
        }
        public static void TwoMinValueMultiply()
        {
            int firstMinValue = 0;
            int secondMinValue = 0;
            for (int i = 0; i < listInput.Count; i++)
            {
                if (listInput[i] != 0)
                {
                    if (listInput[i] >= firstMinValue)
                    {
                        firstMinValue = listInput[i];
                    }
                    else
                    {
                        if (listInput[i] <= secondMinValue)
                        {
                            secondMinValue = input[i];
                        }
                    }
                }
            }
            Console.WriteLine(firstMinValue * secondMinValue);
        }
        public static void FindTheMissingElement()
        {
            var arrayInput = new[] { 1, 0, 3, 4, 6, 7 };
            var maxValue   = arrayInput.Max();

            for (int i = 0; maxValue != i; i++)
            {
                if (!arrayInput.Contains(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PalindromCheck()
        {
            var input  = "238322";
            var output = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            if (input == output)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        public static void Factorial()
        {
            var input  = 7;
            int output = 1;
            for (int i = 1; i <= input; i++)
            {
                output *= i;
            }
            Console.WriteLine(output);
        }
        public static void FibonacciSequence()
        {
            var input    = 7;
            int[] output = new int[input];
            output[0] = 0;
            output[1] = 1;

            for (int i = 2; i < input; i++)
            {
                output[i] = output[i - 1] + output[i - 2];
            }
            foreach (int i in output)
            {
                Console.WriteLine(i + " ");
            }
        }
        public static void FindTheMaxSalary()
        {
            var emp = Data.GetEmployees();
            var result = emp.Where(a => a.Salary >= 500003);
            foreach (var i in result)
            {
                Console.WriteLine($"{i.FullName} : {i.Salary}");
            }
        }
        public static void PrimeNumber()
        {
            int input    = 17;
            bool isprime = true;
            if (input == 1)
            {
                isprime = false;
            }
            else
            {
                for (int i = 2; i < input; i++)
                {
                    if (input % 2 == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
            }
            if (!isprime)
            {
                Console.WriteLine("not prime");
            }
            else
            {
                Console.WriteLine("prime");
            }

        }
        public static void Reflection()
        {
            Type type = typeof(Employee);
            MethodInfo method = type.GetMethod("Print");
            Employee instance = new() { FullName = "John Doe", Id = 123, Email = "j@gmail.com" };
            method?.Invoke(instance, new object[] { "Hello" });
        }
        public static void Bill()
        {
            var input = new[] { 1, 2, 4, 7 };
            //sum=14, 14%4=3,14*4=56,14-4=10, sum of the value, and return the which method is big
            int sum = 0;
            Console.WriteLine();
        }
        public static void Print(string printValue)
        {
            Console.WriteLine(printValue);
        }
        public static int countReplacedEndpoints()
        {
            int n = 6;
            List<int> endpoints = new List<int> { };
            int count = 0, endpointcount = 0;
            foreach (var item in logEntries)
            {
                for (int i = 0; i < n; i++)
                {
                    if (logEntries.Contains(item))
                    {
                        endpointcount++;
                        if (endpointcount == 3)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}