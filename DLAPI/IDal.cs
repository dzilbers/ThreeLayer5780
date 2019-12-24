using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDal
    {
        double GetTemparture(int day);
        double GetWindDirection(int day);
    }
}
