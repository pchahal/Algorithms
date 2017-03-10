using System;

namespace InterviewCake
{
    public class Rectangle
    {
        // coordinates of bottom-left corner
        public   int leftX{ get; set; }

        public int bottomY{ get; set; }

        // width and height
        public int width{ get; set; }

        public int height{ get; set; }

        public Rectangle(int left, int bottom, int w, int h)
        {
            leftX = left;
            bottomY = bottom;
            width = w;
            height = h;
        }


        public bool PointInRect(Rectangle rect, int x, int y)
        {
            if (x >= rect.leftX && x <= (rect.leftX + rect.width))
            if (y >= rect.bottomY && y <= (rect.bottomY + rect.height))
                return true;
            return false;
        }


        public Rectangle InterSection(Rectangle otherRect)
        {
            if (leftX + width <= otherRect.leftX)
                return new Rectangle(0, 0, 0, 0);
            else if (bottomY + height <= otherRect.bottomY)
                return new Rectangle(0, 0, 0, 0);
            else if (PointInRect(otherRect, leftX, bottomY) && PointInRect(otherRect, leftX + width, bottomY + height))
                return new Rectangle(0, 0, 0, 0);
            else if (PointInRect(this, otherRect.leftX, otherRect.bottomY) && PointInRect(this, otherRect.leftX + otherRect.width, otherRect.bottomY + otherRect.height))
                return new Rectangle(0, 0, 0, 0);

            int b = otherRect.bottomY;
            int l = otherRect.leftX;
            int w = (leftX + width) - otherRect.leftX;
            int h = (bottomY + height) - otherRect.bottomY;
            Rectangle rect = new Rectangle(l, b, w, h);

            return rect;
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: leftX={0}, bottomY={1}, width={2}, height={3}]", leftX, bottomY, width, height);
        }

    }
}

