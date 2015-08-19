using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelePomocnikWebService.Controllers
{
    public class InformationController : Controller
    {
        //
        // GET: /Information/

        public JsonResult GetInformations()
        {
            TelePomocnikDbEntities db = new TelePomocnikDbEntities();
            DateTime from = DateTime.Now.AddDays(-2);
            var informations = db.MustCallInformation.ToList();

            string jsonString = JsonHelper.JsonSerializer<MustCallInformation>(db.MustCallInformation.First());

            return Json(jsonString, JsonRequestBehavior.AllowGet);
        }
    }
}
