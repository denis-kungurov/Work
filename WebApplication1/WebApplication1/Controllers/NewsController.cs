using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public string Load()
        {
            ;
            var path = AppDomain.CurrentDomain.BaseDirectory + "/Content/news-headlines.json";
            using (var r = new StreamReader(path))
            {
                return r.ReadToEnd();
            }
        }  
    }
}