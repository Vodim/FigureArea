namespace FigureArea
{
    public class Triangle : ITriangle
    {
        private double eps = Constants.CalculationAccuracy;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < eps)
            {
                throw new ArgumentException("Incorrect side.", nameof(sideA));
            }

            if (sideB < eps)
            {
                throw new ArgumentException("Incorrect side.", nameof(sideB));
            }

            if (sideC < eps)
            {
                throw new ArgumentException("Incorrect side.", nameof(sideC));
            }

            var maxEdge = Math.Max(sideA, Math.Max(sideB, sideC));
            var perimeter = sideA + sideB + sideC;
            if (perimeter - maxEdge - maxEdge < Constants.CalculationAccuracy)
            {
                throw new ArgumentException("The largest side of the triangle must be smaller than the sum of the other sides");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            _isRightTriangle = new Lazy<bool>(GetIsRightTriangle);
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private readonly Lazy<bool> _isRightTriangle;
        public bool IsRightTriangle => _isRightTriangle.Value;

        private bool GetIsRightTriangle()
        {
            double maxSide = SideA, sideB = SideB, sideC = SideC;
            if (sideB - maxSide > Constants.CalculationAccuracy)
            {
                Utils.Utils.Swap(ref maxSide, ref sideB);
            }

            if (sideC - maxSide > Constants.CalculationAccuracy)
            {
                Utils.Utils.Swap(ref maxSide, ref sideC);
            }

            return Math.Abs(Math.Pow(maxSide, 2) - Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) < Constants.CalculationAccuracy;
        }

        public double GetSquare()
        {
            var halfP = (SideA + SideB + SideC) / 2d;
            var square = Math.Sqrt(
                halfP
                * (halfP - SideA)
                * (halfP - SideB)
                * (halfP - SideC)
            );

            return square;
        }
    }
}
