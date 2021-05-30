using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IPersonBusinessLayer
    {
        IEnumerable<Person> GetPersons();
        Task<KeyValuePair<string, string>> Save(Person personModel);
    }
}
