#pragma checksum "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9e3ee01b03c095e9af61fd52f00d7752f67659"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Details), @"mvc.1.0.view", @"/Views/Car/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9e3ee01b03c095e9af61fd52f00d7752f67659", @"/Views/Car/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b796e74e2c7f5fcb342d8007b4616dd0221eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AimsCarRentals.Models.Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c9e3ee01b03c095e9af61fd52f00d7752f676594634", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    <div class=\"row\">\n\n        <div class=\"card-header\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 182, "\"", 221, 2);
#nullable restore
#line 8 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml"
WriteAttributeValue("", 188, WC.ImagePath, 188, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml"
WriteAttributeValue("", 201, Model.CarPictureUrl, 201, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:300px\" />\n        </div>\n    <div class=\"card-body\">\n        <ul>\n            <li><h4><label>Name</label></h4>");
#nullable restore
#line 12 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><h4><label>Make</label></h4>");
#nullable restore
#line 13 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml"
                                       Write(Model.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><h4><label>Plate No</label></h4>");
#nullable restore
#line 14 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml"
                                           Write(Model.PlateNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><h4><label>Serial No</label></h4>");
#nullable restore
#line 15 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml"
                                            Write(Model.SerialNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><h4><label>Branch</label></h4>");
#nullable restore
#line 16 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml"
                                         Write(Model.Branch.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><h4><label>Category</label></h4>");
#nullable restore
#line 17 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml"
                                           Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><h4><label>Description</label></h4>");
#nullable restore
#line 18 "C:\Users\JAFAR LAWAL\source\repos\AimsCarRentals\Views\Car\Details.cshtml"
                                              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        </ul>\n        </div>\n    </div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c9e3ee01b03c095e9af61fd52f00d7752f676599010", async() => {
                WriteLiteral("Continue To Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AimsCarRentals.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
