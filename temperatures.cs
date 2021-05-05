using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        var maxDifference = Int32.MaxValue;
        var result = n > 0 ? Int32.MaxValue : 0;
        
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
            var difference = 0 + t;
            if (Math.Abs(difference) <= maxDifference)
            {
                maxDifference = Math.Abs(difference);
                result = t;
            }
        }

        if (result < 0 && inputs.Contains("" + Math.Abs(result)))
        {
            result = result * -1;
        }
        
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }
}