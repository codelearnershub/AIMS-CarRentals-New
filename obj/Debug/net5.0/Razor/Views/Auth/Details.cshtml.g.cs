#pragma checksum "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b19fc3fa0a9f676d04ed52e75ba90ee469a80d1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Details), @"mvc.1.0.view", @"/Views/Auth/Details.cshtml")]
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
#line 1 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\_ViewImports.cshtml"
using AimsCarRentals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\_ViewImports.cshtml"
using AimsCarRentals.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b19fc3fa0a9f676d04ed52e75ba90ee469a80d1d", @"/Views/Auth/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b796e74e2c7f5fcb342d8007b4616dd0221eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AimsCarRentals.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<ul>\r\n    <li>\r\n        <label><b>Id</b></label>\r\n        <h4>");
#nullable restore
#line 7 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>First Name</b></label>\r\n        <h4>");
#nullable restore
#line 11 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>Middle Name</b></label>\r\n        <h4>");
#nullable restore
#line 15 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>Last Name</b></label>\r\n        <h4>");
#nullable restore
#line 19 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>Gender </b></label>\r\n        <h4>");
#nullable restore
#line 23 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>Email</b></label>\r\n        <h4>");
#nullable restore
#line 27 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>Date of Birth</b></label>\r\n        <h4>");
#nullable restore
#line 31 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>Phone Number</b></label>\r\n        <h4>");
#nullable restore
#line 35 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.PhoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>Password</b></label>\r\n        <h4>");
#nullable restore
#line 39 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.PasswordHash);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>Address</b></label>\r\n        <h4>");
#nullable restore
#line 43 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n    <li>\r\n        <label><b>User was Created At</b></label>\r\n        <h4>");
#nullable restore
#line 47 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Auth\Details.cshtml"
       Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AimsCarRentals.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
