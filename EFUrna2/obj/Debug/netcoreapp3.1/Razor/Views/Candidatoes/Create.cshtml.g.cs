#pragma checksum "D:\programacao\EFUrna\2\EFUrna2\Views\Candidatoes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c3bf451e49ae4a68f2bd77bbd032641a77744b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidatoes_Create), @"mvc.1.0.view", @"/Views/Candidatoes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c3bf451e49ae4a68f2bd77bbd032641a77744b", @"/Views/Candidatoes/Create.cshtml")]
    #nullable restore
    public class Views_Candidatoes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFUrna2.Dominio.Candidato>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\programacao\EFUrna\2\EFUrna2\Views\Candidatoes\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Candidato</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Partido"" class=""control-label""></label>
                <input asp-for=""Partido"" class=""form-control"" />
                <span asp-validation-for=""Partido"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Sigla"" class=""control-label""></label>
                <input asp-for=""Sigla"" class=""form-control"" />
                <span asp-validation-for=""Sigla"" class=""text-danger""></span>
            </di");
            WriteLiteral(@"v>
            <div class=""form-group"">
                <label asp-for=""Votos"" class=""control-label""></label>
                <input asp-for=""Votos"" class=""form-control"" />
                <span asp-validation-for=""Votos"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "D:\programacao\EFUrna\2\EFUrna2\Views\Candidatoes\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFUrna2.Dominio.Candidato> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
