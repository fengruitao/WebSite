using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitBrains.Controllers
{
    public class HomeController : Controller
    {
        #region 页面加载
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WhyFitBrains()
        {
            return View();
        }
        #endregion
    }
}
