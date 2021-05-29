using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRepository.BaseRules
{
    public class BusinessRepository<T> : BaseEntity, IBusinessRepository<T> where T : BaseEntity
    {
        private readonly MPKisaanContext mPKisaanContext;
        private DbSet<T> entities;

        public BusinessRepository(MPKisaanContext mPKisaanContext)
        {
            this.mPKisaanContext = mPKisaanContext;
            entities = mPKisaanContext.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> GetByID(long ID)
        {
            return await entities.SingleOrDefaultAsync(s => s.ID == ID);
        }

        public async Task<KeyValuePair<string, string>> Remove(long ID)
        {
            T obj = await entities.SingleOrDefaultAsync(p => p.ID == ID);
            entities.Remove(obj);
            return new KeyValuePair<string, string>();
        }

        public async Task<KeyValuePair<string, string>> Save(T obj)
        {
            await entities.AddAsync(obj);
            return new KeyValuePair<string, string>("SUCCESS",$"{obj.GetType().Name} has been Saved Successfully !!!");
        }

        public KeyValuePair<string, string> Update(T obj, long ID)
        {
            throw new NotImplementedException();
        }
    }
}
