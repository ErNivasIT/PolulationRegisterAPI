using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PopulationManagementAPI.Models;
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

            HttpWebRequest oRequest = HttpWebRequest.Create("https://localhost/populationregister/api/masters/Genders") as HttpWebRequest;
            oRequest.Method = "GET";
            oRequest.ContentType = "application/json";
            oRequest.KeepAlive = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var oWebResponse = oRequest.GetResponse())
            {
                using (var oStream = oWebResponse.GetResponseStream())
                {
                    using (var oStreamReader = new StreamReader(oStream))
                    {
                        var result = oStreamReader.ReadToEnd();
                        lstGenders = JsonConvert.DeserializeObject<IEnumerable<Genders>>(result);
                    }
                }
            }

            return Json(lstGenders);
        }
        public IActionResult Categories()
        {
            IEnumerable<Categories> lstCategories = new List<Categories>();

            HttpWebRequest oRequest = HttpWebRequest.Create("https://localhost/populationregister/api/masters/Categories") as HttpWebRequest;
            oRequest.Method = "GET";
            oRequest.ContentType = "application/json";
            oRequest.KeepAlive = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var oWebResponse = oRequest.GetResponse())
            {
                using (var oStream = oWebResponse.GetResponseStream())
                {
                    using (var oStreamReader = new StreamReader(oStream))
                    {
                        var result = oStreamReader.ReadToEnd();
                        lstCategories = JsonConvert.DeserializeObject<IEnumerable<Categories>>(result);
                    }
                }
            }

            return Json(lstCategories);
        }
    }
}
