using System;
using System.Collections.Generic;

public class WorldCloudData
{
    string delimeters = ".,;:?!() ";
    //Input: "After beating the eggs, Dana read the next step:")
    //Output: {"after"=>1, "beating"=>1, "the"=>2, "eggs"=>1, "dana"=>1, "read"=>1, "next"=>1, "step"=>1}
    public Dictionary<string, int> GetWorldCloud(string words)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int wordStart = 0;
        int wordEnd = 0;

        wordStart = advanceToNextChar(0, words);
        int i = wordStart;
        while (i<words.Length)
        {
            if (delimeters.Contains(words[i].ToString()))
            {
                wordEnd = i-1;
                AddToDict(dict, wordStart, wordEnd, words);
                wordStart = advanceToNextChar(i,words);
                i = wordStart;
            }
            else
                i++;
        }
        return dict;
    }

  
    public int advanceToNextChar(int i, string words)
    {   
        while (i<words.Length)
        {
            if (!delimeters.Contains(words[i].ToString()))
                break;

            i++;
        }
        return i;
    }

    void AddToDict(Dictionary<string, int> dict, int wordStart, int wordEnd, string words)
    {

        string word = words.Substring(wordStart, wordEnd - wordStart+1);
        
        if (dict.ContainsKey(word))
        {
            int count = dict[word];
            count++;
            dict[word] = count;
        }
        else
            dict[word] = 1;
    }


 

  public void Test()
 {
        Dictionary<string, int> cloud = GetWorldCloud("After beating the eggs, Dana read the next step:");
        
        cloud = GetWorldCloud("Add milk and eggs, then add flour and sugar.");


 }

  
}