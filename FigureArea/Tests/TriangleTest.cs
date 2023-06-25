namespace Tests
{
    using System;
    using FigureArea;
    using NUnit.Framework;
    using NUnit.Framework.Internal;

    public class TriangleTest
    {
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 0, 0)]
        public void InitTriangleWithErrorTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void InitTriangleTest()
        {
            // Arrange.
            double a = 3d, b = 4d, c = 5d;

            // Act.
            var triangle = new Triangle(a, b, c);

            // Assert.
            Assert.NotNull(triangle);
            Assert.Less(Math.Abs(triangle.SideA - a), Constants.CalculationAccuracy);
            Assert.Less(Math.Abs(triangle.SideB - b), Constants.CalculationAccuracy);
            Assert.Less(Math.Abs(triangle.SideC - c), Constants.CalculationAccuracy);
        }

        [Test]
        public void GetSquareTest()
        {
            // Arrange.
            double a = 3d, b = 4d, c = 5d;
            double result = 6d;
            var triangle = new Triangle(a, b, c);

            // Act.
            var square = triangle?.GetSquare();

            // Assert.
            Assert.NotNull(square);
            Assert.Less(Math.Abs(square.Value - result), Constants.CalculationAccuracy);
        }

        [Test]
        public void InitNotTriangleTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(1, 1, 4));
        }

        [TestCase(3, 4, 3, ExpectedResult = false)]
        [TestCase(3, 4, 5 + 2e-7, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 5.000000001, ExpectedResult = true)]
        public bool NotRightTriangle(double a, double b, double c)
        {
            // Arrange.
            var triangle = new Triangle(a, b, c);

            // Act.
            var isRight = triangle.IsRightTriangle;

            // Assert. 
            return isRight;
        }
    }
}