﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLAPI;

namespace BLFactory
{
    public static class BLFactory
    {
        public static IBL GetBL()
        {
            return new BL.BL();
        }
    }
}
