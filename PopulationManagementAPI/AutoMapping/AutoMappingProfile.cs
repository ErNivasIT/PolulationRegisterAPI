using AutoMapper;
using DataAccessLayer;
using PopulationManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopulationManagementAPI.AutoMapping
{
    public  class AutoMappingProfile:Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Person, PersonViewModel>().ReverseMap();
        }
        
    }
}
