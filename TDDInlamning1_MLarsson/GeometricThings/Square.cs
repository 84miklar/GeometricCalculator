using System;

namespace TDDInlamning1_MLarsson.Tests
{
    public class Square : GeometricThing
    {
        private float Side { get; set; }

        public Square(float side)
        {
            this.Side = side;
        }

        public override float GetArea(GeometricThing thing)
        {
            Square square = thing as Square;
            if (square.Side <= 0) return 0;

            square.Area = square.Side * square.Side;
           return square.NiceRound(square.Area);
        }

        public override float GetPerimeter(GeometricThing thing)
        {
            Square square = thing as Square;
            if (square.Side < 0 ) return 0;

            square.Perimeter = square.Side * 4;
            return square.NiceRound(square.Perimeter);
        }
    }
}