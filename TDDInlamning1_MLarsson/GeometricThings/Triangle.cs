using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.GeometricThings
{
    public class Triangle : GeometricThing
    {
        public float Base { get; set; }
        public float Height { get; set; }

        public Triangle(float tbase, float height)
        {
            this.Base = tbase;
            this.Height = height;
        }
    }
}
