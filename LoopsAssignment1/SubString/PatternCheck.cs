using System;

namespace SubString
{
    internal class PatternCheck
    {
        /// <summary>
        /// this method returns true if substring found, false otherwise.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="pattern"></param>
        /// <param name="patternSize"></param>
        /// <param name="wordIndex"></param>
        /// <returns></returns>
        public bool isValid(String word, String pattern, int patternSize, int wordIndex)
        {
            for (int patternIndex = 0; patternIndex < patternSize; patternIndex++)
            {
                // checking the corresponding indexes holding same character ot not
                if (word[patternIndex + wordIndex] != pattern[patternIndex])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

