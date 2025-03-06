//Try-Catch Blocks
try 
{
    string input = Console.ReadLine();
    int num = int.Parse(input);
    Console.WriteLine($"Your number is {num}");
    int quotient = 10 / num;
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch(DivideByZeroException ex) 
{ 
    Console.WriteLine(ex.Message);
}
catch { Console.WriteLine("An unexpected error occurred"); }