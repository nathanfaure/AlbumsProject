#pragma checksum "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Shared\_CommentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe0bb0b7fa61ade77749f0ba7e89b6a4e4ce5a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentPartial), @"mvc.1.0.view", @"/Views/Shared/_CommentPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CommentPartial.cshtml", typeof(AspNetCore.Views_Shared__CommentPartial))]
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
#line 1 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\_ViewImports.cshtml"
using AlbumsProject.Web;

#line default
#line hidden
#line 1 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Shared\_CommentPartial.cshtml"
using AlbumsProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe0bb0b7fa61ade77749f0ba7e89b6a4e4ce5a5", @"/Views/Shared/_CommentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3f98bc0c4b128b6395561871c745378cbbf455", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 71, true);
            WriteLiteral("\r\n<div class=\"form-horizontal\">\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(123, 109, false);
#line 6 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Shared\_CommentPartial.cshtml"
   Write(Html.LabelFor(model => model.Author, htmlAttributes:
             new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(232, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(280, 38, false);
#line 9 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Shared\_CommentPartial.cshtml"
       Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(318, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(387, 106, false);
#line 13 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Shared\_CommentPartial.cshtml"
   Write(Html.LabelFor(model => model.Text, htmlAttributes:
            new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(493, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(541, 36, false);
#line 16 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Shared\_CommentPartial.cshtml"
       Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(577, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
