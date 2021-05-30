using AutoMapper;
using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PopulationManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PopulationManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonBusinessLayer personBusinessLayer;
        private readonly IMapper mapper;

        public PersonsController(IPersonBusinessLayer personBusinessLayer, IMapper mapper)
        {
            this.personBusinessLayer = personBusinessLayer;
            this.mapper = mapper;
        }
        /// <summary>
        /// Get All Registered Persons in Census Survey
        /// </summary>
        /// <returns></returns>
        // GET: api/<PersonsController>
        [HttpGet]
        public IEnumerable<PersonViewModel> Get()
        {
            IEnumerable<Person> lstModels = new List<Person>()
            {
            new Person(){  FirstName="Shreeniwas" ,MiddleName=string.Empty,LastName="Kushwah", Dob=Convert.ToDateTime("02/06/1986"),CategoryId=1,GenderId=1},
            new Person(){  FirstName="Rahul" ,MiddleName=string.Empty,LastName="Kushwah", Dob=Convert.ToDateTime("02/06/1986"),CategoryId=1,GenderId=1},
            new Person(){  FirstName="Vijay" ,MiddleName=string.Empty,LastName="Kushwah", Dob=Convert.ToDateTime("02/06/1986"),CategoryId=1,GenderId=1},
            };

            // lstModels = personBusinessLayer.GetPersons();
            var lst = mapper.Map<IEnumerable<PersonViewModel>>(lstModels);
            return lst;
        }

        // POST api/<PersonsController>

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PersonViewModel person)
        {
            //
            KeyValuePair<string, string> result = new KeyValuePair<string, string>();
            try
            {
                Person objModel = mapper.Map<Person>(person);

                objModel.AddedByIp = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                objModel.AddedOn = DateTime.Now;
                objModel.AddedBy = 1;

                result = await personBusinessLayer.Save(objModel);
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<string, string>("FAIL", ex.Message);
            }

            return Ok(result);
        }

    }
}
