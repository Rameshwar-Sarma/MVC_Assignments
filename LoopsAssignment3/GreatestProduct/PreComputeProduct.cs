using System;

namespace GreatestProduct
{
    internal class PreComputeProduct
    {
        /// <summary>
        /// Filling the PreDefined array
        /// </summary>
        /// <param name="PreDefined"></param>
        /// <param name="Numbers"></param>
        public void FillPreDefined(ref int[] PreDefined, String Numbers)
        {
            PreDefined[0] = Int32.Parse("" + Numbers[0]);
            for (int i = 1; i < PreDefined.Length; i++)
            {
                // each block of array holds multiplication from 0 index to current index
                PreDefined[i] = PreDefined[i - 1] * Int32.Parse("" + Numbers[i]);
            }
        }

        /// <summary>
        /// Finding the Greates Product by using the Predefined Array
        /// </summary>
        /// <param name="preDefined"></param>
        /// <param name="numbers"></param>
        /// <param name="greatestProduct"></param>
        /// <returns></returns>
        public int FindProductIndex(int[] preDefined, String numbers,ref int greatestProduct)
        {
            int greatestProductEndIndex = 3;
            for (int loop = 4; loop < numbers.Length; loop++)
            {
                // finding the 4 adjacent multiplication 
                int productValue = preDefined[loop] / preDefined[loop - 4];
                if (productValue > greatestProduct)
                {
                    // assigning greatese Multiplication value to the variable
                    greatestProduct = productValue;
                    greatestProductEndIndex = loop;
                }
            }
            // returning the ending index of the greatest product values
            return greatestProductEndIndex;
        }
    }
}
