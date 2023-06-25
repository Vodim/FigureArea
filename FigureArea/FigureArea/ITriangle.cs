namespace FigureArea
{
    /// <summary>
    /// Interface to implement the triangle class
    /// </summary>
    public interface ITriangle : IFigure
    {
        double SideA { get; }
        double SideB { get; }
        double SideC { get; }
        bool IsRightTriangle { get; }
    }
}