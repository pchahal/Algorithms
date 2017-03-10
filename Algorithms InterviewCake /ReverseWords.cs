using System;

//Write a function reverseWords() that takes a string message and reverses
// the order of the words in-place ↴ .
//message = "find you will pain only go you recordings security the into if"
// returns: "if into the security recordings you go only pain will you find"
public class ReverseWords
{
    public string reverseWords(string words)
    {
        char[] charArray = words.ToCharArray();
        int length = words.Length;
        int i = 0; int j = words.Length - 1;

        while (i < j)
        {
            char tmp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = tmp;
            i++; j--;
        }

        i = 0;
        int space = Array.FindIndex(charArray, i, item => item == ' ');
        j = space - 1;

        while (i < j)
        {
            while (i < j)
            {
                char tmp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = tmp;
                i++; j--;
            }

            i = space+1;
            if (space==-1)
                break;

            space = Array.FindIndex(charArray, i, item => item == ' ');
            if (space==-1)
                j = words.Length-1;
            else
                j = space - 1;
        }
        return new string(charArray);
    }
}