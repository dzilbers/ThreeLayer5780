using System;
using DalApi;
using DO;
using Data;
using System.Threading;

namespace Dal
{
    sealed class DalObject : IDal
    {
        public static DalObject Instance { get; } = new DalObject();

        static Random rnd = new Random(DateTime.Now.Millisecond);
        double temperature;
        object lockDal;
        Thread myThread;
        volatile bool stopFlag = false;

        static DalObject() {}
        DalObject()
        {
            lockDal = new bool?(false);
            temperature = rnd.NextDouble() * 50 - 10;
            (myThread = new Thread(BackgroundAudit)).Start();
        }

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

        public object GetLock()
        {
            return lockDal;
        }

        public void Shutdown()
        {
            stopFlag = true;
            myThread.Interrupt();
        }

        void BackgroundAudit()
        {
            Console.WriteLine("Thread start");
            while (!stopFlag)
            {
                try { Thread.Sleep(5000); } catch (ThreadInterruptedException ex) { }
                if (stopFlag) break;
                lock (lockDal)
                {
                    try
                    {
                        Console.WriteLine("Thread begin processing");
                        Thread.Sleep(5000);
                        Console.WriteLine("Thread end processing");
                    }
                    catch (ThreadInterruptedException ex) { }
                }
            }
            Console.WriteLine("Thread finish");
        }
    }
}
