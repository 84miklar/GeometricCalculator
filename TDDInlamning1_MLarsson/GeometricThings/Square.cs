namespace TDDInlamning1_MLarsson.Tests
{
    /// <summary>
    /// Class to handle the square shape.
    /// </summary>
    public class Square : GeometricThing
    {
        public Square(float side)
        {
            this.Side = side;
        }

        private float Side { get; }
        public override float GetArea(GeometricThing thing)
        {
            Square square = thing as Square;
            if (square.Side <= 0) return 0;

            square.Area = square.Side * square.Side;
            return Area;
        }

        public override float GetPerimeter(GeometricThing thing)
        {
            Square square = thing as Square;
            if (square.Side < 0 ) return 0;

            square.Perimeter = square.Side * 4;
            return Perimeter;
        }
    }
}