using CodilityTestProblems;
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class Solution
{
    static void Main(string[] args)
    {
        Console.Write("Please enter Message: ");
        string message = Console.ReadLine();

        Console.Write("Please enter number of characters in message: ");
        int numOfChars = int.Parse(Console.ReadLine());

        Service service = new Service();
        string messageOutput = service.ReturnMessage(message, numOfChars);

        Console.WriteLine($"Message: {messageOutput}");
    }
   
}
