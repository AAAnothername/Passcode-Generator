//forgive me for how shitty this code is
using System;
using System.Linq;
                    
public class Program
{
    public static void Main()
    {
        int[] numbers = { };
        Console.WriteLine("Press Enter to generate your code...");
    _Generate:
        ConsoleKeyInfo result = Console.ReadKey();
        if ((result.KeyChar == 13) || (result.KeyChar == 13))
        {

        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid Input.");
            goto _Generate;
        }
        Console.WriteLine();
        Console.WriteLine();

    _ReGenerate:
        int x = 0;
        bool taken = false;
        Console.WriteLine("Generated Code:");
        Random r = new Random(Guid.NewGuid().GetHashCode());
        x = r.Next(111111, 999999); //YOU CAN EDIT THIS TO INCREASE THE NUMBERS ON THE CODE

        if (numbers.Contains(x)) //trying to test if a number is taken in the array
        { taken = true; }

        if (taken == true)
        {
            Console.WriteLine(x + " | ERROR: Number already taken.");
            Console.WriteLine();
            goto _ReGenerate;
        }
        else
        {
            Console.WriteLine(x);
            numbers = numbers.Concat(new int[] { x }).ToArray();
        }
        Console.WriteLine("---------------");
        Console.WriteLine("Existing Codes:");
        foreach (var item in numbers)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine();
        goto _Generate;
    }
}
