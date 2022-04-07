//forgive me for how shitty this code is
using System;
using System.Linq;
                    
public class Program
{
    public static void Main()
    {
        int[] numbers = { };
        Console.WriteLine("Press Enter to generate your code...");
        Console.WriteLine("Press PageUp or PageDown to save your code to a text file...");
        Console.WriteLine();
        _Generate:
        ConsoleKeyInfo result = Console.ReadKey();
        if ((result.KeyChar == 13))
        {

        }
        ////THIS CODE IS UNSTABLE. ITS INTENDED TO WORK WHEN PRESSING PAGEUP OR PAGEDOWN, WHY THE FUCK WONT IT WORK
        //else if ((result.KeyChar == 33) || (result.KeyChar == 34))
        //{
        //
        //}
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid Input.");
            Console.WriteLine();
            goto _Generate;
        }
        Console.WriteLine();
        Console.WriteLine();

    _ReGenerate:
        int x = 0;
        bool taken = false;
        Console.WriteLine("Generated Code:");
        Random r = new Random(Guid.NewGuid().GetHashCode());
        x = r.Next(111111, 999999); //YOU CAN EDIT THIS TO INCREASE AMOUNT OF CODES

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
