using DotVVM.Framework.Configuration;
using DotVVM.Framework.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace RequestLocalizationSample
{
    public class DotvvmRouteRequestCultureProvider : RequestCultureProvider
    {
        private string routeParameterName;

        public DotvvmRouteRequestCultureProvider(string routeParameterName)
        {
            this.routeParameterName = routeParameterName;
        }

        public override async Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            // try to obtain DotVVM configuration
            var dotvvmConfiguration = httpContext.RequestServices.GetService<DotvvmConfiguration>();
            if (dotvvmConfiguration == null)
            {
                return null;
            }

            // adjust URL for matching
            var url = httpContext.Request.Path.Value?.Trim('/') ?? "";
            if (url.StartsWith(HostingConstants.SpaUrlIdentifier, StringComparison.Ordinal))
            {
                url = url.Substring(HostingConstants.SpaUrlIdentifier.Length).Trim('/');
            }

            // match route
            foreach (var route in dotvvmConfiguration.RouteTable)
            {
                if (route.IsMatch(url, out var parameters))
                {
                    if (parameters.TryGetValue(routeParameterName, out var culture))
                    {
                        return new ProviderCultureResult((string)culture);
                    }
                }
            }

            return null;
        }
    }
}