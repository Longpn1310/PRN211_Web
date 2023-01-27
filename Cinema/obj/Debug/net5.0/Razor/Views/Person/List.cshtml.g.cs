#pragma checksum "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a765fe5d2f7872ecccc9dacf483b2ee791b5d5f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_List), @"mvc.1.0.view", @"/Views/Person/List.cshtml")]
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
#line 1 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\_ViewImports.cshtml"
using Cinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\_ViewImports.cshtml"
using Cinema.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a765fe5d2f7872ecccc9dacf483b2ee791b5d5f0", @"/Views/Person/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88b38380ea0d4f64bad62cefdedd00944e4c52ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_LayoutEmpty.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a765fe5d2f7872ecccc9dacf483b2ee791b5d5f04123", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"sidebar\">\r\n    <div class=\"sidebar-logo\">\r\n        <a href=\"/Home/Index\">\r\n            <img width=\"150px\" height=\"40px\" src=\"https://e-cinema.vercel.app/logo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 442, "\"", 448, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </a>
    </div>
    <div class=""sidebar-dashboard"">
        <ul class=""sidebar-list"">
            <li class=""sidebar-item""><i class=""fas fa-home""></i> <a href=""/Movie/Dashboard"" class=""sidebar-link"">Home</a></li>
            <li class=""sidebar-item"">
                <i class=""fas fa-film-alt""></i><a href=""/Movie/List"" class=""sidebar-link"" "">Movie</a>
            </li>
            <li class=""sidebar-item""><i class=""fas fa-user"" style=""color:red""></i> <a href=""/Person/List"" class=""sidebar-link"" style=""color: red;"">User</a></li>
        </ul>
    </div>
</div>

<div class=""container"">
    <div class=""user-create"">
        <span class=""user-heading"">USER MANAGEMENT</span>
    </div>
    <div class=""order-info__table"">
        <table>
            <thead>
                <tr>
                    <th>PersonId</th>
                    <th>FullName</th>
                    <th>Gender</th>
                    <th>Email</th>
                    <th>Active</th>
                    <th");
            WriteLiteral(">Action</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
                 foreach (var item in ViewBag.persons)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
                       Write(item.PersonId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
                       Write(item.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
                       Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
                        Write(item.IsActive == true ?"Active":"Block");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1982, "\"", 2022, 2);
            WriteAttributeValue("", 1989, "/Person/UnBlock?id=", 1989, 19, true);
#nullable restore
#line 54 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
WriteAttributeValue("", 2008, item.PersonId, 2008, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-shield-check user-icon\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2105, "\"", 2143, 2);
            WriteAttributeValue("", 2112, "/Person/Block?id=", 2112, 17, true);
#nullable restore
#line 55 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
WriteAttributeValue("", 2129, item.PersonId, 2129, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-ban user-icon\"></i></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Person\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
