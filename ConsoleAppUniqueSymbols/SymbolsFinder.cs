using System;

namespace ConsoleAppUniqueSymbols
{
    static class SymbolsFinder
    {
        /// <summary>
        /// Returns the size of the max substring of unique symbols.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int MaxUniqueSubsequenceLength(this string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }
            if (str.Length == 1)
            {
                return 1;
            }

            int startIndex = 0;
            int startIndexMax = 0;
            int endIndexMax = 0;

            for (int i = 1; i < str.Length; i++)
            {
                int sameSymbolIndex = str.IndexOfNearestSameSymbol(i);

                if (sameSymbolIndex != -1 && sameSymbolIndex >= startIndex)
                {
                    startIndex = sameSymbolIndex + 1;
                    continue;
                }
                int newLength = i - startIndex + 1;
                if (endIndexMax - startIndexMax < newLength)
                {
                    startIndexMax = startIndex;
                    endIndexMax = i;
                    
                }
            }
            return endIndexMax - startIndexMax + 1;
        }

        /// <summary>
        ///  This method returns nearest from the left the same symbol's index to the symbol with index.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        /// <returns> </returns>
        private static int IndexOfNearestSameSymbol(this string str, int index)
        {
            int lastIndex = -1;
            if (str.Length < index + 1)
            {
                throw new ArgumentOutOfRangeException("Index more than string length");
            }

            for (int i = 0; i < index; i++)
            {
                if (str[i] == str[index])
                {
                    lastIndex = i;
                }
            }

            return lastIndex;
        }
    }
}
