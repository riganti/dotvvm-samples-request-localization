using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using System.Threading;
using Microsoft.AspNetCore.Localization;

namespace RequestLocalizationSample.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		public string Title => Thread.CurrentThread.CurrentCulture.Name;

        [FromRoute("Lang")]
        public string RouteLang { get; private set; }

        public string CookieValue => Context.GetAspNetCoreContext().Request.Cookies[CookieRequestCultureProvider.DefaultCookieName];

        public string AcceptLanguage => Context.GetAspNetCoreContext().Request.Headers["Accept-Language"];
    }
}
