using System;

//URLify: Write a method to replace all spaces in a string with '%20: 
//You may assume that the string has sufficient space at the end to hold the
// additional characters, and that you are given the "true" length of the string. 
// (Note: If implementing in Java, please use a character array so that you //can perform this operation in place.)
//
//EXAMPLE
//Input: "Mr John Smith" 13 Output: "Mr%20J ohn%20Smith"
namespace CTCI
{
    class URLify
    {
        public void ReplaceAllSpaces(char[] str, int len)
        {

            int urlIndex = str.Length - 1;
            int i = len - 1;
            while (i >= 0 && urlIndex >= 0)
            {
                if (str[i] == ' ')
                {
                    str[urlIndex] = '0';
                    str[urlIndex - 1] = '2';
                    str[urlIndex - 2] = '%';
                    urlIndex -= 2;
                }
                else
                    str[urlIndex] = str[i];


                i--;
                urlIndex--;
            }

            int z = 0;

        }

        public void Test()
        {
            char[] array = new char[] { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', '0', '0', '0', '0' };
            ReplaceAllSpaces(array, 13);
            Console.WriteLine(array);
        }


    }
}