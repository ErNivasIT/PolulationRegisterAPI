using BusinessLayer.BaseRules;
using BusinessModels;
using BusinessRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class PersonBusinessLayer : BusinessLayer<PersonModel>, IPersonBusinessLayer
    {
        private readonly IPersonBusinessRepository personBusinessRepository;

        public PersonBusinessLayer(IPersonBusinessRepository personBusinessRepository)
        {
            this.personBusinessRepository = personBusinessRepository;
        }
        public IEnumerable<PersonModel> GetPersons()
        {
            var res = personBusinessRepository.GetPersons();
            return res.Select(p => new PersonModel()
            {
                FirstName = p.FirstName,
                MiddleName = p.MiddleName,
                LastName = p.LastName,
                FatherName = p.FatherName,
                MotherName = p.MotherName,
                Dob = p.Dob,
                CategoryId = p.CategoryId,
                GenderId = p.GenderId,
                Id = p.Id
            }).ToList();
        }
    }
}
