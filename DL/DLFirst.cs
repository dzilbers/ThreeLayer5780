using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DlApi;
using DO;

namespace DL
{
    public sealed class DLFirst : IDL
    {
        static readonly DLFirst instance = new DLFirst();
        static DLFirst() { }
        DLFirst() { }
        public static DLFirst Instance { get { return instance; } }

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
