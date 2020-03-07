using Xunit;
using Geometries;
using System.Collections.Generic;
using System.Collections;
using System;
using DistanceOperators;

namespace DistanceCalculatorTest.Test
{
    
    public class DistanceCalculatorTest : IDisposable
    {
        DistanceCalculator _calc = null;

        public DistanceCalculatorTest()
        {
            /*
            This code executes every time before a test.
            In xUnit, the constructor is like [TestInitialize] in MSTest.
            */
            _calc = new DistanceCalculator();
        }

        public void Dispose()
        {
            /*
            This code executes every time after a test.
            In xUnit Dispose is like [TestCleanup] in MSTest.
            */
            _calc = null;
        }

        [Fact]
        public void CreatePointObject() // Facts cann't receive parameters
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

        [Theory]
        [ClassData(typeof(PointClassData))]
        public void CalculateManDist_NullParameterPoint(Point p)
        {
            Assert.True(_calc.manhattanDistance(null, null) == -1);
            Assert.True(_calc.manhattanDistance(null, p) == -1);
            Assert.True(_calc.manhattanDistance(p, null) == -1);
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