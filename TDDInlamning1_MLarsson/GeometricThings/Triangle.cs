namespace TDDInlamning1_MLarsson.GeometricThings
{
    /// <summary>
    /// Class to handle the triangle shape.
    /// </summary>
    public class Triangle : GeometricThing
    {
        public Triangle(float tbase, float height)
        {
            this.Base = tbase;
            this.Height = height;
        }

        public float Base { get; set; }
        public float Height { get; set; }
        public override float GetArea(GeometricThing thing)
        {
            Triangle triangle = thing as Triangle;
            if (triangle.Base <= 0 || triangle.Height <= 0) return 0;

            triangle.Area = triangle.Base * triangle.Height / 2;
            return triangle.NiceRound(triangle.Area);
        }

        public override float GetPerimeter(GeometricThing thing)
        {
            Triangle triangle = thing as Triangle;
            if (triangle.Base < 0 || triangle.Height < 0) return 0;

            triangle.Perimeter = triangle.Base + triangle.Height * 2;
            return triangle.NiceRound(triangle.Perimeter);
        }
    }
}
