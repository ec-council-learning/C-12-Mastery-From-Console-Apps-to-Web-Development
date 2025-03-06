class Program
{
    static void Main()
    {
        /* For Loops in C#
        for (int i = 7; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        //While Loops in C#
        int j = 7;
        while (j < 5)
        {
            Console.WriteLine($"While loop: {j}");
            j++;
        }


        //Do-While Loops in C#
        int k = 1;
        do
        {
            Console.WriteLine("Done: {0}", k);
            k++;
        } while (k < 6);
        */

        // Nested Loops
        for (int i = 0; i<5; i++) 
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}