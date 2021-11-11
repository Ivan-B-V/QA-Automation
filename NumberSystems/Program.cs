using System;

namespace NumberSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("First argument: decimal value, Second: number system.");
                return;

            }

            Console.WriteLine(NumberSystemsConverter.ConvertFromIntTo(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));
        }
    }
}
