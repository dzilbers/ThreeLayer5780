using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDAL;

namespace SimpleBL
{
    public class BL
    {
        DAL dal;
        public BL()
        {
            dal = new DAL();
        }

        public override string ToString()
        {
            return "" + dal;
        }
    }
}
