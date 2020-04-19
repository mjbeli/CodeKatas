using Xunit;
using Geometries;
using System;
using Test.ClassData;

namespace Test.ManhattanDistance
{

    public class DistanceCalculatorTest : IDisposable
    {
       
        public DistanceCalculatorTest()
        {
            /*
            This code executes every time before a test. In xUnit, the constructor is like [TestInitialize] in MSTest.
            */
        }

        public void Dispose()
        {
            /*
            This code executes every time after a test. In xUnit Dispose is like [TestCleanup] in MSTest.
            */
        }

        [Fact]
        public void CreatePointObject() // Facts cann't receive parameters
        {
            Point p = new Point(1, 2);
            Assert.True(p != null);
        }

        [Theory]
        [ClassData(typeof(PointClassData))]
        public void TestingPrepareData(Point p)
        {
            Assert.True(p != null); // Create Point object with ClassData object
            Assert.True(p.ManhattanDistance(null) == -1); // Testing null parameter.
        }


       [Fact]
        public void CalculateManDist_EqualPoint() // Facts cann't receive parameters
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(1, 2);
            Assert.True(p1.ManhattanDistance(p2) == 0);
        }

        [Theory]
        [ClassData(typeof(FirstPointGreaterThanSecond))]
        [ClassData(typeof(FirstPointLowerThanSecond))]
        [ClassData(typeof(FirstPointXGreaterThanSecondX))]
        [ClassData(typeof(FirstPointYLowerThanSecondY))]
        [ClassData(typeof(EqualPoints))]        
        public void CalculateManDist_ResultNeverNegative(Point p1, Point p2)
        {
            Assert.True(p1.ManhattanDistance(p2) >= 0);
        }


        [Fact]
        public void CalculateManDist_ConcreteCases() // Facts cann't receive parameters
        {
            Point p1 = new Point(3, 5);
            Point p2 = new Point(1, 2);
            Assert.True(p1.ManhattanDistance(p2) == 5);

            p1 = new Point(1, 2);
            p2 = new Point(3, 5);
            Assert.True(p1.ManhattanDistance(p2) == 5);

            p1 = new Point(7, 2);
            p2 = new Point(3, 5);
            Assert.True(p1.ManhattanDistance(p2) == 7);

            p1 = new Point(4, 2);
            p2 = new Point(3, 5);
            Assert.True(p1.ManhattanDistance(p2) == 4);
        }

    } // DistanceCalculatorTest


    

}