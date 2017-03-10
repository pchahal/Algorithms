using System;


namespace CTCI
{
    class ReverseVowels
    {

        private bool isVowel(char c)
        {
            const string vowels = "aeiou";
            return vowels.Contains(c.ToString());
        }

        public void reverseVowels(char[] s)
        {

            int i = 0;
            int j = s.Length - 1;

            bool foundLeft = false;
            bool foundRight = false;

            while (i < j)
            {
                if (isVowel(s[i]))
                    foundLeft = true;
                if (isVowel(s[j]))
                    foundRight = true;

                if (foundLeft && foundRight)
                {
                    char c = s[i];
                    s[i] = s[j];
                    s[j] = c;
                    i++;
                    j--;
                    foundLeft = false;
                    foundRight = false;
                }

                if (foundLeft && !foundRight)
                    j--;
                else if (!foundLeft && foundRight)
                {
                    i++;
                }
                else
                {
                    i++;
                    j--;
                }
            }
        }

        public void Test()
        {
            char[] array = new char[] { 'a', 'p', 'p', 'l', 'e' };
            reverseVowels(array);
            Console.WriteLine(array);


        }

    }
}