using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PopulationRegisterWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
                using (var oStream=oWebResponse.GetResponseStream())
                {
                    using (var oStreamReader = new StreamReader(oStream))
                    {
                        var result = oStreamReader.ReadToEnd();
                        lstPersons= JsonConvert.DeserializeObject<IEnumerable<PersonsViewModel>>(result);                  }
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
            return View();
        }

        // POST: PopulationRegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
