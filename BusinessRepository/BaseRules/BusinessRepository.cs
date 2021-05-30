using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRepository.BaseRules
{
    public class BusinessRepository<T> : IBusinessRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private DbSet<T> entities;

        public BusinessRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            entities = _dbContext.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> GetByID(long ID)
        {
            return await entities.SingleOrDefaultAsync();
        }

        public async Task<KeyValuePair<string, string>> Remove(long ID)
        {
            T obj = await entities.SingleOrDefaultAsync();
            entities.Remove(obj);
            return new KeyValuePair<string, string>();
        }

        public async Task<KeyValuePair<string, string>> Save(T obj)
        {
            try
            {
                entities.Add(obj);
                _dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                return new KeyValuePair<string, string>("FAIL",ex.InnerException.Message);
            }

            return new KeyValuePair<string, string>("SUCCESS", $"{obj.GetType().Name} has been Saved Successfully !!!");
        }

        public KeyValuePair<string, string> Update(T obj, long ID)
        {
            throw new NotImplementedException();
        }
        public async Task SaveChanges()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
