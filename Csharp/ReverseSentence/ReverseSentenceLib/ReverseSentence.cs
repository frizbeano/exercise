using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentenceLib
{
    public class ReverseSentence
    {
        /// <summary>
        /// Reverse an array of chars.
        /// Example: STRING becomes GNIRTS
        /// </summary>
        /// <param name="inputArray">The char array</param>
        /// <returns>the reverse of the input inputArray</returns>
        public static char[] reverseSentencePrimitive(char[] inputArray)
        {

            if (inputArray == null || inputArray.Length < 1)
            {
                return inputArray;
            }

            char emptySpaceChar = ' ';
            char[] resultArray = new char[inputArray.Length];
            int indexMakerFront;
            int indexMarkerBack = inputArray.Length;
            int indexCurrentPosition = 0;

            for (int i = indexMarkerBack - 1; i >= -1; --i)
            {
                if (i == -1 || inputArray[i] == emptySpaceChar)
                {
                    indexMakerFront = i + 1;

                    for (int j = indexMakerFront; j < indexMarkerBack; ++j)
                    {
                        resultArray[indexCurrentPosition] = inputArray[j];
                        indexCurrentPosition++;
                    }

                    if (indexCurrentPosition < resultArray.Length)
                    {
                        resultArray[indexCurrentPosition] = emptySpaceChar;
                        indexCurrentPosition++;
                    }
                    indexMarkerBack = indexMakerFront - 1;
                }
            }
            return resultArray;
        }


        ///
        /// <summary>
        /// Reverse a string.
        /// Example: STRING becomes GNIRTS
        /// </summary>
        /// <param name="inputString">The string </param>
        /// <returns>the reverse of the input String</returns>
        public static String reverseSentence(String inputString)
        {

            if (inputString == null || inputString.Length < 1)
            {
                return inputString;
            }

            char[] emptySpaceString = { ' ' };
            StringBuilder result = new StringBuilder();
            String[] splitValues = inputString.Split(emptySpaceString);

            result.Append(splitValues[splitValues.Length - 1]);
            for (int i = splitValues.Length - 1; i > 0; i--)
            {
                result.Append(emptySpaceString).Append(splitValues[i - 1]);
            }
            return result.ToString();
        }

    }
}
