using TDDInlamning1_MLarsson.GeometricThings;

namespace TDDInlamning1_MLarsson
{
    /// <summary>
    /// Abstract class to be inheritated by different shapes.
    /// Holds properties Perimeter and Area, and abstract functions GetPerimeter() and GetArea().
    /// </summary>
   public abstract class GeometricThing : IVolumeable
    {
        public float Perimeter { get; set; }
        public float Area { get; set; }
        public float Volume { get; set; }

        /// <summary>
        /// Calculates the perimeter of a shape.
        /// </summary>
        /// <returns>The perimeter as a float.</returns>
        public abstract float GetPerimeter();

        /// <summary>
        /// Calculates the area of a shape.
        /// </summary>
        /// <returns>The area as a float.</returns>
        public abstract float GetArea();

        /// <summary>
        /// Calculates the volume of a shape.
        /// </summary>
        /// <returns>The volume as a float</returns>
        public virtual float GetVolume()
        {
            throw new System.NotImplementedException();
        }
    }
}
