#pragma checksum "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaba2a5dbe1d17a659edeaf32e539fd690097227"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Adm4379Example.Pages.Pages_Active), @"mvc.1.0.razor-page", @"/Pages/Active.cshtml")]
namespace Adm4379Example.Pages
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
#line 1 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\_ViewImports.cshtml"
using Adm4379Example;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaba2a5dbe1d17a659edeaf32e539fd690097227", @"/Pages/Active.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4c0dceb6c4d5164b8ed8bf21b90977066b8f0d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Active : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
  
    ViewData["Title"] = "Active business cases";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaba2a5dbe1d17a659edeaf32e539fd6900972273243", async() => {
                WriteLiteral(@"
        <title>Active Business Cases</title>
        <script src=""js/site.js""></script>
         <!-- Global site tag (gtag.js) - Google Analytics -->
                <script async src=""https://www.googletagmanager.com/gtag/js?id=UA-192721075-1""></script>
                <script>
                window.dataLayer = window.dataLayer || [];
                function gtag(){dataLayer.push(arguments);}
                gtag('js', new Date());

                gtag('config', 'UA-192721075-1');
                </script>
            <!-- Google Tag Manager -->
                <script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
                new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
                j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
                'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
                })(window,document,'script','dataLayer','GTM-KLDZ6Z2');</script>
         ");
                WriteLiteral("   <!-- End Google Tag Manager -->\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaba2a5dbe1d17a659edeaf32e539fd6900972275319", async() => {
                WriteLiteral(@"
        <!-- Google Tag Manager (noscript) -->
            <noscript><iframe src=""https://www.googletagmanager.com/ns.html?id=GTM-KLDZ6Z2""
            height=""0"" width=""0"" style=""display:none;visibility:hidden""></iframe></noscript>
        <!-- End Google Tag Manager (noscript) -->
        <h1><span>Active Business Cases</span></h1>
        <div class=""zone flex-wrapper"">
            <!-- we're appending the id in query-format to the end of the URL three lines down, so we can parse it on page load and display the correct case. -->
");
#nullable restore
#line 37 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
             foreach (var bcase in Model.Cases)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a");
                BeginWriteAttribute("href", " href=\"", 1817, "\"", 1842, 2);
                WriteAttributeValue("", 1824, "/Case?id=", 1824, 9, true);
#nullable restore
#line 39 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
WriteAttributeValue("", 1833, bcase.id, 1833, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div class=\"box zone\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col75percent img-wrapper\"><img");
                BeginWriteAttribute("src", " src=\"", 2003, "\"", 2020, 1);
#nullable restore
#line 42 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
WriteAttributeValue("", 2009, bcase.logo, 2009, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><h6>");
#nullable restore
#line 42 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
                                                                                        Write(bcase.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></div>\r\n                            <div class=\"col25percent info\">\r\n                                <div>Responses: ");
#nullable restore
#line 44 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
                                           Write(bcase.num_responses);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                <div");
                BeginWriteAttribute("id", " id=\"", 2224, "\"", 2238, 1);
#nullable restore
#line 45 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
WriteAttributeValue("", 2229, bcase.id, 2229, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                <div>Bounty (USD): ");
#nullable restore
#line 46 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
                                              Write(bcase.bounty);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 51 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        \r\n");
#nullable restore
#line 54 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
         foreach (var bcase in Model.Cases) {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script type=\"text/javascript\">\r\n                document.getElementById(");
#nullable restore
#line 56 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
                                   Write(bcase.id);

#line default
#line hidden
#nullable disable
                WriteLiteral(").innerHTML = \"Posted: \" + timeElapsed(");
#nullable restore
#line 56 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
                                                                                   Write(bcase.datetime);

#line default
#line hidden
#nullable disable
                WriteLiteral(") + \" ago\";\r\n            </script>\r\n");
#nullable restore
#line 58 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Active.cshtml"
        } 

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActiveModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActiveModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActiveModel>)PageContext?.ViewData;
        public ActiveModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
