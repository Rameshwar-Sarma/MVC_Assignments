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
            String BinaryValue = "";

            for (int i = valueA.Length - 1; i >= 0; i--)
            {
                if (valueA[i] == '.' && valueB[i] == '.')
                {
                    BinaryValue = "." + BinaryValue;
                }
                if (valueA[i] == '0' && valueB[i] == '0')
                {
                    if (carry == 0)
                    {
                        BinaryValue = "0" + BinaryValue;
                    }
                    else
                    {
                        BinaryValue = "1" + BinaryValue;
                        carry = 0;
                    }
                }
                else if (valueA[i] == '1' && valueB[i] == '1')
                {
                    if (carry == 0)
                    {
                        BinaryValue = "0" + BinaryValue;
                        carry = 1;
                    }
                    else
                    {
                        BinaryValue = "1" + BinaryValue;
                    }
                }
                else
                {
                    if (carry == 0)
                    {
                        BinaryValue = "1" + BinaryValue;
                    }
                    else
                    {
                        BinaryValue = "0" + BinaryValue;
                        carry = 1;
                    }
                }
            }
            if (carry == 1)
            {
                BinaryValue = "1" + BinaryValue;
            }
            return BinaryValue;
        }
    }
}

