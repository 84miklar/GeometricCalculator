using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDInlamning1_MLarsson.Tests;

namespace TDDInlamning1_MLarsson.GeometricThings
{
    public class Cube : GeometricThing
    {
        public Cube(float side)
        {
            Side = side;
        }

        public float Side { get; set; }

        public override float GetArea()
        {
            return MathF.Round( Area = Side < 0 ? 0 : GetOneSideArea() * 6, 2);
        }

        private float GetOneSideArea()
        {
            var square = new Square(Side);
            return square.GetArea();
        }

        public override float GetPerimeter()
        {
            throw new NotImplementedException();
        }
        public override float GetVolume()
        {
            throw new NotImplementedException();
        }

    }

}

