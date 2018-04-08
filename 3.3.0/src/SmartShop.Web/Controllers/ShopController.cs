using SmartShop.Core.Entities;
using SmartShop.ShopCartApp;
using SmartShop.ShopProductApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartShop.Web.Controllers
{
    public class ShopController : BaseController
    {

        private readonly IShopProductAppService _shopproservice;
        private readonly IShopCartAppService _shopcartservice;

        public ShopController(IShopProductAppService shopproservice
            , IShopCartAppService shopcartservice)
        {
            _shopproservice = shopproservice;
            _shopcartservice = shopcartservice;
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        // GET: Shop
        public ActionResult Index()
        {
            List<ShopProduct> list = _shopproservice.GetAllList();
            return View(list);
        }

        public int GetCartCount()
        {
            if (assets.MemberId > 0)
            {
                return _shopcartservice.GetCountByMemberId(assets.MemberId);
            }
            return _shopcartservice.GetCartCountByCookie(assets.CookieTag);
        }
    }
}