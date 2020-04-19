using System;

namespace Geometries
{
    public class Point
    {
        private readonly int _x;
        private readonly int _y;

        public Point (int x, int y)
        {
            _x = x; _y = y;
        }


        public int ManhattanDistance (Point p)
        {
            if (p == null ) 
                return -1;
            if (this.Equals(p))
                return 0;
            
            int manhattanX = this._x - p._x;
            int manhattanY = this._y - p._y;

            if(manhattanX < 0)
                manhattanX *= -1;
            if(manhattanY < 0)
                manhattanY *= -1;
            return manhattanX + manhattanY;
        }

        public override bool Equals(Object obj)
        {
            if(obj == null || ! this.GetType().Equals(obj.GetType()))
                return false;
            Point p = (Point) obj;
            return (this._x == p._x && this._y == p._y);
        }
    }
}