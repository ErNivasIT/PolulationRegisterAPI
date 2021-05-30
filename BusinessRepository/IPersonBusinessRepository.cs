using BusinessRepository.BaseRules;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRepository
{
    public interface IPersonBusinessRepository: IBusinessRepository<Person>
    {
        public IEnumerable<Person> GetPersons();
       
    }
}
