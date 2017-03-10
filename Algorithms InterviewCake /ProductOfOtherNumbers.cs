using System;

namespace InterviewCake
{

    //Write a function getProductsOfAllIntsExceptAtIndex() that takes an array of integers
    //and returns an array of the products. dont use division

    //Input    [1,  7,  3,  4]
    //Output   [84, 12, 28, 21]
    //
    //[7*3*4, 1*3*4, 1*7*4, 1*7*3]

    public class ProductOfOtherNumbers
    {
        public int[] getProductsOfAllIntsExceptAtIndex(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array [i];            
            }

            for (int i = 0; i < array.Length; i++)
            {
                           
            }



            Console.Write(product);

            return null;
        }
    }
}

