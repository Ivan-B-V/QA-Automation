using System;

namespace ConsoleAppUniqueSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid args array length.");
                return;
            }

            int count = args[0].MaxUniqueSubsequenceLength();

            Console.WriteLine($"Max unique symbols length: {count} ");
        }
    }
}
