﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SmartShop.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SmartShopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}