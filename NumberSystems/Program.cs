using System;

namespace NumberSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("First argument: decimal value, Second: number system.");
                return;
            }

            try
            {
                int value = Convert.ToInt32(args[0]);
                int dataBase = Convert.ToInt32(args[1]);
                Console.WriteLine(NumberSystemsConverter.ConvertFromIntTo(value, dataBase));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
