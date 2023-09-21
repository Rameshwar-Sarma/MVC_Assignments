using System;

namespace GreatestProduct
{
    /// <summary>
    /// This class is to find the greatest product of adjacent 4 numbers.
    /// </summary>
    public class Multiplication
    {
        public int FindIndex(String numbers, ref int MaxProduct)
        {
            int MaxProductIndex = 0;
            for (int StartIndex = 0; StartIndex < numbers.Length -3; StartIndex++)
            {
                int temp = 1;
                for(int loop = StartIndex; loop < StartIndex +4; loop++)
                {
                    temp *= Int32.Parse("" + numbers[loop]);
                }
                if (MaxProduct < temp)
                {
                    MaxProduct = temp;
                    MaxProductIndex = StartIndex;
                }
            }
            return MaxProductIndex;
        }
    }
}

