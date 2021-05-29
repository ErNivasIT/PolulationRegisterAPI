using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRepository
{
    public interface IPersonBusinessRepository
    {
        public IEnumerable<Person> GetPersons();
    }
}
