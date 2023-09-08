using System;

namespace GreatestProduct
{
    /// <summary>
    /// This class aim is to find the greatest product of adjacent 4 numbers.
    /// </summary>
    internal class Multiplication
    {
        /// <summary>
        /// Finding the Index of the Greatest Product.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="MaxProduct"></param>
        /// <returns></returns>
        public int FindIndex(String numbers, ref int MaxProduct)
        {
            int MaxProductIndex = 0;
            for (int loop = 0; loop < numbers.Length -3; loop++)
            {
                int temp = 1;
                for(int index = loop; index < loop +4; index++)
                {
                    temp *= Int32.Parse("" + numbers[index]);
                }
                if (MaxProduct < temp)
                {
                    MaxProduct = temp;
                    MaxProductIndex = loop;
                }
            }
            return MaxProductIndex;
        }
    }
}

