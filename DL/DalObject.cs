using System;
using DalApi;
using DO;
using Data;

namespace Dal
{
    sealed class DalObject : IDal
    {
        static Random rnd = new Random(DateTime.Now.Millisecond);
        static readonly DalObject instance;
        double temperature;

        static DalObject() 
        {
            instance = new DalObject();
        }
        DalObject() {
            temperature = rnd.NextDouble() * 50 - 10; 
        }
        public static DalObject Instance { get { return instance; } }


        public double GetTemparture(int day)
        {
            temperature += rnd.NextDouble() * 10 - 5;
            return temperature;
        }

        public WindDirection GetWindDirection(int day)
        {
            WindDirection direction = DataSource.directions.Find(d => true);
            var directions = (WindDirections[])Enum.GetValues(typeof(WindDirections));
            direction.direction = directions[rnd.Next(0, directions.Length)];

            return direction.Clone();
        }
    }
}
