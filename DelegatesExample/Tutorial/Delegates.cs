using LanguageExt;

namespace DelegatesExample.Tutorial
{
    public class Delegates
    {
        // Define a delegate
        public delegate void PrintDelegate(string message);

        public static void Mainss(string[] args)
        {
            // Instantiate the delegate
            PrintDelegate print = PrintMessage;

            // Call the delegate
            print("World!");

            // Using an anonymous method
            static void printAnonymous(string msg)
            {
                Console.WriteLine("Anonymous: " + msg);
            }
            printAnonymous("Anonymous!");

            // Using a lambda expression
            static void printLambda(string msg) => Console.WriteLine("Lambda: " + msg);
            printLambda(" Lambda!");
        }

        // Method that matches the delegate signature
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
} 
//Delegates
/*
 Delegates in .NET are a type that represents references to methods with a specific parameter list and return type.
They are similar to function pointers in C++ but are type-safe and secure. 
Delegates are used to pass methods as arguments to other methods, 
define callback methods, and implement event handling.

Key Features of Delegates:
Type Safety: Delegates are type-safe, meaning the method signature must match the delegate signature.
Multicast: Delegates can hold references to multiple methods, allowing you to call multiple methods with a single delegate instance.

Anonymous Methods and Lambda Expressions: Delegates can be used with anonymous methods and lambda expressions for more concise code.

Explanation:

Defining a Delegate: The PrintDelegate delegate is defined to take a string parameter and return void.
Instantiating a Delegate: The print delegate is instantiated with the PrintMessage method.
Calling a Delegate: The print delegate is called with the argument "Hello, World!".
Anonymous Method: An anonymous method is assigned to the printAnonymous delegate.
Lambda Expression: A lambda expression is assigned to the printLambda delegate. 
 */    
 