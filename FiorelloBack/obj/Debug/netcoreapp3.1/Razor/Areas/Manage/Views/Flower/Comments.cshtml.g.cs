#pragma checksum "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97077ac6899cd8bc821d9ff06ae8a5fed650ea8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Flower_Comments), @"mvc.1.0.view", @"/Areas/Manage/Views/Flower/Comments.cshtml")]
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
#line 1 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\_ViewImports.cshtml"
using FiorelloBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\_ViewImports.cshtml"
using FiorelloBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\_ViewImports.cshtml"
using FiorelloBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97077ac6899cd8bc821d9ff06ae8a5fed650ea8a", @"/Areas/Manage/Views/Flower/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13b0eb7506d954a10f5093c41afae51b8a5a7022", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Flower_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "flower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CommentStatusChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
  
    ViewData["Title"] = "Comments";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <table class=""mt-3 table table-dark"">
        <thead>
            <tr>
                <th>
                    #
                </th>
                <th>
                    User Fullname
                </th>
                <th>
                    Text
                </th>
                <th>
                    Created Date
                </th>
                <th>
                    Status
                </th>
                <th>
                    Settings
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 30 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
             foreach (var comment in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
               Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
               Write(comment.AppUser.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
                 if (@comment.Text.Length < 50)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 37 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
                   Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 38 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td data-toggle=\"tooltip\" data-placement=\"bottom\"");
            BeginWriteAttribute("title", " title=\"", 1080, "\"", 1101, 1);
#nullable restore
#line 42 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
WriteAttributeValue("", 1088, comment.Text, 1088, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
                                                                                       Write(comment.Text.Substring(0,47));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</td>\r\n");
#nullable restore
#line 43 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 44 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
               Write(comment.CreatedTime.ToString("dd MMMM yyyy HH:m"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
               Write(comment.IsAccess);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 47 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
                     if (comment.IsAccess)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97077ac6899cd8bc821d9ff06ae8a5fed650ea8a9333", async() => {
                WriteLiteral("\r\n                            <i class=\"mdi mdi-alert btn-icon-prepend\"></i>\r\n                            Reject\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
                                                                                      WriteLiteral(comment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97077ac6899cd8bc821d9ff06ae8a5fed650ea8a12297", async() => {
                WriteLiteral("\r\n                            <i class=\"mdi mdi-file-check btn-icon-append\"></i>\r\n                            Accept\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
                                                                                      WriteLiteral(comment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Areas\Manage\Views\Flower\Comments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    <script>\r\n        $(function () {\r\n            $(\'[data-toggle=\"tooltip\"]\').tooltip()\r\n        })\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
