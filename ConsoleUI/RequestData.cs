using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI;

public class RequestData
{
    public static string GetAString(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    public static double GetADouble(string message)
    {
        Console.Write(message);
        string numberText = Console.ReadLine();

        bool isDouble = double.TryParse(numberText, out double output);

        while (!isDouble)
        {
            Console.WriteLine("That was not a valid number. Please try again.");
            Console.WriteLine(message);
            numberText = Console.ReadLine();

            isDouble = double.TryParse(numberText, out output);
        }

        return output;
    }
}
