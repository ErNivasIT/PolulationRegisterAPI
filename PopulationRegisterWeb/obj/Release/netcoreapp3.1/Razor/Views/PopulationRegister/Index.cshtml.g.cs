#pragma checksum "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2200f0aaad3ad8d9c7ed58263d1f8cf10f44d063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PopulationRegister_Index), @"mvc.1.0.view", @"/Views/PopulationRegister/Index.cshtml")]
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
#line 1 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\_ViewImports.cshtml"
using PopulationRegisterWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\_ViewImports.cshtml"
using PopulationRegisterWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2200f0aaad3ad8d9c7ed58263d1f8cf10f44d063", @"/Views/PopulationRegister/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c9b626ce041cd3184182e34313b94e6d1862b1", @"/Views/_ViewImports.cshtml")]
    public class Views_PopulationRegister_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PersonsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PopulationRegister", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header alert-success"">View Person List Registered in Census Survey 2023</div>
    <div class=""card-body"">
        <div class=""col-md-12"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>S.No.</th>
                        <th>First Name</th>
                        <th>Middle Name</th>
                        <th>Last Name</th>
                        <th>DOB</th>
                        <th>Category</th>
                        <th>Gender</th>
                        <th>Father Name</th>
                        <th>Mother Name</th>
                        <th>Added By</th>
                        <th>Added By IP</th>
                        <th>Added On</th>
                    </tr>
                </thead>");
#nullable restore
#line 22 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                           int Sno = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                 foreach (var objPerson in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 27 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                        Write(++Sno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.Dob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.GenderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.MotherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.AddedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.AddedByIp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                       Write(objPerson.AddedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 40 "D:\ShreeNiwas\PolulationRegister\API\PolulationRegisterAPI\PopulationRegisterWeb\Views\PopulationRegister\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-footer alert-success\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2200f0aaad3ad8d9c7ed58263d1f8cf10f44d0639875", async() => {
                WriteLiteral("Register More Person");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PersonsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
