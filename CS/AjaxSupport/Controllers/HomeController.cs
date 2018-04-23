using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxSupport.Models;

namespace AjaxSupport.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult GridViewPartial() {
            return PartialView("GridViewPartial", InMemoryModel.GetDataTableModel());
        }
    }
}