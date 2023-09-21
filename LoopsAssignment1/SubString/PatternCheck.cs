using System;

namespace SubString
{
    public class PatternCheck
    {
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

