using System;
using System.Linq;

namespace InterviewCake
{
    //Given an arrayOfInts, find the highestProduct you can get from three of the integers.
    //The input arrayOfInts will always have at least three integers.
    //2,-4,2,-3,5,-6
  
    /*
    2,-4,2    -> -16
    2,-4,-3   ->  24
    5,-4,-3   ->60
    5,-4,-6   ->120
*/





    public class HighestProductOf3
    {
        public int HighestProduct(int[] array)
        {
            int highestProduct = array [0] * array [1] * array [2];

          



            getMaxProductFromFour(array, highestProduct, array [3]);

            return 0;
        }

        // 2,-4,2      max=-16    next=-3
        private int getMaxProductFromFour(int[] array, int currentMaxProduct, int nextNum)
        {
            int productIndex = -1;


            int p0 = nextNum * array [1] * array [2];
            if (p0 > currentMaxProduct)
            {
                currentMaxProduct = p0;
                productIndex = 0;
            }
        
            int p1 = array [0] * nextNum * array [2];           
            if (p1 > currentMaxProduct)
            {
                currentMaxProduct = p1;
                productIndex = 1;
            }
            int p2 = array [0] * array [2] * nextNum;
            if (p2 > currentMaxProduct)
            {
                currentMaxProduct = p2;
                productIndex = 2;
            }

            if (productIndex != 0)
            {
                array [productIndex] = nextNum;
            }

            return currentMaxProduct;
            Console.WriteLine(currentMaxProduct + ", " + productIndex);

        }
    }
}

