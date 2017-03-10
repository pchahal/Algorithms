using System;
using System.Collections.Generic;

public class PermuationPalindrome
{

    //if length is even, and we have 2 chars for each letter, return true
    //if length is odd, every char should occur 2 times , except 1 letter occur 1 time
    //civic

    public bool isPermPalindrome(string word)
    {
        int length = word.Length;

        Dictionary<char, int> dict = new Dictionary<char, int>();

        int i = 0;
        int occurrences=0;
        while (i<word.Length)
        {
            
            if (dict.ContainsKey(word[i]))
                dict.Remove(word[i]);
            else
                dict[word[i]] = 1;
            i++;
        }

        
        foreach (var key in dict)
        {
            Console.WriteLine(key.Key + "," + key.Value);
        }

        if (word.Length%2==0)
            return dict.Count == 0;
        else
            return dict.Count == 1;

    }

}