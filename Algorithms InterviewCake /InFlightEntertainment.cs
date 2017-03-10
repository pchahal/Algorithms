using System;
using System.Collections.Generic;
//needs more work shouldnt return 2,2
//need to subtract dict entries after using them in result

//Write a function that takes an integer flightLength (in minutes) and an array of //integers movieLengths (in minutes)
// and returns a boolean indicating whether there are
//two numbers in movieLengths whose sum equals flightLength.

//1,1
//2,1
//4,1
//3,1
//flight=4
class InFlightEntertainment
{
    public bool flightLength (int flightLength,int[] movieLengths) 
    {
        
        Dictionary<int,int> moviesDict= new Dictionary<int,int>();
        
        foreach    (var movie in movieLengths)
        {
            if (moviesDict.ContainsKey(movie))
            {
                moviesDict[movie]+= moviesDict[movie];
            }
            else    
             moviesDict[movie]=1;
            
           
        }
        
        
      /* foreach (KeyValuePair<int, int> pair in moviesDict)
    {
        Console.WriteLine("{0},{1}", pair.Key, pair.Value);
    }
        */
         foreach    (var firstMovie in movieLengths)
        {
            
            int secondMovie= flightLength-firstMovie;
            if (moviesDict.ContainsKey(firstMovie))
            {                
                if (moviesDict.ContainsKey(secondMovie))
                {
                   // if (firstMovie!=secondMovie && moviesDict[firstMovie]>1)
                    {
                        Console.WriteLine(firstMovie + ", "+ secondMovie);
                        
                         moviesDict.Remove(firstMovie);
                         moviesDict.Remove(secondMovie);
                    }
                }
            }           
        }
        
   
        
    
        

        return false;
    }
}

