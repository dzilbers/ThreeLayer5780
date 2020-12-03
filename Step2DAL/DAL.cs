using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DalApi;

namespace DAL
{
    public class DAL : IDAL
    {
        DS.DS ds = new DS.DS();
        public int GetDataCount() => ds.datas.Count();
        public Data GetData(int id) => ds.datas[id];
        public IEnumerable<Data> GetDatas() => ds.datas;
    }
}
