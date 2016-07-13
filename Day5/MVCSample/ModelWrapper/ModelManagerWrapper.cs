using Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelWrapper
{
    public class ModelManagerWrapper
    {
        IOManager iomanager;
        public  ModelManagerWrapper()
        {
            iomanager = new IOManager();
        }
        public bool Add(Employee e)
        {
            return iomanager.Insert(e);
        }
        public List<string> QueryAll()
        {
            return iomanager.QueryAll();
        }
        public bool DeletAtIndex(int index)
        {
            return iomanager.DeleteAt(index);
        }
    }
}
