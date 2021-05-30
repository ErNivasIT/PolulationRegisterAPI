using BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IPersonBusinessLayer
    {
        IEnumerable<PersonModel> GetPersons();
        Task<KeyValuePair<string, string>> Save(PersonModel personModel);
    }
}
