using System;


namespace CTCI
{
    class FindInsertedString
    {
        //two sorted strings find where extra inserted char is in s2
        //  s1= abcdef      s2= abcxdef
        //assume unique chars
        public char findInsertedString(string s1, string s2, int low, int high)
        {

            if (s1[low] != s2[low])
                return s2[low];

            int midPoint = (high - low) / 2 + low;


            if (s1[low] == s2[low])
                return findInsertedString(s1, s2, midPoint, high);
            else
                return findInsertedString(s1, s2, low, midPoint);


        }


        public void Test()
        {

            Console.WriteLine(findInsertedString("abcdefgh", "abcdefZgh", 0, 9));

            //abcdefghijklmnopqrstuvwxyz
            //abcdefghijklmnopqrstuvwxZyz
        }

    }
}