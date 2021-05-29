using BusinessLayer.BaseRules;
using BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IPersonBusinessLayer: IBusinessLayer<PersonModel>
    {
        IEnumerable<PersonModel> GetPersons();
    }
}
