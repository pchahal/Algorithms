using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Anagram
    {
        //input "ABC" return         
        //CAB ACB ABC  CBA BCA BAC
        public List<string> GetAnagrams(string original)
        {            
            if (original.Length == 1)
            {   
                List<string> result = new List<string>();
                result.Add(original);
                return result;
            }

            List<string> anagramList = new List<string>();
            anagramList = GetAnagrams(original.Substring(1));
            original = original.Substring(1, original.Length - 1);

            for (int i = 0; i < anagramList.Count; i++)
            {
                for (int j = 0; j <= anagramList [i].Length; j++)
                {
                    string anagram = anagramList [i];
                    anagram = anagram.Insert(j, original);
                    anagramList.Add(anagram);
                }
            }
            return anagramList;
        }
    }
}

