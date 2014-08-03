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

        public ActionResult ClientCase()
        {
            return View();
        }

        public ActionResult WeiXinService() 
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductSoution()
        {
            return View();
        }
        #endregion
    }
}
