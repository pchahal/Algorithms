using System;
using System.Collections.Generic;

namespace InterviewCake
{
    public class TempertureTracker
    {

        List<int> temps = new List<int>();
        Dictionary<int,int> modes = new Dictionary<int,int>();

        int mean = 0;
        int highestMode = 0;
        int sum = 0;


        public void insert(int temp)
        {
            temps.Insert(0, temp);
            temps.Sort();
            sum += temp;

            if (modes.ContainsKey(temp))
            {
                int mode = modes [temp];
                mode++;
                modes [temp] = mode;
                if (mode > highestMode)
                    highestMode = mode;
                    
            } else
                modes [temp] = 1;
        }

        public int getMax()
        {
            if (temps.Count > 0)
                return temps [temps.Count - 1];
            return -1;
        }

        public int getMin()
        {
            if (temps.Count > 0)
                return temps [0];
            return -1;
        }

        public int getMean()
        {
            return sum / temps.Count;
        }

        public int getMode()
        {
            return highestMode;
        }
    }
}

