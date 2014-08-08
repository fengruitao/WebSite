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

        /// <summary>
        /// CooperationPartner页面加载
        /// </summary>
        /// <returns></returns>
        public ActionResult CooperationPartner()
        {
            return View();
        }

        /// <summary>
        /// AboutUs页面加载
        /// </summary>
        /// <returns></returns>
        public ActionResult AboutUs()
        {
            return View();
        }

        /// <summary>
        /// ClientCase页面加载
        /// </summary>
        /// <returns></returns>
        public ActionResult ClientCase()
        {
            return View();
        }

        /// <summary>
        /// WeiXinService页面加载
        /// </summary>
        /// <returns></returns>
        public ActionResult WeiXinService() 
        {
            return View();
        }

        /// <summary>
        /// Index页面加载
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// ProductSoution页面加载
        /// </summary>
        /// <returns></returns>
        public ActionResult ProductSoution()
        {
            return View();
        }
        #endregion
    }
}
