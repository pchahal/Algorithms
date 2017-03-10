using System;
using System.Text;
//String Compression: Implement a method to perform basic string compression 
//using the counts of repeated characters. For example, the string aabcccccaaa would 
//become a2blc5a3. If the "compressed"string would not become smaller than the original 
//string, your method should return the original //string. You can assume the string 
//has only uppercase and lowercase letters (a - z).

namespace CTCI
{
    class StringCompression
    {
        public string RLECompression(string input)
        {
            StringBuilder compressedStr = new StringBuilder();
            if (input.Length <= 1)
                return input;

            int count = 1;
            char prev = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == prev)
                {
                    count++;
                }
                else
                {
                    compressedStr.Append(prev.ToString() + count);
                    count = 1;
                }
                prev = input[i];
            }

            compressedStr.Append(prev.ToString() + count);
            return compressedStr.ToString();
        }

        public void Test()
        {
            string rle = RLECompression("aabcccccaaa");
            Console.WriteLine(rle);
        }
    }
}