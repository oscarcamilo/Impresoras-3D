#pragma checksum "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eb5aa2c0fa4c2d5c13ee536f46ac71011ea4cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Impresora3d.App.Fontend.Pages.Impresora.Pages_Impresora_List), @"mvc.1.0.razor-page", @"/Pages/Impresora/List.cshtml")]
namespace Impresora3d.App.Fontend.Pages.Impresora
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
#line 1 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\_ViewImports.cshtml"
using Impresora3d.App.Fontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb5aa2c0fa4c2d5c13ee536f46ac71011ea4cea", @"/Pages/Impresora/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"886c519554850ffd2c9bbbcf6869d8950b8ad011", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Impresora_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<h5>IMPRESORAS 3D</h5>

<table class=""table table-striped"">
    <tr>
    <th>Placa inventario</th>
    <th>Tipo</th>
    <th>Marca</th>
    <th>Modelo</th>
    <th>Pais de origen</th>
    <th>Volumen de impresion</th>
    <th>Software</th>
    <th>Velocidad de impresion</th>
    <th>Editar</th>
    
  </tr>
");
#nullable restore
#line 20 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
     foreach (var impresora in Model.impresoras)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
           Write(impresora.PlacaInventario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
           Write(impresora.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
           Write(impresora.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
           Write(impresora.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
           Write(impresora.PaisDeOrigen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
           Write(impresora.VolumenImpresion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
           Write(impresora.Software);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
           Write(impresora.VelocidadImpresion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eb5aa2c0fa4c2d5c13ee536f46ac71011ea4cea6291", async() => {
                WriteLiteral("\r\n                <i class=\"fas fa-address-book fa-lg\" aria-hidden=\"true\"></i>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-impresoraId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
                                                                                  WriteLiteral(impresora.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["impresoraId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-impresoraId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["impresoraId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n                  \r\n            \r\n        </tr>\r\n");
#nullable restore
#line 41 "E:\GitHub\Impresoras-3D\Impresora3d.App.Fontend\Pages\Impresora\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Impresora3d.App.Fontend.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Impresora3d.App.Fontend.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Impresora3d.App.Fontend.Pages.ListModel>)PageContext?.ViewData;
        public Impresora3d.App.Fontend.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
