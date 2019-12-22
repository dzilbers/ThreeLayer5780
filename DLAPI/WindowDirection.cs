using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public enum WindowDirections { S, N, W, E, SE, SW, NE, NW, SSE, SEE, SSW, SWW, NNE, NEE, NNW, NWW }
    public class WindowDirection
    {
        public WindowDirections direction { get; set; }
    }
}
