#pragma checksum "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc157506d2bf06e32001555e7115bb7903f9f04e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\_ViewImports.cshtml"
using FridgeTracker.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\_ViewImports.cshtml"
using FridgeTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc157506d2bf06e32001555e7115bb7903f9f04e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2053a6db4b6181c1f759d9e55c8a473829a835a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
  
	ViewBag.Title = "FridgeFood List";

#line default
#line hidden
            BeginContext(69, 64, true);
            WriteLiteral("\r\n<div class=\"row foodtag col-sm-12\" style=\"margin-top:10px;\">\r\n");
            EndContext();
#line 8 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
     foreach (var categ in Model.Categories)
	{

#line default
#line hidden
            BeginContext(180, 6, true);
            WriteLiteral("\t\t<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 186, "\"", 204, 1);
#line 10 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
WriteAttributeValue("", 191, (int)categ, 191, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(205, 100, true);
            WriteLiteral(" class=\" col-sm-4\tcategoryTag\" style=\" min-width: 18rem; margin-left :15px; max-width : 30.5%\">\r\n\t\t\t");
            EndContext();
            BeginContext(305, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc157506d2bf06e32001555e7115bb7903f9f04e5570", async() => {
                BeginContext(385, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(392, 5, false);
#line 13 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
           Write(categ);

#line default
#line hidden
                EndContext();
                BeginContext(397, 52, true);
                WriteLiteral("\r\n\t\t\t\t<span class=\"badge float-lg-right quantities\">");
                EndContext();
                BeginContext(450, 30, false);
#line 14 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
                                                         Write(Model.CountByCateg[(int)categ]);

#line default
#line hidden
                EndContext();
                BeginContext(480, 12, true);
                WriteLiteral("</span>\r\n\t\t\t");
                EndContext();
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
#line 12 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
                  WriteLiteral((int)categ);

#line default
#line hidden
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
            EndContext();
            BeginContext(496, 12, true);
            WriteLiteral("\r\n\t\t</div>\r\n");
            EndContext();
#line 17 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(512, 58, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"card-deck\" style=\"margin:0-10px;\">\r\n");
            EndContext();
#line 21 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
     foreach (var ff in Model.fridgeFoodList)
	{

#line default
#line hidden
            BeginContext(618, 133, true);
            WriteLiteral("\t\t<div class=\"card m-3 indexitem fooditem\" style=\"min-width: 18rem; max-width:30.5%;\">\r\n\t\t\t<div class=\"card-header quantities\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(751, 430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc157506d2bf06e32001555e7115bb7903f9f04e9667", async() => {
                BeginContext(836, 7, true);
                WriteLiteral("\r\n\t\t\t\t\t");
                EndContext();
                BeginContext(844, 7, false);
#line 27 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
               Write(ff.Name);

#line default
#line hidden
                EndContext();
                BeginContext(851, 105, true);
                WriteLiteral("\r\n\t\t\t\t\t<span class=\"float-lg-right\">\r\n\t\t\t\t\t\tDays to be used by:\r\n\t\t\t\t\t\t<span class=\"quantities\">\r\n\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(958, 45, false);
#line 31 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
                        Write((ff.BestBefore.Date - DateTime.Now.Date).Days);

#line default
#line hidden
                EndContext();
                BeginContext(1004, 17, true);
                WriteLiteral("\r\n\t\t\t\t\t\t</span>\r\n");
                EndContext();
#line 33 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
                         if (((ff.BestBefore.Date - DateTime.Now.Date).Days) <= 1)
						{

#line default
#line hidden
                BeginContext(1096, 36, true);
                WriteLiteral("\t\t\t\t\t\t\t<label hidden class=\"alerit\">");
                EndContext();
                BeginContext(1133, 7, false);
#line 35 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
                                                    Write(ff.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1140, 10, true);
                WriteLiteral("</label>\r\n");
                EndContext();
#line 36 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
						}

#line default
#line hidden
                BeginContext(1159, 18, true);
                WriteLiteral("\t\t\t\t\t</span>\r\n\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
                     WriteLiteral(ff.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1181, 23, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            EndContext();
#line 41 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(1208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1228, 58, true);
                WriteLiteral("\r\n\t\t<script>\r\n\t\t\t$(document).ready(function () {\r\n\t\t\t\tif (");
                EndContext();
                BeginContext(1287, 15, false);
#line 46 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
               Write(Model.tagNumber);

#line default
#line hidden
                EndContext();
                BeginContext(1302, 18, true);
                WriteLiteral("> -1) {\r\n\t\t\t\t\t$(\"#");
                EndContext();
                BeginContext(1321, 15, false);
#line 47 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
                   Write(Model.tagNumber);

#line default
#line hidden
                EndContext();
                BeginContext(1336, 48, true);
                WriteLiteral("\").addClass(\"bg-dark categoryTag\");\r\n\t\t\t\t\t//$(\"#");
                EndContext();
                BeginContext(1385, 15, false);
#line 48 "C:\Users\Szabolcs\Source\Repos\FridgeTracker\FridgeTracker\Views\Home\Index.cshtml"
                     Write(Model.tagNumber);

#line default
#line hidden
                EndContext();
                BeginContext(1400, 599, true);
                WriteLiteral(@""").css({});
				}

				$("".quantities"").each(function () {
					if ($(this).text() <= 0) {
						$(this).addClass(""btn-danger"");
						console.log(this);
					}
					else if ($(this).text() < 2) {
						$(this).addClass(""btn-warning"");
					}
					else if ($(this).text() > 1) {
						$(this).addClass(""btn-success"");
					}
				});

			});

			/* useful alert box, just bit annoying currently
			 $(window).on(""load"", function (){
				$("".alerit"").each(function () {
					alert('Check if ' + this.textContent + ' can still be consumed!');
				});
			});
		*/
		</script>
	");
                EndContext();
            }
            );
            BeginContext(2002, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
