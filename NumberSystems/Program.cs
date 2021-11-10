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
            
            //Console.WriteLine(~Convert.ToInt32(args[0]) + 1);
            Console.WriteLine(NumberSystemsConverter.ConvertFromIntTo(args[0], args[1]));
            Console.WriteLine((char)65);
        }
    }
}
