using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using CommandLayer.Common;

namespace CrowSampleApplication.Controllers
{
    public class CroweService
    {

        readonly string uri = "http://croweapitest.azurewebsites.net/api/values";

        public async Task<string> GetAsync()
        {


            using (HttpClient httpClient = new HttpClient())
            {

                return await httpClient.GetStringAsync(uri);
            }
        }
    }
    public class HomeController : BaseController
    {
        private CroweService service = new CroweService();
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> HelloWorld()
        {

            var islocaldata = ConfigurationManager.AppSettings["MyDataSource"];
            if (islocaldata == "local")
            {
                ViewBag.Message = "Hello World from local source!";
                
            }
            else if(islocaldata=="api")
            {

                ViewBag.Message = await service.GetAsync();
                

                
            }else
            {
                var myDbString = "";
                //Get from DB
                using(var myCommand=CommandFactory.Create<GetHelloWorldStringCommand>())
                {
                    myDbString = myCommand.Execute();
                }
                ViewBag.Message = myDbString;
                
            }
            
            return View();
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetData()
        {
            ViewBag.Message = "Hello World!";
            return View();
        }
    }
}