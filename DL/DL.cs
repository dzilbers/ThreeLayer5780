using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DlApi;
using DO;

namespace DL
{
    public sealed class DlFirst : IDL
    {
        static readonly DlFirst instance = new DlFirst();
        static DlFirst() { }
        DlFirst() { }
        public static DlFirst Instance { get { return instance; } }

        static Random rnd = new Random(DateTime.Now.Millisecond);
        public double GetTemparture(int day)
        {
            return rnd.NextDouble() * 60 - 10;
        }

        public double GetWindDirection(int day)
        {
            return rnd.NextDouble() * 2 * Math.PI;
        }
    }
}
