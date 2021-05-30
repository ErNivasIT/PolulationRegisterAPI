using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRepository.BaseRules
{
    public interface IBusinessRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(Int64 ID);
        Task<KeyValuePair<string, string>> Save(T obj);
        KeyValuePair<string, string> Update(T obj, Int64 ID);
        Task<KeyValuePair<string, string>> Remove(Int64 ID);
        Task SaveChanges();
    }
}
