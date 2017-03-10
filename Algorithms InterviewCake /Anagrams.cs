using System;
using System.Collections.Generic;
using System.Text;

//also called RecursiveStringPermutation
public class Anagram
{
    //AB
    //A
    //AB  BA
    //CAB ACB ABC  CBA BCA BAC

    private void insertCharacterAtEveryIndex(List<string> potentialAnagramList, char currentChar, List<string> anagramList)
    {
        foreach (var potentialAnagram in potentialAnagramList)
        {
            for (int insertIndex = 0; insertIndex <= potentialAnagram.Length; insertIndex++)
            {
                StringBuilder sb = new StringBuilder(potentialAnagram);
                if (insertIndex < potentialAnagram.Length)
                    sb.Insert(insertIndex, currentChar);
                else
                    sb.Append(currentChar);
                anagramList.Add(sb.ToString());
            }
        }
    }

    public List<string> GetAnagrams(string original)
    {
        if (original.Length == 1)
        {
            List<string> result = new List<string>();
            result.Add(original);
            return result;
        }
        List<string> anagramList = new List<string>();
        char currChar = original[0];
        string subset = original.Substring(1, original.Length - 1);
        List<string> potentialAnagramList = GetAnagrams(subset);
        insertCharacterAtEveryIndex(potentialAnagramList, currChar, anagramList);
        return anagramList;
    }
}


