﻿using AutoMapper;
using BusinessLayer;
using BusinessModels;
using Microsoft.AspNetCore.Mvc;
using PopulationManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public PersonsController(IPersonBusinessLayer personBusinessLayer,IMapper mapper)
        {
            this.personBusinessLayer = personBusinessLayer;
            this.mapper = mapper;
        }
        // GET: api/<PersonsController>
        [HttpGet]
        public IEnumerable<PersonViewModel> Get()
        {
            IEnumerable<PersonModel> lstModels = new List<PersonModel>();
            lstModels = personBusinessLayer.GetPersons();
            var lst = mapper.Map<IEnumerable<PersonViewModel>>(lstModels);
            return lst;
        }

        // GET api/<PersonsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}