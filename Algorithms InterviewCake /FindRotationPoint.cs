using System;



namespace InterviewCake
{
    
public class FindRotationPoint
{   
    string[] words = new string[]{
    "ptolemaic",
    "retrograde",
    "supplant",
    "undulate",
    "xenoepist",
    "asymptote", // <-- rotates here return 5
    "babka",
    "banoffee",
    "engender",
    "karpatka",
    "othellolagkage",
    "x",
    "y",
    "z",
};


    private int BSRotPoint(string[] words, int min, int max)
    {
        int midPoint=(min+max)/2;

        int compare=string.Compare(words[min],words[midPoint]);
        
        if (compare==1) //B>A
            return BSRotPoint(words,min,midPoint);                        
        else if (compare==0)
            return max;
        else // -1   A<B
             return BSRotPoint(words,midPoint,max);

        
    }

    public int FindRotPoint(string[] words)
    {
        if (words.Length==0)
            return -1;

            int rotPoint=0;
        for (int i=1;i<words.Length;i++)
        {
            Console.WriteLine(words[i]);
            
            
            int compare=string.Compare(words[i],words[i+1]);
           // Console.Write(compare);
            if (compare==1)
            {   
                rotPoint=i+1;
                break;
            }
        }
        

        return rotPoint;;
    }

    public void TestRotPoint()
    {
        Console.WriteLine(BSRotPoint(words,0,words.Length));
    }
}    


}