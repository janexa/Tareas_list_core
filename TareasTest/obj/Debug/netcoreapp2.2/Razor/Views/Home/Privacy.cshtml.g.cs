#pragma checksum "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c3c1c567ae185850bcbdfef891d8929613ffb91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/_ViewImports.cshtml"
using TareasTest;

#line default
#line hidden
#line 2 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/_ViewImports.cshtml"
using TareasTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c3c1c567ae185850bcbdfef891d8929613ffb91", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cfebbb207d6ce6f20e5c7cc263882fcb9c4d45e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NuevaTarea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:0 auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
  
    ViewData["Title"] = "Notas";

#line default
#line hidden
            BeginContext(38, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(44, 17, false);
#line 5 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(61, 15, true);
            WriteLiteral("</h1>\n\n<p>\n    ");
            EndContext();
            BeginContext(76, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c3c1c567ae185850bcbdfef891d8929613ffb915752", async() => {
                BeginContext(99, 11, true);
                WriteLiteral("Nueva tarea");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(114, 6, true);
            WriteLiteral("\n</p>\n");
            EndContext();
            BeginContext(120, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c3c1c567ae185850bcbdfef891d8929613ffb917109", async() => {
                BeginContext(243, 74, true);
                WriteLiteral("\n    <button type=\"submit\" class=\"btn btn-outline-primary\">Crear</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(324, 505, true);
            WriteLiteral(@"

    <div class=""table-responsive"">
        <table class=""table table-hover"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Titulo</th>
                    <th scope=""col"">Descripcion</th>
                    <th scope=""col"">Encargado</th>
                    <th scope=""col"">Acciones</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">");
            EndContext();
            BeginContext(830, 14, false);
#line 27 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
                               Write(ViewData["ID"]);

#line default
#line hidden
            EndContext();
            BeginContext(844, 30, true);
            WriteLiteral("</th>\n                    <td>");
            EndContext();
            BeginContext(875, 14, false);
#line 28 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
                   Write(ViewBag.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(889, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(920, 23, false);
#line 29 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
                   Write(TempData["Descripcion"]);

#line default
#line hidden
            EndContext();
            BeginContext(943, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(974, 21, false);
#line 30 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
                   Write(ViewData["Encargado"]);

#line default
#line hidden
            EndContext();
            BeginContext(995, 329, true);
            WriteLiteral(@"</td>
                    <td>


                        <button type=""button"" class=""btn btn-outline-success"">Editar</button>
                        <button type=""button"" class=""btn btn-outline-danger"">Eliminar</button>

                    

                </td>
            </tr>
        </tbody>
    </table>
</div>


<ul>
");
            EndContext();
#line 47 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
     foreach (string TareasPendientes in (List<string>)ViewData["TareasPendientes"])
    {

#line default
#line hidden
            BeginContext(1415, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(1428, 16, false);
#line 49 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
       Write(TareasPendientes);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 50 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
    }

#line default
#line hidden
            BeginContext(1456, 12, true);
            WriteLiteral("</ul>\n\n<ul>\n");
            EndContext();
#line 54 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
     foreach (string TareasPendientes in ViewBag.TareasPendientes)
    {

#line default
#line hidden
            BeginContext(1541, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(1554, 16, false);
#line 56 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
       Write(TareasPendientes);

#line default
#line hidden
            EndContext();
            BeginContext(1570, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 57 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
    }

#line default
#line hidden
            BeginContext(1582, 12, true);
            WriteLiteral("</ul>\n\n<ul>\n");
            EndContext();
#line 61 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
     foreach (string TareasPendientes in (List<string>)TempData["TareasPendientes"])
    {

#line default
#line hidden
            BeginContext(1685, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(1698, 16, false);
#line 63 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
       Write(TareasPendientes);

#line default
#line hidden
            EndContext();
            BeginContext(1714, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 64 "/Users/janetcc/Projects/TareasTest/TareasTest/Views/Home/Privacy.cshtml"
    }

#line default
#line hidden
            BeginContext(1726, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591