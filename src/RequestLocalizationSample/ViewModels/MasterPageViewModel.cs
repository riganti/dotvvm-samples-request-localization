using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.Hosting;
using DotVVM.Framework.ViewModel;
using Microsoft.AspNetCore.Localization;

namespace RequestLocalizationSample.ViewModels
{
    public class MasterPageViewModel : DotvvmViewModelBase
    {

        public void SwitchLanguage(string language)
        {
            Context.GetAspNetCoreContext().Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(language))
            );
            Context.RedirectToLocalUrl(Context.HttpContext.Request.Url.PathAndQuery);
        }

        public void ResetToDefaultLanguage()
        {
            Context.GetAspNetCoreContext().Response.Cookies.Delete(
                CookieRequestCultureProvider.DefaultCookieName
            );
            Context.RedirectToLocalUrl(Context.HttpContext.Request.Url.PathAndQuery);
        }
    }
}
