using System;

namespace FloatToBinary
{
    internal class BinaryAddition
    {

        /// <summary>
        /// Adding the Binary values for the resultant binary value
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="carry"></param>
        /// <returns></returns>
        public String AddingBinaries(String valueA, String valueB, ref int carry)
        {
            String finalBinaryValue = "";

            for (int i = valueA.Length - 1; i >= 0; i--)
            {
                if (valueA[i] == '.' && valueB[i] == '.')
                {
                    finalBinaryValue = "." + finalBinaryValue;
                }
                if (valueA[i] == '0' && valueB[i] == '0')
                {
                    if (carry == 0)
                    {
                        finalBinaryValue = "0" + finalBinaryValue;
                    }
                    else
                    {
                        finalBinaryValue = "1" + finalBinaryValue;
                        carry = 0;
                    }
                }
                else if (valueA[i] == '1' && valueB[i] == '1')
                {
                    if (carry == 0)
                    {
                        finalBinaryValue = "0" + finalBinaryValue;
                        carry = 1;
                    }
                    else
                    {
                        finalBinaryValue = "1" + finalBinaryValue;
                    }
                }
                else
                {
                    if (carry == 0)
                    {
                        finalBinaryValue = "1" + finalBinaryValue;
                    }
                    else
                    {
                        finalBinaryValue = "0" + finalBinaryValue;
                        carry = 1;
                    }
                }
            }
            if (carry == 1)
            {
                finalBinaryValue = "1" + finalBinaryValue;
            }
            return finalBinaryValue;
        }
    }
}
