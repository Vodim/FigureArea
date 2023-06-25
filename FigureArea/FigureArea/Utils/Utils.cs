namespace FigureArea.Utils
{
    public class Utils
    {
        /// <summary>
        /// Value exchange method
        /// </summary>
        /// <typeparam name="T">Universal type</typeparam>
        /// <param name="a">First value</param>
        /// <param name="b">Second value</param>
        public static void Swap<T>(ref T firstValue, ref T secondValue)
        {
            T temp = firstValue;
            firstValue = secondValue;
            secondValue = temp;
        }
    }
}
