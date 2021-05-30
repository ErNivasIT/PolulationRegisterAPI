using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PopulationManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopulationManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MastersController : ControllerBase
    {
        [Route("Genders")]
        public IEnumerable<Genders> Genders()
        {
            List<Genders> lst = new List<Genders>();
            lst.Add(new Models.Genders() { Gender_ID = 1, Gender_Name = "Male" });
            lst.Add(new Models.Genders() { Gender_ID = 2, Gender_Name = "Female" });
            return lst;
        }
        [Route("Categories")]

        public IEnumerable<Categories> Categories()
        {
            List<Categories> lst = new List<Categories>();
            lst.Add(new Models.Categories() { Category_ID = 1, Category_Name = "SC" });
            lst.Add(new Models.Categories() { Category_ID = 2, Category_Name = "ST" });
            lst.Add(new Models.Categories() { Category_ID = 3, Category_Name = "OBC" });
            lst.Add(new Models.Categories() { Category_ID = 4, Category_Name = "GEN" });

            return lst;
        }
    }
}
