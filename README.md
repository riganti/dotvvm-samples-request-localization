# DotVVM Request Localization Sample

This sample demonstrates using **ASP.NET Core Request Localization** with [DotVVM](https://github.com/riganti/dotvvm).

> This method only works in ASP.NET Core. If you use OWIN, you need to use [Localizable Presenter](https://www.dotvvm.com/docs/tutorials/basics-globalization/latest) or switch the culture manually.

## Prerequisites

* Make sure you have installed [DotVVM for Visual Studio](https://www.dotvvm.com/install)

## How to run the sample

1. [Open the GitHub repo in Visual Studio](git-client://clone/?repo=https%3A%2F%2Fgithub.com%2Friganti%2Fdotvvm-samples-request-localization)
or 
`git clone https://github.com/riganti/dotvvm-samples-request-localization.git`

2. Open `src/RequestLocalizationSample.sln`

3. Right-click the `RequestLocalizationSample` project and select **View > View in Browser**

## What you can learn in the sample

* How to use [Globalization](https://www.dotvvm.com/docs/tutorials/basics-globalization/latest) features in DotVVM

--- 

# About the sample

**Request Localization** is a standard ASP.NET Core way of localizing web apps. It is extensible and works well with `Accept-Language` header and cookies. 

This sample shows the default settings - if the cookie with language is not present, the language is retrieved from the `Accept-Language` header. If the cookie `.AspNetCore.Culture` is set, the language from the cookie is used.

There is also a sample of `DotvvmRouteRequestCultureProvider` that can determine the language from the `Lang` route parameter. It is added as an initial provider, so the order of precedence is this:

* Route parameter
* Cookie
* Accept-Language header

You should not specify `config.DefaultCulture` in `DotvvmStartup` to prevent DotVVM from tampering with the request culture.

## Alternative way: LocalizablePresenter

**DotVVM** ships with a [Localizable Presenter](https://www.dotvvm.com/docs/tutorials/basics-globalization/latest) which allows to switch language based on route parameters or query string values. 

This approach is universal and works on both ASP.NET Core and OWIN.

---

## Other resources

* [Gitter Chat](https://gitter.im/riganti/dotvvm)
* [DotVVM Official Website](https://www.dotvvm.com)
* [DotVVM Documentation](https://www.dotvvm.com/docs)
* [DotVVM GitHub](https://github.com/riganti/dotvvm)
* [Twitter @dotvvm](https://twitter.com/dotvvm)
* [Samples](https://www.dotvvm.com/samples)
