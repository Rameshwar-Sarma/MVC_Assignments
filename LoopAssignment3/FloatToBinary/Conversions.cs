using System;

namespace FloatToBinary
{
    internal class Conversions
    {
        /// <summary>
        /// this method return Final Float value to the Main method
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <returns></returns>
        public double FinalValue(float valueA, float valueB)
        {
            int NumericValueA = (int)valueA;
            int NumericValueB = (int)valueB;
            float FractionalValueA = valueA - NumericValueA;
            float FractionalValueB = valueB - NumericValueB;

            string binaryIntegralValueA = IntegralToBinary(NumericValueA);
            string binaryIntegralValueB = IntegralToBinary(NumericValueB);
            string binaryFractionalValueA = FractionalToBinary(FractionalValueA);
            string binaryFractionalValueB = FractionalToBinary(FractionalValueB);

            // Padding leading zeros and trailing zeros
            PaddingValues(ref binaryIntegralValueA, ref binaryIntegralValueB, true);
            PaddingValues(ref binaryFractionalValueA, ref binaryFractionalValueB, false);

            BinaryAddition addition = new BinaryAddition();

            // declaring resultant Binary Variables and carry variable
            int carry = 0;
            String binaryFractionalValue = addition.AddingBinaries(binaryFractionalValueA, binaryFractionalValueB, ref carry);
            String binaryIntegralValue = addition.AddingBinaries(binaryIntegralValueA, binaryIntegralValueB, ref carry);

            // printing the final binary value
            Console.WriteLine("Binary Value after adding is : " + "0" + binaryIntegralValue + "." + binaryFractionalValue + "0");


            int integralDecimal = 0;
            int integralPlaceValue = 1;

            // Converting Binary Value to Decimal Value of integral Part
            for (int i = binaryIntegralValue.Length - 1; i >= 0; i--)
            {
                if (binaryIntegralValue[i] == '1')
                {
                    integralDecimal += integralPlaceValue;
                }
                integralPlaceValue *= 2;
            }

            double fractionalDecimal = 0;
            double fractionalPlaceValue = 0.5;

            // Converting Binary value to decimal Value of Fractional Part
            for (int i = 0; i < binaryFractionalValue.Length; i++)
            {
                if (binaryFractionalValue[i] == '1')
                {
                    fractionalDecimal += fractionalPlaceValue;
                }
                fractionalPlaceValue *= 0.5;
            }
            return integralDecimal + fractionalDecimal;
        }
        /// <summary>
        /// Converting the Integral part of value to the binary value
        /// </summary>
        /// <param name="intPartValue"></param>
        /// <returns></returns>
        public String IntegralToBinary(int intPartValue)
        {
            if (intPartValue == 0)
                return "0";

            string binary = "";
            while (intPartValue > 0)
            {
                binary = (intPartValue & 1) + binary;
                intPartValue >>= 1;
            }
            return binary;
        }
        /// <summary>
        /// Converting the fractional value to the binary value
        /// </summary>
        /// <param name="floatPartValue"></param>
        /// <returns></returns>
        public String FractionalToBinary(float floatPartValue)
        {
            string binary = "";
            while (floatPartValue > 0 && binary.Length < 32)
            {
                floatPartValue *= 2;
                if (floatPartValue >= 1)
                {
                    binary += "1";
                    floatPartValue -= 1;
                }
                else
                {
                    binary += "0";
                }
            }
            return binary;
        }

        /// <summary>
        /// Padding the integral and decimal values with leading and trailing zeros
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="isIntegral"></param>
        public void PaddingValues(ref String valueA, ref String valueB, bool isIntegral)
        {
            int valueASize = valueA.Length;
            int valueBSize = valueB.Length;
            if (valueASize < valueBSize)
            {
                for (int i = 0; i < valueBSize - valueASize; i++)
                {
                    if (isIntegral)
                    {
                        valueA = "0" + valueA;
                    }
                    else
                    {
                        valueA = valueA + "0";
                    }
                }
            }
            else
            {
                for (int i = 0; i < valueASize - valueBSize; i++)
                {
                    if (isIntegral)
                    {
                        valueB = "0" + valueB;
                    }
                    else
                    {
                        valueB = valueB + "0";
                    }
                }
            }
        }
    }
}


