using System.Collections.Generic;
using System.Collections;
using Geometries;


namespace Test.ClassData
{

    public class PointClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[] {
                new Point (0,0)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


    public class EqualPoints : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[] {
                new Point (1, 2),
                new Point (1, 2)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class FirstPointGreaterThanSecond : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[] {
                new Point (3, 5),
                new Point (1, 2)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class FirstPointLowerThanSecond : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[] {
                new Point (1, 2),
                new Point (3, 5)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class FirstPointXGreaterThanSecondX : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[] {
                new Point (7, 2),
                new Point (3, 5)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class FirstPointYLowerThanSecondY : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[] {
                new Point (4, 2),
                new Point (3, 5)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    

}