
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a continents name.");

        string continent = Console.ReadLine();

        var output = mapswitch(continent);

        Console.WriteLine(output);
    }

    private static String mapswitch(string continent)
    {
        return continent switch
        {
            "Antartica" => $"Yes! {continent} is a Continent!",

            "Europe" => $"Yes! {continent} is a Continent!",

            "Africa" => $"Yes! {continent} is a Continent!",

            "America" => $"Yes! {continent} is a Continent!",

            "Asia" => $"Yes! {continent} is a Continent!",

            "Autralia" => $"Yes! {continent} is a Continent!",

            _ => $"No. {continent} is not a Continent!"

        };
    }
}