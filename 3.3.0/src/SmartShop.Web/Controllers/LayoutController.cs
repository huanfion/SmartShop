﻿using System.Linq;
using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Configuration;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Runtime.Session;
using Abp.Threading;
using SmartShop.Configuration;
using SmartShop.Configuration.Ui;
using SmartShop.Sessions;
using SmartShop.Web.Models;
using SmartShop.Web.Models.Layout;

namespace SmartShop.Web.Controllers
{
    public class LayoutController : SmartShopControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        private readonly ILanguageManager _languageManager;

        public LayoutController(
            IUserNavigationManager userNavigationManager,
            ISessionAppService sessionAppService,
            IMultiTenancyConfig multiTenancyConfig,
            ILanguageManager languageManager)
        {
            _userNavigationManager = userNavigationManager;
            _sessionAppService = sessionAppService;
            _multiTenancyConfig = multiTenancyConfig;
            _languageManager = languageManager;
        }

        [ChildActionOnly]
        public PartialViewResult SideBarNav(string activeMenu = "")
        {
            var model = new SideBarNavViewModel
            {
                MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.ToUserIdentifier())),
                ActiveMenuItemName = activeMenu
            };

            return PartialView("_SideBarNav", model);
        }

        [ChildActionOnly]
        public PartialViewResult SideBarUserArea()
        {
            var model = new SideBarUserAreaViewModel
            {
                LoginInformations = AsyncHelper.RunSync(() => _sessionAppService.GetCurrentLoginInformations()),
                IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled,
            };

            return PartialView("_SideBarUserArea", model);
        }

        [ChildActionOnly]
        public PartialViewResult LanguageSelection()
        {
            var model = new LanguageSelectionViewModel
            {
                CurrentLanguage = _languageManager.CurrentLanguage,
                Languages = _languageManager.GetLanguages()
            };

            return PartialView("_LanguageSelection", model);
        }

        [ChildActionOnly]
        public PartialViewResult RightSideBar()
        {
            var themeName = SettingManager.GetSettingValue(AppSettingNames.UiTheme);

            var viewModel = new RightSideBarViewModel
            {
                CurrentTheme = UiThemes.All.FirstOrDefault(t => t.CssClass == themeName)
            };

            return PartialView("_RightSideBar", viewModel);
        }
    }
}