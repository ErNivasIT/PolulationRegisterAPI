using Newtonsoft.Json;
using PopulationRegisterWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PopulationRegisterWeb.APIDepedency
{
    public class ConnectionToAPI
    {
        private readonly string Url = "https://localhost/populationregister/api/";
        HttpWebRequest oRequest;
        public ConnectionToAPI(string UrlSuffix, string Method)
        {
            oRequest = HttpWebRequest.Create(Url + UrlSuffix) as HttpWebRequest;
            oRequest.Method = Method;
            if (!string.IsNullOrEmpty(ContentType))
                oRequest.ContentType = ContentType;
            oRequest.KeepAlive = KeepAlive;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) =>
            {
                // local dev, just approve all certs
                return true;

            };

        }
        public T DownloadAs<T>() where T : class, new()
        {
            T obj = new T();
            using (var oWebResponse = oRequest.GetResponse())
            {
                using (var oStream = oWebResponse.GetResponseStream())
                {
                    using (var oStreamReader = new StreamReader(oStream))
                    {
                        var result = oStreamReader.ReadToEnd();
                        obj = JsonConvert.DeserializeObject<T>(result);
                    }
                }
            }
            return obj;
        }
        public bool IsHttpsEnable { get; internal set; }
        public string ContentType { get { return oRequest.ContentType; } internal set { oRequest.ContentType = value; } }
        public bool KeepAlive { get { return oRequest.KeepAlive; } internal set { oRequest.KeepAlive = value; } }

        public void PassDataToSend(dynamic obj)
        {
            var jsonData = JsonConvert.SerializeObject(obj);
            var oData = Encoding.UTF8.GetBytes(jsonData);

            using (Stream oReadRequest = oRequest.GetRequestStream())
            {
                oReadRequest.Write(oData, 0, oData.Length);
            }
        }
        public async Task PassDataToSendAsync(dynamic obj)
        {
            var jsonData = JsonConvert.SerializeObject(obj);
            var oData = Encoding.UTF8.GetBytes(jsonData);

            using (Stream oReadRequest =await oRequest.GetRequestStreamAsync())
            {
                oReadRequest.Write(oData, 0, oData.Length);
            }
        }
        public KeyValuePair<string, string> UploadDataAndGetResponse()
        {
            using (HttpWebResponse oWebResponse = oRequest.GetResponse() as HttpWebResponse)
            {
                return new KeyValuePair<string, string>(oWebResponse.StatusCode.ToString(), oWebResponse.StatusDescription);
            }
        }
        public async Task<KeyValuePair<string, string>> UploadDataAndGetResponseAsync()
        {
            using (HttpWebResponse oWebResponse = await oRequest.GetResponseAsync() as HttpWebResponse)
            {
                return new KeyValuePair<string, string>(oWebResponse.StatusCode.ToString(), oWebResponse.StatusDescription);
            }
        }
    }
}
