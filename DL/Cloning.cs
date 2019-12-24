using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace Dal
{
    static class Cloning
    {
        internal static WindDirection Clone(this WindDirection original)
        {
            WindDirection target = new WindDirection();
            target.direction = original.direction;
            return target;
        }
    }
}
