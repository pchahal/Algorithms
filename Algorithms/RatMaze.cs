using System;
using System.Collections.Generic;

namespace Algorithms
{
    //Find a path for a rat given a set of edges and start and goal
    public class RatMaze
    {
        public List<string> edges = new List<string>
        {            
            { "DA" },
            { "AB" },
            { "BE" },
            { "BC" },
            { "EG" },
            { "EF" },
            { "FH" },
            { "GH" },
            { "HI" }
        };

        public string getNeighbors(string cell, List<string> edges)
        {
            string neighbors = "";
            foreach (var edge in edges)
            {
                int index = edge.IndexOf(cell);

                if (index >= 0)
                {
                    index = index == 0 ? 1 : 0;
                    neighbors += edge [index];
                }
            }   
            return neighbors;
        }

        public string FindPath(List<string> edges, string start, string goal, string path)
        {            
            if (start == goal)
            {
                return start + goal;
            }

            string neighbors = getNeighbors(start, edges);

            for (int i = 0; i < neighbors.Length; i++)
            {
                if (path.IndexOf(neighbors [i]) >= 0)
                {
                    path = "";
                    return ""; 
                }
                path += start + neighbors [i]; 
                path = FindPath(edges, neighbors [i] + "", goal, path);
            }           
            return path;
        }
    }
}

