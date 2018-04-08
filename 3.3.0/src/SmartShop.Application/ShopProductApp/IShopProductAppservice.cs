using Abp.Application.Services;
using SmartShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopProductApp
{
    public interface IShopProductAppService: IApplicationService
    {
        /// <summary>
        /// 查找所有商品
        /// </summary>
        /// <returns></returns>
        List<ShopProduct> GetAllList();
    }
}
