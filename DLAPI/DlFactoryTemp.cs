using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DlApi;

namespace DlApi
{
    public static class DlFactoryTemp
    {
        public static IDL GetDl(string type)
        {

            Type dlType;
            switch (type)
            {
                case "data":
                    Assembly asm = Assembly.Load(@"DlFirst");
                    Console.WriteLine((from t in asm.GetTypes() select $"{t}; ").ToArray<string>());
                    dlType = Type.GetType("DlFirst, DlFirst");
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
