using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLAPI;

namespace DLFactory
{
    public static class DLFactory
    {
        public static IDL GetDL(string type)
        {
            switch (type)
            {
                case "data":
                    return DL.DLFirst.Instance;
                case "xml":
                    throw new ArgumentException("Not yet implemented");
                default:
                    throw new ArgumentException("Wrong DL type");
            }
        }
    }
}
