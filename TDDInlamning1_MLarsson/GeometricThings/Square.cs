using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.GeometricThings
{
   public class Square : GeometricThing
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Square(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
