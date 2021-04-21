namespace TDDInlamning1_MLarsson.GeometricThings
{
    /// <summary>
    /// Class to handle the rectangle shape.
    /// </summary>
    public class Rectangle : GeometricThing
    {
        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public float Height { get; set; }
        public float Width { get; set; }

        public override float GetArea(GeometricThing thing)
        {
            Rectangle rectangle = thing as Rectangle;
            if (rectangle.Width <= 0 || rectangle.Height <= 0) return 0;

            rectangle.Area = rectangle.Width * rectangle.Height;
            return Area;
        }

        public override float GetPerimeter(GeometricThing thing)
        {
            Rectangle rectangle = thing as Rectangle;
            if (rectangle.Width < 0 || rectangle.Height < 0) return 0;

            rectangle.Perimeter = (rectangle.Width * 2) + (rectangle.Height * 2);
            return Perimeter;
        }
    }
}
