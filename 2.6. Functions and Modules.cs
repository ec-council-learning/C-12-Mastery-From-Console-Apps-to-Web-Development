using System;

class Program
{
    static void Main()
    {
        /* Defining a simple function
        int mod(int x, int y) 
        { 
            return x % y;
        }*/

        // Calling the function
        Console.WriteLine("Result: " + Remainder.mod(3, 2));
        Console.WriteLine("Result: " + Remainder.mod(5, 3));
        Console.WriteLine("Result: " + Remainder.mod(9, 5));
    }
}

class Remainder
{
    public static int mod(int x, int y)
    {
        return x % y;
    }
}