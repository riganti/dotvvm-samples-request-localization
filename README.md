# DotVVM Request Localization Sample

This sample demonstrates using **ASP.NET Core Request Localization** with [DotVVM](https://github.com/riganti/dotvvm).

**Request Localization** is standard ASP.NET Core way of localizing web apps. It is extensible and works well with `Accept-Language` header and cookies. 

This sample shows the default settings - if the cookie with language is not present, the language is retrieved from the `Accept-Language` header. If the cookie `.AspNetCore.Culture` is set, the language from the cookie is used.

There is also a sample of `DotvvmRouteRequestCultureProvider` that can determine the language from the `Lang` route parameter. It is added as an initial provider, so the order of precedence is this:

* Route parameter
* Cookie
* Accept-Language header

You should not specify `config.DefaultCulture` in `DotvvmStartup` to prevent DotVVM from tampering with the request culture.

## Alternative way: LocalizablePresenter

**DotVVM** ships with a [Localizable Presenter](https://www.dotvvm.com/docs/tutorials/basics-globalization/2.0) which allows to switch language based on route parameters or query string values. 

This approach is universal and works on both ASP.NET Core and OWIN.
