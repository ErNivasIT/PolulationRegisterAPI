using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PopulationRegisterWeb.APIDepedency;
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

            ConnectionToAPI objConnectionToAPI = new ConnectionToAPI("Persons", "GET");
            objConnectionToAPI.IsHttpsEnable = true;
            objConnectionToAPI.ContentType = "application/json";
            objConnectionToAPI.KeepAlive = false;
            lstPersons = objConnectionToAPI.DownloadAs<List<PersonsViewModel>>();

            return View(lstPersons);
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
            obj.AddedByIp =ControllerContext.HttpContext.Connection.RemoteIpAddress.ToString();
            obj.AddedOn = DateTime.Now;

            ConnectionToAPI objConnectionToAPI = new ConnectionToAPI("Persons/Save", "POST");
            objConnectionToAPI.IsHttpsEnable = true;
            objConnectionToAPI.ContentType = "application/json";
            objConnectionToAPI.KeepAlive = false;

            await objConnectionToAPI.PassDataToSendAsync(obj);

            KeyValuePair<string, string> response = await objConnectionToAPI.UploadDataAndGetResponseAsync();

            if (response.Key == "OK")
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(obj);
            }
        }
    }
}
