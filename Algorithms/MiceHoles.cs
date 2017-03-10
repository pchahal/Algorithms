using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class MiceHoles
    {
       
        // positions of mice are:
        // 4 -4 2
        //  positions of holes are:
        //  4 0 5
        public int miceHoles(List<int> A, List<int> B)
        {
            A.Sort();
            B.Sort();

            int maxTime = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int mouseTime = Math.Abs(A [i] - B [i]);
                if (mouseTime > maxTime)
                    maxTime = mouseTime;
            }
            return maxTime;
        }
    }
}
