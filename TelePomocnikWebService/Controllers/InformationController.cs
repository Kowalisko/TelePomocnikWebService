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
            string info = String.Empty;

            for (int i = 0; i < informations.Count; i++)
            {
                if (i == informations.Count - 1)
                    info += informations[i].DateMustContact + ": " + informations[i].Telemarketer.Name + " " + informations[i].Telemarketer.Surname + " do " + informations[i].Contact.Name + " " + informations[i].Contact.Surname + " z informacją: " + informations[i].Information;
                else 
                    info += informations[i].DateMustContact + ": " + informations[i].Telemarketer.Name + " " + informations[i].Telemarketer.Surname + " do " + informations[i].Contact.Name + " " + informations[i].Contact.Surname + " z informacją: " + informations[i].Information + "XYZINFOXYZ";                
            }

            return Json(info, JsonRequestBehavior.AllowGet);
        }
    }
}
