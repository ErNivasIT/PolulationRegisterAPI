using BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IPersonBusinessLayer
    {
        IEnumerable<PersonModel> GetPersons();
    }
}
