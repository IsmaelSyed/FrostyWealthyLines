using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What's on your mind?");
        string message = Console.ReadLine();

        if (IsMessageShortEnough(message))
        {
            Console.WriteLine("Posted");
        }
        else
        {
            Console.WriteLine("Rejected");
        }
    }

    static bool IsMessageShortEnough(string message)
    {
        const int maxLength = 140;
        return message.Length <= maxLength;
    }
}