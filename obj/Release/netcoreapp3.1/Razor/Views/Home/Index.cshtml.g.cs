#pragma checksum "/Users/sgallagher/Dropbox (vINF Consulting)/P-Drive/Project vinf/code/CA-application-dev/webapp/1-WebApp-OIDC/1-1-MyOrg/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "344ffee7ccb815d972e941ba64dbbe00d7b90834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/sgallagher/Dropbox (vINF Consulting)/P-Drive/Project vinf/code/CA-application-dev/webapp/1-WebApp-OIDC/1-1-MyOrg/Views/_ViewImports.cshtml"
using WebApp_OpenIDConnect_DotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sgallagher/Dropbox (vINF Consulting)/P-Drive/Project vinf/code/CA-application-dev/webapp/1-WebApp-OIDC/1-1-MyOrg/Views/_ViewImports.cshtml"
using WebApp_OpenIDConnect_DotNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344ffee7ccb815d972e941ba64dbbe00d7b90834", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3fd628f36a7c79f11495394bc3d66103a7e55da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/sgallagher/Dropbox (vINF Consulting)/P-Drive/Project vinf/code/CA-application-dev/webapp/1-WebApp-OIDC/1-1-MyOrg/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>
    ASP.NET Core web app signing-in users in your organization
</h1>
<p>
    This sample shows how to build a .NET Core MVC Web app that uses OpenID Connect to sign in users in your organization. It leverages the ASP.NET Core OpenID Connect middleware.
</p>
<img src=""https://github.com/Azure-Samples/active-directory-aspnetcore-webapp-openidconnect-v2/raw/master/1-WebApp-OIDC/1-1-MyOrg/ReadmeFiles/sign-in.png
""/>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
