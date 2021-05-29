using BusinessRepository.BaseRules;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BaseRules
{
    public class BusinessLayer<T> : IBusinessLayer<T> where T:class
    {
        public BusinessLayer()
        {

        }
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetByID(long ID)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<string, string> Remove(long ID)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<string, string> Save(T obj)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<string, string> Update(T obj, long ID)
        {
            throw new NotImplementedException();
        }
    }
}
