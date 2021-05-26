using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDInlamning1_MLarsson.GeometricThings
{
    public interface IVolumeable
    {
        public float Volume { get; set; }

        public float GetVolume();
        
    }
}
