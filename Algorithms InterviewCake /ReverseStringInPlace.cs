using System;


class ReverseStringInPlace
{
    public string ReverseString(string s)
    {
        char [] charArray= s.ToCharArray();
        
        int i=0;int j=charArray.Length-1;
        while (i<j)
        {
            char temp=charArray[i];
            charArray[i]=charArray[j];
            charArray[j]=temp;
            i++;
            j--;
        }
        return new string(charArray);   
    }
}
