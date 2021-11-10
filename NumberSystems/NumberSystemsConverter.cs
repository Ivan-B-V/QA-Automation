using System;
using System.Collections.Generic;
using System.Text;


namespace NumberSystems
{
    class NumberSystemsConverter
    {
        //any number system
        public static string ConvertFromIntTo(string inputValue, string numberSystemStr)
        {
            int numberSystem = Convert.ToInt32(numberSystemStr);

            if (numberSystem < 2 || numberSystem > 20)
            {
                throw new Exception("Invalid number system. Should be between 10 and 20.");
            }

            if (inputValue.Length == 0)
            {
                throw new Exception("There is no inputValue.");
            }

            int decNumber = Convert.ToInt32(inputValue);

            StringBuilder outNumber = Converting(decNumber, numberSystem);

            return outNumber.ToString();
        }

        private static StringBuilder Converting(int inputValue, int numberSystem)
        {
           
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
                if (divRemaider < 10)
                {
                    binNumberStr.Insert(0, divRemaider);
                }
                else 
                {
                    binNumberStr.Insert(0, (char)(55 + divRemaider));
                }
                //binNumberStr.Insert(0, divRemaider < 10 ? (int)(char)divRemaider : (char)(55 + divRemaider));
                //binNumberStr.Insert(0, divRemaider < 10 ? divRemaider : Convert.ToChar(55 + divRemaider));
                inputValue /= numberSystem;
            } while (inputValue != 0);

            if (isNegative)
            {
                binNumberStr.Insert(0, "-");
            }

            return binNumberStr;
        }
    }
}
