using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using DO;

namespace Dal
{
    sealed class DalObject : IDal
    {
        static readonly DalObject instance = new DalObject();
        static DalObject() { }
        DalObject() { }
        public static DalObject Instance { get { return instance; } }

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
