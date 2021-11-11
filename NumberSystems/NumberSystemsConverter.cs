using System;
using System.Collections.Generic;
using System.Text;


namespace NumberSystems
{
    class NumberSystemsConverter
    {
        private const int startNumberSystem = 2;
        private const int endNumberSystem = 20;
       
        public static string ConvertFromIntTo(int inputValue, int numberSystem)
        {

            if (numberSystem < startNumberSystem || numberSystem > endNumberSystem)
            {
                throw new Exception($"Invalid number system. Should be between {startNumberSystem} and {endNumberSystem}.");
            }

            StringBuilder binNumberStr = new StringBuilder();

            bool isNegative = false;
            if (inputValue < 0)
            {
                inputValue = -inputValue;
                isNegative = true;
            }

            do
            {
                int divRemaider = inputValue % numberSystem;
                if (divRemaider <= 10)
                {
                    binNumberStr.Insert(0, divRemaider);
                }
                else
                {
                    binNumberStr.Insert(0, (char)(55 + divRemaider)); // ACII 65(A)
                }
                //binNumberStr.Insert(0, divRemaider < 10 ? (char)divRemaider : (char)(55 + divRemaider));
                //binNumberStr.Insert(0, divRemaider < 10 ? divRemaider : Convert.ToChar(55 + divRemaider));
                inputValue /= numberSystem;
            } while (inputValue != 0);

            if (isNegative)
            {
                binNumberStr.Insert(0, "-");
            }

            return binNumberStr.ToString();
        }
    }
}
