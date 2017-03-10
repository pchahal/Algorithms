
using System;
using System.Collections.Generic;
//int[] unsortedScores = {37, 89, 41, 65, 91, 53};
//final int HIGHEST_POSSIBLE_SCORE = 100;

//int[] sortedScores = sortScores(unsortedScores, HIGHEST_POSSIBLE_SCORE);
// sortedScores: [37, 41, 53, 65, 89, 91]

public class TopScores
{
    public int[]  sortScores(int[] scores, int highestScore)
    {

        List<int> sortedScores = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();

        int i = 0;
        while (i<scores.Length)
        {
            if (dict.ContainsKey(scores[i]))
            {
                dict[scores[i]] = dict[scores[i]] + 1;
            }
            else
                dict[scores[i]] = 1;

            i++;
        }

        //foreach unique number in array
        //          foreach time number occurs

        
        for (i = 0; i < highestScore; i++)
        {
            int uniques = 0;    
            if (dict.ContainsKey(i))
                uniques = dict[i];
            for (int j = 0; j < uniques; j++)
            {

                sortedScores.Add(i);
                Console.WriteLine(i);
            }

        }


        return null;    
    }
}