using Xunit;
using Geometries;
using System.Collections.Generic;
using System.Collections;
using System;

namespace DistanceCalculatorTest.Test
{
    
    public class DistanceCalculatorTest : IDisposable
    {
        public DistanceCalculatorTest()
        {
            /*
            This code executes every time before a test.
            In xUnit, the constructor is like [TestInitialize] in MSTest.
            */
        }

        public void Dispose()
        {
            /*
            This code executes every time after a test.
            In xUnit Dispose is like [TestCleanup] in MSTest.
            */
        }

        [Fact]
        public void CreatePointObject()
        {
            Point p = new Point(1,2);
            Assert.True(p != null);
        }

        [Theory]
        [ClassData(typeof(PointClassData))]
        public void CreatePointWithClassDataObject(Point p)
        {
            Assert.True(p != null);
        } 

    }


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