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
            string info = null;

            for (int i = 0; i < informations.Count; i++)
            {
                info += informations[i].DateMustContact + ": " + informations[i].Telemarketer.Name + " " + informations[i].Telemarketer.Surname + " do " + informations[i].Contact.Name + " " + informations[i].Contact.Surname + " z informacją: " + informations[i].Information + (i != informations.Count ? "XYZINFOXYZ" : "");                
            }

            return Json(info, JsonRequestBehavior.AllowGet);
        }
    }
}
