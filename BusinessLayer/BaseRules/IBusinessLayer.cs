using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BaseRules
{
   public interface IBusinessLayer<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetByID(Int64 ID);
        KeyValuePair<string, string> Save(T obj);
        KeyValuePair<string, string> Update(T obj,Int64 ID);
        KeyValuePair<string, string> Remove(Int64 ID);


    }
}
