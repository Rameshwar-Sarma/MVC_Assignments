using System;

namespace FindSubString
{
    internal class StringValidation
    {
        /// <summary>
        /// Checking the substring is valid of the main String
        /// </summary>
        /// <param name="str"></param>
        /// <param name="strLength"></param>
        /// <param name="subStr"></param>
        /// <param name="subStrLength"></param>
        /// <param name="strIndex"></param>
        /// <returns></returns>
        public bool isSubString(String str, int strLength, String subStr, int subStrLength, int strIndex)
        {
            for (int subStrIndex = 0; subStrIndex < subStrLength; subStrIndex++)
            {
                // checking the corresponding indexes holding same character ot not
                if (str[subStrIndex + strIndex] != subStr[subStrIndex])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
