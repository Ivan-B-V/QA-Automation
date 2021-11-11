using System;

namespace ConsoleAppUniqueSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            if (args.Length != 1)
            {
                Console.WriteLine("");
                return;
            }
            count = args[0].MaxUniqueSubsequenceLength();

            Console.WriteLine($"Max unique symbols length: {count} ");
        }
    }
}
