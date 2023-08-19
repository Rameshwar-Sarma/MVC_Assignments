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
            // Decaring and Assigning integral and fractional parts of values
            int decimalIntegralValueA = (int)valueA;
            int decimalIntegralValueB = (int)valueB;
            float decimalFractionalValueA = valueA - decimalIntegralValueA;
            float decimalFractionalValueB = valueB - decimalIntegralValueB;

            // Converting respective values to its binary values
            string binaryIntegralValueA = ConvertIntegralToBinary(decimalIntegralValueA);
            string binaryIntegralValueB = ConvertIntegralToBinary(decimalIntegralValueB);
            string binaryFractionalValueA = ConvertFractionalToBinary(decimalFractionalValueA);
            string binaryFractionalValueB = ConvertFractionalToBinary(decimalFractionalValueB);

            // Padding leading zeros and trailing zeros
            PaddingValues(ref binaryIntegralValueA, ref binaryIntegralValueB, true);
            PaddingValues(ref binaryFractionalValueA, ref binaryFractionalValueB, false);

            // resultant binary values
            String binaryValueA = "0" + binaryIntegralValueA +"."+ binaryFractionalValueA + "0";
            String binaryValueB = "0" + binaryIntegralValueB +"."+ binaryFractionalValueB + "0";

            // printing the resultant Binary values
            Console.WriteLine("BinaryValue of valueA : " + binaryValueA);
            Console.WriteLine("BinaryValue of valueB : " + binaryValueB);

            // creating and object to the class BonaryAddition to add binary values
            BinaryAddition addition = new BinaryAddition();

            // declaring resultant Binary Variables and carry variable
            int carry = 0;
            String finalBinaryFractionalValue = addition.AddingBinaries(binaryFractionalValueA, binaryFractionalValueB, ref carry);
            String finalBinaryIntegralValue = addition.AddingBinaries(binaryIntegralValueA, binaryIntegralValueB, ref carry);
           
            // printing the final binary value
            Console.WriteLine("Final Binary Value is : " + "0" + finalBinaryIntegralValue+ "." + finalBinaryFractionalValue + "0");


            int integralDecimal = 0;
            int integralPlaceValue = 1;

            // Converting Binary Value to Decimal Value of integral Part
            for(int i = finalBinaryIntegralValue.Length -1; i>=0; i--)
            {
                if (finalBinaryIntegralValue[i] == '1')
                {
                    integralDecimal += integralPlaceValue; 
                }
                integralPlaceValue *= 2;
            }

            double fractionalDecimal = 0;
            double fractionalPlaceValue = 0.5;

            // Converting Binary value to decimal Value of Fractional Part
            for (int i = 0; i < finalBinaryFractionalValue.Length; i++)
            {
                if (finalBinaryFractionalValue[i] == '1')
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
        public String ConvertIntegralToBinary(int intPartValue)
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
        public String ConvertFractionalToBinary(float  floatPartValue)
        {
            string binary = "";
            while (floatPartValue > 0 && binary.Length <32)
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
            int valueALength = valueA.Length;
            int valueBLength = valueB.Length;
            if(valueALength < valueBLength)
            {
                for(int i = 0; i < valueBLength - valueALength; i++)
                {
                    if (isIntegral)
                    {
                        valueA = "0" + valueA;
                    }
                    else
                    {
                        valueA =  valueA + "0";
                    }
                        
                }
            }
            else
            {
                for (int i = 0; i < valueALength - valueBLength; i++)
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

