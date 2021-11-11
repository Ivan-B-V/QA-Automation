using System;
using System.Collections.Generic;
using System.Text;


namespace NumberSystems
{
    class NumberSystemsConverter
    {
        //any number system
        // 2 and 20 in const
        public static string ConvertFromIntTo(int decNumber, int numberSystem)
        {
       

            if (numberSystem < 2 || numberSystem > 20)
            {
                throw new Exception($"Invalid number system. Should be between {2} and {20}.");
            }


            string outNumber = Converting(decNumber, numberSystem);

            return outNumber;
        }

        private static string Converting(int inputValue, int numberSystem)
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
