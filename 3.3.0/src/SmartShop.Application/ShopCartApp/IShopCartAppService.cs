using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopCartApp
{
    public interface IShopCartAppService:IApplicationService
    {
        /// <summary>
        /// 获取购物车数量
        /// </summary>
        /// <returns></returns>
        int GetCountByMemberId(int MemberId);

        /// <summary>
        /// 获取当前cookie标识购物车数量
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        int GetCartCountByCookie(string tag);
    }
}
