using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PopulationRegisterWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PopulationRegisterWeb.Controllers
{
    public class PopulationRegisterController : Controller
    {
        // GET: PopulationRegisterController
        public ActionResult Index()
        {
            IEnumerable<PersonsViewModel> lstPersons = new List<PersonsViewModel>();

            HttpWebRequest oRequest = HttpWebRequest.Create("https://localhost/populationregister/api/Persons") as HttpWebRequest;
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
                        lstPersons = JsonConvert.DeserializeObject<IEnumerable<PersonsViewModel>>(result);
                    }
                }
            }

            return View(lstPersons);
        }

        // GET: PopulationRegisterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PopulationRegisterController/Create
        public ActionResult Create()
        {
            PersonsViewModel personsViewModel = new PersonsViewModel();
            return View(personsViewModel);
        }

        // POST: PopulationRegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonsViewModel obj)
        {

            obj.AddedBy = 1;
            obj.AddedByIp = "123";
            obj.AddedOn = DateTime.Now;

            HttpWebRequest oRequest = HttpWebRequest.Create("https://localhost/populationregister/api/persons/save") as HttpWebRequest;
            oRequest.Method = "POST";
            oRequest.ContentType = "application/json";
            oRequest.KeepAlive = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var jsonData = JsonConvert.SerializeObject(obj);
            var oData = Encoding.UTF8.GetBytes(jsonData);
            
            using (Stream oReadRequest = await oRequest.GetRequestStreamAsync())
            {
                oReadRequest.Write(oData, 0, oData.Length);
            }

            using (HttpWebResponse oWebResponse =await oRequest.GetResponseAsync() as HttpWebResponse)
            {
                if (oWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    return  RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(obj);
                }
            }


        }

        // GET: PopulationRegisterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PopulationRegisterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PopulationRegisterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PopulationRegisterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
