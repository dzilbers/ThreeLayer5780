using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DlApi;

namespace DlApi
{
    public static class DlFactory
    {
        public static IDL GetDL(string type)
        {
            Type dlType;
            switch (type)
            {
                case "data":
                    dlType = Type.GetType("DLFirst");
                    break;
                case "xml":
                    throw new ArgumentException("Not yet implemented");
                default:
                    throw new ArgumentException("Wrong DL type");
            }
            IDL dl = Activator.CreateInstance(dlType) as IDL;
            if (dl == null)
                throw new ArgumentException("Bad DL implementation");
            return dl;
        }
    }
}
