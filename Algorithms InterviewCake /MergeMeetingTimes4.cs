using System;
using System.Linq;
using System.Collections.Generic;

namespace InterviewCake
{

    /*  {startTime: 0,  endTime: 1},      01, 
        {startTime: 3,  endTime: 5},      01,35,
        {startTime: 4,  endTime: 8},      01,38
        {startTime: 9,  endTime: 10},     01,38,910
        {startTime: 10, endTime: 12},     01,38,912


        {startTime: 0, endTime: 1},
        {startTime: 3, endTime: 8},
        {startTime: 9, endTime: 12},

   
*/

    public class Meeting
    {
        

        int startTime;
        int endTime;


        public Meeting(int StartTime, int EndTime)
        {
            this.startTime = StartTime;
            this.endTime = EndTime;
        }

        public Meeting isOverlap(Meeting otherMeeting)
        {            
            if (this.endTime >= otherMeeting.startTime)
            {
                Meeting overlaped = new Meeting(Math.Min(this.startTime, otherMeeting.startTime), Math.Max(this.endTime, otherMeeting.endTime));
                return overlaped;
                    
            } else
                return null;


        }
      

    }



    public class MergeMeetingTimes
    {
        List <Meeting> condensedMeetings = new List<Meeting>();

        public List<Meeting> condenseMeetingTimes(List<Meeting> meetings)
        {
           
        

            for (int i = 0; i < meetings.Count; i++)
            {
                Meeting overlapedMeeting = meetings [i].isOverlap(meetings [i + 1]);
            
                if (overlapedMeeting != null)
                {
                    condensedMeetings.Add(overlapedMeeting);
                    i++;
                } else
                    condensedMeetings.Add(meetings [i]);
                    
            }


            return null;
        }

        public void Test()
        {
          

            List<Meeting> meetings = new List<Meeting>();
            meetings.Add(new Meeting(0, 1)); //01
            meetings.Add(new Meeting(3, 5)); //38
            meetings.Add(new Meeting(4, 8)); 
            meetings.Add(new Meeting(9, 10));
            meetings.Add(new Meeting(10, 12));
            condenseMeetingTimes(meetings);

            ToString();
        }


        public override string ToString()
        {
            string result = "";
            foreach (var item in condensedMeetings)
            {
                result += item.ToString();
            }
            return result;
        }
    }





}

