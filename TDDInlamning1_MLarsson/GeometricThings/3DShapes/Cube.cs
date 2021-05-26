using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDInlamning1_MLarsson.Tests;

namespace TDDInlamning1_MLarsson.GeometricThings
{
    /// <summary>
    /// Class to handle the cube object.
    /// </summary>
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
            return Perimeter = Side < 0 ? 0 : MathF.Round(Side * 4, 2);
        }

        public override float GetVolume()
        {
            return Volume = Side < 0 ? 0 : MathF.Round(MathF.Pow(Side, 3), 2);
        }
    }

    }



