﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DlApi;
using BO;

namespace BL
{
    class BlImp1 : IBL
    {
        readonly IDL dl = DlFactory.GetDl("data");

        public Weather GetWeather(int day)
        {
            Weather w = new Weather();
            w.Feeling = (int)(dl.GetTemparture(day) + Math.Sin(dl.GetWindDirection(day)) * 5);
            return w;
        }
    }
}
