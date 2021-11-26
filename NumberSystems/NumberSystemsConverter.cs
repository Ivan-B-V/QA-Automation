
namespace NumberSystems
{
    /// <summary>
    /// Converts a base data type to another base data type. 
    /// </summary>
    public class NumberSystemsConverter
    {
        private const int startNumberSystem = 2;
        private const int endNumberSystem = 20;

        /// <summary>
        /// Converts a base data type to another base data type from 2 to 20 base. 
        /// </summary>
        /// <param name="inputValue"> Integer value to convert. </param>
        /// <param name="numberSystem"> Base of data type to convert. </param>
        /// <returns> Converted input value to the set type in string format. </returns>
        /// <exception cref="System.ArgumentOutOfRangeException"> Input param numberSystem should be between 2 and 20. </exception>
        public static string ConvertFromIntTo(int inputValue, int numberSystem)
        {

            if (numberSystem < startNumberSystem || numberSystem > endNumberSystem)
            {
                throw new System.ArgumentOutOfRangeException(nameof(numberSystem), $"Invalid number system. Should be between {startNumberSystem} and {endNumberSystem}.");
            }

            System.Text.StringBuilder binNumberStr = new();

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
                    binNumberStr.Insert(0, (char)(55 + divRemaider)); // ACII 65(A)
                }
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
