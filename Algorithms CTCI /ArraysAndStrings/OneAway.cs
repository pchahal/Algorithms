using System;


//There are 3 types of edits that can be performed on strings.
//insert a char. remove a char. replace a char.
//given 2 strings write a function to check if they are  1 or 0 edits away
//EXAMPLE
//pale,  ple  -) true 
//pales, pale -) true 
//pale,  bale -) true 
//pale,  bae  -) false

class OneAway
{
    public bool isOneAway(string s1, string s2)
    {
        //check 0 edits
        if (string.Compare(s1, s2) == 0)
            return true;
        int diff = 0;

        //check Replace a Char
        if (s1.Length == s2.Length)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                    diff++;
            }
            if (diff > 1)
                return false;
        }
        //check Replace a Char

        int length = s1.Length < s2.Length ? s1.Length : s2.Length;
        if (Math.Abs(s1.Length - s2.Length) == 1)
        {
            int i = 0;
            int j = 0;
            while (i < s1.Length && j < s2.Length)
            {
                if (s1[i] != s2[j])
                {
                    if (s1.Length < s2.Length)

                        return s2.Substring(i + 1).CompareTo(s1.Substring(i)) == 0;
                    else
                        return s1.Substring(i + 1).CompareTo(s2.Substring(i)) == 0;

                }

                i++; j++;
            }

        }





        return true;
    }

    public void Test()
    {
        //pale,  ple  -) true 
        //pales, pale -) true 
        //pale,  bale -) true 
        //pale,  bae  -) false

        Console.WriteLine(isOneAway("pale", "ple"));
        Console.WriteLine(isOneAway("pales", "pale"));
        Console.WriteLine(isOneAway("pale", "bale"));
        Console.WriteLine(isOneAway("pale", "bae"));

    }
}