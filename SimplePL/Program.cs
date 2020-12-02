using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBL;

namespace SimplePL
{
    class Program
    {
        static BL bl;
        static void Main(string[] args)
        {
            bl = new BL();
            Console.WriteLine(bl.ToString());
        }
    }
}
