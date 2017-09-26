using System;

namespace TreehouseDefense
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            int xySum = xDiffSquared + yDiffSquared;
            double distance = Math.Sqrt(xySum);
            int distance1 = Convert.ToInt32(distance);
            return distance1;
        }
    }
}