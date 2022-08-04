using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Murat_Yücedağ_MVC_Katmanlı_Mimari.Controllers
{
    [AllowAnonymous]
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SweetAlert()
        {
            return View();
        }
    }
}