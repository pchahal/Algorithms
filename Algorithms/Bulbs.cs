using System;
using System.Collections.Generic;

namespace Algorithms
{
    /*
    Given set of switches 1 is on 0 is off, flipping a switch toggles all switches to right
    //  return how many switches need to press to turn all On.
    Input : [0 1 0 1]
    Return : 4

    Explanation :
    press switch 0 : [1 0 1 0]
    press switch 1 : [1 1 0 1]
    press switch 2 : [1 1 1 0]
    press switch 3 : [1 1 1 1]
*/

    public class Bulbs
    {
        public int BulbsSwitch(List<int> A)
        {
            int numSwitchesFlipped = 0;
            int index = 0;
            while (index < A.Count)
            {
                if (A [index] == 1)
                {                   
                    index++;
                    continue;
                } else
                {
                    FlipSwitchesToRightOf(index, A);
                    numSwitchesFlipped++;
                    index++;
                }
            }

            return numSwitchesFlipped;
        }

        void  FlipSwitchesToRightOf(int index, List<int> A)
        {
            for (int i = index; i < A.Count; i++)
            {
                if (A [i] == 0)
                    A [i] = 1;
                else
                    A [i] = 0;
            }
        }
    }
}

