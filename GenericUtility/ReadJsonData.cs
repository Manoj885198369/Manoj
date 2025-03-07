using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Manoj.WebDriver_Methods;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace Manoj.NewFolder
{
   public class ReadJsonData()
    {
       

        
        public  string  ReadTheDataFromJson(string key) {
            string path = IPathConstants.JSON_PATH;
            string file = File.ReadAllText(path);
            JToken token =JToken.Parse(file);
            string value = token[key].ToString();
            return value;
        }
    }
}
