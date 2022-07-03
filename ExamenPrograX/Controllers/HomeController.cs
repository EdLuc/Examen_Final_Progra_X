using Exceptionless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenPrograX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            // Submit logs
            ExceptionlessClient.Default.SubmitLog("Logging made easy");

            // You can also specify the log source and log level.
            // We recommend specifying one of the following log levels: Trace, Debug, Info, Warn, Error
            ExceptionlessClient.Default.SubmitLog(typeof(InvalidProgramException).FullName, "Vas por buen camino", "Info");
            ExceptionlessClient.Default.CreateLog(typeof(InvalidProgramException).FullName, "Vas por buen camino", "Info").AddTags("CiudadDelDollar").Submit();

            //Error
            ExceptionlessClient.Default.SubmitLog(typeof(InvalidProgramException).FullName, "Se produjo un error", "Error");
            ExceptionlessClient.Default.CreateLog(typeof(InvalidProgramException).FullName, "Se produjo un error", "Error").AddTags("CiudadDelDollar").Submit();

            // Submit feature usages
            ExceptionlessClient.Default.SubmitFeatureUsage("MyFeature");
            ExceptionlessClient.Default.CreateFeatureUsage("MyFeature").AddTags("CiudadDelDollar").Submit();

            // Submit a 404
            ExceptionlessClient.Default.SubmitNotFound("/somepage");
            ExceptionlessClient.Default.CreateNotFound("/somepage").AddTags("CiudadDelDollar").Submit();
            return View();
        }
    }
}
