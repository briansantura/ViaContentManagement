using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViaContentManagement.Web.Controllers
{
    public class ClusterController : Controller
    {
        // GET: Cluster
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Collect()
        {
            return View();
        }
    }
}