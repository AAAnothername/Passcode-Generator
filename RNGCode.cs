//forgive me for how shitty this code is
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

public class Program
{
    public static void Main()
    {
        bool dying = false;
        int[] numbers = { };
        Console.WriteLine("Press Enter to generate your code...");
        Console.WriteLine("Press PageUp or PageDown to save your code to a text file...");
        Console.WriteLine("Press Escape to exit...");
        Console.WriteLine();
    _Generate:
        ConsoleKeyInfo result = Console.ReadKey();
        if ((result.KeyChar == 13) && (dying == false))
        {

        }
        ////THIS CODE IS UNSTABLE. ITS INTENDED TO WORK WHEN PRESSING PAGEUP OR PAGEDOWN, WHY THE FUCK WONT IT WORK
        //else if ((result.KeyChar == 33) || (result.KeyChar == 34) && (dying == false)
        //{
        //
        //}
        else if ((result.KeyChar == 27) && (dying == false))
        {
            Console.WriteLine();
            Console.WriteLine("Are you sure? Press Escape again to confirm.");
            Console.WriteLine();
            ConsoleKeyInfo confirmation = Console.ReadKey();
            if ((confirmation.KeyChar == 27))
            {
                dying = true;
                Console.WriteLine();
                Console.WriteLine("Shutting down...");
                Thread.Sleep(3000);
                System.Environment.Exit(0);
                Console.WriteLine("Shutdown failed, please try again.");
                goto _Generate;
                //might be archaic, but it works
                //it tells the program that its shutting off ("dying"), logs it, waits three seconds (for realism) and shuts down.
                //If it fails to shut down, it will log and let you input
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Shutdown cancelled.");
                Console.WriteLine();
                goto _Generate;
            }
        }
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
        x = r.Next(111111111, 999999999); //YOU CAN EDIT THIS TO INCREASE AMOUNT OF CODES

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
