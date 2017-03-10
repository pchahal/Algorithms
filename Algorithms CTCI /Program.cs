using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;


namespace CTCI
{
    public class Program
    {
        delegate void MyDelegate();
        public static void Main(string[] args)
        {
            // new IsUnique().Test();
            //new CheckPermutation().Test();
            //new URLify().Test();
            //new OneAway().Test();
            //new StringCompression().Test();
            //new ReverseVowels().Test();
            //new RotationalSymmetry().Test();
            //new Islands().Test();
            // new RemoveDups().Test();
            //new Partition().Test();
            //new SumLists().Test();
            //new Palindrome().Test();
            //new FindInsertedString().Test();
            //new Intersection().Test();


            Func<int, int> myfunc = num => num * num;
            //Write(myfunc(2));

            string str = "this is a collection form par";

            var coll = str.Where(c => c = 'p');

            foreach (var item in coll)
            {
                System.Write(item);
            }


        }

        static void test2(MyDelegate del)
        {
            del();
        }


    }
}
