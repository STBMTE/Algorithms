using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            ExponentiationAlgorithm ea = new ExponentiationAlgorithm(x);
        }
    }
}
