using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DlApi;

namespace DlApi
{
    public static class DlFactory
    {
        private static Dictionary<string, string> concreteDls = new Dictionary<string, string>
        {
            { "data", "DlFirst"},
            { "xml", "DlXml"},
        };

        public static IDL GetDl(string type)
        {
            Type dlType = null;
            string concreteDl = concreteDls[type];
            if (concreteDl == null)
                throw new ArgumentException($"Wrong DL type: {type}");

            try // to load concrete Dl implementation assembly
            {
                Assembly asm = Assembly.Load(concreteDl);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Requested {type} dll does not exist", ex);
            }

            // Get concrete DL implementation's class object
            dlType = Type.GetType($"DL.{concreteDl}, {concreteDl}");
            if (dlType == null)
                throw new ArgumentException("DL Class name is not the same as Assembly");

            // Get concrete DL implementation's Instance
            IDL dl = (IDL)dlType.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)
                .GetValue(null); // since it's a static property - no need for an object
            if (dl == null)
                throw new ArgumentException("DL Class is not a singleton");

            return dl;
        }
    }
}
