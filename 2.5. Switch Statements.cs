using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a continents name.");

        string continent = Console.ReadLine();

        switch (continent)//expression
        {
            case "Antartica"://value 1
                Console.WriteLine($"Yes! {continent} is a Continent!");//statement to be executed
                break;

            case "Europe"://value 2
                Console.WriteLine($"Yes! {continent} is a Continent!");//statement to be executed
                break;

            case "Africa"://value 3
                Console.WriteLine($"Yes! {continent} is a Continent!");//statement to be executed
                break;

            case "America"://value 3
                Console.WriteLine($"Yes! {continent} is a Continent!");//statement to be executed
                break;

            case "Asia"://value 3
                Console.WriteLine($"Yes! {continent} is a Continent!");//statement to be executed
                break;

            case "Autralia"://value 3
                Console.WriteLine($"Yes! {continent} is a Continent!");//statement to be executed
                break;

            default:
                Console.WriteLine($"No. {continent} is not a Continent!");//statement to be executed if expression doesn't match any case
                break;

        }
    }
}