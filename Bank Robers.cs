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
        var R = int.Parse(Console.ReadLine());
        var V = int.Parse(Console.ReadLine());
        var timesForVaults = new List<double>();
        var vaults = new List<int>();
        var result = 0;
        for (var i = 0; i < V; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            var C = int.Parse(inputs[0]);
            var N = int.Parse(inputs[1]);
            if (N > 0 && C-N>0)
            {
                var timeForVault = Math.Pow(10,N) * Math.Pow(5, C-N);
                timesForVaults.Add(timeForVault);
            } else if (N == C)
            {
                var timeForVault = Math.Pow(10,N);
                timesForVaults.Add(timeForVault);
            } else if (N == 0)
            {
                var timeForVault = Math.Pow(5, C);
                timesForVaults.Add(timeForVault);
            }

        }

        for (var i = R; i < timesForVaults.Count; i++)
        {
            timesForVaults[i] += timesForVaults[i-R];
                
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(timesForVaults.Max());
    }
}