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

            return Math.Abs(manhattanX) + Math.Abs(manhattanY);
        }

        public override bool Equals(Object obj)
        {
            if(obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            Point p = (Point) obj;
            return (this._x == p._x && this._y == p._y);
        }

        /*****
            A hash code is a numeric value that is used to insert and identify an object in a
            hash-based collection such as the Dictionary<TKey,TValue> class or the Hashtable class.

            GetHashCode() is used for algorithms that need quick checks of object equality.

            Two objects that are equal return hash codes that are equal. 
            The reverse is not true: equal hash codes do not imply object equality, 
            because different (unequal) objects can have identical hash codes.

            The result int is used to map objects to a memory direction, so is better every objects in
            a collection results in diferent hash codes. In the case 2 different object result in same
            hash code, .NET must search in the result memory direction search for the desired object.

            Default implementations of GetHashCode() can varies from different versions 
            of .NET framework or .NET Core and can also varies across 32 - 64 bits platforms, so:
            don't store them in databases! 
            don't uses as store keys un collections!
            don't send across different application domains!
        *****/
        public override int GetHashCode()
        {
            return (this._x << 2) ^ this._y; // ^ --> XOR bit a bit. https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators#logical-exclusive-or-operator-
        }
    } // Class Point
}