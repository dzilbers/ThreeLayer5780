using DO;
using System.Collections.Generic;

namespace Data
{
    public static class DataSource
    {
        public static List<WindDirection> directions;

        static DataSource()
        {
            directions = new List<WindDirection>();
            directions.Add(new WindDirection());
        }
    }
}
