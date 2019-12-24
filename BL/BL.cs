using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;
using BO;

namespace BL
{
    class BlImp1 : IBL
    {
        readonly IDal dal = DalFactory.GetDal();

        public Weather GetWeather(int day)
        {
            Weather w = new Weather();
            w.Feeling = (int)(dal.GetTemparture(day) + Math.Sin(dal.GetWindDirection(day)) * 5);
            return w;
        }
    }
}
