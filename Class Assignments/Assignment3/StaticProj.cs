using System;

namespace StaticProj;
class FunctionCounter
{

    private static int count = 0;
    public static void CountFunction()
    {
        count++;  
        Console.WriteLine($"Function has been called {count} times.");
    }
}
internal class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        FunctionCounter.CountFunction();
        FunctionCounter.CountFunction();
        FunctionCounter.CountFunction();
        FunctionCounter.CountFunction();
    }
}
