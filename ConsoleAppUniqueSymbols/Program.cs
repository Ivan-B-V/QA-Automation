using System;

namespace ConsoleAppUniqueSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            if (args.Length != 0)
            {
                //Console.WriteLine(args[0].IndexOfNearestSameSymbol(args[0].Length -1 ));
                count = args[0].MaxUniqueSubsequenceLength();
            }
            

            Console.WriteLine($"Max unique symbols length: {count} ");
        }
    }
}
