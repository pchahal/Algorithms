using System;

namespace Algorithms
{
    //algorithm to bucketfill an image
    public class PaintFill
    {
        public int[,] image = new int[,]
        {   { 1, 1, 1, 1, 1 },
            { 1, 3, 2, 1, 1 },
            { 1, 2, 2, 2, 1 },
            { 1, 2, 2, 2, 1 },
            { 1, 1, 1, 1, 1 },
        };


        public void Paint(int[,] image, int i, int j, int oldcolor, int newcolor)
        {
            if (i < 0 || i > image.GetLength(0) - 1)
                return;

            if (j < 0 || j > image.GetLength(1) - 1)
                return;
            
            if (image [i, j] != oldcolor)
                return;        
                
            image [i, j] = newcolor;
                    
            if (i < image.GetLength(0) - 1)
                Paint(image, i + 1, j, oldcolor, newcolor);
            
            if (i > 0)
                Paint(image, i - 1, j, oldcolor, newcolor);
           
            if (j < image.GetLength(1) - 1)
                Paint(image, i, j + 1, oldcolor, newcolor);

            if (j > 0)
                Paint(image, j, j - 1, oldcolor, newcolor);            
        }
    }
}

