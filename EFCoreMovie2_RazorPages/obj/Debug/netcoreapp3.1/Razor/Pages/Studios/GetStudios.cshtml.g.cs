#pragma checksum "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "baecb04a488a173c2a9647d317af7b8d9d5872d69d0bd1124cd62b87489b8dad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EFCoreMovie_RazorPages.Pages.Studios.Pages_Studios_GetStudios), @"mvc.1.0.razor-page", @"/Pages/Studios/GetStudios.cshtml")]
namespace EFCoreMovie_RazorPages.Pages.Studios
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/_ViewImports.cshtml"
using EFCoreMovie_RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"baecb04a488a173c2a9647d317af7b8d9d5872d69d0bd1124cd62b87489b8dad", @"/Pages/Studios/GetStudios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"136cf1c745fd21a17d6c0c9098c4592a3b5fabad8dba7ad41a647012085aa570", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Studios_GetStudios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Studios/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "GetStudios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
  
    ViewData["Title"] = "GetStudios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>List of studios</h1>\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baecb04a488a173c2a9647d317af7b8d9d5872d69d0bd1124cd62b87489b8dad4985", async() => {
                WriteLiteral("Create New Studio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baecb04a488a173c2a9647d317af7b8d9d5872d69d0bd1124cd62b87489b8dad6161", async() => {
                WriteLiteral("\n    <p>\n        Search: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "baecb04a488a173c2a9647d317af7b8d9d5872d69d0bd1124cd62b87489b8dad6464", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 13 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilterCriteria);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Filter\" />\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baecb04a488a173c2a9647d317af7b8d9d5872d69d0bd1124cd62b87489b8dad8351", async() => {
                    WriteLiteral("Back to Full List ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </p>\n");
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
<h4 style=""color:red""> List of studios</h4>
<table class=""table"">
    <thead>
        <tr>
            <th> Id </th>
            <th> Name  </th>
            <th> Hqcity </th>
            <th> Number of employee </th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 30 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
             foreach (var item in Model.Studios)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td> ");
#nullable restore
#line 35 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>  ");
#nullable restore
#line 36 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>");
#nullable restore
#line 37 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
                   Write(item.Hqcity);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\n                    <td> ");
#nullable restore
#line 38 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
                    Write(item.NoOfEmployees);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                </tr>\n");
#nullable restore
#line 40 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Users/olivervincent/Desktop/Zealand/Software Construction/RazorPages_Spring2021-master/RazorPages_Spring2021/Unsolved/EFCoreMovie2_RazorPages/EFCoreMovie2_RazorPages/Pages/Studios/GetStudios.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFCoreMovie2_RazorPages.Pages.Studios.GetStudiosModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EFCoreMovie2_RazorPages.Pages.Studios.GetStudiosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EFCoreMovie2_RazorPages.Pages.Studios.GetStudiosModel>)PageContext?.ViewData;
        public EFCoreMovie2_RazorPages.Pages.Studios.GetStudiosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
