#pragma checksum "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad209478efc8f4f8618345363b028b49440f5b76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FlowerPartialView), @"mvc.1.0.view", @"/Views/Shared/_FlowerPartialView.cshtml")]
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
#line 1 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad209478efc8f4f8618345363b028b49440f5b76", @"/Views/Shared/_FlowerPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13b0eb7506d954a10f5093c41afae51b8a5a7022", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FlowerPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Flower>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "flower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:relative; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addbasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
 foreach (Flower flower in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div data-aos-offset=\"100\"");
            BeginWriteAttribute("class", "\n         class=\"", 87, "\"", 298, 5);
            WriteAttributeValue("", 104, "product", 104, 7, true);
            WriteAttributeValue(" ", 111, "col-lg-3", 112, 9, true);
            WriteAttributeValue(" ", 120, "col-md-6", 121, 9, true);
            WriteAttributeValue("\n             ", 129, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 7 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
              foreach (FlowerCategory flowerCategory in flower.FlowerCategories)
	{
		 

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
     Write(flowerCategory.Category.Name.ToLower() + " ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                        ;
             }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 143, 138, false);
            WriteAttributeValue("\n             ", 281, "all", 295, 17, true);
            EndWriteAttribute();
            WriteLiteral(">\n        <div>\n            <div class=\"productImage\">\n");
#nullable restore
#line 15 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                 foreach (FlowerImage image in flower.FlowerImages)
                {


                    if (image.isMain)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad209478efc8f4f8618345363b028b49440f5b767341", async() => {
                WriteLiteral("\n");
#nullable restore
#line 24 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                     if (image.Image.Contains("https://"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img");
                BeginWriteAttribute("src", " src=\"", 780, "\"", 798, 1);
#nullable restore
#line 26 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
WriteAttributeValue("", 786, image.Image, 786, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", "\n                             alt=\"", 799, "\"", 834, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ad209478efc8f4f8618345363b028b49440f5b768780", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 919, "~/assets/images/", 919, 16, true);
#nullable restore
#line 30 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
AddHtmlAttributeValue("", 935, image.Image, 935, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 32 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                                  WriteLiteral(flower.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                                                                    WriteLiteral(flower.FlowerCategories.FirstOrDefault().CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 34 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"

                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"productTitle\">\n                <p>");
#nullable restore
#line 40 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
              Write(flower.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n            <div class=\"productPrice\">\n");
#nullable restore
#line 43 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                 if (flower.CampaignId == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"addToCardBtn\" data-id=\"");
#nullable restore
#line 45 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                   Write(flower.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Add to cart</span><span>$</span><span>");
#nullable restore
#line 45 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                                                                     Write(flower.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 46 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"addToCardBtn\" data-id=\"");
#nullable restore
#line 49 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                   Write(flower.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Add to cart</span><span style=\"text-decoration: line-through;\">$");
#nullable restore
#line 49 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                                                                                               Write(flower.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    <span>$</span><span>");
#nullable restore
#line 50 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                    Write(flower.Price * (100 - flower.Campaign.DiscountPercent)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 51 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <div class=\"addToCart\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad209478efc8f4f8618345363b028b49440f5b7617067", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
                                                                                                WriteLiteral(flower.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n\n        </div>\n    </div>\n");
#nullable restore
#line 59 "C:\Users\ULVI\Desktop\P223-FierolloToBack-master\FiorelloBack\Views\Shared\_FlowerPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Flower>> Html { get; private set; }
    }
}
#pragma warning restore 1591
