namespace FigureArea
{
    public class Circle : IFigure
    {
        /// <summary>
        /// Constant for calculation accuracy min radius
        /// </summary>
        public const double MinRadius = 1e-6;

        /// <summary>
        /// Circle radius value
        /// </summary>
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius - MinRadius < Constants.CalculationAccuracy)
            {
                throw new ArgumentException("The circle radius is incorrect.", nameof(radius));
            }

            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
