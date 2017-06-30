using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaperRound.Website.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class IndexController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View("~/Views/Index.cshtml");
        }

        /// <summary>
        /// Handles the uploaded file.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            // TODO : Handle, validate and process uploaded file
            //if (file.ContentLength > 0)
            //{
            //    var fileName = Path.GetFileName(file.FileName);

            //    var path = Path.Combine(Server.MapPath("~/uploads"), fileName);
                
            //    file.SaveAs(path);

            var street = Business.Parse.StreetBuilder.GetStreet();
            //}

            return View("~/Views/Planner.cshtml", street);
        }
    }
}
