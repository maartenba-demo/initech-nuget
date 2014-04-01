using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IniTech.TpsReports.Core;

namespace IniTech.TpsReports.Web.Controllers
{
    // todo: install Bootstrap Datepicker and ELMAH
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new TpsReportCoverSheet());
        }

        [HttpPost]
        public ActionResult Index(TpsReportCoverSheet model)
        {
            if (ModelState.IsValid)
            {
                // Generate the report
                return View("TpsReportCoverSheet", model);
            }

            return View(model);
        }
    }
}