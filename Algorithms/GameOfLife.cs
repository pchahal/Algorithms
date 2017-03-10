using System;

namespace Algorithms
{
    public class GameOfLife
    {
        
        int[,] newboard;

        public GameOfLife()
        {
            
            int[,] board = new int[,]
            {{ 0, 1, 0, 0, 0 },
                { 1, 1, 1, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 0, 1, 0 }
            };
        
            newboard = new int[5, 5];

            Array.Copy(board, newboard, 25);
        }

        public int[,] GetNextGeneration()
        {
            int[] nextGen; 
           


          
            return newboard;
        }
    }
}

