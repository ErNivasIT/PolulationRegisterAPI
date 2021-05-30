using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PopulationManagementAPI.Models;
using PopulationRegisterWeb.APIDepedency;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PopulationRegisterWeb.Controllers
{
    public class MastersController : Controller
    {
        public IActionResult Genders()
        {
            IEnumerable<Genders> lstGenders = new List<Genders>();
            ConnectionToAPI objConnectionToAPI = new ConnectionToAPI("masters/Genders", "GET");
            objConnectionToAPI.IsHttpsEnable = true;
            objConnectionToAPI.ContentType = "application/json";
            objConnectionToAPI.KeepAlive = false;
            lstGenders = objConnectionToAPI.DownloadAs<List<Genders>>();
            return Json(lstGenders);
        }
        public IActionResult Categories()
        {
            IEnumerable<Categories> lstCategories = new List<Categories>();

            ConnectionToAPI objConnectionToAPI = new ConnectionToAPI("masters/Categories", "GET");
            objConnectionToAPI.IsHttpsEnable = true;
            objConnectionToAPI.ContentType = "application/json";
            objConnectionToAPI.KeepAlive = false;
            lstCategories = objConnectionToAPI.DownloadAs<List<Categories>>();
            return Json(lstCategories);
        }
    }
}
