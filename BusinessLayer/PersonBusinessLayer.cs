using BusinessRepository;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonBusinessLayer : IPersonBusinessLayer
    {
        private readonly IPersonBusinessRepository personBusinessRepository;

        public PersonBusinessLayer(IPersonBusinessRepository personBusinessRepository)
        {
            this.personBusinessRepository = personBusinessRepository;
        }
        public IEnumerable<Person> GetPersons()
        {
            var res = personBusinessRepository.GetPersons();
            return res.Select(p => new Person()
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

        public async Task<KeyValuePair<string, string>> Save(Person p)
        {
            KeyValuePair<string, string> result = await personBusinessRepository.Save(new Person()
            {
                FirstName = p.FirstName,
                MiddleName = p.MiddleName,
                LastName = p.LastName,
                FatherName = p.FatherName,
                MotherName = p.MotherName,
                Dob = p.Dob,
                CategoryId = p.CategoryId,
                GenderId = p.GenderId,
                Id = p.Id,
                AddedOn = p.AddedOn,
                AddedByIp = p.AddedByIp,
                AddedBy = p.AddedBy
            });
            return result;
        }
    }
}
