//int[] myArray     = new int[]{3, 4, 6, 10, 11, 15};
//int[] alicesArray = new int[]{1, 5, 8, 12, 14, 19,};

//System.out.println(mergeArrays(myArray, alicesArray));
// prints [1, 3, 4, 5, 6, 8, 10, 11, 12, 14, 15, 19]
using System;

public class MergeSortedArrays
{
    int[] mergeArrays(int[] firstArray, int[] secondArray)
    {
        int[] merged = new int[firstArray.Length + secondArray.Length];

        int firstPtr = firstArray.Length - 1;
        int secondPtr = secondArray.Length - 1;
        int mergePtr = merged.Length - 1;

        while (firstPtr >= 0 || secondPtr >= 0)
        {
          if (firstPtr >= 0 && secondPtr >= 0)
            {
                if (firstArray[firstPtr] > secondArray[secondPtr])
                {
                    merged[mergePtr] = firstArray[firstPtr];
                    firstPtr--;
                }
                else
                {
                    merged[mergePtr] = secondArray[secondPtr];
                    secondPtr--;
                }
            }

            else if (firstPtr>=0)
            {
                 merged[mergePtr] = firstArray[firstPtr];
                firstPtr--;
            }
            else if (secondPtr>=0)
            {
                 merged[mergePtr] = secondArray[secondPtr];
                secondPtr--;
            }


            mergePtr--;
        }




        return merged;
    }

    public void Test()
    {
        int[] myArray = new int[] { 3, 4, 6, 10, 11, 15 };
        int[] alicesArray = new int[] { 1, 5, 8, 12, 14, 19 };

        int[] merged = mergeArrays(myArray, alicesArray);
        foreach (var item in merged)
        {
            Console.WriteLine(item+",");
        }
        
    }
}