using System;

class Islands
{

    public void getNeighbors(int[,] matrix, int i, int j, int[,] visited)
    {

        if (i > 0 && matrix[i - 1, j] == 1 && visited[i - 1, j] == 0)
        {
            visited[i - 1, j] = 1;
            getNeighbors(matrix, i - 1, j, visited);
        }
        if (i < matrix.GetLength(0) - 1 && matrix[i + 1, j] == 1 && visited[i + 1, j] == 0)
        {
            visited[i + 1, j] = 1;
            getNeighbors(matrix, i + 1, j, visited);
        }
        if (j > 0 && matrix[i, j - 1] == 1 && visited[i, j - 1] == 0)
        {
            visited[i, j - 1] = 1;
            getNeighbors(matrix, i, j - 1, visited);
        }
        if (j < matrix.GetLength(1) - 1 && matrix[i, j + 1] == 1 && visited[i, j + 1] == 0)
        {
            visited[i, j + 1] = 1;
            getNeighbors(matrix, i, j + 1, visited);
        }



    }

    public int getIslands(int[,] matrix)
    {
        int count = 0;
        int[,] visited = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 1 && visited[i, j] == 0)
                {
                    getNeighbors(matrix, i, j, visited);
                    count++;

                }
            }
        }
        return count;
    }



    public void Test()
    {
        int[,] matrix = new int[,] {   { 0, 1, 0 },
                                       { 0, 0, 1 },
                                       { 0, 1, 0 }
        };
        int[,] matrix2 = new int[,] {  { 0, 1, 1 },
                                       { 0, 0, 1 },
                                       { 0, 1, 1 }
        };

        Console.WriteLine(getIslands(matrix));
    }

}
