using System;
using System.Collections.Generic;

namespace Algorithms
{
    
    public class FatFingers
    {
        //for a give character return all nearby characters
        public char[] GetNearbyChars(char c)
        {
            if (c == 'h')
                return new char[] { 'g', 'h', 'j' };
            if (c == 'g')
                return new char[] { 'g', 'h', 'j' };
            if (c == 'o')
                return new char[] { 'i', 'p', 'l' };
            
            return new char[] { };
        }

        public bool isWord(string word)
        {
            if (word == "hello")
                return true;
            if (word == "gelll")
                return true;
            
            return false;        
        }

        public List<string> nearby_words(string word)
        {
            //get all perms of words for each char in word
            //check if its a word
            //if so add to nearbyWords list
            List<string> nearbyWords = new  List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                char[] nearbyChars = GetNearbyChars(word [i]);

                foreach (var nearbyChar in nearbyChars)
                {                    
                    string newWord = word.Remove(i, 1);
                    newWord = newWord.Insert(i, nearbyChar.ToString());
                   
                    Console.WriteLine(newWord);
                    if (isWord(newWord))
                        nearbyWords.Add(newWord);                    
                }
            }
            return nearbyWords;
        }
    }
}

