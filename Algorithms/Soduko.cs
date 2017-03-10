using System;
using System.Collections.Generic;

namespace Algorithms
{

    //check if a sodoku board is valid
    public class Soduko
    {
       public int[,] soduboard = new int[,]
        {
            { 1, 2, 3, 4, 5, 6, 2, 8, 9 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },

            { 0, 0, 0, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0 },

            { 1, 0, 2, 0, 0, 0, 0, 9, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 2, 3, 4, 5, 6, 7, 8, 1, 0 }
        };

        public bool isValidRowOrCol(int[,] board)
        {
            
            for (int i = 0; i < 9; i++)
            {
                Dictionary  <int,int> dict = new Dictionary<int, int>();

                for (int j = 0; j < 9; j++)
                {
                    if (board [i, j] != 0)
                    {
                        if (dict.ContainsKey(board [i, j]))
                            return false;
                        else
                            dict.Add(board [i, j], 1);
                    }
                }
            }
            return true;
        }

        public bool isValidBlock(int[,] board, int x, int y)
        {
            Dictionary  <int,int> dict = new Dictionary<int, int>();
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    if (board [i, j] != 0)
                    {
                        if (dict.ContainsKey(board [i, j]))
                            return false;
                        else
                            dict.Add(board [i, j], 1);
                    }
                }   
            }
            return true;
        }


        public bool isValidBlocks(int[,] board)
        {        
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    if (!isValidBlock(board, i, j))
                        return false;                
                }
            }
            return true;
        }

        public bool ValidateSoduko(int[,] board)
        {        
            if (!isValidRowOrCol(board))
                return false;
            if (!isValidBlocks(board))
                return false;
            return true;
        }
    }
}

