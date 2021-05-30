using BusinessRepository.BaseRules;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRepository
{
    public class PersonBusinessRepository : BusinessRepository<Person>, IPersonBusinessRepository
    {
        private MPKisaanContext mPKisaanContext;
        public PersonBusinessRepository(MPKisaanContext mPKisaanContext):base(mPKisaanContext)
        {
            this.mPKisaanContext = mPKisaanContext;
        }
        public IEnumerable<Person> GetPersons()
        {
           return mPKisaanContext.Persons.ToList();
        }

      
    }
}
