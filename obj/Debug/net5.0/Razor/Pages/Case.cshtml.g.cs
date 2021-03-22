#pragma checksum "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a400706ab9ed97363e114f5fdbf8c03cb017103a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Adm4379Example.Pages.Pages_Case), @"mvc.1.0.razor-page", @"/Pages/Case.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a400706ab9ed97363e114f5fdbf8c03cb017103a", @"/Pages/Case.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4c0dceb6c4d5164b8ed8bf21b90977066b8f0d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Case : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
  
    ViewData["Title"] = "Business case details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a400706ab9ed97363e114f5fdbf8c03cb017103a3513", async() => {
                WriteLiteral(@"
        <title>Business Case Details</title>
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a400706ab9ed97363e114f5fdbf8c03cb017103a5585", async() => {
                WriteLiteral(@"
        <!-- Google Tag Manager (noscript) -->
            <noscript><iframe src=""https://www.googletagmanager.com/ns.html?id=GTM-KLDZ6Z2""
            height=""0"" width=""0"" style=""display:none;visibility:hidden""></iframe></noscript>
        <!-- End Google Tag Manager (noscript) -->
        <!-- HttpContext.Request.Query gets the query string with the key ""id"" (""?id=X"" from the URL), which we need in order to know what case to load -->
        <!-- id is saved as a string in the data model to avoid type conversion here -->
        <!-- we compare the ids for the cases in the database (or for now in the json file) and display it if it's found. IDs must be unique for this to work -->
");
#nullable restore
#line 36 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
         foreach (var bcase in Model.Cases) { 
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
             if (HttpContext.Request.Query["id"] == bcase.id) {
                Model.caseFound = true;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h1>");
#nullable restore
#line 39 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
               Write(bcase.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                <div class=\"case_debrief\">\r\n                    <div>\r\n                        <h7 class=\"h7 center\">");
#nullable restore
#line 42 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                         Write(bcase.company);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h7>\r\n                        <p class=\"case_debrief_font\">\r\n                            <b>Keywords: </b> \r\n                            ");
#nullable restore
#line 45 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                       Write(bcase.tags);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p class=\"case_debrief_font\">\r\n                            <b>Country: </b> \r\n                            ");
#nullable restore
#line 49 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                       Write(bcase.country);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p class=\"case_debrief_font\">\r\n                            <b>Bounty: </b> \r\n                            CAD$ ");
#nullable restore
#line 53 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                            Write(bcase.bounty);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <p class=\"case_debrief_font\" id=\"datetime\"></p>    \r\n                        <script>\r\n                            var datetime = convertEpoch(");
#nullable restore
#line 57 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                                   Write(bcase.datetime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@");
                            document.getElementById(""datetime"").innerHTML = ""<b>Date Posted: </b>"" + datetime;
                        </script>
                    </div>
                </div>
                <div>
                    <h2>Full Case</h2>
                    <div class=""flex-wrapper"">
                        <div class=""box2"">
                            <p class =""case_full_font"">");
#nullable restore
#line 66 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
                                                  Write(bcase.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    <h2>Respond to this business case</h2>\r\n                    <div>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a400706ab9ed97363e114f5fdbf8c03cb017103a10279", async() => {
                    WriteLiteral("\r\n                            <textarea id=\"response\" name=\"response\" placeholder=\"Write your response...\" style=\"height:300px\"></textarea>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <br>
                    </div>  
                    <input type=""submit"" value=""Submit Response"">
                </div>
                <div>
                    <h2>Other Responses</h2>
                    <div style=""text-align: left; "">
                        <div class=""flex-wrapper"">
                            <div class=""box2"">
                                <h2 class=""responder_name""> John Patrick</h2>
                                <p class=""responder_date""> 
                                    Febuary 1st, 2021
                                </p>
                                <br>
                                <p class =""case_full_font"">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate ");
                WriteLiteral(@"velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt ");
                WriteLiteral(@"mollit anim id est laborum.
                                </p> 
                            </div> 
                        </div>
                    </div>          
                    <div style=""text-align: left; "">
                        <div class=""flex-wrapper"">
                            <div class=""box2"">
                                <h2 class=""responder_name""> Jennifer Wang</h2>
                                <p class=""responder_date""> 
                                    January 21st, 2021
                                </p>
                                <br>
                                <p class =""case_full_font"">
                                Lorem ipsum doim veniis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labo");
                WriteLiteral(@"re et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                </p> 
                            </div> 
                        </div>
                    </div> 
                    <div style=""text-align: left; "">
                        <div class=""fl");
                WriteLiteral(@"ex-wrapper"">
                            <div class=""box2"">
                                <h2 class=""responder_name""> Saeed Wall</h2>
                                <p class=""responder_date""> 
                                    January 5th, 2021
                                </p>
                                <br>
                                <p class =""case_full_font"">
                                Loremincididun. trliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Ex");
                WriteLiteral(@"cepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                </p> 
                            </div> 
                        </div>
                    </div> 
                </div>
");
#nullable restore
#line 125 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
         if (Model.caseFound == false) {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h1>Sorry, we can\'t find that business case.</h1>\r\n            <div class=\"center\"><button class=\"btn2\" onclick=\"location.href=\'/Active\';\">Go back to active business cases</button></div>\r\n");
#nullable restore
#line 130 "C:\Users\Administrator\Documents\GitHub\CrowdConsult\Pages\Case.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CaseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CaseModel>)PageContext?.ViewData;
        public CaseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
