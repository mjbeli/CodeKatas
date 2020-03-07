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

}